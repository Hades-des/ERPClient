using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Practika.Controls.DocumentsCRUD
{
    public partial class DocumentsAddEditControl : UserControl
    {
        private DatabaseHelper dbHelper;
        private int? documentId;

        public DocumentsAddEditControl(DatabaseHelper helper, int? documentId = null)
        {
            InitializeComponent();
            dbHelper = helper;
            this.documentId = documentId;

            LoadDocumentTypes();
            LoadContractors();
            LoadWarehouses();
            LoadStatusOptions();

            if (documentId.HasValue)
                LoadDocumentData(documentId.Value);
        }

        private void LoadDocumentTypes()
        {
            string query = "SELECT DocumentTypeID, DocumentTypeName FROM DocumentTypes";
            comboBoxDocumentType.DataSource = dbHelper.ExecuteQuery(query);
            comboBoxDocumentType.DisplayMember = "DocumentTypeName";
            comboBoxDocumentType.ValueMember = "DocumentTypeID";
        }

        private void LoadContractors()
        {
            string query = "SELECT ContractorID, ContractorName FROM Contractors";
            comboBoxContractor.DataSource = dbHelper.ExecuteQuery(query);
            comboBoxContractor.DisplayMember = "ContractorName";
            comboBoxContractor.ValueMember = "ContractorID";
        }

        private void LoadWarehouses()
        {
            string query = "SELECT WarehouseID, WarehouseName FROM Warehouses";
            comboBoxWarehouse.DataSource = dbHelper.ExecuteQuery(query);
            comboBoxWarehouse.DisplayMember = "WarehouseName";
            comboBoxWarehouse.ValueMember = "WarehouseID";
        }

        private void LoadStatusOptions()
        {
            comboBoxStatus.Items.AddRange(new[] { "Черновик", "Утвержден", "Завершен", "Отменен", "В процессе" });
        }


        private void LoadDocumentData(int documentId)
        {
            try
            {
                string query = @"
                    SELECT DocumentTypeID, Date, ContractorID, WarehouseID, TotalAmount, Status
                    FROM Documents
                    WHERE DocumentID = @documentId";

                SqlParameter[] parameters = { new SqlParameter("@documentId", documentId) };
                DataTable documentData = dbHelper.ExecuteQuery(query, parameters);

                if (documentData.Rows.Count > 0)
                {
                    DataRow row = documentData.Rows[0];
                    comboBoxDocumentType.SelectedValue = row["DocumentTypeID"];
                    dateTimePickerDate.Value = Convert.ToDateTime(row["Date"]);
                    comboBoxContractor.SelectedValue = row["ContractorID"];
                    comboBoxWarehouse.SelectedValue = row["WarehouseID"];
                    numericUpDownTotalAmount.Value = Convert.ToDecimal(row["TotalAmount"]);
                    comboBoxStatus.SelectedItem = row["Status"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки документа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int documentTypeId = (int)comboBoxDocumentType.SelectedValue;
                DateTime date = dateTimePickerDate.Value;
                int contractorId = (int)comboBoxContractor.SelectedValue;
                int warehouseId = (int)comboBoxWarehouse.SelectedValue;
                decimal totalAmount = numericUpDownTotalAmount.Value;
                string status = comboBoxStatus.SelectedItem?.ToString() ?? "В процессе";

                if (documentId.HasValue)
                {
                    string query = @"
                        UPDATE Documents
                        SET DocumentTypeID = @documentTypeId, Date = @date, ContractorID = @contractorId,
                            WarehouseID = @warehouseId, TotalAmount = @totalAmount, Status = @status
                        WHERE DocumentID = @documentId";

                    SqlParameter[] parameters = {
                        new SqlParameter("@documentTypeId", documentTypeId),
                        new SqlParameter("@date", date),
                        new SqlParameter("@contractorId", contractorId),
                        new SqlParameter("@warehouseId", warehouseId),
                        new SqlParameter("@totalAmount", totalAmount),
                        new SqlParameter("@status", status),
                        new SqlParameter("@documentId", documentId.Value)
                    };

                    dbHelper.ExecuteNonQuery(query, parameters);
                }
                else
                {
                    string query = @"
                        INSERT INTO Documents (DocumentTypeID, Date, ContractorID, WarehouseID, TotalAmount, Status)
                        VALUES (@documentTypeId, @date, @contractorId, @warehouseId, @totalAmount, @status)";

                    SqlParameter[] parameters = {
                        new SqlParameter("@documentTypeId", documentTypeId),
                        new SqlParameter("@date", date),
                        new SqlParameter("@contractorId", contractorId),
                        new SqlParameter("@warehouseId", warehouseId),
                        new SqlParameter("@totalAmount", totalAmount),
                        new SqlParameter("@status", status)
                    };

                    dbHelper.ExecuteNonQuery(query, parameters);
                }

                MessageBox.Show("Документ успешно сохранен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var parentForm = (MainForm)this.ParentForm;
                parentForm.SwitchToControl(new DocumentsControl(dbHelper));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения документа: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            var parentForm = (MainForm)this.ParentForm;
            parentForm.SwitchToControl(new DocumentsControl(dbHelper));
        }
    }
}
