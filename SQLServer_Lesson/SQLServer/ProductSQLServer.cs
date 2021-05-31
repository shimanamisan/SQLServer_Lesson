using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_Lesson.SQLServer
{
    public static class ProductSQLServer
    {

        private static string _connectionString;

        // このクラスにアクセスしようとしたときに最初に動作するコンストラクタを作成
        static ProductSQLServer()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"HOME-SERVER-01\SQLEXPRESS"; // バックスラッシュがある場合は文字列の先頭に@をつける
            builder.InitialCatalog = "My_DB"; // DB名
            builder.IntegratedSecurity = true; // Windows認証の場合
            _connectionString = builder.ToString();
        }

        public static DataTable GetDataTable()
        {
            var sql = @"select * from Product";

            DataTable dt = new DataTable();

            // Disposeが呼び出せる処理はusingを使用してエラー時には接続が閉じるようにする
            // 処理の閉じ忘れを防止して、メモリーの消費を防ぐため
            using (var connection = new SqlConnection(_connectionString))
            using (var adapter = new SqlDataAdapter(sql, connection)) // SQLと接続情報を渡す
            {
                connection.Open();
                // SQLが発行されてDataTableに結果が入る
                adapter.Fill(dt);
            }

            return dt;
        }

        // Readerの処理
        public static List<ProductEntity> GetDataReader()
        {
            // 改行が必要な場合は先頭に@マークをつける
            var sql = @"select
                        ProductId,
                        ProductName,
                        Price from
                        Product";

            var result = new List<ProductEntity>();
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                // データベースに接続してSELECT文の実行結果を1行ずつ返す
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    // 1行ずつ結果を返す、結果がなくなれば処理をfalseを返す
                    // 取得したデータは維持されないので変数に格納しないと消えて無くなる
                    while(reader.Read())
                    {
                        // reader[0] クエリの実行で取得したデータは項目を追加したときにバグが発生するので
                        // インデックスではなく、カラムの名前で取得する
                        // 値はObject型で返ってくるので、必ずデータベースの型と合わせてConvertする
                        // SQLServerのintとC＃のintはどちらも32ビット
                        // SQLServerでBigintだったらC＃ではlongでConvertする
                        // 整数はビット数に気を付ける

                        result.Add(new ProductEntity(
                                    Convert.ToInt32(reader["ProductId"]),
                                    Convert.ToString(reader["ProductName"]),
                                    Convert.ToInt32(reader["Price"])                                      
                                    ));
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

            return result;
        }

        public static void Insert(ProductEntity products)
        {
            string sql = @"insert into Product(ProductId,ProductName,Price) values(@ProductId,@ProductName,@Price)";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                // SQLの値を指定する
                command.Parameters.AddWithValue("@ProductId", products.ProductId);
                command.Parameters.AddWithValue("@ProductName", products.ProductName);
                command.Parameters.AddWithValue("@Price", products.Price);

                // Insertする場合はExecuteNonQueryでSQLコマンドのSQLが実行される
                command.ExecuteNonQuery();
            }
        }
    }
}
