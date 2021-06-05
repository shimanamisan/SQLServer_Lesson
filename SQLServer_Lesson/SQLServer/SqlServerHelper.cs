using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_Lesson.SQLServer
{
    class SqlServerHelper
    {
        // リファクタリングによりProductSQLServerクラスより移動
        internal static string ConnectionString { get; }

        static SqlServerHelper()
        {
            // リファクタリングによりProductSQLServerクラスより移動
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"HOME-SERVER-01\SQLEXPRESS"; // バックスラッシュがある場合は文字列の先頭に@をつける
            builder.InitialCatalog = "My_DB"; // DB名
            builder.IntegratedSecurity = true; // Windows認証の場合
            ConnectionString = builder.ToString();
        }

        // リファクタリングによりProductSQLServerクラスより移動
        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();

            // Disposeが呼び出せる処理はusingを使用してエラー時には接続が閉じるようにする
            // 処理の閉じ忘れを防止して、メモリーの消費を防ぐため
            using (var connection = new SqlConnection(ConnectionString))
            using (var adapter = new SqlDataAdapter(sql, connection)) // SQLと接続情報を渡す
            {
                connection.Open();
                // SQLが発行されてDataTableに結果が入る
                adapter.Fill(dt);
            }

            return dt;
        }

        // リファクタリングによりProductSQLServerクラスより移動
        // 値を返すのではなくActionを使ってSqlDataReaderを通知するだけにする
        public static void Query(string sql, Action<SqlDataReader> action)
        {

            var result = new List<ProductEntity>();
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                // データベースに接続してSELECT文の実行結果を1行ずつ返す
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    // 1行ずつ結果を返す、結果がなくなれば処理をfalseを返す
                    // 取得したデータは維持されないので変数に格納しないと消えて無くなる
                    while (reader.Read())
                    {
                        // reader[0] クエリの実行で取得したデータは項目を追加したときにバグが発生するので
                        // インデックスではなく、カラムの名前で取得する
                        // 値はObject型で返ってくるので、必ずデータベースの型と合わせてConvertする
                        // SQLServerのintとC＃のintはどちらも32ビット
                        // SQLServerでBigintだったらC＃ではlongでConvertする
                        // 整数はビット数に気を付ける

                        // SqlDataReaderで取得したものを通知する
                        action(reader);
                    }

                    // SQLServer real →     C# float ToSingle()
                    // SQLServer float →    C# double ToDouble()
                    // SQLServer bigint →   C# long ToInt64()
                    // SQLServer int →      C# long ToInt32()
                    // SQLServer smallint → C# long ToInt16()
                    // SQLServer tinyint →  C# long ToByte()
                    // SQLServer varchar →  C# string ToString()

                }
            }
        }

        public static int Execute(string sql, List<SqlParameter> sqlParameters)
        {
           
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                if (sqlParameters != null)
                {
                    // Listになっているので、配列に直してAddする必要がある
                    command.Parameters.AddRange(sqlParameters.ToArray());
                }

                // Insertする場合はExecuteNonQueryでSQLコマンドのSQLが実行される
                return command.ExecuteNonQuery();
            }
        }
    }
}
