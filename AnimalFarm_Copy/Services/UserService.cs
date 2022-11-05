using AnimalFarm.Data;
using System;
using System.Linq;
using System.Data.Entity.Migrations;
using System.Collections.Generic;
using AnimalFarm.Data.Model;

namespace AnimalFarm.Service
{
    public class UserService
    {
        private AnimalFarmDbContext dbContext = new AnimalFarmDbContext();
        public List<UserListModel> GetUserList()
        {
            List<UserListModel> userListModels = new List<UserListModel>();
            userListModels = dbContext.USERS.AsNoTracking().Select(u => new UserListModel
            {
                Id = u.ID,
                UserName = u.USER_NAME,
                UserPassword = u.USER_PASSWORD,
            }).ToList();
            return userListModels;
        }
        public bool ValidateUser(string userName, string password)
        {
            if (dbContext.USERS.AsNoTracking().Any(u => u.USER_NAME.Equals(userName) && u.USER_PASSWORD.Equals(password)))
            {
                return true;
            }
            return false;
        }
        public Tuple<bool, string> InsertUser(USER user)
        {
            if (string.IsNullOrEmpty(user.USER_NAME))
            {
                return new Tuple<bool, string>(false, "User name boş olamaz.");
            }
            if (string.IsNullOrEmpty(user.USER_PASSWORD))
            {
                return new Tuple<bool, string>(false, "Şifre boş olamaz.");
            }
            if (user.USER_PASSWORD.Length < 6 || user.USER_PASSWORD.Length > 10)
            {
                return new Tuple<bool, string>(false, "Şifre en az 6 en fazla 10 karakter olabilir.");
            }
            if (dbContext.USERS.Any(u => u.USER_NAME == user.USER_NAME))
            {
                return new Tuple<bool, string>(false, "Bu kullanıcı adı ile kayıt mevcut!");
            }
            dbContext.USERS.Add(user);
            dbContext.SaveChanges();
            return new Tuple<bool, string>(true, "Kayıt başarılı.");
        }
        public Tuple<bool, string> UpdateUser(USER user)
        {
            bool updBool = dbContext.USERS.Any(x => x.ID.Equals(user.ID));
            if (updBool)
            {
                var updRow = dbContext.USERS.Where(x => x.ID.Equals(user.ID)).FirstOrDefault();
                updRow.ID = user.ID;
                updRow.USER_NAME = user.USER_NAME;
                updRow.USER_PASSWORD = user.USER_PASSWORD;
                updRow.USER_KIND = user.USER_KIND;
                dbContext.USERS.AddOrUpdate(updRow);
                dbContext.SaveChanges();
                return new Tuple<bool, string>(true, "Kayıt Güncellendi.");
            }
            else
            {
                return new Tuple<bool, string>(false, "Bu id ile eşleşen kullanıcı yok!");
            }
        }
        public Tuple<bool, string> DeleteUser(int id)
        {
            bool delBool = dbContext.USERS.Any(x => x.ID.Equals(id));
            if (delBool)
            {
                var delRow = dbContext.USERS.FirstOrDefault(x => x.ID.Equals(id));
                dbContext.USERS.Remove(delRow);
                dbContext.SaveChanges();
                return new Tuple<bool, string>(true, "Kayıt Silindi.");
            }
            else
            {
                return new Tuple<bool, string>(false, "Bu id ile kullanıcı yok!");
            }

        }
    }
}
