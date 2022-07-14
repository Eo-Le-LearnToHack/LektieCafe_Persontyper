using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPersontyper
{
    internal class Loop
    {
        public static bool mainProgram = true;
        public static bool addPerson = true;
        public static bool addMorePeople = true;
        public static bool udskrivPerson = true;

        public static void Reset()
        {
            mainProgram = true;
            addPerson = true;
            addMorePeople = true;
            udskrivPerson = true;
        }

        public static void CloseAll()
        {
            mainProgram = false;
            addPerson = false;
            addMorePeople = false;
            udskrivPerson = false;
        }

        public static void StartOver()
        {
            mainProgram = true;
            addPerson = false;
            addMorePeople = false;
            udskrivPerson = false;
        }

        public static void AddPerson()
        {
            mainProgram = true;
            addPerson = true;
            addMorePeople = true;
            udskrivPerson = false;
        }

        public static void UdskrivPerson()
        {
            mainProgram = true;
            addPerson = false;
            addMorePeople = true;
            udskrivPerson = true;
        }

    }
}
