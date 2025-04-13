using Evaluator.Logic;

namespace Evaluator.UI.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtInput.Text += "7";
        }


        private void btn8_Click(object sender, EventArgs e)
        {
            txtInput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtInput.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtInput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtInput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtInput.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtInput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtInput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtInput.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtInput.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtInput.Text += ".";
        }

        private void btnDIvide_Click(object sender, EventArgs e)
        {
            txtInput.Text += "/";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtInput.Text += "*";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtInput.Text += "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            txtInput.Text += "-";
        }

        private void btnOpenParenthesis_Click(object sender, EventArgs e)
        {
            txtInput.Text += "(";
        }

        private void btnCloseParenthesis_Click(object sender, EventArgs e)
        {
            txtInput.Text += ")";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtInput.Text = txtInput.Text.Substring(0, txtInput.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            txtInput.Text += "^";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            txtInput.Text += $"={FunctionEvaluator.Evalute(txtInput.Text)}";
        }
    }
}
