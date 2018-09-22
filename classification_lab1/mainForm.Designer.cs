namespace classification_lab1
{
    partial class mainForm
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
            this.btnSpectr = new System.Windows.Forms.Button();
            this.btnKrab = new System.Windows.Forms.Button();
            this.btnPrima = new System.Windows.Forms.Button();
            this.btnForel = new System.Windows.Forms.Button();
            this.btnForel2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSpectr
            // 
            this.btnSpectr.Location = new System.Drawing.Point(24, 12);
            this.btnSpectr.Name = "btnSpectr";
            this.btnSpectr.Size = new System.Drawing.Size(75, 23);
            this.btnSpectr.TabIndex = 0;
            this.btnSpectr.Text = "СПЕКТР";
            this.btnSpectr.UseVisualStyleBackColor = true;
            this.btnSpectr.Click += new System.EventHandler(this.btnSpectr_Click);
            // 
            // btnKrab
            // 
            this.btnKrab.Location = new System.Drawing.Point(24, 41);
            this.btnKrab.Name = "btnKrab";
            this.btnKrab.Size = new System.Drawing.Size(75, 23);
            this.btnKrab.TabIndex = 1;
            this.btnKrab.Text = "КРАБ";
            this.btnKrab.UseVisualStyleBackColor = true;
            this.btnKrab.Click += new System.EventHandler(this.btnKrab_Click);
            // 
            // btnPrima
            // 
            this.btnPrima.Location = new System.Drawing.Point(24, 70);
            this.btnPrima.Name = "btnPrima";
            this.btnPrima.Size = new System.Drawing.Size(75, 23);
            this.btnPrima.TabIndex = 2;
            this.btnPrima.Text = "ПРІМА";
            this.btnPrima.UseVisualStyleBackColor = true;
            this.btnPrima.Click += new System.EventHandler(this.btnPrima_Click);
            // 
            // btnForel
            // 
            this.btnForel.Location = new System.Drawing.Point(24, 99);
            this.btnForel.Name = "btnForel";
            this.btnForel.Size = new System.Drawing.Size(75, 23);
            this.btnForel.TabIndex = 3;
            this.btnForel.Text = "ФОРЕЛЬ";
            this.btnForel.UseVisualStyleBackColor = true;
            this.btnForel.Click += new System.EventHandler(this.btnForel_Click);
            // 
            // btnForel2
            // 
            this.btnForel2.Location = new System.Drawing.Point(24, 128);
            this.btnForel2.Name = "btnForel2";
            this.btnForel2.Size = new System.Drawing.Size(75, 23);
            this.btnForel2.TabIndex = 4;
            this.btnForel2.Text = "ФОРЕЛЬ2";
            this.btnForel2.UseVisualStyleBackColor = true;
            this.btnForel2.Click += new System.EventHandler(this.btnForel2_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 163);
            this.Controls.Add(this.btnForel2);
            this.Controls.Add(this.btnForel);
            this.Controls.Add(this.btnPrima);
            this.Controls.Add(this.btnKrab);
            this.Controls.Add(this.btnSpectr);
            this.Name = "mainForm";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSpectr;
        private System.Windows.Forms.Button btnKrab;
        private System.Windows.Forms.Button btnPrima;
        private System.Windows.Forms.Button btnForel;
        private System.Windows.Forms.Button btnForel2;
    }
}

