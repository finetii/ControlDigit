using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalculateControlDigit
{
    public partial class MainForm : Form
    {        
        private bool _connectionEstablished = false;
        LibraCentralEntities db = null;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                db = new LibraCentralEntities();
                _connectionEstablished = true;
            }
            catch(Exception e)
            {
                MessageBox.Show("No Connection to the database!", "Error!");
            }
        }

        private void enterNumberTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!isValid(enterNumberTxtBox.Text))
            {
                enterNumberTxtBox.Text = "";
                resultLabel.Text = "";
            }
            else
            {
                Calculate();
                GetArticleFromDB(enterNumberTxtBox.Text);
            }
        }

        private void GetArticleFromDB(string text)
        {
            if (Int32.TryParse(text, out int intVal))
            {
                string article = "";
                string customer = "";
                try
                {
                    Article a = db.Articles.Find(intVal);
                    if(a == null)
                    {
                        article = "Няма артикул с този номер";
                    }
                    else
                    {
                        article += a.CyrName;
                    }
                }
                catch (Exception)
                {
                    article = "Няма артикул с този номер";
                }
                try
                {
                    Customer c = db.Customers.Find(intVal);
                    if (c == null)
                    {
                        customer = "Няма клиент с този номер";
                    }       
                    else
                    {
                        customer += c.Name;
                    }
                }
                catch (Exception)
                {
                    customer = "Няма клиент с този номер";
                }
                label2.Text = "Артикул: " + Environment.NewLine + article + Environment.NewLine + "Клиент:" + Environment.NewLine + customer;
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
            Calculate();
        }

        private void enterNumberTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                calculateBtn_Click(sender, e);
            }
        }

        private void Calculate()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (isValid(enterNumberTxtBox.Text))
            {
                Clipboard.SetText(resultLabel.Text);
                MessageBox.Show("Запаметено е в клипборда!", "Clipboard");
            }
            else
            {
                MessageBox.Show("Въведеното число не е валидно!", "Clipboard", icon: MessageBoxIcon.Warning, buttons: MessageBoxButtons.OK, defaultButton: MessageBoxDefaultButton.Button1);
            }
        }
    }
}
