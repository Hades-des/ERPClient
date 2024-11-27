namespace Practika.Controls.ProductsCRUD
{
    partial class ProductAddEditControl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка ресурсов, используемых контролом.
        /// </summary>
        /// <param name="disposing">Если true, уничтожаются все компоненты.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором формы

        private void InitializeComponent()
        {
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxProductName.Location = new System.Drawing.Point(150, 30);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(200, 20);
            this.textBoxProductName.TabIndex = 0;
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUnit.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxUnit.Location = new System.Drawing.Point(150, 70);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(200, 20);
            this.textBoxUnit.TabIndex = 1;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(150, 110);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numericUpDownPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDownPrice.Location = new System.Drawing.Point(150, 150);
            this.numericUpDownPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownPrice.TabIndex = 3;
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelProductName.Location = new System.Drawing.Point(13, 33);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(106, 13);
            this.labelProductName.TabIndex = 4;
            this.labelProductName.Text = "Название продукта";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUnit.Location = new System.Drawing.Point(13, 73);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(49, 13);
            this.labelUnit.TabIndex = 5;
            this.labelUnit.Text = "Ед. изм.";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCategory.Location = new System.Drawing.Point(13, 113);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Категория";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPrice.Location = new System.Drawing.Point(13, 153);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 13);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Цена";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(150, 200);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(275, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ProductAddEditControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.labelUnit);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxUnit);
            this.Controls.Add(this.textBoxProductName);
            this.Name = "ProductAddEditControl";
            this.Size = new System.Drawing.Size(400, 250);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
