﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.DTO
{
    public class LoginDTO
    {
        public int id_user{ get; set; }
        public string name { get; set; }
        public string firstname { get; set; }
        public Boolean admin { get; set; }
    }
}