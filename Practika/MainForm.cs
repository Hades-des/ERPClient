using Practika.Controls;
using Practika.Controls.DocumentsCRUD;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Practika
{
    public partial class MainForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private DatabaseHelper dbHelper;
        private ProductsControl productsControl;

        public MainForm()
        {
            string connectionString = "Server=HADESLOW;Database=ERP;Integrated Security=True;";
            dbHelper = new DatabaseHelper(connectionString);
            this.FormClosing += MainForm_FormClosing;

            InitializeComponent();

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNav.Height = buttonProducts.Height;
            panelNav.Top = buttonProducts.Top;
            panelNav.Left = buttonProducts.Left;
            buttonProducts.BackColor = Color.FromArgb(23, 23, 23);

            panelOwn.Visible = false; // Скрыть панель по умолчанию

            // Инициализация пользовательского контроля
            productsControl = new ProductsControl(dbHelper);
            productsControl.Dock = DockStyle.Fill;
        }


        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form != this)
                {
                    form.Close();
                    form.Dispose();
                }
            }
        }

        private void MovePanelToButton(Button button)
        {
            panelNav.Height = button.Height;
            panelNav.Top = button.Top;
            panelNav.Left = button.Left;
            panelNav.BackColor = button.ForeColor;
            button.BackColor = Color.FromArgb(23, 23, 23);
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            MovePanelToButton(buttonProducts);


            panelOwn.Controls.Clear();
            panelOwn.Controls.Add(productsControl);
            panelOwn.Visible = true;

            labelCategory.Text = "Продукты";
        }

        private void buttonWarehouses_Click(object sender, EventArgs e)
        {
            MovePanelToButton(buttonWarehouses);

            var warehousesControl = new WarehousesControl(dbHelper);
            SwitchToControl(warehousesControl);

            labelCategory.Text = "Склады";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labelCategory.Text = "В разработке...";
            textBoxSearch.Visible = false;
            panelOwn.Controls.Clear();
            MovePanelToButton(buttonDocs);
            // Добавить функционал для другой сущности
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            MovePanelToButton(buttonExit);

            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void button1_Leave(object sender, EventArgs e)
        {

            buttonProducts.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            buttonWarehouses.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void button4_Leave(object sender, EventArgs e)
        {
            textBoxSearch.Visible = true;
            buttonDocs.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void buttonExit_Leave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.FromArgb(33, 33, 33);
        }

        private void buttonCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SwitchToControl(UserControl newControl)
        {
            panelOwn.Controls.Clear();
            panelOwn.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonProducts.PerformClick();
        }

        private void buttonDocs_Click(object sender, EventArgs e)
        {
            MovePanelToButton(buttonDocs);

            var documentsControl = new DocumentsControl(dbHelper);
            SwitchToControl(documentsControl);

            labelCategory.Text = "Документы";
        }

        private void buttonDocs_Leave(object sender, EventArgs e)
        {
            buttonExit.BackColor = Color.FromArgb(33, 33, 33);
        }
    }
}
