using Projet_Charniau_Nelson.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.dal
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        private const string Filename = "C:\\Users\\user\\Documents\\Progra_Avance\\Projet_Charniau_Nelson\\Projet_Charniau_Nelson\\Images";

        protected override void Seed(ShopContext context)
        {
            var users = new List<User>
            {
            new User{Name="Carson",FirstName="Alexander",Password="123",Mail="Carson.Alexander@gmail.com",Admin=false,Adress="Rue des coquelicots"},
            new User{Name="Durant",FirstName="Phillipe",Password="123",Mail="Durand.Philipe@gmail.com",Admin=false,Adress="Rue des cocotiers"},
            new User{Name="Pairet",FirstName="Paul",Password="123",Mail="Pairet.Paul@gmail.com",Admin=false,Adress="Rue des coquelicots"},

            };
            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();
            var games = new List<Game>
            {
            new Game{Name="Pacman",price=25,image= Image.FromFile(Filename+"\\pacman.jpg") },
            new Game{Name="Pokémon",price=30,image= Image.FromFile(Filename+"\\pokemon.jpg") },
            };
            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();
            var comfacts = new List<Comfact>
            {
                new Comfact{UserID=1,DateCom=DateTime.Now},
            };
            comfacts.ForEach(s => context.Comfacts.Add(s));
            context.SaveChanges();
            var details = new List<Detail>
            {
                new Detail{ComFactID=1,},
            };


        }

    }
}