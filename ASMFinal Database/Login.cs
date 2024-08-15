using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asm2_attendance
{
    public partial class Login : Form
    {
        SqlConnectionStringBuilder sqlstrbuilder = new SqlConnectionStringBuilder();
        public Login()
        {
            InitializeComponent();
            sqlstrbuilder["Server"] = "ADMIN-PC\\SQLEXPRESS";
            sqlstrbuilder["Database"] = "ASM_STD_ATT";
            sqlstrbuilder["Integrated Security"] = "True";
            sqlstrbuilder["Trusted_Connection"] = "Yes";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtpass.Text = "";
            txtuser.Text = "";
        }

        private SqlConnection GetConnection()
        {
            string sql = sqlstrbuilder.ToString();
            var Sqlcon = new SqlConnection(sql);
            try
            {
                if (Sqlcon.State == ConnectionState.Closed)
                {
                    Sqlcon.Open();
                    //MessageBox.Show("Kết Nối Thành Công");
                }
                //LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi : " + ex.Message);
            }
            finally
            {
                Sqlcon.Close();
            }
            return Sqlcon;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string password = txtpass.Text;

            SqlConnection sqlConnection = GetConnection();
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandText = "SELECT Role FROM Users WHERE username = @username AND password = @pass";
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pass", password);

            try
            {
                // Mở kết nối
                

                // Thực thi câu lệnh SQL và lấy vai trò của người dùng
                string role = (string)cmd.ExecuteScalar();

                if (!string.IsNullOrEmpty(role))
                {
                    // Nếu vai trò được xác định, mở form tương ứng
                    MessageBox.Show("Login successful!");

                    switch (role)
                    {
                        case "student":
                            this.Hide();
                            StudentForm formStudent = new StudentForm();
                            formStudent.ShowDialog();
                            break;

                        case "teacher":
                            this.Hide();
                            TeacherForm formTeacher = new TeacherForm();
                            formTeacher.ShowDialog();
                            break;



                        default:
                            MessageBox.Show("Vai trò không xác định!");
                            break;
                    }

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Users formlogin = new Users();
            formlogin.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_pass forgotPasswordForm = new Forgot_pass();
            forgotPasswordForm.Show();
        }
    }
    
}
