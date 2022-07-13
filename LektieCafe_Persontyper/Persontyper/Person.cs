﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persontyper
{
    internal class Person
    {
        public string? Navn { get; set; }
        public double barometer = 100;

        public double Tid { get; set; }
        public double Bæredygtighed { get; set; }
        public double Økonomi { get; set; }
        public static Person[] person = new Person[Counter.person];

        public void NavnTildelt()
        {
            Console.Write("Angiv personens navn:\t\t\t\t\t\t\t");
            Navn = Validering.Text();
            Console.WriteLine();
        }

        public void TidTildelt()
        {
            Console.Write($"Angiv fra 0-{barometer} (i procent) hvor vigtig tiden er for {Navn}:\t\t");
            Tid = Validering.Double(0, barometer);
            barometer -= Tid;
            Console.WriteLine();
        }

        public void BæredygtighedTildelt()
        {
            if (barometer == 0)
            {
                Bæredygtighed = 0;
                Console.WriteLine($"Vigtigheden af Bæredygtighed for {Navn} bliver automatisk tildelt 0, \nfordi Tid = 100 %.\nVigtigheden af Bæredygtighed for {Navn} er derfor =\t\t\t{Bæredygtighed}");
            }
            else
            {
                Console.Write($"Angiv fra 0-{barometer} (i procent) hvor vigtig Bæredygtighed er for {Navn}:\t");
                Bæredygtighed = Validering.Double(0, barometer);
                barometer -= Bæredygtighed;
            }
            Console.WriteLine();
        }

        public void ØkonomiTildelt()
        {
            if (barometer == 0)
            {
                Økonomi = 0;
                Console.WriteLine($"Vigtigheden af Økonomi for {Navn} bliver automatisk tildelt 0, \nbliver automatisk tildelt \npå baggrund af tidligere valg af Tid ({Tid} %) og Bæredygtighed ({Bæredygtighed} %).\nVigtigheden af Økonomi for {Navn} er derfor =\t\t\t\t{Økonomi}");
            }
            else
            {
                Økonomi = 100 - (Tid + Bæredygtighed);
                Console.WriteLine($"Vigtigheden af Økonomi for {Navn} bliver automatisk tildelt \npå baggrund af tidligere valg af Tid ({Tid} %) og Bæredygtighed ({Bæredygtighed} %).\nVigtigheden af Økonomi for {Navn} er derfor =\t\t\t\t{Økonomi}");
            }
            Console.WriteLine();
        }



        public static Person InstantiateAPerson(Person personX)
        {
            Console.WriteLine("Opret første person.");
            personX = new Person(); //Create an object of each person in the array  
            personX.NavnTildelt();
            personX.TidTildelt();
            personX.BæredygtighedTildelt();
            personX.ØkonomiTildelt();
            Counter.person++;
            Counter.index++;
            return personX;
        }

        public static void InstantiateResizePerson()
        {
            Array.Resize<Person>(ref Person.person, Counter.person);
            Person.person[Counter.index] = new Person();
        }
 

        public static Person InstantiateAnExtraPerson(Person personX)
        {
            //Array.Resize<Person>(ref Person.person, Counter.person);
            //Person.person[Counter.index] = new Person();
            personX.NavnTildelt();
            personX.TidTildelt();
            personX.BæredygtighedTildelt();
            personX.ØkonomiTildelt();
            Counter.person++;
            Counter.index++;
            return personX;
        }

        public static void PersonUdskriv()
        {
            Console.Clear();
            Console.WriteLine("Udskriver samtlige personer og deres profiler.");
            Console.WriteLine();
            foreach (Person item in Person.person)
            {
                Console.WriteLine($"{item.Navn}s profil:");
                Console.WriteLine($"Tid:\t{item.Tid}\t\tBæredygtighed:\t{item.Bæredygtighed}\t\tØkonomi:\t{item.Økonomi}");
                Console.WriteLine();
            }
        }

        //        Array.Resize<Person>(ref person, counterPerson);  //Resize<T>(ref T[] ? array, int newSize); https://docs.microsoft.com/en-us/dotnet/api/system.array.resize?view=net-6.0
        //        person[counterIndex] = InstantiateAPerson(person[counterIndex]);
        //        Loop.addPerson = false;



    }//class Person
}