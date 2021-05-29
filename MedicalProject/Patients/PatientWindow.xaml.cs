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

namespace MedicalProject
{
    /// <summary>
    /// Interakční logika pro PatientWindow.xaml
    /// </summary>
    public partial class PatientWindow : Window
    {
        private PatientDataModel model = new PatientDataModel();
        public PatientWindow()
        {
            InitializeComponent();

            this.DataGridPatient.ItemsSource = this.model.Data;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void AddPatientBtn_Click(object sender, RoutedEventArgs e)
        {
            EditPatientWindow editPatientWindow = new EditPatientWindow();
            editPatientWindow.Show();
        }

        private void DeletePatientBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DataGridPatient.Items.RemoveAt(this.DataGridPatient.SelectedIndex);
        }

        private void EditPatientBtn_Click(object sender, RoutedEventArgs e)
        {
            EditPatientWindow editPatientWindow = new EditPatientWindow();
            editPatientWindow.Show();
        }
    }
}
