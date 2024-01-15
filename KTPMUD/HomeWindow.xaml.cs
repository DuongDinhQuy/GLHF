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
            //int[] ids = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int[] totalAmounts = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

            //for (int i =0; i<ids.Length;i++)
            //{
            //    foreach (var ie in incomeExpenses)
            //    {
            //        if (ie.CategoryId == ids[i])
            //            totalAmounts[i] += ie.Amount;
            //    }
            //}
        }

        private void btnAccount_Click(object sender, RoutedEventArgs e)
        {
            new UserInfo().Show();
            Close();
        }
    }
}
