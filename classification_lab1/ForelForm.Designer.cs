namespace classification_lab1
{
    partial class ForelForm
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
            this.panelGraph = new System.Windows.Forms.Panel();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.dataGridViewClassTable = new System.Windows.Forms.DataGridView();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.numericUpDownNumberOfMetrik = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewCoordinateMatrix = new System.Windows.Forms.DataGridView();
            this.numericUpDownAmountOfPoints = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTestData = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfMetrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinateMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGraph
            // 
            this.panelGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraph.Location = new System.Drawing.Point(592, 92);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(480, 480);
            this.panelGraph.TabIndex = 51;
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(428, 12);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(75, 23);
            this.btnDrawGraph.TabIndex = 50;
            this.btnDrawGraph.Text = "Графік";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // dataGridViewClassTable
            // 
            this.dataGridViewClassTable.AllowUserToAddRows = false;
            this.dataGridViewClassTable.AllowUserToDeleteRows = false;
            this.dataGridViewClassTable.AllowUserToResizeColumns = false;
            this.dataGridViewClassTable.AllowUserToResizeRows = false;
            this.dataGridViewClassTable.ColumnHeadersHeight = 20;
            this.dataGridViewClassTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewClassTable.ColumnHeadersVisible = false;
            this.dataGridViewClassTable.Location = new System.Drawing.Point(72, 47);
            this.dataGridViewClassTable.Name = "dataGridViewClassTable";
            this.dataGridViewClassTable.RowHeadersVisible = false;
            this.dataGridViewClassTable.RowHeadersWidth = 40;
            this.dataGridViewClassTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewClassTable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewClassTable.RowTemplate.Height = 20;
            this.dataGridViewClassTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClassTable.Size = new System.Drawing.Size(30, 30);
            this.dataGridViewClassTable.TabIndex = 49;
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(327, 12);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 23);
            this.btnToDo.TabIndex = 47;
            this.btnToDo.Text = "Обчислити";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(153, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 46;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // numericUpDownNumberOfMetrik
            // 
            this.numericUpDownNumberOfMetrik.Location = new System.Drawing.Point(72, 12);
            this.numericUpDownNumberOfMetrik.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownNumberOfMetrik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownNumberOfMetrik.Name = "numericUpDownNumberOfMetrik";
            this.numericUpDownNumberOfMetrik.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownNumberOfMetrik.TabIndex = 45;
            this.numericUpDownNumberOfMetrik.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownNumberOfMetrik.ValueChanged += new System.EventHandler(this.numericUpDownAmountOfPoints_ValueChanged);
            // 
            // dataGridViewCoordinateMatrix
            // 
            this.dataGridViewCoordinateMatrix.AllowUserToAddRows = false;
            this.dataGridViewCoordinateMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewCoordinateMatrix.AllowUserToResizeColumns = false;
            this.dataGridViewCoordinateMatrix.AllowUserToResizeRows = false;
            this.dataGridViewCoordinateMatrix.ColumnHeadersHeight = 20;
            this.dataGridViewCoordinateMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCoordinateMatrix.ColumnHeadersVisible = false;
            this.dataGridViewCoordinateMatrix.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewCoordinateMatrix.Name = "dataGridViewCoordinateMatrix";
            this.dataGridViewCoordinateMatrix.RowHeadersVisible = false;
            this.dataGridViewCoordinateMatrix.RowHeadersWidth = 40;
            this.dataGridViewCoordinateMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCoordinateMatrix.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCoordinateMatrix.RowTemplate.Height = 20;
            this.dataGridViewCoordinateMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCoordinateMatrix.Size = new System.Drawing.Size(30, 30);
            this.dataGridViewCoordinateMatrix.TabIndex = 44;
            // 
            // numericUpDownAmountOfPoints
            // 
            this.numericUpDownAmountOfPoints.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownAmountOfPoints.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAmountOfPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownAmountOfPoints.Name = "numericUpDownAmountOfPoints";
            this.numericUpDownAmountOfPoints.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownAmountOfPoints.TabIndex = 43;
            this.numericUpDownAmountOfPoints.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAmountOfPoints.ValueChanged += new System.EventHandler(this.numericUpDownAmountOfPoints_ValueChanged);
            // 
            // checkBoxTestData
            // 
            this.checkBoxTestData.AutoSize = true;
            this.checkBoxTestData.Location = new System.Drawing.Point(235, 14);
            this.checkBoxTestData.Name = "checkBoxTestData";
            this.checkBoxTestData.Size = new System.Drawing.Size(80, 17);
            this.checkBoxTestData.TabIndex = 52;
            this.checkBoxTestData.Text = "checkBox1";
            this.checkBoxTestData.UseVisualStyleBackColor = true;
            // 
            // ForelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.checkBoxTestData);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.dataGridViewClassTable);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.numericUpDownNumberOfMetrik);
            this.Controls.Add(this.dataGridViewCoordinateMatrix);
            this.Controls.Add(this.numericUpDownAmountOfPoints);
            this.Name = "ForelForm";
            this.Text = "ForelForm";
            this.Load += new System.EventHandler(this.ForelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfMetrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoordinateMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmountOfPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.DataGridView dataGridViewClassTable;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfMetrik;
        private System.Windows.Forms.DataGridView dataGridViewCoordinateMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownAmountOfPoints;
        private System.Windows.Forms.CheckBox checkBoxTestData;
    }
}