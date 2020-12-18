using Projet_Charniau_Nelson.DTO;
using Projet_Charniau_Nelson.Interface;
using Projet_Charniau_Nelson.Models;
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
           var logg =(from r in db.Users where r.Mail == email && r.Password == password select new LoginDTO { firstname = r.FirstName, name= r.Name, id_user = r.ID, admin = r.Admin}).FirstOrDefault();
            return logg;

        }
        public List<PanierDTO> InfoPanier(int id) {
            var info = (from p in db.Paniers
                        join g in db.Games
                        on p.GameID equals g.ID
                        where p.UserID==id
                        select new PanierDTO { GameID = p.GameID, Nom = g.Name, prix = g.price });
            return info.ToList();

        }
        public List<Panier> Listepanier(int id)
        {
            List<Panier> panier = db.Paniers.Where(p => p.UserID == id).ToList();
            return panier;
        }

        public void Supprimer(List<Panier> panier)
        {
            foreach (Panier p in panier)
            {
                db.Paniers.Remove(p);
            }
            db.SaveChanges();
        }
        public int CreaCom(int id) {
            Comfact com = new Comfact();
            com.UserID = id;
            com.DateCom = DateTime.Now;
            db.Comfacts.Add(com);
            db.SaveChanges();

            return com.ID;

        }
        public void EnvoyerversDetail(List<Panier> panier,int idcomfact)
        {
            foreach (Panier p in panier)
            {
                Detail det = new Detail();
                det.ComFactID = idcomfact;
                det.GameID = p.GameID;
                //Récuperer le prix
                db.details.Add(det);
                db.SaveChanges();
            }
           
        }
        public List<Comfact> InfoCom(int id)
        {
            var info = db.Comfacts.Where(c => c.UserID == id);
            return info.ToList();

        }

    }
}