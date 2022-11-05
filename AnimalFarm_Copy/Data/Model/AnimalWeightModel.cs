using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Data.Model
{
    public class AnimalWeightModel
    {
        public int Id { get; set; }
        public int AnimalId { get; set; }
        public string AnimalCode { get; set; }    
        public decimal AnimalWeight { get; set; }
        public DateTime? AnimalWeightDate { get; set; }

    }
}
