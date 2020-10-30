using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string  Mail { get; set; }
        public string Adress { get; set; }

        public Boolean Admin { get; set; }
        public virtual ICollection<Comfact> Comfacts { get; set; }
    }
}