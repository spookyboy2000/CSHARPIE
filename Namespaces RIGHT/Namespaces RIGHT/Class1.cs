using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces_LEFT 
{
    internal class Class1
    {
        private int ai;

        public void Feed(int amount)
        {
            ai -= amount;
            Console.WriteLine(ai);
        }
    }


}
