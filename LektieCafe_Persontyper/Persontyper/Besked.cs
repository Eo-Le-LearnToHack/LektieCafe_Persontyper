using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPersontyper
{
    internal class Besked
    {

        public static string førstePerson = "Opret første person.";
        public static string vælg = "Hvad vil du foretage?";
        public static string udskrivProfil = "Udskriver personprofiler.";

        public static string options = $"{Besked.vælg.ToUpper()} \n" +
               $"\n{Value.validText[0, 0].ToUpper()} \t= {Value.validText[0, 1]}" +
               $"\n{Value.validText[1, 0].ToUpper()} \t\t= {Value.validText[1, 1]}" +
               $"\n{Value.validText[2, 0].ToUpper()} \t= {Value.validText[2, 1]}" +
               $"\n{Value.validText[3, 0].ToUpper()} \t\t= {Value.validText[3, 1]}" +
               "\n";

        public static void startTekst()
        {
            Console.Clear();
            Console.WriteLine(ReadMe.opgavebeskrivelse + "\n" + "Tryk på en vilkårlig tast for at starte programmet");
            Console.ReadLine();
        }
    }
}
