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
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.dataGridViewBHRbuffer = new System.Windows.Forms.DataGridView();
            this.dataGridViewMatrixOfDistances = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBHRbuffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Location = new System.Drawing.Point(12, 12);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            12,
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
            this.numericUpDownNumber.TabIndex = 2;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged);
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(340, 12);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 23);
            this.btnToDo.TabIndex = 15;
            this.btnToDo.Text = "Обчислити";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(166, 12);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
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
            this.dataGridViewBHRbuffer.ColumnHeadersHeight = 20;
            this.dataGridViewBHRbuffer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBHRbuffer.ColumnHeadersVisible = false;
            this.dataGridViewBHRbuffer.Location = new System.Drawing.Point(11, 93);
            this.dataGridViewBHRbuffer.Name = "dataGridViewBHRbuffer";
            this.dataGridViewBHRbuffer.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewBHRbuffer.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBHRbuffer.Size = new System.Drawing.Size(30, 30);
            this.dataGridViewBHRbuffer.TabIndex = 11;
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
            this.dataGridViewMatrixOfDistances.Location = new System.Drawing.Point(11, 57);
            this.dataGridViewMatrixOfDistances.Name = "dataGridViewMatrixOfDistances";
            this.dataGridViewMatrixOfDistances.RowHeadersVisible = false;
            this.dataGridViewMatrixOfDistances.RowHeadersWidth = 40;
            this.dataGridViewMatrixOfDistances.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixOfDistances.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMatrixOfDistances.RowTemplate.Height = 20;
            this.dataGridViewMatrixOfDistances.Size = new System.Drawing.Size(30, 30);
            this.dataGridViewMatrixOfDistances.TabIndex = 10;
            // 
            // PrimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.dataGridViewBHRbuffer);
            this.Controls.Add(this.dataGridViewMatrixOfDistances);
            this.Controls.Add(this.numericUpDownNumber);
            this.Name = "PrimaForm";
            this.Text = "PrimaForm";
            this.Load += new System.EventHandler(this.PrimaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBHRbuffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixOfDistances)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.DataGridView dataGridViewBHRbuffer;
        private System.Windows.Forms.DataGridView dataGridViewMatrixOfDistances;
    }
}