using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    public class MyContext : DbContext
    {
        public DbSet<Patient> Patient { get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Records> records { get; set; }
               

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=mysqlstudenti.litv.sssvt.cz;database=3c2_husakondrej_db1;user=husakondrej;password=123456");
        }

    }

}
