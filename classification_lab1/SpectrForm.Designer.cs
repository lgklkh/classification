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
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGridViewMatrixOfDistances = new System.Windows.Forms.DataGridView();
            this.dataGridViewSpectrumOfBonds = new System.Windows.Forms.DataGridView();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnToDo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpectrumOfBonds)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(34, 20);
            this.numericUpDownNumber.TabIndex = 1;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(52, 9);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Створити";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataGridViewMatrixOfDistances
            // 
            this.dataGridViewMatrixOfDistances.AllowUserToAddRows = false;
            this.dataGridViewMatrixOfDistances.AllowUserToDeleteRows = false;
            this.dataGridViewMatrixOfDistances.AllowUserToResizeColumns = false;
            this.dataGridViewMatrixOfDistances.AllowUserToResizeRows = false;
            this.dataGridViewMatrixOfDistances.ColumnHeadersHeight = 20;
            this.dataGridViewMatrixOfDistances.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMatrixOfDistances.ColumnHeadersVisible = false;
            this.dataGridViewMatrixOfDistances.Location = new System.Drawing.Point(12, 54);
            this.dataGridViewMatrixOfDistances.Name = "dataGridViewMatrixOfDistances";
            this.dataGridViewMatrixOfDistances.RowHeadersVisible = false;
            this.dataGridViewMatrixOfDistances.RowHeadersWidth = 40;
            this.dataGridViewMatrixOfDistances.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixOfDistances.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMatrixOfDistances.RowTemplate.Height = 20;
            this.dataGridViewMatrixOfDistances.Size = new System.Drawing.Size(30, 30);
            this.dataGridViewMatrixOfDistances.TabIndex = 3;
            // 
            // dataGridViewSpectrumOfBonds
            // 
            this.dataGridViewSpectrumOfBonds.AllowUserToAddRows = false;
            this.dataGridViewSpectrumOfBonds.AllowUserToDeleteRows = false;
            this.dataGridViewSpectrumOfBonds.AllowUserToResizeColumns = false;
            this.dataGridViewSpectrumOfBonds.AllowUserToResizeRows = false;
            this.dataGridViewSpectrumOfBonds.ColumnHeadersHeight = 20;
            this.dataGridViewSpectrumOfBonds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSpectrumOfBonds.ColumnHeadersVisible = false;
            this.dataGridViewSpectrumOfBonds.Location = new System.Drawing.Point(12, 90);
            this.dataGridViewSpectrumOfBonds.Name = "dataGridViewSpectrumOfBonds";
            this.dataGridViewSpectrumOfBonds.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSpectrumOfBonds.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSpectrumOfBonds.Size = new System.Drawing.Size(30, 30);
            this.dataGridViewSpectrumOfBonds.TabIndex = 4;
            // 
            // btnDrawGraph
            // 
            this.btnDrawGraph.Location = new System.Drawing.Point(556, 54);
            this.btnDrawGraph.Name = "btnDrawGraph";
            this.btnDrawGraph.Size = new System.Drawing.Size(75, 23);
            this.btnDrawGraph.TabIndex = 6;
            this.btnDrawGraph.Text = "Графік";
            this.btnDrawGraph.UseVisualStyleBackColor = true;
            this.btnDrawGraph.Click += new System.EventHandler(this.btnDrawGraph_Click);
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(556, 159);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(500, 300);
            this.zedGraph.TabIndex = 7;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(167, 9);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Тест";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(341, 9);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 23);
            this.btnToDo.TabIndex = 9;
            this.btnToDo.Text = "Обчислити";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // SpectrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.dataGridViewSpectrumOfBonds);
            this.Controls.Add(this.dataGridViewMatrixOfDistances);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.numericUpDownNumber);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "SpectrForm";
            this.Text = "SpectrForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpectrumOfBonds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGridViewMatrixOfDistances;
        private System.Windows.Forms.DataGridView dataGridViewSpectrumOfBonds;
        private System.Windows.Forms.Button btnDrawGraph;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnToDo;
    }
}