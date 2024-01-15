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
                // Check if a user is logged in
                if (LoginWindow.currentUser == null)
                {
                    MessageBox.Show("No user is currently logged in.");
                    return;
                }

                // Load the list of IncomeExpense for the current user
                List<IncomeExpenseView> incomeExpenses = new Provider().Select<IncomeExpenseView>($"SELECT * FROM {typeof(IncomeExpenseView).Name} WHERE UsersAcc = '{LoginWindow.currentUser.Acc}';");

                // Display the data in the DataGrid
                dataGrid.ItemsSource = incomeExpenses;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading income/expense list: {ex.Message}");
            }
        }
    }
}
