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
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
            PieChartViewModel viewModel = new PieChartViewModel();
            DataContext = viewModel;
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            // Mở lại cửa sổ HomeWindow
            HomeWindow homeWindow = new HomeWindow();
            homeWindow.Show();

            // Đóng cửa sổ hiện tại
            Close();
        }
    }
}