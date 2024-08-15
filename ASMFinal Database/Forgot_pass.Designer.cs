namespace asm2_attendance
{
    partial class Forgot_pass
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
            this.txtphone = new System.Windows.Forms.TextBox();
            this.btnshowpass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(383, 246);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(284, 22);
            this.txtphone.TabIndex = 0;
            // 
            // btnshowpass
            // 
            this.btnshowpass.Location = new System.Drawing.Point(439, 316);
            this.btnshowpass.Name = "btnshowpass";
            this.btnshowpass.Size = new System.Drawing.Size(118, 27);
            this.btnshowpass.TabIndex = 1;
            this.btnshowpass.Text = "Show Password";
            this.btnshowpass.UseVisualStyleBackColor = true;
            this.btnshowpass.Click += new System.EventHandler(this.btnshowpass_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(349, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 97);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập số điện thoại để tìm mật khẩu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Forgot_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 569);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshowpass);
            this.Controls.Add(this.txtphone);
            this.Name = "Forgot_pass";
            this.Text = "Forgot_pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnshowpass;
        private System.Windows.Forms.Label label1;
    }
}