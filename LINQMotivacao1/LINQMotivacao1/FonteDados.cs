using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMotivacao1
{
    public class FonteDados
    {
        public static List<int> GetNumeros()
        {
            List<int> numeros = new List<int>()
            {
                1, 2, 4, 8, 16, 32, 64, 128, 256, 512
            };
            return numeros;
        }

        public static List<int> GetListaNegra()
        {
            List<int> numeros = new List<int>()
            {
                16, 128, 512
            };
            return numeros;
        }
    }
}
