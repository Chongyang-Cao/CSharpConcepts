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
            //Console.WriteLine("# Triangle identify");
            //Console.WriteLine();
            //Console.WriteLine(SelectionExercises.triangle(3, 4, 5));
            //Console.WriteLine(SelectionExercises.triangle(3, 3, 5));
            //Console.WriteLine(SelectionExercises.triangle(1, 1, 12));
            //Console.WriteLine(SelectionExercises.triangle(5, 5, 5));
            //Console.WriteLine("# Century Runs");
            //Console.WriteLine();
            //Console.WriteLine(IterationExercises.NumberOfCenturiesScored(new(){ 100, 150, 75 }));
            //Console.WriteLine("# Average Runs");
            //Console.WriteLine();
            //Console.WriteLine(IterationExercises.BattingAverage(new() { 123, 25, -1, 11, 83 }));
            //Console.WriteLine("# Username generator");
            //Console.WriteLine();
            //IterationExercises.UserNames(new() { "Jank", "asdsadas", "owieujksadijuk", "god-damn" });
            //Console.WriteLine("# Multiples of x up to y");
            //Console.WriteLine();
            //IterationExercises.CalculateMultiples(3, 12);
            //Console.WriteLine("# Primecheck");
            //Console.WriteLine();
            //Console.WriteLine(IterationExercises.Prime(2));
            //Console.WriteLine(IterationExercises.Prime(21));
            //Console.WriteLine(IterationExercises.Prime(23));
            //Console.WriteLine(IterationExercises.Prime(32));
            //Console.WriteLine(IterationExercises.Prime(1));
            //Console.WriteLine(IterationExercises.Prime(0));
            //Console.WriteLine(IterationExercises.Prime(-5));
            //Console.WriteLine("# Star Stairs");
            //Console.WriteLine();
            //IterationExercises.starstair(120);
            Console.WriteLine("# Os and Xs");
            Console.WriteLine();
            List<List<char>> board = new()
        {
            new() { 'X', '0', 'X' },
            new() { ' ', '0', ' ' },
            new() { 'X', '0', ' ' }
        };
            List<List<char>> board1 = new()
        {
            new() { 'X', 'X', 'X' },
            new() { ' ', '0', ' ' },
            new() { 'X', '0', ' ' }
        };
            List<List<char>> board2 = new()
        {
            new() { 'X', '0', 'X' },
            new() { ' ', 'X', ' ' },
            new() { 'X', '0', ' ' }
        };
            List<List<char>> board3 = new()
        {
            new() { 'X', '0', 'X' },
            new() { ' ', ' ', ' ' },
            new() { 'X', '0', ' ' }
        };
            List<List<char>> board4 = new()
        {
            new() { 'X', '0', 'X' },
            new() { 'X', '0', ' ' },
            new() { 'X', '0', ' ' }
        };
            Console.WriteLine(IterationExercises.OsXs(board));
            Console.WriteLine(IterationExercises.OsXs(board1));
            Console.WriteLine(IterationExercises.OsXs(board2));
            Console.WriteLine(IterationExercises.OsXs(board3));
            Console.WriteLine(IterationExercises.OsXs(board4));
        }
    }
}
