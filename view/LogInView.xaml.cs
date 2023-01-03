using System.Windows;
using System.Windows.Controls;
using OOP_lab3.model.Static;


namespace OOP_lab3.view
{
    public partial class LogInView : UserControl
    {
        private LogIN logIn = null;
        public LogInView()
        {
            InitializeComponent();
            logIn = model.Static.LogIN.Initializate();
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            if (!CheckRegister()) return;
            logIn.NewAccount(Register_login.Text, Register_nickname.Text, Register_password.Text);
            LogIN_INFO_label.Content = "Done!";
        }

        private bool CheckLogIN()
        {
            if (LogIN_Name.Text == ""  && LogIN_Password.Text == "")
            {
                LogIN_INFO_label.Content = "Need to fill the boxes";
                return false;
            }
            return true;
        }

        private void LogIN(object sender, RoutedEventArgs e)
        {
            if (!CheckLogIN()) return;
            if(!logIn.authLogIN(LogIN_Name.Text,LogIN_Password.Text))
            {
                LogIN_INFO_label.Content = "Incorrect data";
                return;
            }
            LogIN_INFO_label.Content = "Done!";
        }
        
        private bool CheckRegister()
        {
            if (Register_login.Text == "" && Register_password.Text == "" && Register_nickname.Text == "")
            {
                Register_INFO_label.Content = "Need to fill the boxes";
                return false;
            }
            return true;
        }
    }
}