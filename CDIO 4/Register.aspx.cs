using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CDIO_4
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            string userName = TextBoxUserName.Text;
            string password = TextBoxPassword.Text;
            string confirmPassword = TextBoxConfirmPassword.Text;

            if (password != confirmPassword)
            {
                LabelMessage.Text = "Mật khẩu và xác nhận mật khẩu không khớp. Vui lòng thử lại.";
                return;
            }

            using (SqlConnection myCon = new SqlConnection(ConfigurationManager.ConnectionStrings["ShopConnection"].ConnectionString))
            {
                myCon.Open();

                // KT xem tài khoản đã tồn tại chưa
                string checkUserQuery = "SELECT COUNT(*) FROM Nguoidung WHERE UserName = @UserName";
                SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, myCon);
                checkUserCmd.Parameters.AddWithValue("@UserName", userName);
                int userExists = (int)checkUserCmd.ExecuteScalar();

                if (userExists > 0)
                {
                    LabelMessage.Text = "Tài khoản đã tồn tại. Vui lòng chọn tài khoản khác.";
                }
                else
                {
                    // add tài khoản mới vào cơ sở dữ liệu
                    string insertQuery = "INSERT INTO Nguoidung (UserName, Pass) VALUES (@UserName, @Password)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, myCon);
                    insertCmd.Parameters.AddWithValue("@UserName", userName);
                    insertCmd.Parameters.AddWithValue("@Password", password);

                    int result = insertCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        LabelMessage.Text = "Đăng ký tài khoản thành công!";
                    }
                    else
                    {
                        LabelMessage.Text = "Đăng ký tài khoản thất bại. Vui lòng thử lại.";
                    }
                }
            }
        }
    }
}