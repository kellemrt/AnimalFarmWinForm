using AnimalFarm.Data;
using AnimalFarm.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace AnimalFarm.Service
{
    public class VeccineService : animalService
    {
        private AnimalFarmDbContext dbContext = new AnimalFarmDbContext();
        public List<AnimalVeccineListModel> GetAnimalVeccineList()
        {
            List<AnimalVeccineListModel> returnList = new List<AnimalVeccineListModel>();
            returnList = dbContext.ANIMAL_VECCINE.AsNoTracking().Select(u => new AnimalVeccineListModel
            {
                ID = u.ID,
                AnimalCode = u.ANIMAL_LIST.ANIMAL_CODE,
                VeccineDate = u.VECCINE_DATE,
                VeccineKind = u.VECCINE_KIND,
            }).ToList();
            return returnList;
        }
        public Tuple<bool, string> InsertAnimalVeccineList(ANIMAL_VECCINE list)
        {
            dbContext.ANIMAL_VECCINE.Add(list);
            dbContext.SaveChanges();
            return new Tuple<bool, string>(true, "Aşı Kaydı Eklendi");
        }
        public bool DeleteAnimalVeccine(int id)
        {
            bool hasValue = dbContext.ANIMAL_VECCINE.Where(x => x.ID == id).Any();
            if (hasValue)
            {
                var list = dbContext.ANIMAL_VECCINE.Where(x => x.ID == id).FirstOrDefault();
                dbContext.ANIMAL_VECCINE.Remove(list);
                dbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
