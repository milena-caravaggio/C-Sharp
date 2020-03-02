using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaConta
{
    public partial class Form1 : Form

    {       
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (lhsOperand.Text == string.Empty || rhsOperand.Text == string.Empty)
            {
                MessageBox.Show(" Preencha o campo dos numeros ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radioAdd.Checked)
            {
                string teste1 = lhsOperand.Text.Replace(".", ",");
                decimal lhs = decimal.Parse(teste1);
                string teste2 = rhsOperand.Text.Replace(".", ",");
                decimal rhs = decimal.Parse(teste2);
                decimal outcome;
                outcome = lhs + rhs;
                txtExp.Text = lhsOperand.Text + " + " + rhsOperand.Text;
                txtResult.Text = outcome.ToString();
            }
            else if (radioDiv.Checked)
            {
                decimal lhs = decimal.Parse(lhsOperand.Text.Replace(".", ","));
                decimal rhs = decimal.Parse(rhsOperand.Text.Replace(".", ","));
                decimal outcome;
                outcome = lhs / rhs;
                txtExp.Text = lhsOperand.Text + " / " + rhsOperand.Text;
                txtResult.Text = outcome.ToString();

            }
            else if (radioMult.Checked)
            {
                decimal lhs = decimal.Parse(lhsOperand.Text.Replace(".", ","));
                decimal rhs = decimal.Parse(rhsOperand.Text.Replace(".", ","));
                decimal outcome;
                outcome = lhs * rhs;
                txtExp.Text = lhsOperand.Text + " * " + rhsOperand.Text;
                txtResult.Text = outcome.ToString();
            }
            else if (radioSub.Checked)
            {
                decimal lhs = decimal.Parse(lhsOperand.Text.Replace(".", ","));
                decimal rhs = decimal.Parse(rhsOperand.Text.Replace(".", ","));
                decimal outcome;
                outcome = lhs - rhs;
                txtExp.Text = lhsOperand.Text + " - " + rhsOperand.Text;
                txtResult.Text = outcome.ToString();
            }
            else if (radioRam.Checked)
            {
                decimal lhs = decimal.Parse(lhsOperand.Text.Replace(".", ","));
                decimal rhs = decimal.Parse(rhsOperand.Text.Replace(".", ","));
                decimal outcome;
                outcome = lhs % rhs;
                txtExp.Text = lhsOperand.Text + " % " + rhsOperand.Text;
                txtResult.Text = outcome.ToString();
            }
            else
            {
                MessageBox.Show(" Selecione uma operação ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lhsOperand_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoNumeros(e);
        }

        private static void TratamentoNumeros(KeyPressEventArgs e)
        {
            if (e.KeyChar == 44)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
        }

        private void rhsOperand_KeyPress(object sender, KeyPressEventArgs e)
        {
            TratamentoNumeros(e);
        }
    }
}
