using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        soapServiceRef.Service1Client proxy = new soapServiceRef.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            //Regex for age input such that it can only conatins Numerical values
            Regex regex = new Regex("^[0-9]+$");

            //Empty String check for the inputs
            if (string.IsNullOrWhiteSpace(firstNameText.Text) && string.IsNullOrWhiteSpace(lastNameText.Text) && string.IsNullOrWhiteSpace(ageTextBox.Text))
            {
                ErrorLabel.Text = "Please Enter the values";
                return;
            }

            //Length of String should be minimum 2

            else if ((firstNameText.Text.Length < 2))
            {
                ErrorLabel.Text = "First Name should have atleast 2 characters";
                return;
            }
            else if ((lastNameText.Text.Length < 2))
            {
                ErrorLabel.Text = "Last Name should have atleast 2 characters";
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
                try
                {
                    //Calling the API methods of the service

                    string pass = proxy.password(firstNameText.Text, lastNameText.Text, Int32.Parse(ageTextBox.Text));
                    int user = proxy.loginId(Int32.Parse(ageTextBox.Text));

                    //If there is an Integer Overflow after calculating user ID then prompt the user to Enter Integer Value 
                    if (user < 0)
                    {
                        ErrorLabel.Text = "Please Enter a Integer value for age in range (0 to 10737417)";
                        return;
                    }
                    else
                    {
                        ErrorLabel.Visible = false;

                        userLabel.Text = user.ToString();
                        passLabel.Text = pass;

                        button1.Enabled = false;
                    }
                }
                catch
                {
                    ErrorLabel.Text = "Please Enter Valid Inputs";
                    return;
                }
            }
        }
    }
}