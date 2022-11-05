using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity.Migrations;
using AnimalFarm.Data;
using AnimalFarm.Data.Model;
using System.Data.Entity;

namespace AnimalFarm.Service
{
    public class animalService
    {
        private AnimalFarmDbContext dbContext = new AnimalFarmDbContext();
        public int GetLastAnimalID()
        {
            int id = dbContext.ANIMAL_LIST.AsNoTracking().OrderByDescending(x => x.ANIMAL_ID).FirstOrDefault().ANIMAL_ID;
            return id;
        }
        private string CalculateAnimalWeightProductivity(int id) /* besi verimlilik hesaplama metodu.*/
        {
            var listOfAnimalWeight = dbContext.ANIMAL_WEIGHT_BEHAVE.AsNoTracking().Where(u => u.ANIMAL_ID == id).ToList();
            if (!listOfAnimalWeight.Any())
                return "Ağırlık kaydı bulunamadı.";
            if (listOfAnimalWeight.Count() < 2)
                return " Verim hesaplanamadı.";
            var lastRecord = listOfAnimalWeight.OrderByDescending(u => u.ANIMAL_WEIGHT_DATE).FirstOrDefault();
            var secondRecord = listOfAnimalWeight.OrderByDescending(u => u.ANIMAL_WEIGHT_DATE).Skip(1).Take(1).FirstOrDefault();
            decimal item1 = lastRecord.ANIMAL_WEIGHT;
            decimal item2 = secondRecord.ANIMAL_WEIGHT;
            DateTime date1 = lastRecord.ANIMAL_WEIGHT_DATE;
            DateTime date2 = secondRecord.ANIMAL_WEIGHT_DATE;
            TimeSpan ts = date1 - date2;
            decimal dt = Convert.ToDecimal(ts.Days.ToString()); ;
            if (dt > 0)
            {
                decimal x = (item1 - item2) * 1000 / dt;
                int c = Convert.ToInt32(x * 100 / 800);
                decimal y = x / 1000;
                if (x >= 800)
                {
                    string result = c.ToString() + " Verimli.Günlük Kilo Artışı:" + y.ToString();
                    return result;
                }
                else
                {
                    string resulfalse = c.ToString() + " Verimsiz! Kaybedilen Kilo:" + (item2 - item1).ToString();
                    return resulfalse;
                }
            }
            else
            {
                return " Verim Bulunamadı!";
            }
        }
        public Tuple<bool, int> GetAnimalID(string code)
        {
            if (dbContext.ANIMAL_LIST.Any(u => u.ANIMAL_CODE == code))
            {
                int id = dbContext.ANIMAL_LIST.AsNoTracking().FirstOrDefault(x => x.ANIMAL_CODE == code).ANIMAL_ID;
                return new Tuple<bool, int>(true, id);
            }
            else
            {
                return new Tuple<bool, int>(false, 0);
            }
        }
        public Tuple<bool, int> InsertAnimalList(ANIMAL_LIST list)
        {
            dbContext.ANIMAL_LIST.Add(list);
            dbContext.SaveChanges();
            int id = list.ANIMAL_ID;
            return new Tuple<bool, int>(true, id);
        }
        public Tuple<bool, string> InsertAnimalBehave(ANIMAL_WEIGHT_BEHAVE behave)
        {
            if (behave.ANIMAL_ID == 0)
            {
                return new Tuple<bool, string>(false, "Hayvan Küpe numarası boş olamaz.");
            }
            dbContext.ANIMAL_WEIGHT_BEHAVE.Add(behave);
            dbContext.SaveChanges();
            return new Tuple<bool, string>(true, "Kayıt başarılı.");
        }
        public bool UpdateAnimalList(ANIMAL_LIST list)
        {
            if (string.IsNullOrEmpty(list.ANIMAL_CODE))
            {
                return false;
            }
            dbContext.ANIMAL_LIST.AddOrUpdate(list);
            dbContext.SaveChanges();
            return true;
        }
        public bool DeleteAnimalList(int id)
        {
            var delete = dbContext.ANIMAL_LIST.Find(id);
            dbContext.ANIMAL_LIST.Remove(delete);
            return true;
        }
        public Tuple<bool, string> DeleteAnimalBehave(int id)
        {
            bool hasvalue = dbContext.ANIMAL_WEIGHT_BEHAVE.Any(u => u.ANIMAL_ID == id);
            if (hasvalue)
            {
                var listBehave = from q in dbContext.ANIMAL_WEIGHT_BEHAVE
                                 where q.ANIMAL_ID == id
                                 select q;
                foreach (var item in listBehave)
                {
                    dbContext.ANIMAL_WEIGHT_BEHAVE.Remove(item);
                }
                if (dbContext.ANIMAL_VECCINE.Any(x => x.VECCINE_ANIMAL_ID == id))
                {
                    var list = from q in dbContext.ANIMAL_VECCINE
                               where q.VECCINE_ANIMAL_ID == id
                               select q;
                    foreach (var item in list)
                    {
                        dbContext.ANIMAL_VECCINE.Remove(item);
                    }
                }
                dbContext.SaveChanges();
                return new Tuple<bool, string>(true, "Kayıt silindi.");
            }
            else
            {
                return new Tuple<bool, string>(false, "Kayıt silindi.");
            }
        }
        public List<AnimalListModel> GetAnimalList()
        {
            List<AnimalListModel> returnList = new List<AnimalListModel>();
            returnList = dbContext.ANIMAL_LIST.AsNoTracking().Select(u => new AnimalListModel
            {
                AnimalCode = u.ANIMAL_CODE,
                AnimalId = u.ANIMAL_ID,
                AnimalKind = u.ANIMAL_KIND,
                AnimalNote = u.ANIMAL_NOTE,
                AnimalSaveDate = u.ANIMAL_SAVEDATE
            }).ToList();
            return returnList;
        }
        public List<AnimalWeightModel> GetAnimalWeightWhere(int? animalId)
        {
            var returnList = dbContext.ANIMAL_WEIGHT_BEHAVE.AsNoTracking()
                .Where(u => (!animalId.HasValue || u.ANIMAL_ID == animalId))
                .Select(u => new AnimalWeightModel
                {
                    AnimalId = u.ANIMAL_ID,
                    AnimalCode = u.ANIMAL_LIST.ANIMAL_CODE,
                    AnimalWeight = u.ANIMAL_WEIGHT,
                    AnimalWeightDate = u.ANIMAL_WEIGHT_DATE
                })
                .OrderBy(u => u.AnimalWeightDate).ToList();
            return returnList;
        }
        public List<AnimalProductivityModel> GetAnimalProductivities()
        {
            List<AnimalProductivityModel> returnList = new List<AnimalProductivityModel>();
            returnList = dbContext.ANIMAL_LIST.AsNoTracking().AsEnumerable().Select(u => new AnimalProductivityModel
            {
                AnimalID = u.ANIMAL_ID,
                AnimalCode = u.ANIMAL_CODE,
                AnimalProductivity = "%" + CalculateAnimalWeightProductivity(u.ANIMAL_ID).ToString()
            }).ToList();
            return returnList;
        }
    }
}