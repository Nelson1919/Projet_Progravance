﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace Projet_Charniau_Nelson.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public float price { get; set; }
        public Image image { get; set;}
        public Boolean isavailable { get; set; }


    }
}