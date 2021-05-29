using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    class SearchingPatient
    {
        public static int Id { get; set; }
        public static string Jmeno { get; set; }
        public static string Prijmeni { get; set; }

        public static string DatumNarozeni { set; get; }
        public static string RodneCislo { get; set; }
        public static string AdresaBydliste { get; set; }
        public static string Pojistovna { get; set; }


        public SearchingPatient()
        {

        }
    }
}
