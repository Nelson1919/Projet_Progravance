using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class Detail
    {
        public int ComFactID  { get; set; }
        public virtual Comfact comfact { get; set; }
        
        public virtual ICollection<Game> Games { get; set; }

        public float prix { get; set; }
    }
}