using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPersontyper
{
    internal class Value
    {
        private const int row = 4;
        private const int col = 2;

        public static string[,] validText = new string[Value.row, Value.col]
        {
            {"Udskriv", "Udskriv personprofiler."},
            {"Add" , "Tilføj endnu en person."},
            {"Nulstil" , "Nulstil og starte forfra."},
            {"Luk", "Luk for programmet"}
        };

    }
}
