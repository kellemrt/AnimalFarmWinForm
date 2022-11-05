using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Data.Model
{
    public class AnimalVeccineListModel
    {
        public int ID { get; set; }
        public string AnimalCode { get; set; }
        public DateTime VeccineDate { get; set; }
        public string VeccineKind { get; set; }
    }
}
