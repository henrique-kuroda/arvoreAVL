using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace arvoreAVL
{
    public class No
    {
        public int valor { get; set; }
        public No Esquerdo { get; set; }
        public No Direito { get; set; }
        public int altura { get; set; }

        public No(int valor)
        {
            this.valor = valor;
            this.altura = 1;
        }
    }
}
