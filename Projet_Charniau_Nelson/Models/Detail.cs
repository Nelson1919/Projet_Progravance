using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class Detail
    {
        [Key]
        public int ID
        {
            get; set;
        }
        public int ComFactID  { get; set; }
        public virtual Comfact comfact { get; set; }
        public int GameID { get; set; }
        public virtual Game Game { get; set; }

        public float prix { get; set; }
    }
}