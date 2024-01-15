using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KTPMUD
{
    /// <summary>
    /// Interaction logic for SignupWindow.xaml
    /// </summary>
    public partial class SignupWindow : Window
    {
        public SignupWindow()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Lấy giá trị từ các ô nhập liệu
                string acc = txtAcc.Text;
                string pass = txtPass.Text;
                string username = txtUsername.Text;
                int age = int.Parse(txtAge.Text);
                string gender = txtGender.Text;

                // Thêm tài khoản mới vào cơ sở dữ liệu
                AddNewAccount(acc, pass, username, age, gender);

                if(IsAccountExist(acc))
                {
                    return;
                }    
                else
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đăng ký tài khoản: {ex.Message}");
            }
        }

        private void AddNewAccount(string acc, string pass, string username, int age, string gender)
        {
            try
            {
                // Kiểm tra xem tài khoản đã tồn tại chưa
                if (IsAccountExist(acc))
                {
                    MessageBox.Show("Tài khoản đã tồn tại. Vui lòng chọn một tài khoản khác.");
                    return;
                }

                // Thực hiện lệnh SQL để thêm tài khoản mới
                string insertQuery = $"INSERT INTO {typeof(Users).Name} VALUES ('{acc}', '{pass}', '{username}', {age}, '{gender}')";

                if (new Models.Provider().Execute(insertQuery))
                {
                    MessageBox.Show("Thêm tài khoản mới thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm tài khoản mới không thành công.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm tài khoản mới: {ex.Message}");
            }
        }

        private bool IsAccountExist(string acc)
        {
            // Kiểm tra xem tài khoản đã tồn tại trong cơ sở dữ liệu chưa
            List<Users> existingAccounts = new Models.Provider().Select<Users>($"SELECT * FROM {typeof(Users).Name} WHERE Acc = '{acc}'");
            return existingAccounts.Count > 0;
        }
    }
}
