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
    public partial class Users : Form
    {
        SqlConnectionStringBuilder sqlstrbuilder = new SqlConnectionStringBuilder();
        public Users()
        {
           
            InitializeComponent();
            sqlstrbuilder["Server"] = "ADMIN-PC\\SQLEXPRESS";
            sqlstrbuilder["Database"] = "ASM_STD_ATT";
            sqlstrbuilder["Integrated Security"] = "True";
            sqlstrbuilder["Trusted_Connection"] = "Yes";
        }

        private void Users_Load(object sender, EventArgs e)
        {
            txtuserid.Text = "";
            LoadData();
            
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
        private void LoadData()
        {
            string sql = sqlstrbuilder.ToString();
            var Sqlcon = new SqlConnection(sql);
            Sqlcon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Sqlcon;
            cmd.CommandText = "SELECT * FROM Users";
            var sqlreader = cmd.ExecuteReader();
            
            var datatable = new DataTable();
            datatable.Load(sqlreader);
            dataGridView1.DataSource = datatable;

            Sqlcon.Close();
        }
        private int GenerateNewUserID()
        {
            int newUserID = 0;
            SqlConnection sqlConnection = GetConnection();
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlConnection;
                cmd.CommandText = "SELECT ISNULL(MAX(userID), 0) + 1 FROM Users";
                newUserID = (int)cmd.ExecuteScalar();
            }
            sqlConnection.Close();
            return newUserID;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int userID;
            if (!int.TryParse(txtuserid.Text, out userID))
            {
                userID = GenerateNewUserID();
            }

            string username = txtusername.Text;
            string password = txtpass.Text;
            string firstname = txtfirstname.Text;
            string lastname = txtlastname.Text;
            string phone = txtphone.Text;
            string dateofbirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string role = rbtnadmin.Checked ? "admin" : (rbtnteacher.Checked ? "teacher" : "student");

            using (SqlConnection sqlConnection = GetConnection())
            {
                sqlConnection.Open();
                if (sqlConnection.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = "SET IDENTITY_INSERT Users ON; " +
                                      "INSERT INTO Users (userID, username, password, role, phone, firstname, lastname, dateofbirth) VALUES (@userID, @username, @pass, @role, @phone, @firstname, @lastname, @dateofbirth); " +
                                      "SET IDENTITY_INSERT Users OFF";
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@firstname", firstname);
                    cmd.Parameters.AddWithValue("@lastname", lastname);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                    cmd.Parameters.AddWithValue("@role", role);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Không thể thêm được người dùng");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                        LoadData();
                    }
                }
            }
        }


        private void btnedit_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(txtuserid.Text);
            if (userID > 0)
            {
                string username = txtusername.Text;
                string password = txtpass.Text;
                string firstname = txtfirstname.Text;
                string lastname = txtlastname.Text;
                string phone = txtphone.Text;
                string dateofbirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string role = rbtnadmin.Checked ? "admin" : (rbtnteacher.Checked ? "teacher" : "student");

                using (SqlConnection sqlConnection = GetConnection())
                {
                    sqlConnection.Open();
                    if (sqlConnection.State == ConnectionState.Open)
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = sqlConnection;
                        cmd.CommandText = "UPDATE Users SET " +
                                          "username = @username, " +
                                          "password = @pass, " +
                                          "firstname = @firstname, " +
                                          "lastname = @lastname, " +
                                          "phone = @phone, " +
                                          "role = @role, " +
                                          "dateofbirth = @dateofbirth " +
                                          "WHERE userID = @userID";
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@firstname", firstname);
                        cmd.Parameters.AddWithValue("@lastname", lastname);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                        cmd.Parameters.AddWithValue("@role", role);

                        var result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Không thể cập nhật được người dùng");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thành công");
                            LoadData();
                        }
                    }
                }
            }
        }


        private void btndelect_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(txtuserid.Text);
            if (userID > 0)
            {
               
                SqlConnection sqlConnection = GetConnection();
                sqlConnection.Open();
                if (sqlConnection.State == ConnectionState.Open)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = "DELETE FROM Users WHERE userID = @userID ";
                    cmd.Parameters.AddWithValue("userID", userID);
                    //cmd.Parameters.AddWithValue("username", username);
                    //cmd.Parameters.AddWithValue("password", password);
                    //cmd.Parameters.AddWithValue("firstname", firstname);
                    //cmd.Parameters.AddWithValue("lastname", lastname);
                    //cmd.Parameters.AddWithValue("email", email);
                    //cmd.Parameters.Add("dob", SqlDbType.Date).Value = dob;
                    //cmd.Parameters.AddWithValue("role", role);

                    var result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Khong the xoa duoc user");
                    }
                    else
                    {
                        MessageBox.Show("Xoa thanh cong");
                        LoadData();
                    }
                }
                sqlConnection.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            int userID = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
            txtuserid.Text = userID.ToString();
            txtfirstname.Text = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
            txtlastname.Text = Convert.ToString(dataGridView1.Rows[index].Cells[4].Value);
            txtusername.Text = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            txtpass.Text = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            txtphone.Text = Convert.ToString(dataGridView1.Rows[index].Cells[5].Value);
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[index].Cells[6].Value.ToString());

            if (Convert.ToString(dataGridView1.Rows[index].Cells[7].Value) == "admin")
            {
                rbtnadmin.Checked = true;
            }
            else if (Convert.ToString(dataGridView1.Rows[index].Cells[7].Value) == "teacher")
            {
                rbtnteacher.Checked = true;
            }
            else
            {
                rbtnstudent.Checked = true;
            }
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                this.Hide();

                Login formlogin = new Login();
                formlogin.ShowDialog();

                this.Close();
            }
        }

        private void txtfirstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlastname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
