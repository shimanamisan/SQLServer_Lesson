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
        public static void GetDataReader()
        {
            var sql = @"select * from Product";

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                // データベースに接続してSELECT文の実行結果を1行ずつ返す
                using (var reader = command.ExecuteReader())
                {
                    // 1行ずつ結果を返す、結果がなくなれば処理をfalseを返す
                    while(reader.Read())
                    {

                    }
                }
            }
        }
    }
}
