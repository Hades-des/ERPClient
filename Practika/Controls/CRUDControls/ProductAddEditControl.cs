using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika.Controls.ProductsCRUD
{
    public partial class ProductAddEditControl : UserControl
    {
        private DatabaseHelper dbHelper;
        private int? productId;

        public ProductAddEditControl(DatabaseHelper helper, int? productId = null)
        {
            InitializeComponent();
            dbHelper = helper;
            this.productId = productId;

            LoadCategories();

            if (productId.HasValue)
            {
                LoadProductData(productId.Value);
            }
            else
            {
                // Инициализация для нового продукта
            }
        }
        private void LoadCategories()
        {
            try
            {
                string query = "SELECT CategoryID, CategoryName FROM Categories";
                DataTable categories = dbHelper.ExecuteQuery(query);

                comboBoxCategory.DataSource = categories;
                comboBoxCategory.DisplayMember = "CategoryName"; // Показываем названия категорий
                comboBoxCategory.ValueMember = "CategoryID";     // Используем ID для логики
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки категорий: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProductData(int productId)
        {
            // Загрузка данных для редактирования
            string query = @"
            SELECT ProductName, Unit, CategoryID, Price
            FROM Products
            WHERE ProductID = @productId";

            SqlParameter[] parameters = { new SqlParameter("@productId", productId) };
            DataTable productData = dbHelper.ExecuteQuery(query, parameters);

            if (productData.Rows.Count > 0)
            {
                DataRow row = productData.Rows[0];
                textBoxProductName.Text = row["ProductName"].ToString();
                textBoxUnit.Text = row["Unit"].ToString();
                comboBoxCategory.SelectedValue = row["CategoryID"];
                numericUpDownPrice.Value = Convert.ToDecimal(row["Price"]);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxProductName.Text.Trim();
                string unit = textBoxUnit.Text.Trim();
                decimal price = numericUpDownPrice.Value;

                // Проверка, выбрана ли категория
                if (comboBoxCategory.SelectedValue == null)
                {
                    MessageBox.Show("Пожалуйста, выберите категорию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int categoryId = (int)comboBoxCategory.SelectedValue;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(unit))
                {
                    MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (productId.HasValue)  // Обновление продукта
                {
                    string query = @"
                UPDATE Products 
                SET ProductName = @name, Unit = @unit, CategoryID = @categoryId, Price = @price 
                WHERE ProductID = @productId";

                    SqlParameter[] parameters =
                    {
                new SqlParameter("@name", name),
                new SqlParameter("@unit", unit),
                new SqlParameter("@categoryId", categoryId),
                new SqlParameter("@price", price),
                new SqlParameter("@productId", productId.Value)
            };

                    dbHelper.ExecuteNonQuery(query, parameters);
                }
                else  // Добавление нового продукта
                {
                    string query = @"
                INSERT INTO Products (ProductName, Unit, CategoryID, Price) 
                VALUES (@name, @unit, @categoryId, @price)";

                    SqlParameter[] parameters =
                    {
                new SqlParameter("@name", name),
                new SqlParameter("@unit", unit),
                new SqlParameter("@categoryId", categoryId),
                new SqlParameter("@price", price)
            };

                    dbHelper.ExecuteNonQuery(query, parameters);
                }

                MessageBox.Show("Продукт успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Возвращаемся к ProductsControl
                var parentForm = (MainForm)this.ParentForm;
                parentForm.SwitchToControl(new ProductsControl(dbHelper));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var parentForm = (MainForm)this.ParentForm;
            var productsControl = new ProductsControl(dbHelper);
            parentForm.SwitchToControl(productsControl);
        }
    }
}
