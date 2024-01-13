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
        
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=GLHF;Integrated Security=True"; 
        public IncomeAndExpense()
        {
            InitializeComponent();
            UpdateCategoryComboBox();
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Lấy giá trị từ các thành phần giao diện người dùng
                decimal amount = decimal.Parse(txtAmount.Text);
                string category = cmbCategory.Text;
                DateTime time = dpTime.SelectedDate ?? DateTime.Now;

                // Thực hiện thêm thu/chi vào cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo câu lệnh SQL để thêm dữ liệu
                    string insertQuery = "INSERT INTO IncomeExpense (Amount, Category, Time) VALUES (@Amount, @Category, @Time)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Thêm các tham số để tránh tấn công SQL Injection
                        command.Parameters.AddWithValue("@Amount", amount);
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@Time", time);

                        // Thực hiện câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Thông báo thành công (hoặc thực hiện các hành động khác)
                            MessageBox.Show("Thêm thu/chi thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thu/chi không thành công.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có lỗi
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        int savedCategoryId;
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            savedCategoryId = (int)cmbCategory.SelectedValue;
            new Models.Provider().Execute("INSERT INTO Category value");
            MessageBox.Show($"{savedCategoryId}");

        }

        private void UpdateCategoryComboBox()
        {
            List<Category> dbContext = new Models.Provider().Select<Category>($"SELECT * FROM {typeof(Category).Name};");
                {

                // Gán danh sách Category cho ComboBox
                cmbCategory.ItemsSource = dbContext;
                cmbCategory.DisplayMemberPath = "Categoryname";
                cmbCategory.SelectedValuePath = "ID";
            }
        }

    }
}
