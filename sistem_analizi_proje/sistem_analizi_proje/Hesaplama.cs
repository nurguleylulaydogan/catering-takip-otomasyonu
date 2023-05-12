using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistem_analizi_proje
{
    class Hesaplama
    {
        public static int islem(int miktar, int tl)   //Static metot
        {
            int tutar;
            tutar = miktar * tl;
            return tutar;
        }
    }
}
