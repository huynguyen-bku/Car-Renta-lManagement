namespace CarRentalManagement
{
    partial class FormCompare
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_tru = new System.Windows.Forms.Button();
            this.txt_number_a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_number_b = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_compare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_tru
            // 
            this.btn_tru.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tru.Location = new System.Drawing.Point(32, 140);
            this.btn_tru.Name = "btn_tru";
            this.btn_tru.Size = new System.Drawing.Size(179, 62);
            this.btn_tru.TabIndex = 1;
            this.btn_tru.Text = "SO SÁNH ĐIỂM";
            this.btn_tru.UseVisualStyleBackColor = true;
            this.btn_tru.Click += new System.EventHandler(this.btn_tru_Click);
            // 
            // txt_number_a
            // 
            this.txt_number_a.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number_a.Location = new System.Drawing.Point(217, 25);
            this.txt_number_a.Name = "txt_number_a";
            this.txt_number_a.Size = new System.Drawing.Size(207, 34);
            this.txt_number_a.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "SỐ ĐT NGƯỜI B";
            // 
            // txt_number_b
            // 
            this.txt_number_b.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_number_b.Location = new System.Drawing.Point(216, 65);
            this.txt_number_b.Name = "txt_number_b";
            this.txt_number_b.Size = new System.Drawing.Size(208, 34);
            this.txt_number_b.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "SỐ ĐT NGƯỜI A";
            // 
            // btn_compare
            // 
            this.btn_compare.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compare.Location = new System.Drawing.Point(241, 140);
            this.btn_compare.Name = "btn_compare";
            this.btn_compare.Size = new System.Drawing.Size(183, 62);
            this.btn_compare.TabIndex = 1;
            this.btn_compare.Text = "KIỂM TRA TÊN";
            this.btn_compare.UseVisualStyleBackColor = true;
            this.btn_compare.Click += new System.EventHandler(this.btn_compare_Click);
            // 
            // FormCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 221);
            this.Controls.Add(this.txt_number_b);
            this.Controls.Add(this.txt_number_a);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_compare);
            this.Controls.Add(this.btn_tru);
            this.Controls.Add(this.label3);
            this.Name = "FormCompare";
            this.Text = "FormCompare";
            this.Load += new System.EventHandler(this.FormCompare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btn_tru;
        private System.Windows.Forms.TextBox txt_number_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_number_b;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_compare;
    }
}