namespace CarRentalManagement
{
    partial class FormMain
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
            this.btn_ListVehicle = new System.Windows.Forms.Button();
            this.btn_listcustomer = new System.Windows.Forms.Button();
            this.btn_listcontract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ListVehicle
            // 
            this.btn_ListVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_ListVehicle.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListVehicle.ForeColor = System.Drawing.Color.Gold;
            this.btn_ListVehicle.Location = new System.Drawing.Point(12, 12);
            this.btn_ListVehicle.Name = "btn_ListVehicle";
            this.btn_ListVehicle.Size = new System.Drawing.Size(341, 466);
            this.btn_ListVehicle.TabIndex = 0;
            this.btn_ListVehicle.Text = "XE";
            this.btn_ListVehicle.UseVisualStyleBackColor = false;
            this.btn_ListVehicle.Click += new System.EventHandler(this.btn_ListVehicle_Click);
            // 
            // btn_listcustomer
            // 
            this.btn_listcustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_listcustomer.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listcustomer.ForeColor = System.Drawing.Color.Gold;
            this.btn_listcustomer.Location = new System.Drawing.Point(375, 12);
            this.btn_listcustomer.Name = "btn_listcustomer";
            this.btn_listcustomer.Size = new System.Drawing.Size(368, 466);
            this.btn_listcustomer.TabIndex = 1;
            this.btn_listcustomer.Text = "KHÁCH HÀNG";
            this.btn_listcustomer.UseVisualStyleBackColor = false;
            this.btn_listcustomer.Click += new System.EventHandler(this.btn_listcustomer_Click);
            // 
            // btn_listcontract
            // 
            this.btn_listcontract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_listcontract.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listcontract.ForeColor = System.Drawing.Color.Gold;
            this.btn_listcontract.Location = new System.Drawing.Point(764, 12);
            this.btn_listcontract.Name = "btn_listcontract";
            this.btn_listcontract.Size = new System.Drawing.Size(387, 466);
            this.btn_listcontract.TabIndex = 2;
            this.btn_listcontract.Text = "HỢP ĐỒNG";
            this.btn_listcontract.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 492);
            this.Controls.Add(this.btn_listcontract);
            this.Controls.Add(this.btn_listcustomer);
            this.Controls.Add(this.btn_ListVehicle);
            this.Name = "FormMain";
            this.Text = "BigMomForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListVehicle;
        private System.Windows.Forms.Button btn_listcustomer;
        private System.Windows.Forms.Button btn_listcontract;
    }
}