using System.Windows;
using System.Data.SqlClient;
using System.Data;
using KTPMUD;
using System.Collections.Generic;
using Models;
using System;

namespace KTPMUD

{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    class Program
    {
        [STAThread] // Thêm này để hỗ trợ WPF và Windows Forms
        static void Main()
        {
            // Tạo và hiển thị cửa sổ đăng nhập
            Application app = new Application();
            LoginWindow loginWindow = new LoginWindow();
            app.Run(loginWindow);
        }
    }
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }
        internal static Users currentUser;
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            // Xác thực đăng nhập
            string username = txtUsername.Text;
            string password = txtPassword.Password;

            // Kiểm tra xác nhận đăng nhập
            if (CheckLogin(username, password))
            {
                MessageBox.Show("Đăng nhập thành công"); 

                new HomeWindow().Show();

                Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tài khoản và mật khẩu.");
            }

        }
        private bool CheckLogin(string username, string password)
        {
            List<Users> NguoiDung = new Provider().Select<Users>($"SELECT * FROM {typeof(Users).Name};");
            foreach (var usr in NguoiDung)
            {
                if (usr.Acc == username && usr.Pass == password)
                {
                    currentUser = usr;
                    return true;
                }
            }
            return false;
        }
    }
}
