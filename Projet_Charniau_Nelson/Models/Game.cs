using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class Game
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public float price { get; set; }


    }
}