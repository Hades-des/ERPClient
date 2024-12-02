namespace Practika
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonInWork = new System.Windows.Forms.Button();
            this.panelNav = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDocs = new System.Windows.Forms.Button();
            this.buttonWarehouses = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelOwn = new System.Windows.Forms.Panel();
            this.buttonCloseApp = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.buttonInWork);
            this.panel1.Controls.Add(this.panelNav);
            this.panel1.Controls.Add(this.buttonExit);
            this.panel1.Controls.Add(this.buttonDocs);
            this.panel1.Controls.Add(this.buttonWarehouses);
            this.panel1.Controls.Add(this.buttonProducts);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // buttonInWork
            // 
            this.buttonInWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonInWork.FlatAppearance.BorderSize = 0;
            this.buttonInWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInWork.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(19)))));
            this.buttonInWork.Image = ((System.Drawing.Image)(resources.GetObject("buttonInWork.Image")));
            this.buttonInWork.Location = new System.Drawing.Point(0, 270);
            this.buttonInWork.Name = "buttonInWork";
            this.buttonInWork.Size = new System.Drawing.Size(186, 42);
            this.buttonInWork.TabIndex = 100;
            this.buttonInWork.Text = "В разработке...";
            this.buttonInWork.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonInWork.UseVisualStyleBackColor = true;
            this.buttonInWork.Visible = false;
            this.buttonInWork.Click += new System.EventHandler(this.button4_Click);
            this.buttonInWork.Leave += new System.EventHandler(this.button4_Leave);
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(232)))), ((int)(((byte)(158)))));
            this.panelNav.Location = new System.Drawing.Point(0, 192);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(3, 100);
            this.panelNav.TabIndex = 99;
            // 
            // buttonExit
            // 
            this.buttonExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(0, 535);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(186, 42);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            this.buttonExit.Leave += new System.EventHandler(this.buttonExit_Leave);
            // 
            // buttonDocs
            // 
            this.buttonDocs.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDocs.FlatAppearance.BorderSize = 0;
            this.buttonDocs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDocs.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDocs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(64)))), ((int)(((byte)(19)))));
            this.buttonDocs.Image = ((System.Drawing.Image)(resources.GetObject("buttonDocs.Image")));
            this.buttonDocs.Location = new System.Drawing.Point(0, 228);
            this.buttonDocs.Name = "buttonDocs";
            this.buttonDocs.Size = new System.Drawing.Size(186, 42);
            this.buttonDocs.TabIndex = 5;
            this.buttonDocs.Text = "Документы";
            this.buttonDocs.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDocs.UseVisualStyleBackColor = true;
            this.buttonDocs.Click += new System.EventHandler(this.buttonDocs_Click);
            this.buttonDocs.Leave += new System.EventHandler(this.buttonDocs_Leave);
            // 
            // buttonWarehouses
            // 
            this.buttonWarehouses.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonWarehouses.FlatAppearance.BorderSize = 0;
            this.buttonWarehouses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWarehouses.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWarehouses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(232)))), ((int)(((byte)(158)))));
            this.buttonWarehouses.Image = ((System.Drawing.Image)(resources.GetObject("buttonWarehouses.Image")));
            this.buttonWarehouses.Location = new System.Drawing.Point(0, 186);
            this.buttonWarehouses.Name = "buttonWarehouses";
            this.buttonWarehouses.Size = new System.Drawing.Size(186, 42);
            this.buttonWarehouses.TabIndex = 3;
            this.buttonWarehouses.Text = "Склады";
            this.buttonWarehouses.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonWarehouses.UseVisualStyleBackColor = true;
            this.buttonWarehouses.Click += new System.EventHandler(this.buttonWarehouses_Click);
            this.buttonWarehouses.Leave += new System.EventHandler(this.button2_Leave);
            // 
            // buttonProducts
            // 
            this.buttonProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonProducts.FlatAppearance.BorderSize = 0;
            this.buttonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProducts.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(232)))), ((int)(((byte)(158)))));
            this.buttonProducts.Image = ((System.Drawing.Image)(resources.GetObject("buttonProducts.Image")));
            this.buttonProducts.Location = new System.Drawing.Point(0, 144);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(186, 42);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Продукты";
            this.buttonProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            this.buttonProducts.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(49, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "IT-Специалист";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(55)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Иванов Иван Иваныч";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelOwn);
            this.panelMain.Controls.Add(this.buttonCloseApp);
            this.panelMain.Controls.Add(this.textBoxSearch);
            this.panelMain.Controls.Add(this.labelCategory);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(186, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(765, 577);
            this.panelMain.TabIndex = 2;
            // 
            // panelOwn
            // 
            this.panelOwn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOwn.Location = new System.Drawing.Point(0, 53);
            this.panelOwn.Name = "panelOwn";
            this.panelOwn.Size = new System.Drawing.Size(765, 524);
            this.panelOwn.TabIndex = 4;
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseApp.ForeColor = System.Drawing.Color.White;
            this.buttonCloseApp.Location = new System.Drawing.Point(718, 17);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(25, 25);
            this.buttonCloseApp.TabIndex = 2;
            this.buttonCloseApp.Text = "X";
            this.buttonCloseApp.UseVisualStyleBackColor = true;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxSearch.Location = new System.Drawing.Point(386, 17);
            this.textBoxSearch.Multiline = true;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(292, 25);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.Text = "Поиск...";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelCategory.Location = new System.Drawing.Point(6, 10);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(170, 32);
            this.labelCategory.TabIndex = 0;
            this.labelCategory.Text = "TableName";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFormDesign";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDocs;
        private System.Windows.Forms.Button buttonWarehouses;
        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Button buttonCloseApp;
        public System.Windows.Forms.Panel panelOwn;
        private System.Windows.Forms.Button buttonInWork;
    }
}