namespace CarRentalManagement
{
    partial class FormMainVehicle
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
            this.btn_search = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addcar = new System.Windows.Forms.Button();
            this.btn_removecar = new System.Windows.Forms.Button();
            this.btn_service = new System.Windows.Forms.Button();
            this.btn_serviceall = new System.Windows.Forms.Button();
            this.btn_repair = new System.Windows.Forms.Button();
            this.btn_sevicehistory = new System.Windows.Forms.Button();
            this.lbl_print = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(27, 144);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(299, 51);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "TÌM XE";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(332, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(884, 456);
            this.dataGridView1.TabIndex = 1;
            // 
            // btn_addcar
            // 
            this.btn_addcar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcar.Location = new System.Drawing.Point(27, 12);
            this.btn_addcar.Name = "btn_addcar";
            this.btn_addcar.Size = new System.Drawing.Size(299, 51);
            this.btn_addcar.TabIndex = 3;
            this.btn_addcar.Text = "THÊM XE";
            this.btn_addcar.UseVisualStyleBackColor = true;
            this.btn_addcar.Click += new System.EventHandler(this.btn_addcar_Click);
            // 
            // btn_removecar
            // 
            this.btn_removecar.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removecar.Location = new System.Drawing.Point(27, 78);
            this.btn_removecar.Name = "btn_removecar";
            this.btn_removecar.Size = new System.Drawing.Size(299, 51);
            this.btn_removecar.TabIndex = 0;
            this.btn_removecar.Text = "XÓA XE";
            this.btn_removecar.UseVisualStyleBackColor = true;
            this.btn_removecar.Click += new System.EventHandler(this.btn_removecar_Click);
            // 
            // btn_service
            // 
            this.btn_service.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_service.Location = new System.Drawing.Point(27, 282);
            this.btn_service.Name = "btn_service";
            this.btn_service.Size = new System.Drawing.Size(299, 51);
            this.btn_service.TabIndex = 4;
            this.btn_service.Text = "BẢO DƯỠNG MỘT XE";
            this.btn_service.UseVisualStyleBackColor = true;
            this.btn_service.Click += new System.EventHandler(this.btn_service_Click);
            // 
            // btn_serviceall
            // 
            this.btn_serviceall.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_serviceall.Location = new System.Drawing.Point(27, 351);
            this.btn_serviceall.Name = "btn_serviceall";
            this.btn_serviceall.Size = new System.Drawing.Size(299, 48);
            this.btn_serviceall.TabIndex = 5;
            this.btn_serviceall.Text = "BẢO DƯỠNG CẢ ĐỘI XE";
            this.btn_serviceall.UseVisualStyleBackColor = true;
            this.btn_serviceall.Click += new System.EventHandler(this.btn_serviceall_Click);
            // 
            // btn_repair
            // 
            this.btn_repair.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_repair.Location = new System.Drawing.Point(27, 211);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Size = new System.Drawing.Size(299, 54);
            this.btn_repair.TabIndex = 6;
            this.btn_repair.Text = "CẬP NHẬP THÔNG TIN";
            this.btn_repair.UseVisualStyleBackColor = true;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // btn_sevicehistory
            // 
            this.btn_sevicehistory.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sevicehistory.Location = new System.Drawing.Point(27, 418);
            this.btn_sevicehistory.Name = "btn_sevicehistory";
            this.btn_sevicehistory.Size = new System.Drawing.Size(299, 50);
            this.btn_sevicehistory.TabIndex = 7;
            this.btn_sevicehistory.Text = "LỊCH SỬ BẢO DƯỠNG";
            this.btn_sevicehistory.UseVisualStyleBackColor = true;
            this.btn_sevicehistory.Click += new System.EventHandler(this.btn_sevicehistory_Click);
            // 
            // lbl_print
            // 
            this.lbl_print.AutoSize = true;
            this.lbl_print.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_print.ForeColor = System.Drawing.Color.Red;
            this.lbl_print.Location = new System.Drawing.Point(388, 435);
            this.lbl_print.Name = "lbl_print";
            this.lbl_print.Size = new System.Drawing.Size(0, 27);
            this.lbl_print.TabIndex = 8;
            // 
            // FormMainVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 480);
            this.Controls.Add(this.lbl_print);
            this.Controls.Add(this.btn_sevicehistory);
            this.Controls.Add(this.btn_repair);
            this.Controls.Add(this.btn_serviceall);
            this.Controls.Add(this.btn_service);
            this.Controls.Add(this.btn_addcar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_removecar);
            this.Controls.Add(this.btn_search);
            this.Name = "FormMainVehicle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_addcar;
        private System.Windows.Forms.Button btn_removecar;
        private System.Windows.Forms.Button btn_service;
        private System.Windows.Forms.Button btn_serviceall;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.Button btn_sevicehistory;
        private System.Windows.Forms.Label lbl_print;
    }
}

