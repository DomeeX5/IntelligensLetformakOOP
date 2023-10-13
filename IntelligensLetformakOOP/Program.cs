using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligensLetformakOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string menu = "0";
            string kerdes;
            do
            {
                Console.WriteLine("0: kilépés\t1: Parrot\t2: Dulltherapist\t3: LazyTherapist");
                while (menu == "" && menu != "0" || menu != "1" || menu != "2" || menu != "3")
                {
                    menu = Console.ReadLine();
                    switch (menu)
                    {
                        case "1":
                            Console.WriteLine("Jelenleg a Parrot AI-t használod. A kilépéshez írd be azt, hogy 'vége'.");
                            do
                            {
                                Parrot parrot = new Parrot();
                                Console.Write("Te: ");
                                kerdes = Console.ReadLine();
                                while (kerdes == "")
                                {
                                    Console.Write("Te: ");
                                    kerdes = Console.ReadLine();
                                }
                                if (kerdes == "vége")
                                {
                                    Console.Clear();
                                    Console.WriteLine("0: kilépés\t1: Parrot\t2: Dulltherapist\t3: LazyTherapist");
                                }
                                else
                                {
									parrot.Valaszol(kerdes);
								}
                            } while (kerdes != "vége");
                            break;

                        case "2":
                            Console.WriteLine("Jelenleg a DullTherapist AI-t használod. A kilépéshez írd be azt, hogy 'vége'.");
                            do
                            {
                                DullTherapist dt = new DullTherapist();
                                Console.Write("Te: ");
                                kerdes = Console.ReadLine();
                                while (kerdes == "")
                                {
                                    Console.Write("Te: ");
                                    kerdes = Console.ReadLine();
                                }
								if (kerdes == "vége")
								{
									Console.Clear();
									Console.WriteLine("0: kilépés\t1: Parrot\t2: Dulltherapist\t3: LazyTherapist");
								}
								else
								{
									dt.Valaszol(kerdes);
								}
                            } while (kerdes != "vége");
                            break;

                        case "3":
                            Console.WriteLine("Jelenleg a LazyTherapist AI-t használod. A kilépéshez írd be azt, hogy 'vége'.");
                            do
                            {
                                LazyTherapist lazy = new LazyTherapist();
                                Console.Write("Te: ");
                                kerdes = Console.ReadLine();
                                while (kerdes == "")
                                {
                                    Console.Write("Te: ");
                                    kerdes = Console.ReadLine();
                                }
								if (kerdes == "vége")
								{
									Console.Clear();
									Console.WriteLine("0: kilépés\t1: Parrot\t2: Dulltherapist\t3: LazyTherapist");
								}
								else
								{
									lazy.Valaszol(kerdes);
								}
                            } while (kerdes != "vége");
                            break;
                    }
                }
            } while (menu != "0");
        }
    }
}
