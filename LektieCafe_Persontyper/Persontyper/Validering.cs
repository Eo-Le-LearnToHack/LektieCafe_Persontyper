using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persontyper
{
    internal class Validering
    {
        public static double Double(double numMin, double numMax)
        {
            double? value = null;
            string messageChoice = $"Du kan kun vælge mellem {numMin}-{numMax}.";
            do
            {
                string? answer = Console.ReadLine();
                double tempValue;
                if (double.TryParse(answer, out tempValue) && tempValue >= numMin && tempValue <= numMax)
                {
                    value = tempValue;
                    if (value < numMin && value > numMax)
                    {
                        Console.WriteLine(messageChoice);
                        value = null;
                    }
                }
                else
                {
                    Console.WriteLine(messageChoice);
                }
            } while (value == null);
            return (double)value;
        }

        public static string Text()
        {
            string? value = null;
            string messageChoice = $"Du skal angive et navn.";
            do
            {
                string? answer = Console.ReadLine();
                if (answer == null || answer.Trim() == "") Console.WriteLine(messageChoice);
                else value = answer;
            } while (value == null);
            return value;
        }

        public static string AddPersonStartOverOrQuit()
        {
            string? value = null;
            string messageChoice = $"Vil du tilføje flere personer? \n(Ja = Tilføje endnu en person.\n(Nulstil = Nulstil og starte forfra)\n(Exit = Udskriv profilerne og Luk for programmet";
            Console.WriteLine(messageChoice);
            do
            {
                string? answer = Console.ReadLine();
                if (answer.ToLower() == "ja" || answer.ToLower() == "nulstil" || answer.ToLower() == "exit") value = answer;
                else Console.WriteLine(messageChoice);
            } while (value == null);
            return value;
        }


    }
}
