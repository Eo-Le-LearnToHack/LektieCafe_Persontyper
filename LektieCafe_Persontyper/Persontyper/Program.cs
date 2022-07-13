using System;

namespace NPersontyper
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Besked.startTekst(); //Opgavebeskrivelse... Ophæv kommentar "//" for at se opgavebeskrivelsen.
            //Person person = new();
            //Action Vigtighed;
            //Vigtighed = person.NavnTildelt;
            //Vigtighed += person.TidTildelt;
            //Vigtighed = person.BæredygtighedTildelt;
            //Vigtighed = person.ØkonomiTildelt;
            do
            {
                Reset.Parameter();
                Person.AddFirstPerson();
                Person.AddMorePeople();
            } while (Loop.mainProgram);

        }//Main(string[] args)
    }//class Program
}//namespace NPersontyper