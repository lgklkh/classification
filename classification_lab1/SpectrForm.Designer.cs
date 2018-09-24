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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewMatrixOfDistances = new System.Windows.Forms.DataGridView();
            this.dataGridViewSpectrumOfBonds = new System.Windows.Forms.DataGridView();
            this.btnDrawGraph = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnToDo = new System.Windows.Forms.Button();
            this.panelGraph = new System.Windows.Forms.Panel();
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
            // panelGraph
            // 
            this.panelGraph.Location = new System.Drawing.Point(610, 90);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(450, 450);
            this.panelGraph.TabIndex = 32;
            // 
            // SpectrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.panelGraph);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnDrawGraph);
            this.Controls.Add(this.dataGridViewSpectrumOfBonds);
            this.Controls.Add(this.dataGridViewMatrixOfDistances);
            this.Controls.Add(this.numericUpDownNumber);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 680);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.Name = "SpectrForm";
            this.Text = "SpectrForm";
            this.Load += new System.EventHandler(this.SpectrForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpectrumOfBonds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.DataGridView dataGridViewMatrixOfDistances;
        private System.Windows.Forms.DataGridView dataGridViewSpectrumOfBonds;
        private System.Windows.Forms.Button btnDrawGraph;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Panel panelGraph;
    }
}