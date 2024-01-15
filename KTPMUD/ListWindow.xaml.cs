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
            // Lấy danh sách thu chi của tài khoản đã đăng nhập
            List<IncomeExpenseView> incomeExpenses = new Provider().Select<IncomeExpenseView>($"SELECT * FROM {typeof(IncomeExpenseView).Name};");

            //int[] ids = new int[] { 1, 2, 4, 5};
            //int[] totalAmounts = new int[] { 0, 0, 0, 0};

            //for (int i =0; i<ids.Length;i++)
            //{
            //    foreach (var ie in incomeExpenses)
            //    {
            //        if (ie.CategoryId == ids[i])
            //            totalAmounts[i] += ie.Amount;
            //    }
            //}

            /*
             * int arr[] = {1, 2, 3, 4, 5};
             * for(auto x : arr)
             *     cout << x << endl;
             */

            // Hiển thị dữ liệu trong DataGrid
            dataGrid.ItemsSource = incomeExpenses;
        }
    }
}
