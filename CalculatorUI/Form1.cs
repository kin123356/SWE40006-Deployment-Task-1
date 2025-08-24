using System;
using System.Windows.Forms;
using ClassLibrary1; // Import the class library

namespace CalculatorUI
{
    public partial class Form1 : Form
    {
        private readonly Class1 calculator;

        public Form1()
        {
            InitializeComponent();
            calculator = new Class1();

            // Wire up the event handlers
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PerformCalculation("+");
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            PerformCalculation("-");
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            PerformCalculation("*");
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            PerformCalculation("/");
        }

        private void PerformCalculation(string operation)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);
                int result = calculator.Calculate(num1, num2, operation);
                resultLabel.Text = "Result: " + result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid integers.", "Input Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error");
            }
        }
    }
}
