using Projet_Charniau_Nelson.DTO;
using Projet_Charniau_Nelson.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.dal
{
    public class Repository : IRepository
    {
        private ShopContext db = new ShopContext();

        public LoginDTO Authentifier(string email, string password)
        {
           var logg =(from r in db.Users where r.Mail == email && r.Password == password select new LoginDTO { firstname = r.FirstName, name= r.Name, id_user = r.ID}).FirstOrDefault();
            return logg;

        }
    }
}