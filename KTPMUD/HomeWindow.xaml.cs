using System.Windows;
using System.Data.SqlClient;
using System.Data;

namespace KTPMUD
{
    /// <summary>
    /// Interaction logic for HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
        }

        private void btnIncomeAndExpense_Click(object sender, RoutedEventArgs e)
        {
            // Mở cửa sổ IncomeAndExpense
            IncomeAndExpense incomeAndExpenseWindow = new IncomeAndExpense();
            incomeAndExpenseWindow.Show();
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
