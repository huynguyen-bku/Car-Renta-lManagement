namespace CarRentalManagement
{
    partial class FormMainCustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add_customer = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_adjust_info_cus = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_compare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(245, 29);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(671, 381);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_customer.Location = new System.Drawing.Point(17, 29);
            this.btn_add_customer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(203, 73);
            this.btn_add_customer.TabIndex = 1;
            this.btn_add_customer.Text = "THÊM KHÁCH HÀNG";
            this.btn_add_customer.UseVisualStyleBackColor = true;
            this.btn_add_customer.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(17, 110);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(203, 64);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "XÓA KHÁCH HÀNG";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_adjust_info_cus
            // 
            this.btn_adjust_info_cus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adjust_info_cus.Location = new System.Drawing.Point(17, 182);
            this.btn_adjust_info_cus.Margin = new System.Windows.Forms.Padding(4);
            this.btn_adjust_info_cus.Name = "btn_adjust_info_cus";
            this.btn_adjust_info_cus.Size = new System.Drawing.Size(203, 74);
            this.btn_adjust_info_cus.TabIndex = 1;
            this.btn_adjust_info_cus.Text = "SỬA THÔNG TIN KHÁCH HÀNG";
            this.btn_adjust_info_cus.UseVisualStyleBackColor = true;
            this.btn_adjust_info_cus.Click += new System.EventHandler(this.btn_adjust_info_cus_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(17, 264);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(203, 67);
            this.btn_Search.TabIndex = 1;
            this.btn_Search.Text = "TÌM THÔNG TIN KHÁCH HÀNG";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_compare
            // 
            this.btn_compare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compare.Location = new System.Drawing.Point(17, 348);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(203, 62);
            this.btn_compare.TabIndex = 2;
            this.btn_compare.Text = "SO SÁNH KHÁCH HÀNG";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // FormMainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 442);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_adjust_info_cus);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add_customer);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainCustomer";
            this.ShowIcon = false;
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add_customer;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_adjust_info_cus;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_compare;
    }
}