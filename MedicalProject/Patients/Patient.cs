using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    [Table("tbPacienti")]
    public  class Patient
    {
        //[Column("Id")]
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        
        public DateTime DatumNarozeni { set; get; }
        public string RodneCislo { get; set; }
        public string AdresaBydliste { get; set; }
        public string Pojistovna { get; set; }

        public static int GetID { get; set; }

    }
}
