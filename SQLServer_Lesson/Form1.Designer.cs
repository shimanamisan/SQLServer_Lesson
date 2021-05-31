
namespace SQLServer_Lesson
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DatabaseReadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReaderReadButton = new System.Windows.Forms.Button();
            this.InsertCommandButton = new System.Windows.Forms.Button();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseReadButton
            // 
            this.DatabaseReadButton.Location = new System.Drawing.Point(12, 27);
            this.DatabaseReadButton.Name = "DatabaseReadButton";
            this.DatabaseReadButton.Size = new System.Drawing.Size(200, 30);
            this.DatabaseReadButton.TabIndex = 0;
            this.DatabaseReadButton.Text = "Database read";
            this.DatabaseReadButton.UseVisualStyleBackColor = true;
            this.DatabaseReadButton.Click += new System.EventHandler(this.DatabaseRead);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(413, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadButton
            // 
            this.ReaderReadButton.Location = new System.Drawing.Point(12, 63);
            this.ReaderReadButton.Name = "ReaderReadButton";
            this.ReaderReadButton.Size = new System.Drawing.Size(200, 30);
            this.ReaderReadButton.TabIndex = 2;
            this.ReaderReadButton.Text = "Reader read";
            this.ReaderReadButton.UseVisualStyleBackColor = true;
            this.ReaderReadButton.Click += new System.EventHandler(this.ReaderRead);
            // 
            // InsertCommandButton
            // 
            this.InsertCommandButton.Location = new System.Drawing.Point(12, 99);
            this.InsertCommandButton.Name = "InsertCommandButton";
            this.InsertCommandButton.Size = new System.Drawing.Size(200, 30);
            this.InsertCommandButton.TabIndex = 3;
            this.InsertCommandButton.Text = "Insert Command";
            this.InsertCommandButton.UseVisualStyleBackColor = true;
            this.InsertCommandButton.Click += new System.EventHandler(this.InsertCommandButton_Click);
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(215, 27);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(120, 19);
            this.ProductIdTextBox.TabIndex = 4;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(341, 27);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(120, 19);
            this.ProductNameTextBox.TabIndex = 5;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(467, 27);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(120, 19);
            this.PriceTextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 461);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.InsertCommandButton);
            this.Controls.Add(this.ReaderReadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DatabaseReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DatabaseReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReaderReadButton;
        private System.Windows.Forms.Button InsertCommandButton;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
    }
}

