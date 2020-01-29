using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialCalculator
{
    public partial class FactorialCalculator : Form
    {
        public FactorialCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 5!
            // 5 * 4 * 3 *2 *1
            
            int number;
            String inputNumber = txtNumber.Text;
            if(!Int32.TryParse(inputNumber,out number))
            {
                MessageBox.Show("Invalid numeric input", "Error!");
                return;
            }
            if (number <= 0)
            {
                MessageBox.Show("Input must be a positive integer", "Error!");
                return;
            }

            Decimal factorialValue = number; //5
            for(int x = number-1;x>=1;x--)
            {
                factorialValue *= x;
            }

            txtFactorial.Text = factorialValue.ToString();
        }
    }
}
