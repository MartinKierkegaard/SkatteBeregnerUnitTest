using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleAppDemo
{
    public class SkatteBeregner
    {
        /// <summary>
        /// En metode til at beregne skat, lav eller høj skat
        /// Hvis jobKategorien er pensionist eller studerende betales kun 5%
        /// </summary>
        /// <param name="indkomst">hvilken indkomst har personen</param>
        /// <param name="jobKategori 1: studerende, 2: pensionist, 3:underviser på Zealand">hvilken kategori er personen</param>
        /// <returns>skat der skal betales</returns>
        public int BeregnSkat(int indkomst,int jobKategori)
        {


            int specialSkat = 5;
            int lavSkat = 10;
            int HøjSkat = 20;



            //no tax
            if (indkomst <= 0)
            {
                return 0;
            }

            if (jobKategori == 1 || jobKategori == 2)
                return indkomst * specialSkat / 100;

            //low tax 
            if (indkomst <= 20000)
                return indkomst * lavSkat / 100;
            //high tax
            else
                return indkomst * HøjSkat / 100;

        }

    }
}
