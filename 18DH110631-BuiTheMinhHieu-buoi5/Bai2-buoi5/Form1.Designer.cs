namespace Bai2_buoi5
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTuSoA = new System.Windows.Forms.TextBox();
            this.txtMauSoA = new System.Windows.Forms.TextBox();
            this.txtTuSoB = new System.Windows.Forms.TextBox();
            this.txtMauSoB = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhap tu so a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhap mau so a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhap tu so b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhap mau so b:";
            // 
            // txtTuSoA
            // 
            this.txtTuSoA.Location = new System.Drawing.Point(168, 35);
            this.txtTuSoA.Name = "txtTuSoA";
            this.txtTuSoA.Size = new System.Drawing.Size(100, 20);
            this.txtTuSoA.TabIndex = 4;
            // 
            // txtMauSoA
            // 
            this.txtMauSoA.Location = new System.Drawing.Point(168, 73);
            this.txtMauSoA.Name = "txtMauSoA";
            this.txtMauSoA.Size = new System.Drawing.Size(100, 20);
            this.txtMauSoA.TabIndex = 5;
            // 
            // txtTuSoB
            // 
            this.txtTuSoB.Location = new System.Drawing.Point(168, 109);
            this.txtTuSoB.Name = "txtTuSoB";
            this.txtTuSoB.Size = new System.Drawing.Size(100, 20);
            this.txtTuSoB.TabIndex = 6;
            // 
            // txtMauSoB
            // 
            this.txtMauSoB.Location = new System.Drawing.Point(168, 157);
            this.txtMauSoB.Name = "txtMauSoB";
            this.txtMauSoB.Size = new System.Drawing.Size(100, 20);
            this.txtMauSoB.TabIndex = 7;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(191, 198);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(0, 13);
            this.lblKetQua.TabIndex = 8;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(157, 225);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(111, 23);
            this.btnTinh.TabIndex = 9;
            this.btnTinh.Text = "Tong 2 phan so";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 286);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtMauSoB);
            this.Controls.Add(this.txtTuSoB);
            this.Controls.Add(this.txtMauSoA);
            this.Controls.Add(this.txtTuSoA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTuSoA;
        private System.Windows.Forms.TextBox txtMauSoA;
        private System.Windows.Forms.TextBox txtTuSoB;
        private System.Windows.Forms.TextBox txtMauSoB;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnTinh;
    }
}

