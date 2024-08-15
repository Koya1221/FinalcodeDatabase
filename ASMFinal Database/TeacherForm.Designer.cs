namespace asm2_attendance
{
    partial class TeacherForm
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
            this.btnadd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btngrade = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtGradeID = new System.Windows.Forms.TextBox();
            this.TXTStudentID = new System.Windows.Forms.TextBox();
            this.txtS1S = new System.Windows.Forms.TextBox();
            this.txtS2S = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnadd.Location = new System.Drawing.Point(89, 365);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(60, 40);
            this.btnadd.TabIndex = 75;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnEdit.Location = new System.Drawing.Point(10, 365);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(57, 40);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.Text = "Editt";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(474, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 71;
            this.label2.Text = "Grades";
            // 
            // btngrade
            // 
            this.btngrade.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btngrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngrade.ForeColor = System.Drawing.Color.Black;
            this.btngrade.Location = new System.Drawing.Point(31, 149);
            this.btngrade.Margin = new System.Windows.Forms.Padding(2);
            this.btngrade.Name = "btngrade";
            this.btngrade.Size = new System.Drawing.Size(118, 48);
            this.btngrade.TabIndex = 70;
            this.btngrade.Text = "Grades";
            this.btngrade.UseVisualStyleBackColor = false;
            this.btngrade.Click += new System.EventHandler(this.btngrade_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(5, 139);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 318);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 118);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 339);
            this.dataGridView1.TabIndex = 68;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Location = new System.Drawing.Point(171, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(630, 64);
            this.button2.TabIndex = 67;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(5, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 124);
            this.button1.TabIndex = 66;
            this.button1.Text = "Teacher";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLogout.Location = new System.Drawing.Point(89, 411);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(60, 37);
            this.btnLogout.TabIndex = 76;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btndelete.Location = new System.Drawing.Point(10, 411);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(59, 37);
            this.btndelete.TabIndex = 77;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtGradeID
            // 
            this.txtGradeID.Location = new System.Drawing.Point(75, 204);
            this.txtGradeID.Name = "txtGradeID";
            this.txtGradeID.Size = new System.Drawing.Size(74, 20);
            this.txtGradeID.TabIndex = 78;
            this.txtGradeID.TextChanged += new System.EventHandler(this.txtGradeID_TextChanged);
            // 
            // TXTStudentID
            // 
            this.TXTStudentID.Location = new System.Drawing.Point(75, 230);
            this.TXTStudentID.Name = "TXTStudentID";
            this.TXTStudentID.Size = new System.Drawing.Size(74, 20);
            this.TXTStudentID.TabIndex = 79;
            this.TXTStudentID.TextChanged += new System.EventHandler(this.TXTStudentID_TextChanged);
            // 
            // txtS1S
            // 
            this.txtS1S.Location = new System.Drawing.Point(75, 285);
            this.txtS1S.Name = "txtS1S";
            this.txtS1S.Size = new System.Drawing.Size(74, 20);
            this.txtS1S.TabIndex = 96;
            // 
            // txtS2S
            // 
            this.txtS2S.Location = new System.Drawing.Point(75, 313);
            this.txtS2S.Name = "txtS2S";
            this.txtS2S.Size = new System.Drawing.Size(74, 20);
            this.txtS2S.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "GradeID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 84;
            this.label4.Text = "Student";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "S1S";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "S2S";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtuserid
            // 
            this.txtuserid.AutoSize = true;
            this.txtuserid.Location = new System.Drawing.Point(155, 435);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(0, 13);
            this.txtuserid.TabIndex = 88;
            this.txtuserid.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "FS";
            // 
            // txtFS
            // 
            this.txtFS.Location = new System.Drawing.Point(75, 339);
            this.txtFS.Name = "txtFS";
            this.txtFS.Size = new System.Drawing.Size(74, 20);
            this.txtFS.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 97;
            this.label5.Text = "Class";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(75, 259);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(74, 20);
            this.txtClass.TabIndex = 98;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFS);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtS2S);
            this.Controls.Add(this.txtS1S);
            this.Controls.Add(this.TXTStudentID);
            this.Controls.Add(this.txtGradeID);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngrade);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "TeacherForm";
            this.Text = "S";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngrade;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtGradeID;
        private System.Windows.Forms.TextBox TXTStudentID;
        private System.Windows.Forms.TextBox txtS1S;
        private System.Windows.Forms.TextBox txtS2S;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtuserid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClass;
    }
}