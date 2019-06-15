using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace InputValidation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_CanExecuteSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_ExecutedSave(object sender, ExecutedRoutedEventArgs e)
        {
            if (!ValidName(txtName.Text))
            {
                MessageBox.Show("Invalid Name");
            }
            else if (!ValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Invalid Phone");

            }
            else if (!ValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid Email");

            }
        }

        private bool ValidEmail(string email)

        {
            return Regex.IsMatch(email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        }

        private bool ValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^\d{11}$");
        }

        private bool ValidName(string name)
        {
            return Regex.IsMatch(name, @"^([A-Za-z]+\s*)+$");
        }
    }
}
