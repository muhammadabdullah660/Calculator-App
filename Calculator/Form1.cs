using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        char op;
        public Form1 ()
        {
            InitializeComponent();
        }

        private void Form1_Load (object sender , EventArgs e)
        {

        }
        private void btn1_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn1.Text;
        }
        private void btn2_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn2.Text;
        }
        private void btn3_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn3.Text;
        }
        private void btn4_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn4.Text;
        }
        private void btn5_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn5.Text;
        }
        private void btn6_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn6.Text;
        }
        private void btn7_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn7.Text;
        }
        private void btn8_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn8.Text;
        }
        private void btn9_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn9.Text;

        }
        private void btn0_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btn0.Text;

        }
        private void btnPoint_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btnPoint.Text;

        }
        private void btnC_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text = "";
        }

        private void btnCE_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text = txtBoxResult.Text.Remove(txtBoxResult.Text.Length - 1);
        }
        private void btnMinus_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btnMinus.Text;
            op = '-';

        }
        private void btnDivide_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btnDivide.Text;
            op = '/';
        }

        private void btnMultiply_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btnMultiply.Text;
            op = '*';
        }

        private void btnEqual_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text = compute(txtBoxResult.Text).ToString();
        }
        private void btnPlus_Click (object sender , EventArgs e)
        {
            txtBoxResult.Text += btnPlus.Text;
            op = '+';
        }
        public float compute (string expression)
        {
            float operand1, operand2;
            string[] operands = expression.Split(op);
            operand1 = float.Parse(operands[0]);
            operand2 = float.Parse(operands[1]);
            return eval(operand1 , operand2);
        }
        public float eval (float operand1 , float operand2)
        {

            if (op == '+')
            {
                return operand1 + operand2;
            }
            if (op == '-')
            {
                return operand1 - operand2;
            }
            if (op == '*')
            {
                return operand1 * operand2;
            }
            if (op == '/')
            {
                return operand1 / operand2;
            }
            return 0;
        }
    }
}
