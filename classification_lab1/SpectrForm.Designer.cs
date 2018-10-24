namespace classification_lab1
{
    partial class SpectrForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewMatrixOfDistances = new System.Windows.Forms.DataGridView();
            this.dataGridViewSpectrumOfBonds = new System.Windows.Forms.DataGridView();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnLoadDataset = new System.Windows.Forms.Button();
            this.dataGridViewMatrixDataset = new System.Windows.Forms.DataGridView();
            this.numericUpDownMetrik = new System.Windows.Forms.NumericUpDown();
            this.btnGetMatrixOfDistances = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.btnNormalizationOfData = new System.Windows.Forms.Button();
            this.cbMetrik = new System.Windows.Forms.ComboBox();
            this.tbValuer = new System.Windows.Forms.TextBox();
            this.tbValuep = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpectrumOfBonds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(963, 304);
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
            this.numericUpDownNumber.TabIndex = 1;
            this.numericUpDownNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged);
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
            this.dataGridViewMatrixOfDistances.Location = new System.Drawing.Point(415, 5);
            this.dataGridViewMatrixOfDistances.Name = "dataGridViewMatrixOfDistances";
            this.dataGridViewMatrixOfDistances.RowHeadersVisible = false;
            this.dataGridViewMatrixOfDistances.RowHeadersWidth = 10;
            this.dataGridViewMatrixOfDistances.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixOfDistances.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatrixOfDistances.RowTemplate.Height = 20;
            this.dataGridViewMatrixOfDistances.Size = new System.Drawing.Size(408, 380);
            this.dataGridViewMatrixOfDistances.TabIndex = 3;
            // 
            // dataGridViewSpectrumOfBonds
            // 
            this.dataGridViewSpectrumOfBonds.AllowUserToAddRows = false;
            this.dataGridViewSpectrumOfBonds.AllowUserToDeleteRows = false;
            this.dataGridViewSpectrumOfBonds.AllowUserToResizeColumns = false;
            this.dataGridViewSpectrumOfBonds.AllowUserToResizeRows = false;
            this.dataGridViewSpectrumOfBonds.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSpectrumOfBonds.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSpectrumOfBonds.ColumnHeadersHeight = 20;
            this.dataGridViewSpectrumOfBonds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSpectrumOfBonds.ColumnHeadersVisible = false;
            this.dataGridViewSpectrumOfBonds.Location = new System.Drawing.Point(826, 5);
            this.dataGridViewSpectrumOfBonds.Name = "dataGridViewSpectrumOfBonds";
            this.dataGridViewSpectrumOfBonds.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSpectrumOfBonds.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSpectrumOfBonds.Size = new System.Drawing.Size(554, 122);
            this.dataGridViewSpectrumOfBonds.TabIndex = 4;
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(1155, 211);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(90, 27);
            this.btnDrawGraph.TabIndex = 6;
            this.btnDrawGraph.Text = "Графік";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(963, 184);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(90, 54);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(1155, 184);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(90, 27);
            this.btnToDo.TabIndex = 9;
            this.btnToDo.Text = "Обчислити";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // btnLoadDataset
            // 
            this.btnLoadDataset.Location = new System.Drawing.Point(1059, 124);
            this.btnLoadDataset.Name = "btnLoadDataset";
            this.btnLoadDataset.Size = new System.Drawing.Size(90, 54);
            this.btnLoadDataset.TabIndex = 33;
            this.btnLoadDataset.Text = "Завантажити Dataset";
            this.btnLoadDataset.UseVisualStyleBackColor = true;
            this.btnLoadDataset.Click += new System.EventHandler(this.btnLoadDataset_Click);
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
            this.dataGridViewMatrixDataset.Location = new System.Drawing.Point(5, 5);
            this.dataGridViewMatrixDataset.Name = "dataGridViewMatrixDataset";
            this.dataGridViewMatrixDataset.RowHeadersVisible = false;
            this.dataGridViewMatrixDataset.RowHeadersWidth = 10;
            this.dataGridViewMatrixDataset.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixDataset.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMatrixDataset.RowTemplate.Height = 20;
            this.dataGridViewMatrixDataset.Size = new System.Drawing.Size(408, 380);
            this.dataGridViewMatrixDataset.TabIndex = 34;
            // 
            // numericUpDownMetrik
            // 
            this.numericUpDownMetrik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDownMetrik.Location = new System.Drawing.Point(1059, 304);
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
            this.numericUpDownMetrik.TabIndex = 35;
            this.numericUpDownMetrik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownMetrik.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownMetrik.ValueChanged += new System.EventHandler(this.numericUpDownMetrik_ValueChanged);
            // 
            // btnGetMatrixOfDistances
            // 
            this.btnGetMatrixOfDistances.Location = new System.Drawing.Point(1059, 244);
            this.btnGetMatrixOfDistances.Name = "btnGetMatrixOfDistances";
            this.btnGetMatrixOfDistances.Size = new System.Drawing.Size(90, 54);
            this.btnGetMatrixOfDistances.TabIndex = 36;
            this.btnGetMatrixOfDistances.Text = "Матриця відстаней";
            this.btnGetMatrixOfDistances.UseVisualStyleBackColor = true;
            this.btnGetMatrixOfDistances.Click += new System.EventHandler(this.btnGetMatrixOfDistances_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.IsShowPointValues = true;
            this.zedGraph.Location = new System.Drawing.Point(5, 408);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(1375, 350);
            this.zedGraph.TabIndex = 37;
            this.zedGraph.UseExtendedPrintDialog = true;
            this.zedGraph.PointValueEvent += new ZedGraph.ZedGraphControl.PointValueHandler(this.zedGraph_PointValueEvent);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.Color.Pink;
            this.numericUpDownCount.Location = new System.Drawing.Point(1155, 304);
            this.numericUpDownCount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownCount.TabIndex = 38;
            this.numericUpDownCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnNormalizationOfData
            // 
            this.btnNormalizationOfData.Location = new System.Drawing.Point(1059, 184);
            this.btnNormalizationOfData.Name = "btnNormalizationOfData";
            this.btnNormalizationOfData.Size = new System.Drawing.Size(90, 54);
            this.btnNormalizationOfData.TabIndex = 39;
            this.btnNormalizationOfData.Text = "Нормалізація даних";
            this.btnNormalizationOfData.UseVisualStyleBackColor = true;
            this.btnNormalizationOfData.Click += new System.EventHandler(this.btnNormalizationOfData_Click);
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
            this.cbMetrik.Location = new System.Drawing.Point(963, 262);
            this.cbMetrik.Name = "cbMetrik";
            this.cbMetrik.Size = new System.Drawing.Size(90, 21);
            this.cbMetrik.TabIndex = 40;
            // 
            // tbValuer
            // 
            this.tbValuer.Location = new System.Drawing.Point(1155, 250);
            this.tbValuer.Name = "tbValuer";
            this.tbValuer.Size = new System.Drawing.Size(89, 20);
            this.tbValuer.TabIndex = 41;
            this.tbValuer.Text = "r";
            // 
            // tbValuep
            // 
            this.tbValuep.Location = new System.Drawing.Point(1155, 272);
            this.tbValuep.Name = "tbValuep";
            this.tbValuep.Size = new System.Drawing.Size(89, 20);
            this.tbValuep.TabIndex = 42;
            this.tbValuep.Text = "p";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1282, 192);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 39);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SpectrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbValuep);
            this.Controls.Add(this.tbValuer);
            this.Controls.Add(this.cbMetrik);
            this.Controls.Add(this.btnNormalizationOfData);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.btnGetMatrixOfDistances);
            this.Controls.Add(this.numericUpDownMetrik);
            this.Controls.Add(this.dataGridViewMatrixDataset);
            this.Controls.Add(this.btnLoadDataset);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.dataGridViewSpectrumOfBonds);
            this.Controls.Add(this.dataGridViewMatrixOfDistances);
            this.Controls.Add(this.numericUpDownNumber);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 800);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1400, 800);
            this.Name = "SpectrForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpectrForm";
            this.Load += new System.EventHandler(this.SpectrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpectrumOfBonds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.DataGridView dataGridViewMatrixOfDistances;
        private System.Windows.Forms.DataGridView dataGridViewSpectrumOfBonds;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button btnLoadDataset;
        private System.Windows.Forms.DataGridView dataGridViewMatrixDataset;
        private System.Windows.Forms.NumericUpDown numericUpDownMetrik;
        private System.Windows.Forms.Button btnGetMatrixOfDistances;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Button btnNormalizationOfData;
        private System.Windows.Forms.ComboBox cbMetrik;
        private System.Windows.Forms.TextBox tbValuer;
        private System.Windows.Forms.TextBox tbValuep;
        private System.Windows.Forms.Button btnCancel;
    }
}