namespace ChucNangDangNhap
{
    partial class fdangky
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.tbtendangnhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btndangky = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(160, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbmatkhau);
            this.panel1.Controls.Add(this.tbtendangnhap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(23, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 146);
            this.panel1.TabIndex = 1;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbmatkhau.Location = new System.Drawing.Point(145, 98);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(231, 22);
            this.tbmatkhau.TabIndex = 7;
            // 
            // tbtendangnhap
            // 
            this.tbtendangnhap.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbtendangnhap.Location = new System.Drawing.Point(145, 28);
            this.tbtendangnhap.Name = "tbtendangnhap";
            this.tbtendangnhap.Size = new System.Drawing.Size(231, 22);
            this.tbtendangnhap.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "mật khâu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "tên đăng nhập:";
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(167, 377);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(232, 38);
            this.btndangky.TabIndex = 6;
            this.btndangky.Text = "Đăng Ký";
            this.btndangky.UseVisualStyleBackColor = true;
            // 
            // fdangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 511);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fdangky";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fdangky";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.TextBox tbtendangnhap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btndangky;
    }
}