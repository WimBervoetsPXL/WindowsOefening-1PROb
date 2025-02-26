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
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        UpdateWindow updateWindow;

        public StartWindow()
        {
            InitializeComponent();
        }

        private void OnPassword_Changed(object sender, RoutedEventArgs e)
        {
            if (updateWindow is not null)
            {
                updateWindow.PasswordToDisplay = passwordTextBox.Password;

                //Optie 3
                //Data.Password = passwordTextBox.Password;
                //updateWindow.UpdatePassword();

                //Optie 2 + 4:
                //updateWindow.DisplayPassword(passwordTextBox.Password);

            }
        }

        private void OnShowPassword_Clicked(object sender, RoutedEventArgs e)
        {
            if (updateWindow is null)
            {


                //Optie 1 : WriteOnly Property
                updateWindow = new UpdateWindow();
                updateWindow.PasswordToDisplay = passwordTextBox.Password;

                //Optie 2 : Methode met parameter
                //updateWindow = new UpdateWindow();
                //updateWindow.DisplayPassword(passwordTextBox.Password);

                //Optie 3 : Static Data class met methode
                //updateWindow = new UpdateWindow();
                //Data.Password = passwordTextBox.Password;
                //updateWindow.UpdatePassword();

                //Optie 4 : Constructor
                updateWindow = new UpdateWindow(passwordTextBox.Password);




                updateWindow.Show();
            }
        }
    }
}
