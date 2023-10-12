using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensLetformakOOP
{
    internal class Parrot : IntelligensLetformak
    {
        public void Valaszol(string kerdes)
        {
            Console.WriteLine($"Parrot: {kerdes}");
        }
    }
}
