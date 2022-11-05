using System.Windows;
using Practics.DemoExam.Extensions;
using Practics.DemoExam.Services;

namespace Practics.DemoExam.Windows
{
    public partial class LoginWindow : Window
    {
        private readonly LoginService _loginService;
        
        public LoginWindow(LoginService loginService)
        {
            _loginService = loginService;
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            InitializeComponent();
        }

        private void TryLoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OpenWindow<ProductWindow>();
        }

        private void SignUpButton_OnClick(object sender, RoutedEventArgs e)
        {
            this.OpenWindow<SignUpWindow>(_loginService);
        }
        
    }
}