namespace Practika.Controls.CRUDControls
{
    partial class WarehouseAddEditControl
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

        #region Код, автоматически созданный конструктором компонентов

        private void InitializeComponent()
        {
            this.labelWarehouseName = new System.Windows.Forms.Label();
            this.textBoxWarehouseName = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelCapacity = new System.Windows.Forms.Label();
            this.numericUpDownCapacity = new System.Windows.Forms.NumericUpDown();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWarehouseName
            // 
            this.labelWarehouseName.AutoSize = true;
            this.labelWarehouseName.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWarehouseName.Location = new System.Drawing.Point(16, 16);
            this.labelWarehouseName.Name = "labelWarehouseName";
            this.labelWarehouseName.Size = new System.Drawing.Size(99, 13);
            this.labelWarehouseName.TabIndex = 0;
            this.labelWarehouseName.Text = "Название склада:";
            // 
            // textBoxWarehouseName
            // 
            this.textBoxWarehouseName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxWarehouseName.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxWarehouseName.Location = new System.Drawing.Point(148, 13);
            this.textBoxWarehouseName.Name = "textBoxWarehouseName";
            this.textBoxWarehouseName.Size = new System.Drawing.Size(200, 20);
            this.textBoxWarehouseName.TabIndex = 1;
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.labelLocation.Location = new System.Drawing.Point(16, 50);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(98, 13);
            this.labelLocation.TabIndex = 2;
            this.labelLocation.Text = "Местоположение:";
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBoxLocation.ForeColor = System.Drawing.SystemColors.Control;
            this.textBoxLocation.Location = new System.Drawing.Point(148, 47);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(200, 20);
            this.textBoxLocation.TabIndex = 3;
            // 
            // labelCapacity
            // 
            this.labelCapacity.AutoSize = true;
            this.labelCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCapacity.Location = new System.Drawing.Point(16, 84);
            this.labelCapacity.Name = "labelCapacity";
            this.labelCapacity.Size = new System.Drawing.Size(113, 13);
            this.labelCapacity.TabIndex = 4;
            this.labelCapacity.Text = "Емкость склада (м³):";
            // 
            // numericUpDownCapacity
            // 
            this.numericUpDownCapacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDownCapacity.ForeColor = System.Drawing.SystemColors.Control;
            this.numericUpDownCapacity.Location = new System.Drawing.Point(148, 82);
            this.numericUpDownCapacity.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCapacity.Name = "numericUpDownCapacity";
            this.numericUpDownCapacity.Size = new System.Drawing.Size(200, 20);
            this.numericUpDownCapacity.TabIndex = 5;
            this.numericUpDownCapacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSave.Location = new System.Drawing.Point(148, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(95, 26);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCancel.Location = new System.Drawing.Point(253, 118);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 26);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // WarehouseAddEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.numericUpDownCapacity);
            this.Controls.Add(this.labelCapacity);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.textBoxWarehouseName);
            this.Controls.Add(this.labelWarehouseName);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "WarehouseAddEditControl";
            this.Size = new System.Drawing.Size(380, 160);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWarehouseName;
        private System.Windows.Forms.TextBox textBoxWarehouseName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label labelCapacity;
        private System.Windows.Forms.NumericUpDown numericUpDownCapacity;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
