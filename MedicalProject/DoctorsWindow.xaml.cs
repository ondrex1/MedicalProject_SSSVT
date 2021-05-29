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
    /// Interakční logika pro DoctorsWindow.xaml
    /// </summary>
    public partial class DoctorsWindow : Window
    {
        private DoctorsDataModel modelDoc = new DoctorsDataModel();
        public DoctorsWindow()
        {
            InitializeComponent();
            this.DataGridDoctors.ItemsSource = this.modelDoc.DataDoc;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void AddDoctorBtn_Click(object sender, RoutedEventArgs e)
        {
            EditDoctorWindow editDoctorWindow = new EditDoctorWindow(new Doctors());
            if (editDoctorWindow.ShowDialog() == true)
            {

                this.modelDoc.Add(editDoctorWindow.doctors);
            }
        }

        private void DeleteDoctorBtn_Click(object sender, RoutedEventArgs e)
        {
            this.modelDoc.delete(this.DataGridDoctors.SelectedIndex);
        }
    }
}
