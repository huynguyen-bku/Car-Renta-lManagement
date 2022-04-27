namespace CarRentalManagement
{
    partial class FormMainConTract
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_repair_book = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btn_ChangeContract = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_create.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.Black;
            this.btn_create.Location = new System.Drawing.Point(12, 12);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(210, 100);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "TẠO HỢP ĐỒNG";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_repair_book
            // 
            this.btn_repair_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_repair_book.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repair_book.ForeColor = System.Drawing.Color.Black;
            this.btn_repair_book.Location = new System.Drawing.Point(12, 118);
            this.btn_repair_book.Name = "btn_repair_book";
            this.btn_repair_book.Size = new System.Drawing.Size(210, 100);
            this.btn_repair_book.TabIndex = 2;
            this.btn_repair_book.Text = "SỬA HỢP ĐỒNG ĐẶT TRƯỚC";
            this.btn_repair_book.UseVisualStyleBackColor = false;
            this.btn_repair_book.Click += new System.EventHandler(this.btn_repair_book_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(12, 328);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(210, 98);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "TÌM HỢP ĐỒNG";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(228, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(673, 505);
            this.dataGridView2.TabIndex = 0;
            // 
            // btn_ChangeContract
            // 
            this.btn_ChangeContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_ChangeContract.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeContract.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeContract.Location = new System.Drawing.Point(12, 224);
            this.btn_ChangeContract.Name = "btn_ChangeContract";
            this.btn_ChangeContract.Size = new System.Drawing.Size(210, 98);
            this.btn_ChangeContract.TabIndex = 4;
            this.btn_ChangeContract.Text = "CHUYỂN ĐỔI";
            this.btn_ChangeContract.UseVisualStyleBackColor = false;
            this.btn_ChangeContract.Click += new System.EventHandler(this.btn_ChangeContract_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_remove.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.ForeColor = System.Drawing.Color.Black;
            this.btn_remove.Location = new System.Drawing.Point(13, 432);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(209, 85);
            this.btn_remove.TabIndex = 5;
            this.btn_remove.Text = "KẾT THÚC HỢP ĐỒNG";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // FormMainConTract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 550);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_ChangeContract);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_repair_book);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dataGridView2);
            this.Name = "FormMainConTract";
            this.Text = "FormConTract";
            this.Load += new System.EventHandler(this.FormConTract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_repair_book;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_ChangeContract;
        private System.Windows.Forms.Button btn_remove;
    }
}