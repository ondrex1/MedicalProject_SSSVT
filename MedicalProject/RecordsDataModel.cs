using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalProject
{
    public class RecordsDataModel
    {
        private RecordsRepository recordsRepository = new RecordsRepository();

        public ObservableCollection<Records> Data { get; set; }

        public RecordsDataModel()
        {
            this.Data = new ObservableCollection<Records>(this.recordsRepository.FindByName());
        }

        public void Add(Records records)
        {
            this.Data.Add(records);
            this.recordsRepository.insert(records);

        }
    }
}
