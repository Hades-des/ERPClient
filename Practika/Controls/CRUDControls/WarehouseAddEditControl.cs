using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practika.Controls.CRUDControls
{
    public partial class WarehouseAddEditControl : UserControl
    {
        private DatabaseHelper dbHelper;
        private int? warehouseId;

        public WarehouseAddEditControl(DatabaseHelper helper, int? warehouseId = null)
        {
            InitializeComponent();
            dbHelper = helper;
            this.warehouseId = warehouseId;

            if (warehouseId.HasValue)
            {
                LoadWarehouseData(warehouseId.Value);
            }
            

        }

        private void LoadWarehouseData(int warehouseId)
        {
            string query = @"
            SELECT WarehouseName, Location, Capacity 
            FROM Warehouses
            WHERE WarehouseID = @warehouseId";

            SqlParameter[] parameters = { new SqlParameter("@warehouseId", warehouseId) };
            DataTable warehouseData = dbHelper.ExecuteQuery(query, parameters);

            if (warehouseData.Rows.Count > 0)
            {
                DataRow row = warehouseData.Rows[0];
                textBoxWarehouseName.Text = row["WarehouseName"].ToString();
                textBoxLocation.Text = row["Location"].ToString();

                if (row["Capacity"] != DBNull.Value)
                {
                    string capacityString = row["Capacity"].ToString().Trim(); 

                    capacityString = capacityString.Replace(",", ".");
                    decimal capacityValue;
                    bool isValid = Decimal.TryParse(capacityString, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out capacityValue);

                    if (isValid)
                    {
                        numericUpDownCapacity.Value = capacityValue;
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение для вместимости склада: " + capacityString);
                    }
                }
                else
                {
                    MessageBox.Show("Вместимость склада не указана.");
                }



                //numericUpDownCapacity.Value = Convert.ToDecimal(row["Capacity"]);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBoxWarehouseName.Text.Trim();
                string location = textBoxLocation.Text.Trim();
                decimal capacity = numericUpDownCapacity.Value;

                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(location))
                {
                    MessageBox.Show("Заполните все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (warehouseId.HasValue) // Обновление
                {
                    string query = @"
                    UPDATE Warehouses 
                    SET WarehouseName = @name, Location = @location, Capacity = @capacity 
                    WHERE WarehouseID = @warehouseId";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@name", name),
                        new SqlParameter("@location", location),
                        new SqlParameter("@capacity", capacity),
                        new SqlParameter("@warehouseId", warehouseId.Value)
                    };

                    dbHelper.ExecuteNonQuery(query, parameters);
                }
                else // Добавление
                {
                    string query = @"
                    INSERT INTO Warehouses (WarehouseName, Location, Capacity) 
                    VALUES (@name, @location, @capacity)";

                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@name", name),
                        new SqlParameter("@location", location),
                        new SqlParameter("@capacity", capacity)
                    };

                    dbHelper.ExecuteNonQuery(query, parameters);
                }

                MessageBox.Show("Склад успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var parentForm = (MainForm)this.ParentForm;
                parentForm.SwitchToControl(new WarehousesControl(dbHelper));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var parentForm = (MainForm)this.ParentForm;
            parentForm.SwitchToControl(new WarehousesControl(dbHelper));
        }
    }
}
