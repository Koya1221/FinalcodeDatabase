using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace asm2_attendance
{
    public partial class TeacherForm : Form
    {
        //private readonly string connectionString;
        SqlConnectionStringBuilder sqlstrbuilder = new SqlConnectionStringBuilder();

        public TeacherForm()
        {
            
            InitializeComponent();
            {
                sqlstrbuilder["Server"] = "ADMIN-PC\\SQLEXPRESS";
                sqlstrbuilder["Database"] = "ASM_STD_ATT";
                sqlstrbuilder["Integrated Security"] = "True";
                sqlstrbuilder["Trusted_Connection"] = "Yes";
            };
            
        }

        private SqlConnection GetConnection()
        {
            var connectionString = sqlstrbuilder.ToString();
            var sqlcon = new SqlConnection(connectionString);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
               
            }
            //finally 
            //{ 
            //    sqlcon.Close(); 
            //}
            return sqlcon;
        }
        private void LoadData()
        {
            using (var sqlcon = GetConnection())
            {
                // Truy vấn kết hợp giữa bảng Grades, Students và Class để lấy StudentName và ClassName
                var query = @"
            SELECT g.GradesID, s.StudentName, c.ClassName, g.Semester1Scores, g.Semester2Scores, g.FinalScores
            FROM Grades g
            JOIN Students s ON g.StudentID = s.StudentID
            JOIN Class c ON g.ClassID = c.ClassID";

                using (var cmd = new SqlCommand(query, sqlcon))
                {
                    using (var sqlreader = cmd.ExecuteReader())
                    {
                        var datatable = new DataTable();
                        datatable.Load(sqlreader);
                        dataGridView1.DataSource = datatable;
                    }
                }
            }
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            int gradeID = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

            txtGradeID.Text = gradeID.ToString();
            TXTStudentID.Text = dataGridView1.Rows[index].Cells["StudentName"].Value.ToString();
            txtClass.Text = dataGridView1.Rows[index].Cells["ClassName"].Value.ToString();
            txtS1S.Text = dataGridView1.Rows[index].Cells["Semester1Scores"].Value.ToString();
            txtS2S.Text = dataGridView1.Rows[index].Cells["Semester2Scores"].Value.ToString();
            txtFS.Text = dataGridView1.Rows[index].Cells["FinalScores"].Value.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                try
                {
                    using (var sqlcon = GetConnection())
                    {
                        // Thêm dữ liệu vào bảng Grades
                        var query = @"
                    INSERT INTO Grades (GradesID, StudentID, ClassID, Semester1Scores, Semester2Scores, FinalScores)
                    VALUES (@GradeID, (SELECT StudentID FROM Students WHERE StudentName = @StudentName), 
                            (SELECT ClassID FROM Class WHERE ClassName = @ClassName), @S1S, @S2S, @FS)";

                        using (var cmd = new SqlCommand(query, sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@GradeID", txtGradeID.Text);
                            cmd.Parameters.AddWithValue("@StudentName", TXTStudentID.Text);
                            cmd.Parameters.AddWithValue("@ClassName", txtClass.Text);
                            cmd.Parameters.AddWithValue("@S1S", txtS1S.Text);
                            cmd.Parameters.AddWithValue("@S2S", txtS2S.Text);
                            cmd.Parameters.AddWithValue("@FS", txtFS.Text);
                            cmd.ExecuteNonQuery();
                            LoadData();
                            MessageBox.Show("Data added successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (IsInputValid())
            {
                try
                {
                    using (var sqlcon = GetConnection())
                    {
                        // Cập nhật dữ liệu trong bảng Grades
                        var query = @"
                    UPDATE Grades 
                    SET StudentID = (SELECT StudentID FROM Students WHERE StudentName = @StudentName), 
                        ClassID = (SELECT ClassID FROM Class WHERE ClassName = @ClassName), 
                        Semester1Scores = @S1S, Semester2Scores = @S2S, FinalScores = @FS 
                    WHERE GradesID = @GradeID";

                        using (var cmd = new SqlCommand(query, sqlcon))
                        {
                            cmd.Parameters.AddWithValue("@GradeID", txtGradeID.Text);
                            cmd.Parameters.AddWithValue("@StudentName", TXTStudentID.Text);
                            cmd.Parameters.AddWithValue("@ClassName", txtClass.Text);
                            cmd.Parameters.AddWithValue("@S1S", txtS1S.Text);
                            cmd.Parameters.AddWithValue("@S2S", txtS2S.Text);
                            cmd.Parameters.AddWithValue("@FS", txtFS.Text);
                            cmd.ExecuteNonQuery();
                            LoadData();
                            MessageBox.Show("Data updated successfully!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    using (var sqlcon = GetConnection())
                    {
                        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                        {
                            var gradeID = row.Cells["GradesID"].Value.ToString();
                            var query = "DELETE FROM Grades WHERE GradesID = @GradeID";

                            using (var cmd = new SqlCommand(query, sqlcon))
                            {
                                cmd.Parameters.AddWithValue("@GradeID", gradeID);
                                cmd.ExecuteNonQuery();
                            }
                            dataGridView1.Rows.Remove(row);
                        }
                        MessageBox.Show("Data deleted successfully!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select rows to delete.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        private bool IsInputValid()
        {
            return !string.IsNullOrWhiteSpace(txtGradeID.Text) &&
                   !string.IsNullOrWhiteSpace(TXTStudentID.Text) &&
                   !string.IsNullOrWhiteSpace(txtClass.Text) &&
                   !string.IsNullOrWhiteSpace(txtS1S.Text) &&
                   !string.IsNullOrWhiteSpace(txtS2S.Text) &&
                   !string.IsNullOrWhiteSpace(txtFS.Text);
        }





        private void btngrade_Click(object sender, EventArgs e)
        {

        }

        private void txtGradeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXTStudentID_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            

        }

        private void TeacherTranscript_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            //int gradeID = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

            txtClass.Text = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            txtFS.Text = Convert.ToString(dataGridView1.Rows[index].Cells[5].Value);
            txtGradeID.Text = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
            txtS1S.Text = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
            txtS2S.Text = Convert.ToString(dataGridView1.Rows[index].Cells[4].Value);
            TXTStudentID.Text = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);

        }
    }
}
