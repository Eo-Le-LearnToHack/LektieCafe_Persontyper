using System;

namespace Persontyper
{


    class Program
    {
        public static void Main(string[] args)
        {
            Besked.startTekst();
            Loop.main = true;
            do
            {
                Console.Clear();
                Loop.addPerson = true;
                Loop.end = true;
                Counter.person = 0;
                Counter.index = 0;
                Person.InstantiateResizePerson();
                Person.person[Counter.index] = Person.InstantiateAPerson(Person.person[Counter.index]); //Opret første person

                do
                {
                    string? AddorQuit = Validering.AddPersonStartOverOrQuit();
                    if (AddorQuit.ToLower() == "exit")
                    {
                        Loop.main = false;
                        Loop.addPerson = false;
                        Loop.end = false;
                    }
                    else if (AddorQuit.ToLower() == "nulstil")
                    {
                        Loop.main = true;
                        Loop.addPerson = false;
                        Loop.end = false;
                    }
                    else if (AddorQuit.ToLower() == "ja")
                    {
                        Loop.addPerson = true;
                    }

                    while (Loop.addPerson)
                    {
                        Person.InstantiateResizePerson(); //Resize<T>(ref T[] ? array, int newSize); https://docs.microsoft.com/en-us/dotnet/api/system.array.resize?view=net-6.0
                        Person.person[Counter.index] = Person.InstantiateAnExtraPerson(Person.person[Counter.index]); //Opret ny person
                        Loop.addPerson = false;
                    }
                } while (Loop.end);

                
                Person.PersonUdskriv();
                Console.ReadLine();

            } while (Loop.main);

        }//Main(string[] args)
    }//class Program
}//namespace Persontyper