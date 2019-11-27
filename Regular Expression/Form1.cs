using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Regular_Expression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidName(textName.Text))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)");
            }
            if (!ValidPhone(textPhone.Text))
            {
                MessageBox.Show("The phone number is not a valid US phone number");

                }
            if (!ValidMail(textMail.Text))
            {
                MessageBox.Show("The e-mail address is not valid.");

            }
            else
            {
                MessageBox.Show("Mail is OK");
            }

            textPhone.Text = ReformatPhone(textPhone.Text);

        }

        public bool ValidName (String nameText)
        {
            string name = "[a-zA-Z]+";
            string whitespace = @"\s";
            string pattern = "^(" + name + whitespace +"*)+$";
            
            if(Regex.IsMatch(nameText, pattern))
            {
                return true;
            }
            return false;
        }

        public bool ValidPhone(string textPhone)
        {
            //@"^(((\d{3})?)|(\d{3}-))?\d{3}-\d{4}$"
            string number = @"\d{3}";
            string number2 = @"\d{4}";
            string pattern = "^(((" + number +")?)|" +"("+ number +"-))?" + number+ "-" +number2+ "$";

            if (Regex.IsMatch(textPhone, pattern))
            {
                return true;
            }
            return false;
        }

        public bool ValidMail(String email)
        {
            string first = @"[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]";
            string second = @"[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9]";
            string pattern = "^" + first + "+@" + second + "):?)*$";
            if(Regex.IsMatch(email, pattern))
            {
                return true;
            }
            return false;
        }

        static string ReformatPhone(string s)
        {
            Match m = Regex.Match(s, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");
            return String.Format("({0}) {1}-{2}", m.Groups[1], m.Groups[2], m.Groups[3]);
           

        }
    }
}
