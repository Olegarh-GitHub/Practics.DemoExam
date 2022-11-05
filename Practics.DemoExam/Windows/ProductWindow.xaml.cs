using System;
using System.Windows;

namespace Practics.DemoExam.Windows
{
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Closed += ClosedEventHandler;
            
            InitializeComponent();
        }

        private void ClosedEventHandler(object sender, EventArgs args)
        {
            Application.Current.Shutdown();
        }
    }
}