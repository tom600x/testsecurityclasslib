using System.Text.RegularExpressions;

namespace testsecurityclasslib
{
    public class Class1
    {
        public string UpdateCustomerPassword(string txtUsername, string txtPassword)
        {
            string userName = txtUsername;
            string password = txtPassword;

            Regex testPassword = new Regex(userName);
            Match match = testPassword.Match(password);
            if (match.Success)
            {
                return "Do not include name in password.";
            }
            else
            {
                return "Good password.";
            }
        }
    }
}
