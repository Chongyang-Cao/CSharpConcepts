using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpConcepts.Classes.Examples.TypeExamples;

namespace CSharpConcepts.Classes.Exercises
{
    public static class TypeExercises
    {
        // Q1: Calculator 1
        // Write to the console correctly the results of: +. - , *, /
        public static void Calculator(int num1, int num2)
        {
            string sign = Console.ReadLine();
            if (sign == "+")
            {
                Console.WriteLine(num1+"+"+num2);
                Console.WriteLine(num1+num2);
            }
            if (sign == "-")
            {
                Console.WriteLine(num1 + "-" + num2);
                Console.WriteLine(num1 - num2);
            }
            if (sign == "x")
            {
                Console.WriteLine(num1 + "x" + num2);
                Console.WriteLine(num1*num2);
            }
            if (sign == "/")
            {
                Console.WriteLine(num1 + "/" + num2);
                Console.WriteLine(num1/num2);
            }
        }

        // Q2: Calculator 2
        // Try to convert both the values to a double and write to the console the results of: +. - , *, /
        public static void Calculator(string value1, string value2)
        {
            double a = Convert.ToDouble(value1);
            double b = Convert.ToDouble(value2);
            string sign = Console.ReadLine();
            if (sign == "+")
            {
                Console.WriteLine(a + "+" + b);
                Console.WriteLine(a + b);
            }
            if (sign == "-")
            {
                Console.WriteLine(a+ "-" + b);
                Console.WriteLine(a - b);
            }
            if (sign == "x")
            {
                Console.WriteLine(a + "x" + b);
                Console.WriteLine(a * b);
            }
            if (sign == "/")
            {
                Console.WriteLine(a + "/" + b);
                Console.WriteLine(a / b);
            }
        }

        // Q3: Binary Strings
        // Write to the console the number printed in Binary, Decimal and Hex formats
        public static void BinaryStrings(int num)
        {
            string a = Convert.ToString(num,2);
            string b = Convert.ToString(num,10);
            string c = Convert.ToString(num,16);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        //Q4: BMI
        //Calculate and return the BMI - Body mass index
        public static double BMICalculator(double height, double weight)
        {
            if (height > 2)
            {
                height /= 100;
            }
            double a = weight / (height * height);
            return a;
        }

        // Q5: FutureDate
        // Write to the console today's date. Return the date that it will be when the days passed in are added to the current date. 
        public static DateTime FutureDate(int days)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            return today.AddDays(days);
        }
        
        // Q6: Languages
        // Using the enum below write a program that will convert the proposed language to the enum if availabe
        // Otherwise it should randomly assign a language
        public enum Language
        {
            French,
            Italian,
            Spanish,
            Finnish
        }
        public static Language SelectLanguages()
        {
            Random random = new Random();
            int choice = random.Next(0, 4);
            Language Language = (Language)choice; // Converts the number to the house enum
            return Language;
        }
        public static Language SelectLanguage(string proposedLanguage)
        {
            if (Enum.TryParse(proposedLanguage, true, out Language Language))
            {
                return Language;
            }
            else
            {
                Console.WriteLine("Sorry your language does not exist. You will be randomly assigned a language");
                Language = SelectLanguages();
                return Language;
            }
        }


    }
}
