// Derek Lo
// CSC470
// Lab05 - Security Panel

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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        DateTime now;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "9";
        }

        private void ButtonC_Click(object sender, RoutedEventArgs e)
        {
            Password.Password = "";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            Password.Password += "0";
        }

        /// <summary>
        /// When # is pressed, password is checked for validity.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PoundButton_Click(object sender, RoutedEventArgs e)
        {
            
            switch (Password.Password)
            {
                case "1645":
                case "1689":
                    now = DateTime.Now;
                    Log.Text += $"\n{now}>Access Granted. Welcome Technician.";
                    Password.Password = "";
                    break;

                case "8345":
                    now = DateTime.Now;
                    Log.Text += $"\n{now}>Access Granted. Welcome Custodian.";
                    Password.Password = "";
                    break;

                case "9998":
                case "1006":
                case "1007":
                case "1008":
                    now = DateTime.Now;
                    Log.Text += $"\n{now}>Access Granted. Welcome Scientist.";
                    Password.Password = "";
                    break;

                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "0":
                    now = DateTime.Now;
                    Log.Text += $"\n{now}>Calling security guard. Please stand by.";
                    Password.Password = "";
                    break;

                default:
                    now = DateTime.Now;
                    Log.Text += $"\n{now}>Access Denied.";
                    Password.Password = "";
                    break;
            }
        }
    }
}
