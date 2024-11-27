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
using Practika.Controls.CRUDControls;
namespace Practika.Controls
{
    public partial class WarehousesControl : UserControl
    {
        private DatabaseHelper dbHelper;

        public WarehousesControl(DatabaseHelper helper)
        {
            InitializeComponent();
            dbHelper = helper;
            LoadWarehouses();
        }

        public void LoadWarehouses()
        {
            try
            {
                string query = @"
                SELECT 
                    WarehouseID,
                    WarehouseName AS 'Название склада',
                    Location AS 'Местоположение',
                    Capacity AS 'Вместимость (тонн)'
                FROM Warehouses";

                DataTable dataTable = dbHelper.ExecuteQuery(query);

                dataGridViewWarehouses.DataSource = dataTable;

                // Скрываем колонку WarehouseID
                if (dataGridViewWarehouses.Columns["WarehouseID"] != null)
                {
                    dataGridViewWarehouses.Columns["WarehouseID"].Visible = false;
                }

                dataGridViewWarehouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки складов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var warehouseAddEditControl = new WarehouseAddEditControl(dbHelper);
            SwitchToControl(warehouseAddEditControl);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                int warehouseId = int.Parse(dataGridViewWarehouses.SelectedRows[0].Cells["WarehouseID"].Value.ToString());
                var warehouseAddEditControl = new WarehouseAddEditControl(dbHelper, warehouseId);
                SwitchToControl(warehouseAddEditControl);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewWarehouses.SelectedRows.Count > 0)
            {
                int warehouseId = int.Parse(dataGridViewWarehouses.SelectedRows[0].Cells["WarehouseID"].Value.ToString());

                string query = "DELETE FROM Warehouses WHERE WarehouseID = @warehouseId";
                SqlParameter[] parameters = { new SqlParameter("@warehouseId", warehouseId) };

                dbHelper.ExecuteNonQuery(query, parameters);

                // Удаляем строку из dataGridView без перезагрузки
                dataGridViewWarehouses.Rows.RemoveAt(dataGridViewWarehouses.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите склад для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SwitchToControl(UserControl newControl)
        {
            var parentForm = (MainForm)this.ParentForm;
            parentForm.SwitchToControl(newControl);
        }
    }
}
