namespace Bai1_buoi7
{
    partial class Xoa
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
            this.txtMSHH = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMSHH
            // 
            this.lblMSHH.AutoSize = true;
            this.lblMSHH.Location = new System.Drawing.Point(132, 85);
            this.lblMSHH.Name = "lblMSHH";
            this.lblMSHH.Size = new System.Drawing.Size(125, 13);
            this.lblMSHH.TabIndex = 11;
            this.lblMSHH.Text = "Mã số hàng hóa cần xóa";
            // 
            // txtMSHH
            // 
            this.txtMSHH.Location = new System.Drawing.Point(260, 78);
            this.txtMSHH.Name = "txtMSHH";
            this.txtMSHH.Size = new System.Drawing.Size(189, 20);
            this.txtMSHH.TabIndex = 15;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(260, 146);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(374, 146);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // Xoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtMSHH);
            this.Controls.Add(this.lblMSHH);
            this.Name = "Xoa";
            this.Text = "Xoa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMSHH;
        private System.Windows.Forms.TextBox txtMSHH;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
    }
}