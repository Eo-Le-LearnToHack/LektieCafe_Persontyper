using System;

namespace NPersontyper
{
    class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                Reset.Parameter();          //NULSTILLER ALLE PARAMETRENE
                Person.AddFirstPerson();
                Person.AddMorePeople();
            } while (Loop.mainProgram);

        }//Main(string[] args)
    }//class Program
}//namespace NPersontyper