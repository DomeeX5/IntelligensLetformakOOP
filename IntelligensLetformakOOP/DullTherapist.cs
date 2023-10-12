using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensLetformakOOP
{
    internal class DullTherapist : IntelligensLetformak
    {
        private string[] opciok;
        private Random rand;

        public void Valaszol(string kerdes)
        {
            opciok = new string[]
            { 
                "Kérem, folytassa",
                "Biztos ebben?",
                "Csakugyan?",
                "Nem tudom. Talán így van. Ön mit gondol erről?"
            };

            rand = new Random();
            Console.WriteLine($"DullTherapist: {opciok[rand.Next(0, opciok.Length)]}");
        }

    }
}
