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
    /// Interakční logika pro PatientsWindow.xaml
    /// </summary>
    public partial class PatientsWindow : Window
    {
        private PatientDataModel model = new PatientDataModel();



        public PatientsWindow()
        {
            InitializeComponent();
            this.DataGridPatients.ItemsSource = this.model.Data;
        }

        private void AddPatientBtn_Click(object sender, RoutedEventArgs e)
        {
            EditPatientWindow editPatientWindow = new EditPatientWindow(new Patient());
            if (editPatientWindow.ShowDialog() == true)
            {
                this.model.Add(editPatientWindow.patient);
            }

        }

        private void EditPatientBtn_Click(object sender, RoutedEventArgs e)
        {
            if (this.DataGridPatients.SelectedIndex < 0)
                return;

            Patient patient = this.model.Data[this.DataGridPatients.SelectedIndex];

            EditPatientWindow editPatientWindow = new EditPatientWindow(patient);

            if (editPatientWindow.ShowDialog() == true)
            {
                this.model.update(editPatientWindow.patient, this.DataGridPatients.SelectedIndex);
                this.DataGridPatients.Items.Refresh();

            }
        }

        private void DeletePatientBtn_Click(object sender, RoutedEventArgs e)
        {
            this.model.delete(this.DataGridPatients.SelectedIndex);
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }




        private void ShowPatientCard_Click(object sender, RoutedEventArgs e)
        {
            new SearchingPatient();
            RecordsWindow records = new RecordsWindow();

            records.RecordName.Text = SearchingPatient.Jmeno;
            records.RecordSurname.Text = SearchingPatient.Prijmeni;
            records.RecordDate.Text = SearchingPatient.DatumNarozeni;
            records.RecordStreet.Text = SearchingPatient.AdresaBydliste;
            records.RecordNumber.Text = SearchingPatient.RodneCislo;
            records.RecordInsurance.Text = SearchingPatient.Pojistovna;


            records.Show();
            this.Close();

        }

        private void backBtn_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void DataGridPatients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var data = this.DataGridPatients.SelectedItem;
                SearchingPatient.Jmeno = (this.DataGridPatients.SelectedCells[0].Column.GetCellContent(data) as TextBlock)?.Text;
                SearchingPatient.Prijmeni = (this.DataGridPatients.SelectedCells[1].Column.GetCellContent(data) as TextBlock)?.Text;
                SearchingPatient.DatumNarozeni = (this.DataGridPatients.SelectedCells[2].Column.GetCellContent(data) as TextBlock)?.Text;
                SearchingPatient.AdresaBydliste = (this.DataGridPatients.SelectedCells[3].Column.GetCellContent(data) as TextBlock)?.Text;
                SearchingPatient.RodneCislo = (this.DataGridPatients.SelectedCells[4].Column.GetCellContent(data) as TextBlock)?.Text;
                SearchingPatient.Pojistovna = (this.DataGridPatients.SelectedCells[5].Column.GetCellContent(data) as TextBlock)?.Text;
                UpdateLayout();
            }
            catch
            {

            }
        }
    }
}
