using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persontyper
{
    internal class Besked
    {
        public static void startTekst()
        {
            Console.Clear();
            Console.WriteLine(ReadMe.opgavebeskrivelse);
            Console.WriteLine();
            Console.WriteLine("Tryk på en vilkårlig tast for at starte programmet");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
