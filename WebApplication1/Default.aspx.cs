using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        soapServiceRef.Service1Client proxy = new soapServiceRef.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            if (string.IsNullOrWhiteSpace(firstNameText.Text) && string.IsNullOrWhiteSpace(lastNameText.Text) && string.IsNullOrWhiteSpace(ageTextBox.Text))
            {
                ErrorLabel.Text = "Please Enter the values";
                return;
            }
            else if (string.IsNullOrWhiteSpace(firstNameText.Text))
            {
                ErrorLabel.Text = "Please Enter the First Name";
                return;
            }
            else if (string.IsNullOrWhiteSpace(lastNameText.Text))
            {
                ErrorLabel.Text = "Please Enter the Last Name";
                return;
            }
            else if (string.IsNullOrWhiteSpace(ageTextBox.Text))
            {
                ErrorLabel.Text = "Please Enter the Age";
                return;
            }

            else if (!regex.IsMatch(ageTextBox.Text))
            {
                ErrorLabel.Text = "Please Enter a Valid Age";
                return;
            }
            else
            {
                ErrorLabel.Visible = false;
                string pass = proxy.password(firstNameText.Text, lastNameText.Text, Int32.Parse(ageTextBox.Text));
                int user = proxy.loginId(Int32.Parse(ageTextBox.Text));

                userLabel.Text = user.ToString();
                passLabel.Text = pass;

                button1.Enabled = false;
            }
        }
     }
}