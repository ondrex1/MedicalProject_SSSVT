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
    /// Interakční logika pro AddRecordsWindow.xaml
    /// </summary>
    public partial class AddRecordsWindow : Window
    {
        public Records records {get;set;}

        public AddRecordsWindow(Records records)
        {
            InitializeComponent();
            this.records = records;
            this.DataContext = records;
        }

        private void OkBtn_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
