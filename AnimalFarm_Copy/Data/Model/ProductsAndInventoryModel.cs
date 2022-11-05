using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.Data.Model
{
    public class ProductsAndInventoryModel
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productUnit { get; set; }
        public int ?productInventory { get; set; }


    }
}
