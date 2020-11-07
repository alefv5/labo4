using System;
using System.Collections.Generic;
using System.Text;

namespace patronDeDiseñoAdapter
{
    class ComputadoraAdapter : Computadora
    {
        private MaquinaEscribir maquina = new MaquinaEscribir();

        public override string encender()
        {
            return maquina.AbrirMaquina();
        }
        public override string apagar()
        {
            return maquina.CerrarMaquina();
        }
    }
}

