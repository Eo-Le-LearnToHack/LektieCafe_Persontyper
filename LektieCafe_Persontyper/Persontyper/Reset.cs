using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPersontyper
{
    internal class Reset
    {
        public static void Parameter()
        {
            Console.Clear();
            Loop.addPerson = true;
            Loop.addMorePeople = true;
            Counter.person = 1;
            Counter.index = 0;
        }
    }
}
