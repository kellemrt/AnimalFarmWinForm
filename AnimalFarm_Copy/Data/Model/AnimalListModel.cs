using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Data.Model
{
    public class AnimalListModel
    {
        public int AnimalId { get; set; }
        public string AnimalCode { get; set; }
        public string AnimalKind { get; set; }
        public string AnimalNote { get; set; }
        public DateTime? AnimalSaveDate { get; set; }
    }
}
