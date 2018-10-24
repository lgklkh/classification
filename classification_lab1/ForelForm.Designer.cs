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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbValuep = new System.Windows.Forms.TextBox();
            this.tbValuer = new System.Windows.Forms.TextBox();
            this.cbMetrik = new System.Windows.Forms.ComboBox();
            this.btnLoadDataset = new System.Windows.Forms.Button();
            this.numericUpDownMetrik = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewClassTable = new System.Windows.Forms.DataGridView();
            this.btnToDo = new System.Windows.Forms.Button();
            this.dataGridViewMatrixDataset = new System.Windows.Forms.DataGridView();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1025, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 39);
            this.btnCancel.TabIndex = 58;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbValuep
            // 
            this.tbValuep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValuep.Location = new System.Drawing.Point(1004, 158);
            this.tbValuep.Name = "tbValuep";
            this.tbValuep.Size = new System.Drawing.Size(79, 26);
            this.tbValuep.TabIndex = 57;
            this.tbValuep.Text = "p";
            this.tbValuep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbValuer
            // 
            this.tbValuer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbValuer.Location = new System.Drawing.Point(1004, 126);
            this.tbValuer.Name = "tbValuer";
            this.tbValuer.Size = new System.Drawing.Size(79, 26);
            this.tbValuer.TabIndex = 56;
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
            this.cbMetrik.Location = new System.Drawing.Point(1004, 99);
            this.cbMetrik.Name = "cbMetrik";
            this.cbMetrik.Size = new System.Drawing.Size(79, 21);
            this.cbMetrik.TabIndex = 55;
            // 
            // btnLoadDataset
            // 
            this.btnLoadDataset.Location = new System.Drawing.Point(501, 1);
            this.btnLoadDataset.Name = "btnLoadDataset";
            this.btnLoadDataset.Size = new System.Drawing.Size(90, 41);
            this.btnLoadDataset.TabIndex = 53;
            this.btnLoadDataset.Text = "Завантажити Dataset";
            this.btnLoadDataset.UseVisualStyleBackColor = true;
            this.btnLoadDataset.Click += new System.EventHandler(this.btnLoadDataset_Click);
            // 
            // numericUpDownMetrik
            // 
            this.numericUpDownMetrik.BackColor = System.Drawing.SystemColors.HotTrack;
            this.numericUpDownMetrik.Location = new System.Drawing.Point(108, 12);
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
            this.numericUpDownMetrik.TabIndex = 50;
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
            this.numericUpDownNumber.Location = new System.Drawing.Point(12, 12);
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
            this.numericUpDownNumber.TabIndex = 49;
            this.numericUpDownNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownAmountOfPoints_ValueChanged);
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
            this.dataGridViewClassTable.Location = new System.Drawing.Point(250, 44);
            this.dataGridViewClassTable.Name = "dataGridViewClassTable";
            this.dataGridViewClassTable.RowHeadersVisible = false;
            this.dataGridViewClassTable.RowHeadersWidth = 40;
            this.dataGridViewClassTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewClassTable.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClassTable.RowTemplate.Height = 20;
            this.dataGridViewClassTable.Size = new System.Drawing.Size(748, 582);
            this.dataGridViewClassTable.TabIndex = 52;
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(327, 9);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 23);
            this.btnToDo.TabIndex = 51;
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
            this.dataGridViewMatrixDataset.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewMatrixDataset.Name = "dataGridViewMatrixDataset";
            this.dataGridViewMatrixDataset.RowHeadersVisible = false;
            this.dataGridViewMatrixDataset.RowHeadersWidth = 40;
            this.dataGridViewMatrixDataset.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewMatrixDataset.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewMatrixDataset.RowTemplate.Height = 20;
            this.dataGridViewMatrixDataset.Size = new System.Drawing.Size(232, 582);
            this.dataGridViewMatrixDataset.TabIndex = 48;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.BackColor = System.Drawing.Color.Pink;
            this.numericUpDownCount.Location = new System.Drawing.Point(204, 12);
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
            this.numericUpDownCount.TabIndex = 59;
            this.numericUpDownCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ForelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 641);
            this.Controls.Add(this.numericUpDownCount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbValuep);
            this.Controls.Add(this.tbValuer);
            this.Controls.Add(this.cbMetrik);
            this.Controls.Add(this.btnLoadDataset);
            this.Controls.Add(this.numericUpDownMetrik);
            this.Controls.Add(this.numericUpDownNumber);
            this.Controls.Add(this.dataGridViewClassTable);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.dataGridViewMatrixDataset);
            this.Name = "ForelForm";
            this.Text = "ForelForm";
            this.Load += new System.EventHandler(this.ForelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMetrik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrixDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbValuep;
        private System.Windows.Forms.TextBox tbValuer;
        private System.Windows.Forms.ComboBox cbMetrik;
        private System.Windows.Forms.Button btnLoadDataset;
        private System.Windows.Forms.NumericUpDown numericUpDownMetrik;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.DataGridView dataGridViewClassTable;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.DataGridView dataGridViewMatrixDataset;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
    }
}