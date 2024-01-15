using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for IncomeAndExpense.xaml
    /// </summary>
    public partial class IncomeAndExpense : Window
    {
        public IncomeAndExpense()
        {
            InitializeComponent();
            UpdateCategoryComboBox();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {

                decimal amount = decimal.Parse(txtAmount.Text);

                if (cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một danh mục.");
                    return; // Dừng hàm nếu danh mục là null
                }
                int savedCategoryId = (int)cmbCategory.SelectedValue;

                DateTime time = dpTime.SelectedDate ?? DateTime.Now;

                if (new Models.Provider().Execute($"INSERT INTO {typeof(IncomeExpense).Name} values ('{LoginWindow.currentUser.Acc}', {amount}, {savedCategoryId}, '{time.ToString("yyyy-MM-dd HH:mm:ss")}')"))
                {
                    MessageBox.Show("Thêm thu/chi thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thu/chi không thành công.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền không hợp lệ.");
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            new HomeWindow().Show();
            Close();
        }

        private void UpdateCategoryComboBox()
        {
            List<Category> dbContext = new Models.Provider().Select<Category>($"SELECT * FROM {typeof(Category).Name};");

                {

                // Gán danh sách Category cho ComboBox
                cmbCategory.ItemsSource = dbContext;
                cmbCategory.DisplayMemberPath = "CategoryName";
                cmbCategory.SelectedValuePath = "ID";
            }
        }

    }
}
