using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    public class DoctorsRepository
    {

        private MyContext contextDoc = new MyContext();

        public List<Doctors> FindAll()
        {
            return this.contextDoc.Doctors.ToList();
        }

        public void insert(Doctors doctors)
        {
            this.contextDoc.Doctors.Add(doctors);
            this.contextDoc.SaveChanges();         
        }
        public void delete(Doctors doctors)
        {
            

            this.contextDoc.Remove(doctors);
            this.contextDoc.SaveChanges();
        }
        public void update(Doctors doctors)
        {
            Doctors db = this.contextDoc.Doctors.Find(doctors.Id);

            db.Jmeno = doctors.Jmeno;
            db.Prijmeni = doctors.Prijmeni;
            db.Specializace = doctors.Specializace;
            db.PrihlasovaciJmeno = doctors.PrihlasovaciJmeno;
            db.PrihlasovaciHeslo = doctors.PrihlasovaciHeslo;

            this.contextDoc.SaveChanges();

        }

    }
}
