﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPersontyper
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

            Console.WriteLine(Besked.options);
            do
            {
                string? answer = Console.ReadLine();
                if(TextExists(answer)) value = answer;    
            } while (value == null);
            return value;


            static bool TextExists(string answer)
            {
                bool Exist = false;
                for (int i = 0; i < 4; i++)
                {
                    if (answer.ToLower() == Value.validText[i, 0].ToLower())
                    {
                        Exist = true;
                        break;
                    }
                }
                return Exist;
            }

        }
    }//class Validering
}//namespace NPersontyper
