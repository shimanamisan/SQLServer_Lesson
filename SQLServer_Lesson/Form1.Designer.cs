
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatabaseReadButton
            // 
            this.DatabaseReadButton.Location = new System.Drawing.Point(12, 12);
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
            this.dataGridView1.Location = new System.Drawing.Point(215, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(413, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadButton
            // 
            this.ReaderReadButton.Location = new System.Drawing.Point(12, 52);
            this.ReaderReadButton.Name = "ReaderReadButton";
            this.ReaderReadButton.Size = new System.Drawing.Size(200, 30);
            this.ReaderReadButton.TabIndex = 2;
            this.ReaderReadButton.Text = "Reader read";
            this.ReaderReadButton.UseVisualStyleBackColor = true;
            this.ReaderReadButton.Click += new System.EventHandler(this.ReaderRead);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 461);
            this.Controls.Add(this.ReaderReadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DatabaseReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DatabaseReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReaderReadButton;
    }
}

