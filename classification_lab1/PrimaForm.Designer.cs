namespace classification_lab1
{
    partial class PrimaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.dataGridViewBHRbuffer = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrixDataset = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrixOfDistances = new System.Windows.Forms.DataGridView();
            this.numericUpDownMetrik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.btnGetMatrixOfDistances = new System.Windows.Forms.Button();
            this.btnLoadDataset = new System.Windows.Forms.Button();
            this.btnNormalizationOfData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBHRbuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(174, 13);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 24);
            this.btnToDo.TabIndex = 15;
            this.btnToDo.Text = "Обчислити";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(255, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 24);
            this.btnTest.TabIndex = 14;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // dataGridViewBHRbuffer
            // 
            this.dataGridViewBHRbuffer.AllowUserToAddRows = false;
            this.dataGridViewBHRbuffer.AllowUserToDeleteRows = false;
            this.dataGridViewBHRbuffer.AllowUserToResizeColumns = false;
            this.dataGridViewBHRbuffer.AllowUserToResizeRows = false;
            this.dataGridViewBHRbuffer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewBHRbuffer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBHRbuffer.ColumnHeadersHeight = 20;
            this.dataGridViewBHRbuffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBHRbuffer.ColumnHeadersVisible = false;
            this.dataGridViewBHRbuffer.Location = new System.Drawing.Point(7, 427);
            this.dataGridViewBHRbuffer.Name = "dataGridViewBHRbuffer";
            this.dataGridViewBHRbuffer.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBHRbuffer.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBHRbuffer.Size = new System.Drawing.Size(822, 106);
            this.dataGridViewBHRbuffer.TabIndex = 11;
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
            this.dataGridViewMatrixDataset.Location = new System.Drawing.Point(7, 41);
            this.dataGridViewMatrixDataset.Name = "dataGridViewMatrixDataset";
            this.dataGridViewMatrixDataset.RowHeadersVisible = false;
            this.dataGridViewMatrixDataset.RowHeadersWidth = 40;
            this.dataGridViewMatrixDataset.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixDataset.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatrixDataset.RowTemplate.Height = 20;
            this.dataGridViewMatrixDataset.Size = new System.Drawing.Size(408, 380);
            this.dataGridViewMatrixDataset.TabIndex = 36;
            // 
            // dataGridViewMatrixOfDistances
            // 
            this.dataGridViewMatrixOfDistances.AllowUserToAddRows = false;
            this.dataGridViewMatrixOfDistances.AllowUserToDeleteRows = false;
            this.dataGridViewMatrixOfDistances.AllowUserToResizeColumns = false;
            this.dataGridViewMatrixOfDistances.AllowUserToResizeRows = false;
            this.dataGridViewMatrixOfDistances.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMatrixOfDistances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMatrixOfDistances.ColumnHeadersHeight = 20;
            this.dataGridViewMatrixOfDistances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMatrixOfDistances.ColumnHeadersVisible = false;
            this.dataGridViewMatrixOfDistances.Location = new System.Drawing.Point(421, 41);
            this.dataGridViewMatrixOfDistances.Name = "dataGridViewMatrixOfDistances";
            this.dataGridViewMatrixOfDistances.RowHeadersVisible = false;
            this.dataGridViewMatrixOfDistances.RowHeadersWidth = 40;
            this.dataGridViewMatrixOfDistances.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixOfDistances.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMatrixOfDistances.RowTemplate.Height = 20;
            this.dataGridViewMatrixOfDistances.Size = new System.Drawing.Size(408, 380);
            this.dataGridViewMatrixOfDistances.TabIndex = 35;
            // 
            // numericUpDownMetrik
            // 
            this.numericUpDownMetrik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDownMetrik.Location = new System.Drawing.Point(93, 15);
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
            this.numericUpDownMetrik.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownMetrik.TabIndex = 38;
            this.numericUpDownMetrik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMetrik.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMetrik.ValueChanged += new System.EventHandler(this.numericUpDownMetrik_ValueChanged);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(12, 15);
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
            this.numericUpDownNumber.Size = new System.Drawing.Size(75, 20);
            this.numericUpDownNumber.TabIndex = 37;
            this.numericUpDownNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged);
            // 
            // btnGetMatrixOfDistances
            // 
            this.btnGetMatrixOfDistances.Location = new System.Drawing.Point(622, 11);
            this.btnGetMatrixOfDistances.Name = "btnGetMatrixOfDistances";
            this.btnGetMatrixOfDistances.Size = new System.Drawing.Size(130, 24);
            this.btnGetMatrixOfDistances.TabIndex = 42;
            this.btnGetMatrixOfDistances.Text = "Матриця відстаней";
            this.btnGetMatrixOfDistances.UseVisualStyleBackColor = true;
            this.btnGetMatrixOfDistances.Click += new System.EventHandler(this.btnGetMatrixOfDistances_Click);
            // 
            // btnLoadDataset
            // 
            this.btnLoadDataset.Location = new System.Drawing.Point(356, 11);
            this.btnLoadDataset.Name = "btnLoadDataset";
            this.btnLoadDataset.Size = new System.Drawing.Size(130, 24);
            this.btnLoadDataset.TabIndex = 40;
            this.btnLoadDataset.Text = "Завантажити Dataset";
            this.btnLoadDataset.UseVisualStyleBackColor = true;
            this.btnLoadDataset.Click += new System.EventHandler(this.btnLoadDataset_Click);
            // 
            // btnNormalizationOfData
            // 
            this.btnNormalizationOfData.Location = new System.Drawing.Point(489, 11);
            this.btnNormalizationOfData.Name = "btnNormalizationOfData";
            this.btnNormalizationOfData.Size = new System.Drawing.Size(130, 24);
            this.btnNormalizationOfData.TabIndex = 43;
            this.btnNormalizationOfData.Text = "Нормалізація даних";
            this.btnNormalizationOfData.UseVisualStyleBackColor = true;
            this.btnNormalizationOfData.Click += new System.EventHandler(this.btnNormalizationOfData_Click);
            // 
            // PrimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 536);
            this.Controls.Add(this.btnNormalizationOfData);
            this.Controls.Add(this.btnGetMatrixOfDistances);
            this.Controls.Add(this.btnLoadDataset);
            this.Controls.Add(this.numericUpDownMetrik);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.dataGridViewMatrixDataset);
            this.Controls.Add(this.dataGridViewMatrixOfDistances);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dataGridViewBHRbuffer);
            this.MaximumSize = new System.Drawing.Size(853, 575);
            this.MinimumSize = new System.Drawing.Size(853, 575);
            this.Name = "PrimaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrimaForm";
            this.Load += new System.EventHandler(this.PrimaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBHRbuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dataGridViewBHRbuffer;
        private System.Windows.Forms.DataGridView dataGridViewMatrixDataset;
        private System.Windows.Forms.DataGridView dataGridViewMatrixOfDistances;
        private System.Windows.Forms.NumericUpDown numericUpDownMetrik;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Button btnGetMatrixOfDistances;
        private System.Windows.Forms.Button btnLoadDataset;
        private System.Windows.Forms.Button btnNormalizationOfData;
    }
}