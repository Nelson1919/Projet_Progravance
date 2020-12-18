
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class Panier
    {
        [Key]
        public int ID
        {
            get; set;
        }
        public int UserID { get; set; }
        public virtual User Buyer { get; set; }
        public int GameID { get; set; }

        public virtual ICollection<Game> Games { get; set; }


    }
}