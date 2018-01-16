using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szinhaz
{
    class Kategoria
    {
        int[] ArKategoriak = { 5000, 4000, 3000, 2000, 1500 };
        public int[] Katstat = new int[5];
        public int Arkategoria { get; private set; }

        public Kategoria(int index)
        {
            Arkategoria = ArKategoriak[index - 1];
            //Katstat[index - 1]++;
        }
        
    }
}
