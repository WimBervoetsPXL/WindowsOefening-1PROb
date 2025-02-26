using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WindowsOefening
{
    /// <summary>
    /// Interaction logic for UpdateWindow.xaml
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }

        public UpdateWindow(string password) : this()
        {
            passwordLabel.Content = password;
        }

        //Optie 1
        public string PasswordToDisplay
        {
            set
            {
                passwordLabel.Content = value;
            }
        }

        //Optie 2
        //public void DisplayPassword(string password)
        //{
        //    passwordLabel.Content = password;
        //}

        //Optie 3
        //public void UpdatePassword()
        //{
        //    passwordLabel.Content = Data.Password;
        //}
    }

}
