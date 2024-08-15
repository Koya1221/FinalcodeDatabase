namespace asm2_attendance
{
    partial class Courses
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
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.lblcourseid = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(561, 147);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(100, 22);
            this.txtcourse.TabIndex = 0;
            this.txtcourse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblcourseid
            // 
            this.lblcourseid.AutoSize = true;
            this.lblcourseid.Location = new System.Drawing.Point(460, 153);
            this.lblcourseid.Name = "lblcourseid";
            this.lblcourseid.Size = new System.Drawing.Size(63, 16);
            this.lblcourseid.TabIndex = 1;
            this.lblcourseid.Text = "CourseID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 328);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 241);
            this.dataGridView1.TabIndex = 2;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblcourseid);
            this.Controls.Add(this.txtcourse);
            this.Name = "Courses";
            this.Text = "Courses";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.Label lblcourseid;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}