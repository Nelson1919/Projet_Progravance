using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class Comfact
    {
        public int ID { get; set; }
        public int UserID { get; set; }

        public virtual User Buyer { get; set; }
        public DateTime DateCom { get; set; }

    }
}