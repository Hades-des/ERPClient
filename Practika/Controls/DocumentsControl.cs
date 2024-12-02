using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace Practika.Controls.DocumentsCRUD
{
    public partial class DocumentsControl : UserControl
    {
        private DatabaseHelper dbHelper;

        public DocumentsControl(DatabaseHelper helper)
        {
            InitializeComponent();
            dbHelper = helper;
            LoadDocuments();
        }

        private void LoadDocuments()
        {
            try
            {
                string query = @"
                    SELECT d.DocumentID, dt.DocumentTypeName AS 'Тип документа', d.Date AS 'Дата', c.ContractorName 'Контрагент', 
                           w.WarehouseName AS 'Склад', d.TotalAmount AS 'Кол-во', d.Status AS 'Статус'
                    FROM Documents d
                    JOIN DocumentTypes dt ON d.DocumentTypeID = dt.DocumentTypeID
                    LEFT JOIN Contractors c ON d.ContractorID = c.ContractorID
                    LEFT JOIN Warehouses w ON d.WarehouseID = w.WarehouseID";

                System.Data.DataTable documents = dbHelper.ExecuteQuery(query);
                dataGridViewDocuments.DataSource = documents;
                if (dataGridViewDocuments.Columns["DocumentID"] != null)
                {
                    dataGridViewDocuments.Columns["DocumentID"].Visible = false;
                }
                dataGridViewDocuments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки документов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var parentForm = (MainForm)this.ParentForm;
            parentForm.SwitchToControl(new DocumentsAddEditControl(dbHelper));
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocuments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Выберите документ для редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int documentId = Convert.ToInt32(dataGridViewDocuments.SelectedRows[0].Cells["DocumentID"].Value);
            var parentForm = (MainForm)this.ParentForm;
            parentForm.SwitchToControl(new DocumentsAddEditControl(dbHelper, documentId));
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDocuments.SelectedRows.Count > 0)
            {
                int documentId = int.Parse(dataGridViewDocuments.SelectedRows[0].Cells["DocumentID"].Value.ToString());

                string query = "DELETE FROM Documents WHERE DocumentID = @documentId";
                SqlParameter[] parameters =
                {
                new SqlParameter("@documentId", documentId)
                };

                dbHelper.ExecuteNonQuery(query, parameters);

                // Удаляем строку из dataGridView без перезагрузки
                dataGridViewDocuments.Rows.RemoveAt(dataGridViewDocuments.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите документ для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            // Запрос диапазона дат
            DateTime startDate = new DateTime(2024, 1, 1); // Пример начальной даты
            DateTime endDate = DateTime.Now; // Текущая дата

            string query = @"
        SELECT Date, TotalAmount 
        FROM Documents
        WHERE Date BETWEEN @startDate AND @endDate";

            SqlParameter[] parameters = {
        new SqlParameter("@startDate", SqlDbType.DateTime) { Value = startDate },
        new SqlParameter("@endDate", SqlDbType.DateTime) { Value = endDate }
    };

            try
            {
                // Выполнение запроса для получения данных о закупках
                System.Data.DataTable purchases = dbHelper.ExecuteQuery(query, parameters);

                if (purchases.Rows.Count == 0)
                {
                    MessageBox.Show("Нет данных за указанный период.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Генерация Word-документа
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                Document doc = wordApp.Documents.Add();

                // Заголовок документа
                Paragraph title = doc.Content.Paragraphs.Add();
                title.Range.Text = $"Отчет о закупках с {startDate:dd.MM.yyyy} по {endDate:dd.MM.yyyy}";
                title.Range.Font.Size = 16;
                title.Range.Font.Bold = 1;
                title.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();

                // Данные о закупках
                Paragraph tableParagraph = doc.Content.Paragraphs.Add(); 
                double totalPurchases = purchases.AsEnumerable().Sum(row => Convert.ToDouble(row.Field<decimal>("TotalAmount")));
                tableParagraph.Range.Text = $"Данные о закупках: всего закуплено {totalPurchases:C}";
                tableParagraph.Range.InsertParagraphAfter();

                // Создание таблицы
                Table table = doc.Tables.Add(tableParagraph.Range, purchases.Rows.Count + 1, 3); // Дополнительная строка для заголовков
                table.Borders.Enable = 1;

                // Заголовки столбцов
                table.Cell(1, 1).Range.Text = "Дата";
                table.Cell(1, 2).Range.Text = "Продукты";
                table.Cell(1, 3).Range.Text = "Сумма";

                // Заполнение таблицы
                for (int i = 0; i < purchases.Rows.Count; i++)
                {
                    DataRow row = purchases.Rows[i];
                    table.Cell(i + 2, 1).Range.Text = Convert.ToDateTime(row["Date"]).ToString("dd.MM.yyyy");

                    // Пример данных для продуктов (заполните по аналогии с запросом о продуктах)
                    string productsQuery = @"
                SELECT p.ProductName, dl.Quantity, dl.UnitPrice, dl.TotalPrice
                FROM DocumentLines dl
                JOIN Products p ON dl.ProductID = p.ProductID
                WHERE dl.DocumentID = (SELECT DocumentID FROM Documents WHERE Date = @docDate)";

                    SqlParameter[] productParams = {
                new SqlParameter("@docDate", SqlDbType.DateTime) { Value = row["Date"] }
            };

                    // Получаем данные по продуктам
                    System.Data.DataTable productDetails = dbHelper.ExecuteQuery(productsQuery, productParams);

                    string productNames = string.Join(", ", productDetails.AsEnumerable()
                        .Select(pr => $"{pr["ProductName"]}({pr["Quantity"]})"));

                    table.Cell(i + 2, 2).Range.Text = productNames; // Продукты
                    table.Cell(i + 2, 3).Range.Text = row["TotalAmount"].ToString(); // Сумма
                }

                // График
                Paragraph chartParagraph = doc.Content.Paragraphs.Add();
                chartParagraph.Range.Text = "График затрат:";
                chartParagraph.Range.InsertParagraphAfter();

                // Создание графика
                System.Windows.Forms.DataVisualization.Charting.Chart chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
                chart.Width = 800;
                chart.Height = 400;

                System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea("MainArea");
                chart.ChartAreas.Add(chartArea);

                System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Закупки")
                {
                    ChartType = SeriesChartType.Line,
                    Color = Color.Blue
                };

                foreach (DataRow row in purchases.Rows)
                {
                    DateTime date = Convert.ToDateTime(row["Date"]);
                    double totalAmount = Convert.ToDouble(row["TotalAmount"]);
                    series.Points.AddXY(date.ToShortDateString(), totalAmount);
                }
                chart.Series.Add(series);

                // Сохраняем график в файл
                string chartPath = Path.Combine("C:\\Users\\User\\Documents", "chart.png");
                chart.SaveImage(chartPath, ChartImageFormat.Png);

                // Вставляем график в документ Word
                if (File.Exists(chartPath))
                {
                    InlineShape chartShape = chartParagraph.Range.InlineShapes.AddPicture(chartPath);
                    chartShape.Width = 350;
                    chartShape.Height = 200;
                }
                else
                {
                    MessageBox.Show($"Не удалось найти файл изображения: {chartPath}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
                // Показать документ
                wordApp.Visible = true;

            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка SQL: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
