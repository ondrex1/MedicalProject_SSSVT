using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    [Table("tbProblem")]
    public class Records
    {
        //[Column("Id")]
        public int Id { get; set; }
        public string DatumVzniku { get; set; }
        public int OsetrujiciLekar { get; set; }

        public string Stav { set; get; }
        public string SubjektivniPopis { get; set; }
        public string ObjektivniPopis { get; set; }
        public string Medikace { get; set; }

        public DateTime DatumKontroly { get; set; }
        public int IdKontrola { get; set; }
        public int IdPacienta { get; set; }

    }
}
