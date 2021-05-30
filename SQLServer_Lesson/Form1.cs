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

        }
    }
}
