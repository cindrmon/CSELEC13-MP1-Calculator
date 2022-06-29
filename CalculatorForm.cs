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
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private double EvaluateString(string expression)
        {
            DataTable table = new DataTable();
            table.Columns.Add("expression", typeof(string), expression);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["expression"]);
        }

        private void Calculate()
        {
            ClearOutput();
            try
            {
                double rawAnswer = EvaluateString(tbCalcInput.Text);

                if (rawAnswer == Double.PositiveInfinity)
                {
                    lblErrorText.Text = "Error: Dividing by Zero is Invalid";
                }
                else
                {
                    lblResultOutput.Text = rawAnswer.ToString();
                }
                
            }
            catch (SyntaxErrorException seEx)
            {
                lblErrorText.Text = "Error: Invalid Syntax";
            }
            catch (EvaluateException eEx)
            {
                lblErrorText.Text = "Error: Invalid Syntax";
            }
            ClearInput();
        }

        private void ClearInput()
        {
            tbCalcInput.Text = "";
        }

        private void ClearOutput()
        {
            lblResultOutput.Text = "";
            lblErrorText.Text = "";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "9";
        }
        
        private void btnDot_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += ".";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "+";
        }
        
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "-";
        }
        
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "*";
        }
        
        private void btnDivide_Click(object sender, EventArgs e)
        {
            tbCalcInput.Text += "/";
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            ClearInput();
            ClearOutput();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void tbCalcInput_HandleKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calculate();
                e.Handled = true;
            }
        }

    }
}