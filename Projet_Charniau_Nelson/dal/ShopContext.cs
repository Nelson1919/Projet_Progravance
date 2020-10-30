using Projet_Charniau_Nelson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Projet_Charniau_Nelson.dal
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("ShopContext")
        { 
        }
            public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }

        public DbSet<Panier> Paniers { get; set; }
        public DbSet<Comfact> Comfacts { get; set; }
        public DbSet<Detail> details { get; set; }
    }
    }
