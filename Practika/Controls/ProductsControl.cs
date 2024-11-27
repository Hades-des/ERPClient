using Practika.Controls.ProductsCRUD;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practika
{
    public partial class ProductsControl : UserControl
    {
        private DatabaseHelper dbHelper;

        public ProductsControl(DatabaseHelper helper)
        {
            InitializeComponent();
            dbHelper = helper;
            LoadProducts();
        }

        public void LoadProducts()
        {
            try
            {
                string query = @"
            SELECT 
                p.ProductID,
                p.ProductName AS 'Название продукта',
                c.CategoryName AS 'Категория',
                p.Unit AS 'Ед. изм.',
                p.Price AS 'Цена'
            FROM Products p
            INNER JOIN Categories c ON p.CategoryID = c.CategoryID";

                DataTable dataTable = dbHelper.ExecuteQuery(query);

                // Устанавливаем источник данных для DataGridView
                dataGridViewProducts.DataSource = dataTable;

                // Скрываем колонку ProductID
                if (dataGridViewProducts.Columns["ProductID"] != null)
                {
                    dataGridViewProducts.Columns["ProductID"].Visible = false;
                }

                // Устанавливаем авторазмер колонок
                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Открываем ProductAddEditControl для добавления нового продукта
            var productAddEditControl = new ProductAddEditControl(dbHelper);
            SwitchToControl(productAddEditControl);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = int.Parse(dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value.ToString());
                var productAddEditControl = new ProductAddEditControl(dbHelper, productId);
                SwitchToControl(productAddEditControl);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {
                int productId = int.Parse(dataGridViewProducts.SelectedRows[0].Cells["ProductID"].Value.ToString());

                string query = "DELETE FROM Products WHERE ProductID = @productId";
                SqlParameter[] parameters =
                {
                new SqlParameter("@productId", productId)
            };

                dbHelper.ExecuteNonQuery(query, parameters);

                // Удаляем строку из dataGridView без перезагрузки
                dataGridViewProducts.Rows.RemoveAt(dataGridViewProducts.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SwitchToControl(UserControl newControl)
        {
            // Ожидаем, что MainForm передаст panelOwn для переключения
            var parentForm = (MainForm)this.ParentForm;
            parentForm.panelOwn.Controls.Clear();
            parentForm.panelOwn.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill;
        }
    }
}
