using Models;
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
    /// Interaction logic for ListWindow.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        public ListWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Kiểm tra xem người dùng đã đăng nhập hay chưa.
                if (LoginWindow.currentUser == null)
                {
                    MessageBox.Show("Hiện không có người dùng nào đã đăng nhập.");
                    return;
                }

                // Tải danh sách Thu/Chi cho người dùng hiện tại.
                List<IncomeExpenseView> incomeExpenses = new Provider().Select<IncomeExpenseView>($"SELECT * FROM {typeof(IncomeExpenseView).Name} WHERE UsersAcc = '{LoginWindow.currentUser.Acc}';");

                // Hiển thị dữ liệu trong DataGrid.
                dataGrid.ItemsSource = incomeExpenses;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra trong quá trình tải danh sách thu/chi: {ex.Message}");
            }
        }

        private void btnCLose_Click(object sender, RoutedEventArgs e)
        {
            new HomeWindow().Show();
            Close();
        }
    }
}
