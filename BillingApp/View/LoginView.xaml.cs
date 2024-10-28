using System;
using System.Windows;

namespace BillingApp.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();

        }

        // credentials
        private string passwordInput;
        private string userNameInput;
        private string password = "password65456";
        private string username = "admin12321";
        
        // login event handler
        private void OnSubmit(object sender, RoutedEventArgs e)
        {
            // take user input from form fields
            passwordInput = pwdBox.Password;
            userNameInput = usernameTb.Text;

            // if login credentials are valid, hide login panel and open input form
            if (String.Equals(passwordInput, password) && String.Equals(userNameInput, username))
            {
                var AppWindow = new WindowApp();
                AppWindow.Show();
                AppWindow.Closed += (s, args) => Show();  //  s refers to the sender of the event, the instance of addWindow

                Hide();  // Hide
            }
        }

        // close button for login panel
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
