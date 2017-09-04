using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculateControlDigit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void enterNumberTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!isValid(enterNumberTxtBox.Text))
            {
                enterNumberTxtBox.Text = "";
            }
        }

        bool isValid(string input)
        {
            try
            {
                int.Parse(input);
            }
            catch
            {
                if (input != "" && input != null)
                    resultLabel.Text = "Въведете валиден номер!!!";
                return false;
            }
            return true;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            int.TryParse(enterNumberTxtBox.Text, out int number);
            int result = (7 * ((number / 1) % 10) + 6 * ((number / 10) % 10) 
                + 5 * ((number / 100) % 10) + 4 * ((number / 1000) % 10) 
                + 3 * ((number / 10000) % 10) + 2 * ((number / 100000) % 10));
            if ((result % 11) == 10)
                number = number * 10 + 0;
            else
                number = number * 10 + (result % 11);
            resultLabel.Text = number.ToString();
        }

        private void enterNumberTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                calculateBtn_Click(sender, e);
            }
        }
    }
}
