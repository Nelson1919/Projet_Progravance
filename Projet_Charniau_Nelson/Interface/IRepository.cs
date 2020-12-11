using Projet_Charniau_Nelson.DTO;
using Projet_Charniau_Nelson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Interface
{
    public interface IRepository
    {
        LoginDTO Authentifier(string email, string password);
        List<PanierDTO> InfoPanier(int id);
         List<Panier> Listepanier(int id);
        void Supprimer(List<Panier> panier);
        int CreaCom(int id);
        void EnvoyerversDetail(List<Panier> panier, int idcomfact);
    }
}