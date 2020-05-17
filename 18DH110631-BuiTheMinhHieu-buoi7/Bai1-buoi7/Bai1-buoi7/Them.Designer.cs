namespace Bai1_buoi7
{
    partial class Them
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
            this.lblMSHH = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMSHH = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.rdTrue = new System.Windows.Forms.RadioButton();
            this.rdFalse = new System.Windows.Forms.RadioButton();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSHH
            // 
            this.lblMSHH.AutoSize = true;
            this.lblMSHH.Location = new System.Drawing.Point(70, 34);
            this.lblMSHH.Name = "lblMSHH";
            this.lblMSHH.Size = new System.Drawing.Size(84, 13);
            this.lblMSHH.TabIndex = 0;
            this.lblMSHH.Text = "Mã số hàng hóa";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(70, 70);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(74, 13);
            this.lblTenHang.TabIndex = 1;
            this.lblTenHang.Text = "Tên hàng hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gía";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tình Trạng";
            // 
            // txtMSHH
            // 
            this.txtMSHH.Location = new System.Drawing.Point(188, 34);
            this.txtMSHH.Name = "txtMSHH";
            this.txtMSHH.Size = new System.Drawing.Size(189, 20);
            this.txtMSHH.TabIndex = 4;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(188, 70);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(189, 20);
            this.txtTenHang.TabIndex = 5;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(188, 105);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(189, 20);
            this.txtGia.TabIndex = 6;
            // 
            // rdTrue
            // 
            this.rdTrue.AutoSize = true;
            this.rdTrue.Checked = true;
            this.rdTrue.Location = new System.Drawing.Point(188, 141);
            this.rdTrue.Name = "rdTrue";
            this.rdTrue.Size = new System.Drawing.Size(73, 17);
            this.rdTrue.TabIndex = 7;
            this.rdTrue.TabStop = true;
            this.rdTrue.Text = "Còn Hàng";
            this.rdTrue.UseVisualStyleBackColor = true;
            // 
            // rdFalse
            // 
            this.rdFalse.AutoSize = true;
            this.rdFalse.Location = new System.Drawing.Point(292, 141);
            this.rdFalse.Name = "rdFalse";
            this.rdFalse.Size = new System.Drawing.Size(71, 17);
            this.rdFalse.TabIndex = 8;
            this.rdFalse.TabStop = true;
            this.rdFalse.Text = "Hết Hàng";
            this.rdFalse.UseVisualStyleBackColor = true;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(188, 192);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 9;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(302, 192);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 315);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.rdFalse);
            this.Controls.Add(this.rdTrue);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMSHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lblMSHH);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSHH;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMSHH;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.RadioButton rdTrue;
        private System.Windows.Forms.RadioButton rdFalse;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
    }
}