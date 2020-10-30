using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class Panier
    {
        public int UserID { get; set; }
        public virtual User Buyer { get; set; }
        public virtual ICollection<Game> Games { get; set; }
    }
}