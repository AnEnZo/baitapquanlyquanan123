namespace ChucNangDangNhap
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
            this.tbtendangnhap = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.btndangnhap = new System.Windows.Forms.Button();
            this.btndangky = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(50, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "mật khâu:";
            // 
            // tbtendangnhap
            // 
            this.tbtendangnhap.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbtendangnhap.Location = new System.Drawing.Point(144, 234);
            this.tbtendangnhap.Name = "tbtendangnhap";
            this.tbtendangnhap.Size = new System.Drawing.Size(221, 22);
            this.tbtendangnhap.TabIndex = 2;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tbmatkhau.Location = new System.Drawing.Point(144, 304);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(221, 22);
            this.tbmatkhau.TabIndex = 3;
            // 
            // btndangnhap
            // 
            this.btndangnhap.Location = new System.Drawing.Point(133, 377);
            this.btndangnhap.Name = "btndangnhap";
            this.btndangnhap.Size = new System.Drawing.Size(232, 44);
            this.btndangnhap.TabIndex = 4;
            this.btndangnhap.Text = "Đăng nhập";
            this.btndangnhap.UseVisualStyleBackColor = true;
            this.btndangnhap.Click += new System.EventHandler(this.button1_Click);
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(133, 449);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(232, 38);
            this.btndangky.TabIndex = 5;
            this.btndangky.Text = "Đăng Ký";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.btndangky_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 529);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.btndangnhap);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtendangnhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtendangnhap;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.Button btndangnhap;
        private System.Windows.Forms.Button btndangky;
    }
}

