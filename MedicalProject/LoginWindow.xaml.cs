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
using System.Windows.Shapes;

namespace MedicalProject
{
    /// <summary>
    /// Interakční logika pro LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }


        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {

            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
            //if (username != null)
            //{
            //    MessageBox.Show("");

            //}
            //else if (this.usernameTextBox.Text == username.PrihlasovaciJmeno && this.passwordTextBox.Password == passwd.PrihlasovaciHeslo)
            //{
            //    MessageBox.Show("");
            //}
            //else
            //{
            //    MessageBox.Show("incorrect");
            ////}


            //if (IsValidUsername() == true)
            //{
            //    if (IsValidPassword() == true)
            //    {
            //        MainWindow main = new MainWindow();
            //        main.Show();
            //        this.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("neplatné heslo");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("neplatné jméno");
            //}




        }
        private bool IsValidUsername()
        {
            //MyContext context = new MyContext();

            ////pouze písmena
            //string valuetext = this.usernameTextBox.Text;
            //var username = context.Doctors.Where(i => i.PrihlasovaciJmeno == this.usernameTextBox.Text).FirstOrDefault();
            //var passwd = context.Doctors.Where(i => i.PrihlasovaciHeslo == this.passwordTextBox.Password).FirstOrDefault();

            //if (Regex.IsMatch(valuetext, @"^[a-zA-Z]+$"))
            //{
            //    if (username != null)
            //    {
            //        return true;
            //    }
            //}

            return false;
        }

        private bool IsValidPassword()
        {
            //MyContext context = new MyContext();
            ////Heslo musí být v rozsahu 8-15 a musí obsahovat číslo
            //string valuePasswd = this.passwordTextBox.Password;
            //var passwd = context.Doctors.Where(i => i.PrihlasovaciHeslo == this.passwordTextBox.Password).FirstOrDefault();
            //if (Regex.IsMatch(valuePasswd, @"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$"))
            //{
            //    if (passwd != null)
            //    {
            //        return true;
            //    }
            //}

            return false;

        }



        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
