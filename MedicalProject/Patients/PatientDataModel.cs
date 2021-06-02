using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    public class PatientDataModel
    {
        private PatientRepository repository = new PatientRepository();

        public ObservableCollection<Patient> Data { get; set; }
        
        public PatientDataModel()
        {
            this.Data = new ObservableCollection<Patient>(this.repository.FindAll());
        }
        public void Add(Patient patient)
        {
            this.Data.Add(patient);
            this.repository.insert(patient); 

        }
        public void delete(int index)
        {

            this.repository.delete(this.Data[index]);
            this.Data.RemoveAt(index);


        }
        public void update(Patient patient, int index)
        {
            this.Data[index] = patient;
            this.repository.update(patient);
        }

    }
}
