using System;
using System.Windows;

namespace Practics.DemoExam.Extensions
{
    public static class ControlExtensions
    {
        public static void OpenWindow<TWindow>(this Window sender, params object[] args) where TWindow : Window
        {
            TWindow windowToOpen = (TWindow) Activator.CreateInstance(typeof(TWindow), args);
            
            windowToOpen.Show();
        }
    }
}