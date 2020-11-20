using Projet_Charniau_Nelson.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projet_Charniau_Nelson.Interface
{
    public interface IRepository
    {
        LoginDTO Authentifier(string email, string password);
        
    }
}