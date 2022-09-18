using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static CSharpConcepts.Classes.Examples.TypeExamples;

namespace CSharpConcepts.Classes.Exercises
{
    public static class SelectionExercises
    {
        // Q1: FizzBuzz
        // Return Fizz if divisible by 3. Buzz if divisible by 5. FizzBuzz if divisible by both.
        // If divisible by neither return the number itself (as a string)
        public static string FizzBuzz(int num)
        {
            string a = "";
            if (num %3 == 0)
            {
                a = "div3";
            }
            if (num%5 == 0)
            {
                a = "div5";
            }
            if (num%15 == 0){
                a = "div15";
            }

            switch (a)
            {
                case "div15":
                    return ("FizzBuzz");
                    
                case "div3":
                    return ("Fizz");
                  
                case "div5":
                    return("Buzz");
                default:
                    string num1 = Convert.ToString(num);
                    return(num1);


            }
        }

        // Q2: Vowel or Consonant
        // Using a switch statement write a function which returns true if the input is a vowel and
        // false if it is a consonant
        public enum Vowels
        {
            a,
            e,
            i,
            o,
            u

        }
        public static bool VowelOrConsonant(char letter)
        {
            string a = letter.ToString();
            if (Enum.TryParse(a, true, out Vowels Vowel))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Q3: DiceRoller
        // Write a procedure which rolls three dice and write the following messages to the console
        // If all three dice have the same value write, "Three of a kind"
        // If two of the dice have the same value write, "You have a pair!
        // Otherwise write, "Sorry you lose
        public static void DiceRoll()
        {
            Random random = new Random();
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            int roll3 = random.Next(1, 7);
            Console.WriteLine(roll1);
            Console.WriteLine(roll2);
            Console.WriteLine(roll3);
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("Three of a kind");
            }
            else if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
            {
                Console.WriteLine("You have a pair!");
            }
            else
            {
                Console.WriteLine("Sorry you lose");
            }   
        }
        // Q4: Angles
        // Write a function to return whether the angle input is acute, right angle, obtuse, straight or reflex
        // Use an enum for the different angle types
        public enum anglenames
        {
            reflex,
            straight,
            obtuse,
            right_angle,
            acute
        }
        public static anglenames anglecheck(int angle)
        {
            int a = 0;
            if (angle > 180)
            {
                a = 0;
            }
            else if (angle == 180)
            {
                a = 1;
            }
            else if (angle > 90)
            {
                a = 2;
            }
            else if (angle == 90)
            {
                a = 3;
            }
            else
            {
                a = 4;
            }
            return (anglenames)a;
           
        }
        // Q5: Rock, Paper Scissors
        // Write a procedure which takes the user's choice as input and randomly generate the computer's choice
        // It should write the computer's choice to the console and write whether the user lost, won, or drew.
        // Handle the user input in the calling code in Program.cs
        public enum RPSchoice
        {
            Rock,
            Paper,
            Scissors
        }
        public static void RPS()
        {
            Random random = new Random();
            Console.WriteLine("Rock paper scissors! \n1.Rock \n2.Paper \n3.Scissors ");
            Console.WriteLine();
            int choice = Convert.ToInt32(Console.ReadLine());
            while ((choice < 0) || (choice > 3))
            {
                Console.WriteLine("Invalid choice, choose again");
                choice = Convert.ToInt32(Console.ReadLine());
                //A bit of validation if I do a misinput
            }
            choice = choice - 1;
            int cpu = random.Next(0, 3);
            RPSchoice cpuchoice = (RPSchoice)cpu;
            //Console.WriteLine(choice.ToString());
            //Console.WriteLine(cpu.ToString()); Just checking the value i got was right
            Console.WriteLine($"You chose {(RPSchoice)choice} and the computer chose {(RPSchoice)cpu} ");
            if ((cpu < choice) || ((cpu == 2)&&(choice == 0)))
            {
                Console.WriteLine(cpu);
                Console.WriteLine(choice);
                Console.WriteLine("You won!");
            }
            else if (cpu == choice)
            {
                Console.WriteLine(cpu);
                Console.WriteLine(choice);
                Console.WriteLine("You tie");
            }
            else
            {
                Console.WriteLine(cpu);
                Console.WriteLine(choice);
                Console.WriteLine("You lost!");
            }
            //slight error, will fix later

        }
        // Q6: Triangle
        // Write a function that takes in three side lengths.
        // Determine whether a triangle with those sides is equilateral, isosceles, scalene or impossible
        public static string triangle(int a, int b, int c)
        {
            int ab = a + b;
            int ac = a + c;
            int bc = b + c;
            if ((ab < c) || (ac < b) || (bc < a))
            {
                return "impossible";
            }
            else if ((a == b) && (b == c))
            {
                return "equaliteral";
            }
            else if (((a == b) && (b != c)) || ((a == c) && (c != b)) || ((b == c) && (c != a))){
                return "isosceles";
            }
            else
            {
                return "scalene";
            }
        }

           
    }
}
