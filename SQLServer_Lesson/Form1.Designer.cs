
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
            this.UpdateCommandButton = new System.Windows.Forms.Button();
            this.DeleteCommandButton = new System.Windows.Forms.Button();
            this.DapperReadButton = new System.Windows.Forms.Button();
            this.DapperInsertButton = new System.Windows.Forms.Button();
            this.EFReadtButton = new System.Windows.Forms.Button();
            this.EFInsertButton = new System.Windows.Forms.Button();
            this.EFUpdateButton = new System.Windows.Forms.Button();
            this.EFDeleteButton = new System.Windows.Forms.Button();
            this.DapperUpdateButton = new System.Windows.Forms.Button();
            this.DapperDeleteButton = new System.Windows.Forms.Button();
            this.InsertDataButton = new System.Windows.Forms.Button();
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
            // UpdateCommandButton
            // 
            this.UpdateCommandButton.Location = new System.Drawing.Point(12, 135);
            this.UpdateCommandButton.Name = "UpdateCommandButton";
            this.UpdateCommandButton.Size = new System.Drawing.Size(200, 30);
            this.UpdateCommandButton.TabIndex = 7;
            this.UpdateCommandButton.Text = "Update Command";
            this.UpdateCommandButton.UseVisualStyleBackColor = true;
            this.UpdateCommandButton.Click += new System.EventHandler(this.UpdateCommandButton_Click);
            // 
            // DeleteCommandButton
            // 
            this.DeleteCommandButton.Location = new System.Drawing.Point(12, 171);
            this.DeleteCommandButton.Name = "DeleteCommandButton";
            this.DeleteCommandButton.Size = new System.Drawing.Size(200, 30);
            this.DeleteCommandButton.TabIndex = 8;
            this.DeleteCommandButton.Text = "Delete Command";
            this.DeleteCommandButton.UseVisualStyleBackColor = true;
            this.DeleteCommandButton.Click += new System.EventHandler(this.DeleteCommandButton_Click);
            // 
            // DapperReadButton
            // 
            this.DapperReadButton.Location = new System.Drawing.Point(12, 207);
            this.DapperReadButton.Name = "DapperReadButton";
            this.DapperReadButton.Size = new System.Drawing.Size(200, 30);
            this.DapperReadButton.TabIndex = 9;
            this.DapperReadButton.Text = "Dapper read";
            this.DapperReadButton.UseVisualStyleBackColor = true;
            this.DapperReadButton.Click += new System.EventHandler(this.DapperReadButton_Click);
            // 
            // DapperInsertButton
            // 
            this.DapperInsertButton.Location = new System.Drawing.Point(12, 243);
            this.DapperInsertButton.Name = "DapperInsertButton";
            this.DapperInsertButton.Size = new System.Drawing.Size(200, 30);
            this.DapperInsertButton.TabIndex = 10;
            this.DapperInsertButton.Text = "Dapper Insert";
            this.DapperInsertButton.UseVisualStyleBackColor = true;
            this.DapperInsertButton.Click += new System.EventHandler(this.DapperInsertButton_Click);
            // 
            // EFReadtButton
            // 
            this.EFReadtButton.Location = new System.Drawing.Point(215, 359);
            this.EFReadtButton.Name = "EFReadtButton";
            this.EFReadtButton.Size = new System.Drawing.Size(200, 30);
            this.EFReadtButton.TabIndex = 11;
            this.EFReadtButton.Text = "EF Read";
            this.EFReadtButton.UseVisualStyleBackColor = true;
            this.EFReadtButton.Click += new System.EventHandler(this.EFReadtButton_Click);
            // 
            // EFInsertButton
            // 
            this.EFInsertButton.Location = new System.Drawing.Point(421, 359);
            this.EFInsertButton.Name = "EFInsertButton";
            this.EFInsertButton.Size = new System.Drawing.Size(200, 30);
            this.EFInsertButton.TabIndex = 12;
            this.EFInsertButton.Text = "EF Insert";
            this.EFInsertButton.UseVisualStyleBackColor = true;
            this.EFInsertButton.Click += new System.EventHandler(this.EFInsertButton_Click);
            // 
            // EFUpdateButton
            // 
            this.EFUpdateButton.Location = new System.Drawing.Point(215, 395);
            this.EFUpdateButton.Name = "EFUpdateButton";
            this.EFUpdateButton.Size = new System.Drawing.Size(200, 30);
            this.EFUpdateButton.TabIndex = 13;
            this.EFUpdateButton.Text = "EF Update";
            this.EFUpdateButton.UseVisualStyleBackColor = true;
            this.EFUpdateButton.Click += new System.EventHandler(this.EFUpdateButton_Click);
            // 
            // EFDeleteButton
            // 
            this.EFDeleteButton.Location = new System.Drawing.Point(421, 395);
            this.EFDeleteButton.Name = "EFDeleteButton";
            this.EFDeleteButton.Size = new System.Drawing.Size(200, 30);
            this.EFDeleteButton.TabIndex = 14;
            this.EFDeleteButton.Text = "EF Delete";
            this.EFDeleteButton.UseVisualStyleBackColor = true;
            this.EFDeleteButton.Click += new System.EventHandler(this.EFDeleteButton_Click);
            // 
            // DapperUpdateButton
            // 
            this.DapperUpdateButton.Location = new System.Drawing.Point(12, 279);
            this.DapperUpdateButton.Name = "DapperUpdateButton";
            this.DapperUpdateButton.Size = new System.Drawing.Size(200, 30);
            this.DapperUpdateButton.TabIndex = 15;
            this.DapperUpdateButton.Text = "Dappert Update";
            this.DapperUpdateButton.UseVisualStyleBackColor = true;
            this.DapperUpdateButton.Click += new System.EventHandler(this.DapperUpdateButton_Click);
            // 
            // DapperDeleteButton
            // 
            this.DapperDeleteButton.Location = new System.Drawing.Point(12, 315);
            this.DapperDeleteButton.Name = "DapperDeleteButton";
            this.DapperDeleteButton.Size = new System.Drawing.Size(200, 30);
            this.DapperDeleteButton.TabIndex = 16;
            this.DapperDeleteButton.Text = "Dapper Delete";
            this.DapperDeleteButton.UseVisualStyleBackColor = true;
            this.DapperDeleteButton.Click += new System.EventHandler(this.DapperDeleteButton_Click);
            // 
            // InsertDataButton
            // 
            this.InsertDataButton.Location = new System.Drawing.Point(12, 351);
            this.InsertDataButton.Name = "InsertDataButton";
            this.InsertDataButton.Size = new System.Drawing.Size(200, 50);
            this.InsertDataButton.TabIndex = 17;
            this.InsertDataButton.Text = "Insert 5万件";
            this.InsertDataButton.UseVisualStyleBackColor = true;
            this.InsertDataButton.Click += new System.EventHandler(this.InsertDataButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 461);
            this.Controls.Add(this.InsertDataButton);
            this.Controls.Add(this.DapperDeleteButton);
            this.Controls.Add(this.DapperUpdateButton);
            this.Controls.Add(this.EFDeleteButton);
            this.Controls.Add(this.EFUpdateButton);
            this.Controls.Add(this.EFInsertButton);
            this.Controls.Add(this.EFReadtButton);
            this.Controls.Add(this.DapperInsertButton);
            this.Controls.Add(this.DapperReadButton);
            this.Controls.Add(this.DeleteCommandButton);
            this.Controls.Add(this.UpdateCommandButton);
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
        private System.Windows.Forms.Button UpdateCommandButton;
        private System.Windows.Forms.Button DeleteCommandButton;
        private System.Windows.Forms.Button DapperReadButton;
        private System.Windows.Forms.Button DapperInsertButton;
        private System.Windows.Forms.Button EFReadtButton;
        private System.Windows.Forms.Button EFInsertButton;
        private System.Windows.Forms.Button EFUpdateButton;
        private System.Windows.Forms.Button EFDeleteButton;
        private System.Windows.Forms.Button DapperUpdateButton;
        private System.Windows.Forms.Button DapperDeleteButton;
        private System.Windows.Forms.Button InsertDataButton;
    }
}

