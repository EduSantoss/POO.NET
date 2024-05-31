using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_NET.Models
{    
    // basicamente todas as classes já herdam da Object, por isso é redudante fazer isso abaixo.
    public class Computador : Object
    {
        public override string ToString()
        {
            return "Método ToString() sobrescrito";
        }
    }
}