namespace CarRentalManagement
{
    partial class FormResetCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_old_name = new System.Windows.Forms.TextBox();
            this.txt_old_birth = new System.Windows.Forms.TextBox();
            this.txt_old_phone = new System.Windows.Forms.TextBox();
            this.txt_old_point = new System.Windows.Forms.TextBox();
            this.txt_new_name = new System.Windows.Forms.TextBox();
            this.txt_new_birth = new System.Windows.Forms.TextBox();
            this.txt_new_phone = new System.Windows.Forms.TextBox();
            this.txt_new_point = new System.Windows.Forms.TextBox();
            this.btn_oke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập ID";
            // 
            // txt_input
            // 
            this.txt_input.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_input.Location = new System.Drawing.Point(156, 43);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(155, 29);
            this.txt_input.TabIndex = 1;
            // 
            // btn_input
            // 
            this.btn_input.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_input.Location = new System.Drawing.Point(360, 39);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(97, 35);
            this.btn_input.TabIndex = 2;
            this.btn_input.Text = "Xác nhận";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Điểm";
            // 
            // txt_old_name
            // 
            this.txt_old_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_old_name.Location = new System.Drawing.Point(129, 97);
            this.txt_old_name.Name = "txt_old_name";
            this.txt_old_name.ReadOnly = true;
            this.txt_old_name.Size = new System.Drawing.Size(155, 29);
            this.txt_old_name.TabIndex = 1;
            // 
            // txt_old_birth
            // 
            this.txt_old_birth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_old_birth.Location = new System.Drawing.Point(129, 132);
            this.txt_old_birth.Name = "txt_old_birth";
            this.txt_old_birth.ReadOnly = true;
            this.txt_old_birth.Size = new System.Drawing.Size(155, 29);
            this.txt_old_birth.TabIndex = 1;
            // 
            // txt_old_phone
            // 
            this.txt_old_phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_old_phone.Location = new System.Drawing.Point(129, 167);
            this.txt_old_phone.Name = "txt_old_phone";
            this.txt_old_phone.ReadOnly = true;
            this.txt_old_phone.Size = new System.Drawing.Size(155, 29);
            this.txt_old_phone.TabIndex = 1;
            // 
            // txt_old_point
            // 
            this.txt_old_point.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_old_point.Location = new System.Drawing.Point(129, 203);
            this.txt_old_point.Name = "txt_old_point";
            this.txt_old_point.ReadOnly = true;
            this.txt_old_point.Size = new System.Drawing.Size(155, 29);
            this.txt_old_point.TabIndex = 1;
            // 
            // txt_new_name
            // 
            this.txt_new_name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_name.Location = new System.Drawing.Point(321, 97);
            this.txt_new_name.Name = "txt_new_name";
            this.txt_new_name.Size = new System.Drawing.Size(155, 29);
            this.txt_new_name.TabIndex = 1;
            // 
            // txt_new_birth
            // 
            this.txt_new_birth.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_birth.Location = new System.Drawing.Point(321, 132);
            this.txt_new_birth.Name = "txt_new_birth";
            this.txt_new_birth.Size = new System.Drawing.Size(155, 29);
            this.txt_new_birth.TabIndex = 1;
            // 
            // txt_new_phone
            // 
            this.txt_new_phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_phone.Location = new System.Drawing.Point(321, 167);
            this.txt_new_phone.Name = "txt_new_phone";
            this.txt_new_phone.Size = new System.Drawing.Size(155, 29);
            this.txt_new_phone.TabIndex = 1;
            // 
            // txt_new_point
            // 
            this.txt_new_point.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_new_point.Location = new System.Drawing.Point(321, 202);
            this.txt_new_point.Name = "txt_new_point";
            this.txt_new_point.Size = new System.Drawing.Size(155, 29);
            this.txt_new_point.TabIndex = 1;
            // 
            // btn_oke
            // 
            this.btn_oke.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oke.Location = new System.Drawing.Point(197, 246);
            this.btn_oke.Name = "btn_oke";
            this.btn_oke.Size = new System.Drawing.Size(97, 35);
            this.btn_oke.TabIndex = 2;
            this.btn_oke.Text = "OKE";
            this.btn_oke.UseVisualStyleBackColor = true;
            this.btn_oke.Click += new System.EventHandler(this.btn_oke_Click);
            // 
            // FormAdjustInforCusmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 293);
            this.Controls.Add(this.btn_oke);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.txt_old_point);
            this.Controls.Add(this.txt_old_phone);
            this.Controls.Add(this.txt_old_birth);
            this.Controls.Add(this.txt_old_name);
            this.Controls.Add(this.txt_new_point);
            this.Controls.Add(this.txt_new_phone);
            this.Controls.Add(this.txt_new_birth);
            this.Controls.Add(this.txt_new_name);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdjustInforCusmer";
            this.Text = "FormAdjustInforCusmer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_old_name;
        private System.Windows.Forms.TextBox txt_old_birth;
        private System.Windows.Forms.TextBox txt_old_phone;
        private System.Windows.Forms.TextBox txt_old_point;
        private System.Windows.Forms.TextBox txt_new_name;
        private System.Windows.Forms.TextBox txt_new_birth;
        private System.Windows.Forms.TextBox txt_new_phone;
        private System.Windows.Forms.TextBox txt_new_point;
        private System.Windows.Forms.Button btn_oke;
    }
}