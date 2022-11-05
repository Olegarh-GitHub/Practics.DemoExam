using System.Windows;
using Practics.DemoExam.Models;
using Practics.DemoExam.Services;

namespace Practics.DemoExam.Windows
{
    public partial class SignUpWindow : Window
    {
        private readonly LoginService _loginService;
        
        public SignUpWindow(LoginService loginService)
        {
            _loginService = loginService;
            
            InitializeComponent();
        }

        private User InitializeUserFromInputs()
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Password;

            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            string middleName = MiddleNameTextBox.Text;

            return new User();
        }
    }
}