using Dapper;
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

        //private static string _connectionString;

        // このクラスにアクセスしようとしたときに最初に動作するコンストラクタを作成
        static ProductSQLServer()
        {
            // リファクタリングによりProductSQLServerクラスへ移動

            //var builder = new SqlConnectionStringBuilder();
            //builder.DataSource = @"HOME-SERVER-01\SQLEXPRESS"; // バックスラッシュがある場合は文字列の先頭に@をつける
            //builder.InitialCatalog = "My_DB"; // DB名
            //builder.IntegratedSecurity = true; // Windows認証の場合
            //_connectionString = builder.ToString();
        }

        public static DataTable GetDataTable()
        {
            var sql = @"select * from Product";

            return SqlServerHelper.GetDataTable(sql);

            // リファクタリングによりProductSQLServerクラスへ移動

            //DataTable dt = new DataTable();

            //// Disposeが呼び出せる処理はusingを使用してエラー時には接続が閉じるようにする
            //// 処理の閉じ忘れを防止して、メモリーの消費を防ぐため
            //using (var connection = new SqlConnection(_connectionString))
            //using (var adapter = new SqlDataAdapter(sql, connection)) // SQLと接続情報を渡す
            //{
            //    connection.Open();
            //    // SQLが発行されてDataTableに結果が入る
            //    adapter.Fill(dt);
            //}

            //return dt;
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

            SqlServerHelper.Query(sql, reader =>
            {
                // SqlServerHelperの方でループ処理が実行されているときに
                // ここの処理が呼ばれて1行ずつリストに追加される
                result.Add(new ProductEntity(
                        Convert.ToInt32(reader["ProductId"]),
                        Convert.ToString(reader["ProductName"]),
                        Convert.ToInt32(reader["Price"])
                        ));

            });

            // リファクタリングによりProductSQLServerクラスへ移動

            //using (var connection = new SqlConnection(_connectionString))
            //using (var command = new SqlCommand(sql, connection))
            //{
            //    // データベースに接続してSELECT文の実行結果を1行ずつ返す
            //    connection.Open();
            //    using (var reader = command.ExecuteReader())
            //    {
            //        // 1行ずつ結果を返す、結果がなくなれば処理をfalseを返す
            //        // 取得したデータは維持されないので変数に格納しないと消えて無くなる
            //        while (reader.Read())
            //        {
            //            // reader[0] クエリの実行で取得したデータは項目を追加したときにバグが発生するので
            //            // インデックスではなく、カラムの名前で取得する
            //            // 値はObject型で返ってくるので、必ずデータベースの型と合わせてConvertする
            //            // SQLServerのintとC＃のintはどちらも32ビット
            //            // SQLServerでBigintだったらC＃ではlongでConvertする
            //            // 整数はビット数に気を付ける

            //            result.Add(new ProductEntity(
            //                        Convert.ToInt32(reader["ProductId"]),
            //                        Convert.ToString(reader["ProductName"]),
            //                        Convert.ToInt32(reader["Price"])
            //                        ));
            //        }

            //        // SQLServer real →     C# float ToSingle()
            //        // SQLServer float →    C# double ToDouble()
            //        // SQLServer bigint →   C# long ToInt64()
            //        // SQLServer int →      C# long ToInt32()
            //        // SQLServer smallint → C# long ToInt16()
            //        // SQLServer tinyint →  C# long ToByte()
            //        // SQLServer varchar →  C# string ToString()

            //    }
            //}

            return result;
        }

        public static void Insert(ProductEntity products)
        {
            string sql = @"insert into Product(ProductId,ProductName,Price) values(@ProductId,@ProductName,@Price)";

            var p = new List<SqlParameter>();

            p.Add(new SqlParameter("@ProductId", products.ProductId));
            p.Add(new SqlParameter("@ProductName", products.ProductName));
            p.Add(new SqlParameter("@Price", products.Price));
            SqlServerHelper.Execute(sql, p);
            
        }

        public static void Update(ProductEntity products)
        {

            string sql = @"update Product set ProductName=@ProductName, Price=@Price where ProductId=@ProductId";

            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", products.ProductId));
            p.Add(new SqlParameter("@ProductName", products.ProductName));
            p.Add(new SqlParameter("@Price", products.Price));
            var update_count = SqlServerHelper.Execute(sql, p);
            
            if (update_count < 1)
            {
                Insert(products);
            }

        }

        public static void Delete(int producId)
        {

            string sql = @"delete Product where ProductId=@ProductId";

            var p = new List<SqlParameter>();
            p.Add(new SqlParameter("@ProductId", producId));
            SqlServerHelper.Execute(sql, p);
        }

        // GetDapper
        public static List<ProductEntity> GetDapper()
        {
            // 改行が必要な場合は先頭に@マークをつける
            var sql = @"select
                        ProductId,
                        ProductName,
                        Price from
                        Product";

            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                // SQLを実行してProductEntityの型にマッピングして値を返してくれる
                // Queryメソッドに合わせてF12キーを押すとDapperクラスに飛べる
                return connection.Query<ProductEntity>(sql).ToList();
            }

        }

        // DapperInsert
        public static void DapperInsert(ProductEntity products)
        {
            string sql = @"insert into Product(ProductId,ProductName,Price) values(@ProductId,@ProductName,@Price)";

            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                connection.Execute(sql, new { products.ProductId, products.ProductName, products.Price });
            }
        }

        // DapperUpdate
        public static void DapperUpdate(ProductEntity products)
        {
            string sql = @"update Product set ProductName=@ProductName, Price=@Price where ProductId=@ProductId";

            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                connection.Execute(sql, new { products.ProductId, products.ProductName, products.Price } );
            }
        }

        // DapperDelete
        public static void DapperDelete(int productId)
        {
            string sql = @"delete Product where ProductId=@ProductId";

            using (var connection = new SqlConnection(SqlServerHelper.ConnectionString))
            {
                connection.Execute(sql, new { productId });
            }
        }

    }
}
