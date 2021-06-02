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
        public List<Records> FindById(int patientId)
        {
            string query = "SELECT p.Id, p.DatumVzniku, p.OsetrujiciLekar, p.Stav, p.SubjektivniPopis, p.ObjektivniPopis, p.Medikace, p.DatumKontroly, p.IdKontrola, p.IdPacienta " +
                $"FROM tbProblem p inner join tbPacienti pac on p.IdPacienta = pac.Id WHERE pac.Id = {patientId}";
            return this.context.records.FromSqlRaw(query, patientId).ToList();
        }


        public void insert(Records records)
        {
            this.context.records.Add(records);
            this.context.SaveChanges();
        }
        public void Delete(Records records)
        {
            this.context.Remove(records);
            this.context.SaveChanges();
        }
        public void Edit(Records records)
        {            
              Records db = this.context.records.Find(records.IdPacienta);
            
              db.DatumKontroly = records.DatumKontroly;
              db.DatumVzniku = records.DatumVzniku;
              db.IdKontrola = records.IdKontrola;
              db.IdPacienta = records.IdKontrola;
              db.Medikace = records.Medikace;
              db.ObjektivniPopis = records.Medikace;
              db.OsetrujiciLekar = records.OsetrujiciLekar;
              db.Stav = records.Stav;
              db.SubjektivniPopis = records.SubjektivniPopis;
              db.Id = records.Id;
        }


    }
}
