using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes.Exercises
{
    public static class IterationExercises
    {
        // Q1: Centuries
        // Calculate the number of times a batter scored a century (100 runs) or more in a match
        public static int NumberOfCenturiesScored(List<int> runsScored)
        {
            int a = 0;
            foreach(int num in runsScored)
            {
                if (num >= 100)
                {
                    a += 1;
                }
            }
            return a;
        }

        // Q2: Batting Average
        // Calculate the batting average.
        // Exclude any values where the runs scored were negative as a negative value indicates that they did not bat in that match.
        public static double BattingAverage(List<int> runsScored)
        {
            double average = 0;
            int count = 0;
           foreach (int num in runsScored)
            {
                if (num >= 0)
                {
                    average = average + num;
                    count += 1;
                }
            }
           average = average / count;
           return average;
        }

        // Q3: User Names
        // Determine the user names
        // It will be the first three characters of their name and a number, which will be the order of the name in the list.
        public static List<string> UserNames(List<string> names)
        {
            List<string> finalreturn = new List<string>();
            for (int i = 0; i < names.Count; i++)
            {
                string firstthree = names[i].Substring(0,3);
                string username = firstthree + i;
                finalreturn.Add(username);
                //Console.WriteLine(username);
            }
            foreach (string name in finalreturn)
            {
                Console.WriteLine(name);
            }
            return finalreturn;
        }

        // Q4: Calculate Multiples
        // Write a function that will output the multiple of a number from 1 to the max number specified
        // So called with 6 and 10 it would output [6, 12, 18, 24, 30, 36, 42, 48, 54, 60]
        public static List<int> CalculateMultiples(int number, int maximumMultiple)
        {
            List<int> multiples = new List<int>();
            for (int i = 1; i <= maximumMultiple; i++)
            {
                multiples.Add(number*i);
            }
            foreach (int num in multiples)
            {
                Console.WriteLine(num);
            }
            return multiples;
        }

        // Q5: Is Prime
        // Write a function to determine whether a number is prime
        public static bool Prime(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                if (number%i == 0) 
                {
                    result = false;
                }
            }
            if (number <= 1)
            {
                result = false;
            }
            return result;
        }


        // Q6: Star Pattern
        // Write a procedure to output a star pattern based on the number of stars input
        // So for example if the user enters 6 then it will output:

        //*
        //**
        //***
        //****
        //*****
        //******
        //*****
        //****
        //***
        //**
        //*
        public static void starstair(int num)
        {
            string star = "*";
            string a = star;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(a);
                a = a + star;
                
            }

            for (int i = num-1; i >0; i--)
            {
                string b = "";
                for (int j = 0; j < i; j++)
                {
                    //Console.WriteLine(j);
                    //Console.WriteLine(i);
                    //Console.WriteLine(b);
                    b = b + star;
                }
                Console.WriteLine(b);
                
            }
        }
        // Q7: This function should take a noughts and crosses board represented as an character list,
        // A space represents an empty space as shown below.

       /* List<List<char>> board = new()
        {
            new() { 'X', '0', 'X' },
            new() { ' ', '0', ' ' },
            new() { 'X', '0', ' ' }
        };*/

        // The function should return a char: 'X' if player X has won, '0' if the player 0 has won,
        // and ' ' if there is currently no winner.
        public static char OsXs(List<List<char>> board)
        {
            char x = Convert.ToChar("X");
            char o = Convert.ToChar("0");
            for (int i = 0; i < 3; i++)
            {
                if ((board[i][0] == board[i][1]) && (board[i][1] == board[i][2])){
                    if (board[i][0] == x)
                    {
                        return x;
                    } 
                    else if (board[i][0] == o)
                    {
                        return o;
                    }
                }
                if ((board[0][i] == board[1][i]) && (board[1][i] == board[2][i]))
                {
                    if (board[0][i] == x)
                    {
                        return x;
                    }
                    else if (board[0][i] == o)
                    {
                        return o;
                    }
                }
            }
            if ((board[0][0] == board[1][1]) && (board[1][1] == board[2][2])|| (board[2][0] == board[1][1]) && (board[1][1] == board[0][2]))
            {
                if (board[1][1] == x)
                {
                    return x;
                }
                else if (board[1][1] == o)
                {
                    return o;
                }
            }
            char blank = ' ';
            return blank;
        }
    }
}
