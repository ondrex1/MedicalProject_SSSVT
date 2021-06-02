using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MedicalProject
{
    public class PatientRepository
    {
        private MyContext context = new MyContext();
        
        public List<Patient> FindAll()
        {
            return this.context.Patient.ToList();
        }


        public void insert (Patient patient)
        {
            this.context.Patient.Add(patient);
            this.context.SaveChanges();
        }
        public void delete(Patient patient)
        {

            this.context.Remove(patient);
            this.context.SaveChanges();
        }
        public void update(Patient patient)
        {
            Patient db = this.context.Patient.Find(patient.Id);
            db.Jmeno = patient.Jmeno;
            db.Prijmeni = patient.Prijmeni;
            db.DatumNarozeni = patient.DatumNarozeni;
            db.RodneCislo = patient.RodneCislo;
            db.AdresaBydliste = patient.AdresaBydliste;
            db.Pojistovna = patient.Pojistovna;

            this.context.SaveChanges();
        }
    }
}
 