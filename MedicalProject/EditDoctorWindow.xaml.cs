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
    /// Interakční logika pro EditDoctorWindow.xaml
    /// </summary>
    public partial class EditDoctorWindow : Window
    {
        public Doctors doctors { get; set; }
        public EditDoctorWindow(Doctors doctors)
        {
            InitializeComponent();
            this.DataContext = doctors;
            this.doctors = doctors;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
         
            if (IsValidUsername() == true)
            {
                if (IsValidPassword() == true)
                {
                    this.DialogResult = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Neplatný formát příhlašovacího hesla");
                }
                
            }
            else
            {
                MessageBox.Show("Neplatný formát příhlašovacího jména");
            }
            
        }

        public bool IsValidUsername()
        {
            //pouze písmena
            string valuetext = this.loginUsernameTextBox.Text;
            if (Regex.IsMatch(valuetext, @"^[a-zA-Z]+$"))
            {
                return true;
            }

            return false;
        }

        private bool IsValidPassword()
        {
            //Heslo musí být v rozsahu 8-15 a musí obsahovat číslo
            string valuePasswd = this.loginPasswdTextBox.Text;

            if (Regex.IsMatch(valuePasswd, @"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$"))
            {
                return true;
            }

            return false;

        }



        
    }
}
