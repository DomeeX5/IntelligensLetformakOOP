using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensLetformakOOP
{
    internal class LazyTherapist : IntelligensLetformak
    {
        private string[] opciokHaKerdojel;
        private string[] opciokHaFelkiatojel;
        private string[] opciokHaMas;
        private Random rand;

        public void Valaszol(string kerdes)
        {
            opciokHaKerdojel = new string[] 
            { 
                "Biztos ön ebben?",
                "Miért gondolja ezt?",
                "El tudja képzelni ennek az ellenkezőjét is?",
                "Nem tudom. Talán így van. Ön mit gondol erről?" 
            };
            opciokHaFelkiatojel = new string[] 
            { 
                "Most dühös lett?",
                "Mit érez miközben ezt mondja?",
                "Feszült lett attól, amiről beszélünk?" 
            };
            opciokHaMas = new string[] 
            { 
                "Kérem, folytassa",
                "Biztos ebben?",
                "Csakugyan?",
                "Hmm. Ez érdekes. Kérem fejtse ki bővebben!" 
            };
            rand = new Random();

            switch (kerdes[kerdes.Length - 1])
            {
                case '?':
                    Console.WriteLine($"LazyTherapist: {opciokHaKerdojel[rand.Next(0, opciokHaKerdojel.Length)]}");
                    break;
                case '!':
                    Console.WriteLine($"LazyTherapist: {opciokHaFelkiatojel[rand.Next(0, opciokHaFelkiatojel.Length)]}");
                    break;
                default:
                    Console.WriteLine($"LazyTherapist: {opciokHaMas[rand.Next(0, opciokHaMas.Length)]}");
                    break;
            }
        }
    }
}
