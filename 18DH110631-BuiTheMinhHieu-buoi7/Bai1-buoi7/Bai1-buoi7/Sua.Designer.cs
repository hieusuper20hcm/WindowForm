namespace Bai1_buoi7
{
    partial class Sua
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnChinhMoi = new System.Windows.Forms.Button();
            this.rdFalse = new System.Windows.Forms.RadioButton();
            this.rdTrue = new System.Windows.Forms.RadioButton();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMSHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblMSHH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(326, 232);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnChinhMoi
            // 
            this.btnChinhMoi.Location = new System.Drawing.Point(212, 232);
            this.btnChinhMoi.Name = "btnChinhMoi";
            this.btnChinhMoi.Size = new System.Drawing.Size(75, 23);
            this.btnChinhMoi.TabIndex = 20;
            this.btnChinhMoi.Text = "Chỉnh Mới";
            this.btnChinhMoi.UseVisualStyleBackColor = true;
            this.btnChinhMoi.Click += new System.EventHandler(this.btnChinhMoi_Click);
            // 
            // rdFalse
            // 
            this.rdFalse.AutoSize = true;
            this.rdFalse.Location = new System.Drawing.Point(330, 176);
            this.rdFalse.Name = "rdFalse";
            this.rdFalse.Size = new System.Drawing.Size(71, 17);
            this.rdFalse.TabIndex = 19;
            this.rdFalse.Text = "Hết Hàng";
            this.rdFalse.UseVisualStyleBackColor = true;
            // 
            // rdTrue
            // 
            this.rdTrue.AutoSize = true;
            this.rdTrue.Checked = true;
            this.rdTrue.Location = new System.Drawing.Point(212, 176);
            this.rdTrue.Name = "rdTrue";
            this.rdTrue.Size = new System.Drawing.Size(73, 17);
            this.rdTrue.TabIndex = 18;
            this.rdTrue.TabStop = true;
            this.rdTrue.Text = "Còn Hàng";
            this.rdTrue.UseVisualStyleBackColor = true;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(212, 135);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(189, 20);
            this.txtGia.TabIndex = 17;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(212, 99);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(189, 20);
            this.txtTenHang.TabIndex = 16;
            // 
            // txtMSHH
            // 
            this.txtMSHH.Location = new System.Drawing.Point(212, 59);
            this.txtMSHH.Name = "txtMSHH";
            this.txtMSHH.Size = new System.Drawing.Size(189, 20);
            this.txtMSHH.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tình Trạng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gía";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(80, 106);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(74, 13);
            this.lblTenHang.TabIndex = 12;
            this.lblTenHang.Text = "Tên hàng hóa";
            // 
            // lblMSHH
            // 
            this.lblMSHH.AutoSize = true;
            this.lblMSHH.Location = new System.Drawing.Point(80, 59);
            this.lblMSHH.Name = "lblMSHH";
            this.lblMSHH.Size = new System.Drawing.Size(84, 13);
            this.lblMSHH.TabIndex = 11;
            this.lblMSHH.Text = "Mã số hàng hóa";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnChinhMoi);
            this.Controls.Add(this.rdFalse);
            this.Controls.Add(this.rdTrue);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMSHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lblMSHH);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnChinhMoi;
        private System.Windows.Forms.RadioButton rdFalse;
        private System.Windows.Forms.RadioButton rdTrue;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMSHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblMSHH;
    }
}