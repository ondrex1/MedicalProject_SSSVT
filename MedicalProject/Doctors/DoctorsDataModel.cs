using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    public class DoctorsDataModel
    {
        private DoctorsRepository repositoryDoc = new DoctorsRepository();

        public ObservableCollection<Doctors> DataDoc { get; set; }

        public DoctorsDataModel()
        {
            this.DataDoc = new ObservableCollection<Doctors>(this.repositoryDoc.FindAll());
        }


        public void Add(Doctors doctors)
        {
            this.DataDoc.Add(doctors);
            this.repositoryDoc.insert(doctors);

        }

        public void delete(int index)
        {
            this.repositoryDoc.delete(this.DataDoc[index]);
            this.DataDoc.RemoveAt(index);
        }
        public void update(Doctors doctors, int index)
        {
            this.DataDoc[index] = doctors;
            this.repositoryDoc.update(doctors);
        }
    }
}
