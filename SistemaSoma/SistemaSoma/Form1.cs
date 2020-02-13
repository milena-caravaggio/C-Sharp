using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSoma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            num1 = Convert.ToInt32(txtNUm.Text);
            num2 = Convert.ToInt32(txtNDois.Text);
            result = num1 + num2;
            txtResult.Text = (result).ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNUm.Text = ("");
            txtNDois.Text = ("");
            txtResult.Text = ("");
        }
    }
}
