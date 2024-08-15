using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace asm2_attendance
{
    public partial class StudentForm : Form
    {
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTable;

        public DataTable DataTableFromTeacher { get; set; }

        public StudentForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            var sqlstrbuilder = new SqlConnectionStringBuilder
            {
                ["Server"] = "ADMIN-PC\\SQLEXPRESS",
                ["Database"] = "ASM_STD_ATT",
                ["Integrated Security"] = true,
                ["TrustServerCertificate"] = true
            };

            sqlConnection = new SqlConnection(sqlstrbuilder.ToString());
        }

        private void LoadData()
        {
            try
            {
                sqlConnection.Open();

                // Cập nhật câu truy vấn để kết hợp dữ liệu từ bảng Students và Class
                string query = @"
            SELECT g.GradesID, s.StudentName, c.ClassName, g.Semester1Scores, g.Semester2Scores, g.FinalScores
            FROM Grades g
            JOIN Students s ON g.StudentID = s.StudentID
            JOIN Class c ON g.ClassID = c.ClassID";

                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                var sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);

                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        private void StudentForm_Load(object sender, EventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

            private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateData();
            MessageBox.Show("Data has been updated successfully.");
        }

        private void UpdateData()
        {
            if (dataTable == null) return;

            try
            {
                sqlConnection.Open();
                sqlDataAdapter.Update(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating data: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();  // Close the current form after logout
        }

        private void btngrade_Click(object sender, EventArgs e)
        {
            // Assuming this button also saves data; otherwise, implement the intended functionality
            UpdateData();
            MessageBox.Show("Data has been updated successfully.");
            if (DataTableFromTeacher != null && DataTableFromTeacher.Rows.Count > 0)
            {
                dataGridView1.DataSource = DataTableFromTeacher;
            }
            else
            {
                LoadData();
            }
        }
    }
}
