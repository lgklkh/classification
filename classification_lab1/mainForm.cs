using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classification_lab1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void btnSpectr_Click(object sender, EventArgs e)
        {
            var form = new SpectrForm();
            form.Show();
        }

        private void btnKrab_Click(object sender, EventArgs e)
        {
            var form = new KrabForm();
            form.Show();
        }

        private void btnPrima_Click(object sender, EventArgs e)
        {
            var form = new PrimaForm();
            form.Show();
        }

        private void btnForel_Click(object sender, EventArgs e)
        {
            var form = new ForelForm();
            form.Show();
        }

        private void btnForel2_Click(object sender, EventArgs e)
        {
            var form = new Forel2Form();
            form.Show();
        }
    }
}
