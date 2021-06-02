using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MedicalProject
{
    public class RecordsDataModel
    {
        private RecordsRepository recordsRepository = new RecordsRepository();

        public ObservableCollection<Records> Data { get; set;}

        public RecordsDataModel()
        {
            PatientsWindow patientsWindow = new PatientsWindow();


            this.Data = new ObservableCollection<Records>(this.recordsRepository.FindById(Patient.GetID));
        }

        public void Add(Records records)
        {
            this.Data.Add(records);
            this.recordsRepository.insert(records);
        }

        public void Remove(int index)
        {
            this.recordsRepository.Delete(this.Data[index]);
            this.Data.RemoveAt(index);
        }
        public void Edit(Records records, int index)
        {
            this.Data[index] = records;
            this.recordsRepository.Edit(records);
        }

    }
}
