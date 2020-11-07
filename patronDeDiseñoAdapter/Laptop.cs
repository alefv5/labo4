using System;
using System.Collections.Generic;
using System.Text;

namespace patronDeDiseñoAdapter
{
    class Laptop : Computadora
    {
        public override string encender()
        {
            return ("Laptop Encendida");
        }
        public override string apagar()
        {
            return ("Apagando laptop");
        }
    }
}
