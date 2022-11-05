using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalFarm.Data;
using AnimalFarm.Data.Model;

namespace AnimalFarm.Services
{
    public class ProductsService
    {
        private AnimalFarmDbContext dbContext = new AnimalFarmDbContext();
        public List<ProductsAndInventoryModel> GetProductsAndInventories()
        {
            List<ProductsAndInventoryModel> productsList = new List<ProductsAndInventoryModel>();
            productsList = dbContext.PRODUCTS.AsNoTracking().Select(u => new ProductsAndInventoryModel
            {
                productId = u.PRODUCTS_ID,
                productName = u.PRODUCTS_NAME,
                productUnit = u.PRODUCTS_UNIT,
                productInventory = u.PRODUCTS_QUANTITY
            }).ToList();
            return productsList;
        }
        public Tuple<bool, string> InsertProductAndInventories(PRODUCT product)
        {
            dbContext.PRODUCTS.Add(product);
            dbContext.SaveChanges();
            return new Tuple<bool, string>(true, "Kayıt Eklendi");
        }
        public Tuple<bool, string> DeleteProductAndInventories(int id)
        {
            bool hasvalue = dbContext.PRODUCTS.Any(u => u.PRODUCTS_ID == id);
            if (hasvalue)
            {
                var listProduct = from q in dbContext.PRODUCTS
                                 where q.PRODUCTS_ID == id
                                 select q;
                foreach (var item in listProduct)
                {
                    dbContext.PRODUCTS.Remove(item);
                }
                
                dbContext.SaveChanges();
                return new Tuple<bool, string>(true, "Kayıt silindi.");
            }
            else
            {
                return new Tuple<bool, string>(false, "Kayıt silinemedi.");
            }
        }
    }
}
