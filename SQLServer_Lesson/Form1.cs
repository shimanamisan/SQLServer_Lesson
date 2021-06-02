using SQLServer_Lesson.Models;
using SQLServer_Lesson.SQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServer_Lesson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }


        private void DatabaseRead(object sender, EventArgs e)
        {
            // 共通処理はProductSQLServerクラスに移動

            //// 接続情報を作成する
            //var builder = new SqlConnectionStringBuilder();
            //builder.DataSource = @"HOME-SERVER-01\SQLEXPRESS"; // バックスラッシュがある場合は文字列の先頭に@をつける
            //builder.InitialCatalog = "My_DB"; // DB名
            //builder.IntegratedSecurity = true; // Windows認証の場合
            ////builder.UserID = ""; // SQLServer認証の場合はIDとPassを入力し、IntegratedSecurityをFalseにする

            //// SQLSeverの接続するために必要な文字列が生成される
            //var connectionString = builder.ToString();

            //var sql = @"select * from Product";

            //DataTable dt = new DataTable();

            //// Disposeが呼び出せる処理はusingを使用してエラー時には接続が閉じるようにする
            //// 処理の閉じ忘れを防止して、メモリーの消費を防ぐため
            //using (var connection = new SqlConnection(connectionString))
            //using (var adapter = new SqlDataAdapter(sql, connection)) // SQLと接続情報を渡す
            //{
            //    connection.Open();
            //    // SQLが発行されてDataTableに結果が入る
            //    adapter.Fill(dt);
            //}

            // 実行結果を画面に表示させる
            dataGridView1.DataSource = ProductSQLServer.GetDataTable();

        }

        private void ReaderRead(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductSQLServer.GetDataReader();
        }

        private void InsertCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);
            string productName = Convert.ToString(ProductNameTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, price);
            ProductSQLServer.Insert(entity);
        }

        private void UpdateCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);
            string productName = Convert.ToString(ProductNameTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, price);
            ProductSQLServer.Update(entity);
        }

        private void DeleteCommandButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);

            ProductSQLServer.Delete(productId);
        }

        private void DapperReadButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductSQLServer.GetDapper();
        }

        private void DapperInsertButton_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ProductIdTextBox.Text);
            string productName = Convert.ToString(ProductNameTextBox.Text);
            int price = Convert.ToInt32(PriceTextBox.Text);

            var entity = new ProductEntity(productId, productName, price);
            ProductSQLServer.DapperInsert(entity);
        }

        private void EFReadtButton_Click(object sender, EventArgs e)
        {
            // EntityFrameworkで自動的に生成されたリストを使用する
            var source = new List<Product>();

            // 接続はApp.Configにつながる
            // connectionString="接続先"となっているので接続先を変更したければここを変更する
            using (var db = new Model1())
            {
                source.AddRange(db.Products);
            }

            dataGridView1.DataSource = source;
        }

        private void EFInsertButton_Click(object sender, EventArgs e)
        {
            // EntityFrameworkで自動生成されたクラスに格納する
            Product p = new Product();

            p.ProductId = Convert.ToInt32(ProductIdTextBox.Text);
            p.ProductName = Convert.ToString(ProductNameTextBox.Text);
            p.Price = Convert.ToInt32(PriceTextBox.Text);

            using (var db = new Model1())
            {
                db.Products.Add(p);
                // データベースに保存するときは必ず実行する
                db.SaveChanges();
            }
        }

        private void EFUpdateButton_Click(object sender, EventArgs e)
        {
            using (var db = new Model1())
            {
                // IDをキーにしてデータを取得する
                var p = db.Products.Find(Convert.ToInt32(ProductIdTextBox.Text));

                p.ProductName = ProductNameTextBox.Text;
                p.Price = Convert.ToInt32(PriceTextBox.Text);
                db.SaveChanges();
            }
        }
    }
}
