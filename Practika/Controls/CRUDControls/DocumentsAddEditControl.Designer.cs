namespace Practika.Controls.DocumentsCRUD
{
    partial class DocumentsAddEditControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelDocumentType = new System.Windows.Forms.Label();
            this.comboBoxDocumentType = new System.Windows.Forms.ComboBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelContractor = new System.Windows.Forms.Label();
            this.comboBoxContractor = new System.Windows.Forms.ComboBox();
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.numericUpDownTotalAmount = new System.Windows.Forms.NumericUpDown();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDocumentType
            // 
            this.labelDocumentType.AutoSize = true;
            this.labelDocumentType.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDocumentType.Location = new System.Drawing.Point(17, 17);
            this.labelDocumentType.Name = "labelDocumentType";
            this.labelDocumentType.Size = new System.Drawing.Size(86, 13);
            this.labelDocumentType.TabIndex = 13;
            this.labelDocumentType.Text = "Тип документа:";
            // 
            // comboBoxDocumentType
            // 
            this.comboBoxDocumentType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxDocumentType.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxDocumentType.FormattingEnabled = true;
            this.comboBoxDocumentType.Location = new System.Drawing.Point(150, 14);
            this.comboBoxDocumentType.Name = "comboBoxDocumentType";
            this.comboBoxDocumentType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxDocumentType.TabIndex = 12;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDate.Location = new System.Drawing.Point(17, 52);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 11;
            this.labelDate.Text = "Дата:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(150, 46);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 10;
            // 
            // labelContractor
            // 
            this.labelContractor.AutoSize = true;
            this.labelContractor.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContractor.Location = new System.Drawing.Point(17, 87);
            this.labelContractor.Name = "labelContractor";
            this.labelContractor.Size = new System.Drawing.Size(68, 13);
            this.labelContractor.TabIndex = 9;
            this.labelContractor.Text = "Контрагент:";
            // 
            // comboBoxContractor
            // 
            this.comboBoxContractor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxContractor.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxContractor.FormattingEnabled = true;
            this.comboBoxContractor.Location = new System.Drawing.Point(150, 79);
            this.comboBoxContractor.Name = "comboBoxContractor";
            this.comboBoxContractor.Size = new System.Drawing.Size(200, 21);
            this.comboBoxContractor.TabIndex = 8;
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWarehouse.Location = new System.Drawing.Point(17, 121);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.Size = new System.Drawing.Size(41, 13);
            this.labelWarehouse.TabIndex = 7;
            this.labelWarehouse.Text = "Склад:";
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxWarehouse.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(150, 113);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(200, 21);
            this.comboBoxWarehouse.TabIndex = 6;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTotalAmount.Location = new System.Drawing.Point(17, 156);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(69, 13);
            this.labelTotalAmount.TabIndex = 5;
            this.labelTotalAmount.Text = "Количество:";
            // 
            // numericUpDownTotalAmount
            // 
            this.numericUpDownTotalAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numericUpDownTotalAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.numericUpDownTotalAmount.Location = new System.Drawing.Point(150, 150);
            this.numericUpDownTotalAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownTotalAmount.Name = "numericUpDownTotalAmount";
            this.numericUpDownTotalAmount.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownTotalAmount.TabIndex = 4;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(17, 191);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(44, 13);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(150, 187);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStatus.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(17, 230);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 26);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(120, 230);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 26);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // DocumentsAddEditControl
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.numericUpDownTotalAmount);
            this.Controls.Add(this.labelTotalAmount);
            this.Controls.Add(this.comboBoxWarehouse);
            this.Controls.Add(this.labelWarehouse);
            this.Controls.Add(this.comboBoxContractor);
            this.Controls.Add(this.labelContractor);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.comboBoxDocumentType);
            this.Controls.Add(this.labelDocumentType);
            this.Name = "DocumentsAddEditControl";
            this.Size = new System.Drawing.Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelDocumentType;
        private System.Windows.Forms.ComboBox comboBoxDocumentType;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelContractor;
        private System.Windows.Forms.ComboBox comboBoxContractor;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalAmount;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
