namespace classification_lab1
{
    partial class Forel2Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewClassTable = new System.Windows.Forms.DataGridView();
            this.btnToDo = new System.Windows.Forms.Button();
            this.dataGridViewMatrixDataset = new System.Windows.Forms.DataGridView();
            this.numericUpDownMetrik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.btnNormalizationOfData = new System.Windows.Forms.Button();
            this.btnLoadDataset = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbValuep = new System.Windows.Forms.TextBox();
            this.tbValuer = new System.Windows.Forms.TextBox();
            this.cbMetrik = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClassTable
            // 
            this.dataGridViewClassTable.AllowUserToAddRows = false;
            this.dataGridViewClassTable.AllowUserToDeleteRows = false;
            this.dataGridViewClassTable.AllowUserToResizeColumns = false;
            this.dataGridViewClassTable.AllowUserToResizeRows = false;
            this.dataGridViewClassTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewClassTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassTable.ColumnHeadersHeight = 20;
            this.dataGridViewClassTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewClassTable.ColumnHeadersVisible = false;
            this.dataGridViewClassTable.Location = new System.Drawing.Point(246, 47);
            this.dataGridViewClassTable.Name = "dataGridViewClassTable";
            this.dataGridViewClassTable.RowHeadersVisible = false;
            this.dataGridViewClassTable.RowHeadersWidth = 40;
            this.dataGridViewClassTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewClassTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClassTable.RowTemplate.Height = 20;
            this.dataGridViewClassTable.Size = new System.Drawing.Size(748, 582);
            this.dataGridViewClassTable.TabIndex = 40;
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(323, 12);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 23);
            this.btnToDo.TabIndex = 38;
            this.btnToDo.Text = "Обчислити";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // dataGridViewMatrixDataset
            // 
            this.dataGridViewMatrixDataset.AllowUserToAddRows = false;
            this.dataGridViewMatrixDataset.AllowUserToDeleteRows = false;
            this.dataGridViewMatrixDataset.AllowUserToResizeColumns = false;
            this.dataGridViewMatrixDataset.AllowUserToResizeRows = false;
            this.dataGridViewMatrixDataset.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrixDataset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrixDataset.ColumnHeadersHeight = 20;
            this.dataGridViewMatrixDataset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMatrixDataset.ColumnHeadersVisible = false;
            this.dataGridViewMatrixDataset.Location = new System.Drawing.Point(8, 47);
            this.dataGridViewMatrixDataset.Name = "dataGridViewMatrixDataset";
            this.dataGridViewMatrixDataset.RowHeadersVisible = false;
            this.dataGridViewMatrixDataset.RowHeadersWidth = 40;
            this.dataGridViewMatrixDataset.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixDataset.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatrixDataset.RowTemplate.Height = 20;
            this.dataGridViewMatrixDataset.Size = new System.Drawing.Size(232, 582);
            this.dataGridViewMatrixDataset.TabIndex = 35;
            // 
            // numericUpDownMetrik
            // 
            this.numericUpDownMetrik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDownMetrik.Location = new System.Drawing.Point(104, 15);
            this.numericUpDownMetrik.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownMetrik.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMetrik.Name = "numericUpDownMetrik";
            this.numericUpDownMetrik.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownMetrik.TabIndex = 37;
            this.numericUpDownMetrik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMetrik.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMetrik.ValueChanged += new System.EventHandler(this.numericUpDownAmountOfPoints_ValueChanged);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(8, 15);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownNumber.TabIndex = 36;
            this.numericUpDownNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownAmountOfPoints_ValueChanged);
            // 
            // btnNormalizationOfData
            // 
            this.btnNormalizationOfData.Location = new System.Drawing.Point(605, 4);
            this.btnNormalizationOfData.Name = "btnNormalizationOfData";
            this.btnNormalizationOfData.Size = new System.Drawing.Size(90, 41);
            this.btnNormalizationOfData.TabIndex = 42;
            this.btnNormalizationOfData.Text = "Нормалізація даних";
            this.btnNormalizationOfData.UseVisualStyleBackColor = true;
            this.btnNormalizationOfData.Click += new System.EventHandler(this.btnNormalizationOfData_Click);
            // 
            // btnLoadDataset
            // 
            this.btnLoadDataset.Location = new System.Drawing.Point(497, 4);
            this.btnLoadDataset.Name = "btnLoadDataset";
            this.btnLoadDataset.Size = new System.Drawing.Size(90, 41);
            this.btnLoadDataset.TabIndex = 41;
            this.btnLoadDataset.Text = "Завантажити Dataset";
            this.btnLoadDataset.UseVisualStyleBackColor = true;
            this.btnLoadDataset.Click += new System.EventHandler(this.btnLoadDataset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1021, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 39);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbValuep
            // 
            this.tbValuep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValuep.Location = new System.Drawing.Point(1000, 161);
            this.tbValuep.Name = "tbValuep";
            this.tbValuep.Size = new System.Drawing.Size(79, 26);
            this.tbValuep.TabIndex = 46;
            this.tbValuep.Text = "p";
            this.tbValuep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbValuer
            // 
            this.tbValuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValuer.Location = new System.Drawing.Point(1000, 129);
            this.tbValuer.Name = "tbValuer";
            this.tbValuer.Size = new System.Drawing.Size(79, 26);
            this.tbValuer.TabIndex = 45;
            this.tbValuer.Text = "r";
            this.tbValuer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbMetrik
            // 
            this.cbMetrik.AutoCompleteCustomSource.AddRange(new string[] {
            "da",
            "asd",
            "ad",
            "asd"});
            this.cbMetrik.FormattingEnabled = true;
            this.cbMetrik.Items.AddRange(new object[] {
            "Евклидово r",
            "Квадрат евклидового r",
            "r городских кварталов",
            "r Чебешева",
            "Степенное r"});
            this.cbMetrik.Location = new System.Drawing.Point(1000, 102);
            this.cbMetrik.Name = "cbMetrik";
            this.cbMetrik.Size = new System.Drawing.Size(79, 21);
            this.cbMetrik.TabIndex = 44;
            // 
            // Forel2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbValuep);
            this.Controls.Add(this.tbValuer);
            this.Controls.Add(this.cbMetrik);
            this.Controls.Add(this.btnNormalizationOfData);
            this.Controls.Add(this.btnLoadDataset);
            this.Controls.Add(this.numericUpDownMetrik);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.dataGridViewClassTable);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.dataGridViewMatrixDataset);
            this.Name = "Forel2Form";
            this.Text = "Forel2Form";
            this.Load += new System.EventHandler(this.Forel2Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewClassTable;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.DataGridView dataGridViewMatrixDataset;
        private System.Windows.Forms.NumericUpDown numericUpDownMetrik;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Button btnNormalizationOfData;
        private System.Windows.Forms.Button btnLoadDataset;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbValuep;
        private System.Windows.Forms.TextBox tbValuer;
        private System.Windows.Forms.ComboBox cbMetrik;
    }
}