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
            new IncomeAndExpense().Show();
            Close();
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            new ListWindow().Show();
            Close();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            new UserInfo().Show();
            Close();
        }
    }
}
