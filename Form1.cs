using System;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        double firstNum = 0;
        string numStr = "0";
        double result = 0;
        string operation = "";
        bool existancePoint = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {   
            if (numStr == "0") numStr = "1";
            else numStr += "1";
            textBox.Text = numStr;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "2";
            else numStr += "2";
            textBox.Text = numStr;
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "3";
            else numStr += "3";
            textBox.Text = numStr;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "4";
            else numStr += "4";
            textBox.Text = numStr;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "5";
            else numStr += "5";
            textBox.Text = numStr;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "6";
            else numStr += "6";
            textBox.Text = numStr;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "7";
            else numStr += "7";
            textBox.Text = numStr;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "8";
            else numStr += "8";
            textBox.Text = numStr;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (numStr == "0") numStr = "9";
            else numStr += "9";
            textBox.Text = numStr;
        }

        private void button_0_Click(object sender, EventArgs e)
        {   
            if (numStr != "0")
            {
                numStr += "0";
                textBox.Text = numStr;
            }else textBox.Text = "0";
        }
        private void button_pi_Click(object sender, EventArgs e)
        {
            if (numStr == "-") numStr += Math.PI.ToString();
            else numStr = Math.PI.ToString();

            textBox.Text = numStr;
            existancePoint = true;
        }


        private void button_plus_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstNum = Convert.ToDouble(numStr);
            numStr = "0";
            textBox.Text = operation;
            existancePoint = false;
        }
        private void button_minus_Click(object sender, EventArgs e)
        {   
            if (numStr != "0")
            {
                operation = "-";
                firstNum = Convert.ToDouble(numStr);
                numStr = "0";
                textBox.Text = operation;
                existancePoint = false;
            }
            else
            {
                numStr = "-";
            }
        }
        private void button_multipl_Click(object sender, EventArgs e)
        {
            operation = "*";
            firstNum = Convert.ToDouble(numStr);
            numStr = "0";
            textBox.Text = operation;
            existancePoint = false;
        }
        private void button_div_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstNum = Convert.ToDouble(numStr);
            numStr = "0";
            textBox.Text = operation;
            existancePoint = false;
        }
        private void button_point_Click(object sender, EventArgs e)
        {   
            if (!existancePoint)
            {
                existancePoint = true;
                numStr += ",";
            }
        }

        private void button_eq_Click(object sender, EventArgs e)
        {   
            double secondNum = Convert.ToDouble(numStr);
            switch(operation)
            {
                
                case "+":
                    result = firstNum + secondNum;
                    textBox.Text = result.ToString();
                    numStr = result.ToString();
                    break;
                case "-":
                    result = firstNum - secondNum;
                    textBox.Text = result.ToString();
                    numStr = result.ToString();
                    break;
                case "*":
                    result = firstNum * secondNum;
                    textBox.Text = result.ToString();
                    numStr = result.ToString();
                    break;
                case "/":
                    if (secondNum != 0)
                    {
                        result = firstNum / secondNum;
                        textBox.Text = result.ToString();
                        numStr = result.ToString();

                    }
                    else
                    {
                        result = 0;
                        textBox.Text = "ERROR";
                        numStr = "0";
                        firstNum = 0;
                        existancePoint = false;
                    }

                    break;
                case "pow":
                    result = Math.Pow(firstNum, secondNum);
                    textBox.Text = result.ToString();
                    numStr = result.ToString();
                    break;

            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            if (numStr != "0" && numStr.Length == 1) numStr = "0";

            else if (numStr != "0" && numStr.Length > 1)
            {
                if (numStr[numStr.Length - 1] == ',')
                {
                    existancePoint = false;
                }
                numStr = numStr.Remove(numStr.Length - 1);   
            }
            textBox.Text = numStr;
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            numStr = "0";
            existancePoint = false;
            firstNum = 0;
            textBox.Text = numStr;
        }
        private void button_sin_Click(object sender, EventArgs e)
        {

                double num = Convert.ToDouble(numStr);
                numStr = Math.Sin(num).ToString();
                textBox.Text = numStr;                     
        }

        private void button_cos_Click(object sender, EventArgs e)
        {

                double num = Convert.ToDouble(numStr);
                numStr = Math.Cos(num).ToString();
                textBox.Text = numStr;           
        }

        private void button_tg_Click(object sender, EventArgs e)
        {

                double num = Convert.ToDouble(numStr);
                numStr = Math.Tan(num).ToString();
                textBox.Text = numStr;        
        }

        private void button_invert_Click(object sender, EventArgs e)
        {
            if (numStr != "0")
            {
                double num = Convert.ToDouble(numStr);
                numStr = (1 / num).ToString();
                textBox.Text = numStr;

            }
        }

        private void button_lg_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numStr);
            if (num > 0)
            {
                numStr = Math.Log10(num).ToString();
                textBox.Text = numStr;
            }
            else
            {
                textBox.Text = "ERROR";
                numStr = "0";
                existancePoint = false;
                firstNum = 0;
                operation = "";
            }
            
        }

        private void button_ln_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numStr);
            if (num > 0)
            {
                numStr = Math.Log(num).ToString();
                textBox.Text = numStr;
            }
            else
            {
                textBox.Text = "ERROR";
                numStr = "0";
                existancePoint = false;
                firstNum = 0;
                operation = "";
            }

        }

        private void button_invert_sign_Click(object sender, EventArgs e)
        {
            if (numStr != "0")
            {
                double num = Convert.ToDouble(numStr) * -1;
                numStr = num.ToString();
                textBox.Text = numStr;
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(numStr);
            if (num >= 0)
            {
                numStr = Math.Sqrt(num).ToString();
                textBox.Text = numStr;
            }
            else
            {
                textBox.Text = "ERROR";
                numStr = "0";
                existancePoint = false;
                firstNum = 0;
                operation = "";
            }
        }

        private void button_pow_2_Click(object sender, EventArgs e)
        {

                double num = Convert.ToDouble(numStr);
                numStr = (num * num).ToString();
                textBox.Text = numStr;
            
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            operation = "pow";
            firstNum = Convert.ToDouble(numStr);
            numStr = "0";
            textBox.Text = "^";
            existancePoint = false;
        }


    }
}
