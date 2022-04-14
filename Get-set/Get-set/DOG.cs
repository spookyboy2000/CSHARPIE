using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_set
{
    internal class DOG
    {
        private static PAW paw = new PAW("woof");
        public static PAW GetPAW()
        {
            return paw;
        }
        public static void SetPAW(PAW Paw)
        {
            paw = Paw; 
        }
    }
}
