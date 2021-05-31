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
    /// Interakční logika pro RecordsWindow.xaml
    /// </summary>
    public partial class RecordsWindow : Window
    {
        private RecordsDataModel recordsModel = new RecordsDataModel();
        public RecordsWindow()
        {
            InitializeComponent();

            this.RecordsDataGrid.ItemsSource = recordsModel.Data;
            
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            PatientsWindow patientsWindow = new PatientsWindow();
            patientsWindow.Show();
            this.Close();
        }
        //přidat záznam
        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {
            AddRecordsWindow addRecordsWindow = new AddRecordsWindow(new Records());

            if (addRecordsWindow.ShowDialog() == true)
            {
                this.recordsModel.Add(addRecordsWindow.records);

            }
        }
        //odstranit záznam
        private void removeRecord_Click(object sender, RoutedEventArgs e)
        {
            this.recordsModel.Remove(this.RecordsDataGrid.SelectedIndex);

        }
        //upravit záznam
        private void editRecord_Click(object sender, RoutedEventArgs e)
        {

            if (this.RecordsDataGrid.SelectedIndex<0)
            {
                return;
            }

            Records records = this.recordsModel.Data[this.RecordsDataGrid.SelectedIndex];

            AddRecordsWindow addRecordsWindow = new AddRecordsWindow(records);

            if (addRecordsWindow.ShowDialog() == true)
            {
                this.recordsModel.Edit(addRecordsWindow.records, this.RecordsDataGrid.SelectedIndex);
                this.RecordsDataGrid.Items.Refresh();
            }

        }
    }
}
