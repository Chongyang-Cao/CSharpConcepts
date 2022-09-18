using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using CSharpConcepts.Classes.Exercises;

namespace CSharpConcepts
{
    internal class Exercises
    {
        internal static void Run()
        {
            //CallTypeExercises();
            CallSelectionExercises();
        }

        private static void CallTypeExercises()
        {
            // Add your calling code here for the questions an example is below

            //Console.WriteLine("# Calculator");
            //TypeExercises.Calculator(12, 6);
            //Console.WriteLine("# Calculator2")
            //Console.WriteLine();
            //TypeExercises.Calculator("14", "7");
            //Console.WriteLine("# BinaryStrings");
            //Console.WriteLine();
            //TypeExercises.BinaryStrings(32);
            //Console.WriteLine("# BMI");
            //Console.WriteLine();
            //Console.WriteLine(TypeExercises.BMICalculator(160, 80));
            //Console.WriteLine("# Date");
            //Console.WriteLine();
            //Console.WriteLine(TypeExercises.FutureDate(3));
            //Console.WriteLine("# Language stuff");
            //Console.WriteLine();
            //Console.WriteLine(TypeExercises.SelectLanguage("French"));
            //Console.WriteLine(TypeExercises.SelectLanguage("Chinese"));
        }

        private static void CallSelectionExercises()
        {
            //Console.WriteLine("# FizzBuzz");
            //Console.WriteLine();
            //Console.WriteLine(SelectionExercises.FizzBuzz(30));
            //Console.WriteLine(SelectionExercises.FizzBuzz(25));
            //Console.WriteLine(SelectionExercises.FizzBuzz(9));
            //Console.WriteLine("# VowelOrConsonent");
            //Console.WriteLine();
            //Console.WriteLine(SelectionExercises.VowelOrConsonant(Convert.ToChar("a")));
            //Console.WriteLine(SelectionExercises.VowelOrConsonant(Convert.ToChar("d")));
            //Console.WriteLine("# DiceRoller");
            //Console.WriteLine();
            //SelectionExercises.DiceRoll();
            //Console.WriteLine("# anglecheck");
            //Console.WriteLine();
            //Console.WriteLine(SelectionExercises.anglecheck(180));
            //Console.WriteLine(SelectionExercises.anglecheck(65));
            //Console.WriteLine(SelectionExercises.anglecheck(190));
            //Console.WriteLine(SelectionExercises.anglecheck(125));
            //Console.WriteLine("# Rock, Paper, Scissors");
            //Console.WriteLine();
            //SelectionExercises.RPS();
            Console.WriteLine("# Triangle identify");
            Console.WriteLine();
            Console.WriteLine(SelectionExercises.triangle(3, 4, 5));
            Console.WriteLine(SelectionExercises.triangle(3, 3, 5));
            Console.WriteLine(SelectionExercises.triangle(1, 1, 12));
            Console.WriteLine(SelectionExercises.triangle(5, 5, 5));
        }
    }
}
