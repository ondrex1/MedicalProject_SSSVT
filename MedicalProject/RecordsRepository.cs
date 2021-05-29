using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MedicalProject
{
    public class RecordsRepository
    {
        private MyContext context = new MyContext();

        public List<Records> FindAll()
        {
            return this.context.records.ToList();
        }
        public List<Records> FindByName()
        {
            PatientsWindow patientsWindow = new PatientsWindow();

            string data = "Ondra";
            string query = $"SELECT p.Id, p.DatumVzniku, p.OsetrujiciLekar, p.Stav, p.SubjektivniPopis, p.ObjektivniPopis, p.Medikace, p.DatumKontroly, p.IdKontrola, p.IdPacienta " +
                $"FROM tbProblem p inner join tbPacienti pac on p.IdPacienta = pac.Id WHERE pac.Jmeno = '{data}'";
            try
            {
                 data = patientsWindow.DataGridPatients.SelectedCells[0].Column.GetCellContent(patientsWindow.DataGridPatients.SelectedItem).ToString();

            }
            catch
            {

            }

            return this.context.records.FromSqlRaw(query).ToList();

        }

        public List<Records> Find()
        {
            return context.records.FromSqlRaw("Select * from tbProblem").Where(a => a.IdPacienta == 89).ToList();
             
        }



    }
}
