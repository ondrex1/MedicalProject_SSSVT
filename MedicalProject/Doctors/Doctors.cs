using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    [Table("tbLekari")]
    public class Doctors
    {
        //[Column("Id")]
        public int Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Specializace { get; set; }
        public string PrihlasovaciJmeno { get; set; }
        public string PrihlasovaciHeslo { get; set; }


    }
}
