using System;
using System.Collections.Generic;
using System.Text;

namespace patronDeDiseñoAdapter
{
    class Desktop : Computadora
    {
        public override string encender()
        {
            return ("Desktop Encendida");
        }
        public override string apagar()
        {
            return ("Apagando desktop");
        }
    }
}
