using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpConcepts.Classes.Exercises.Diary;
using CSharpConcepts.Classes.Exercises.BankAccount;
using System.Diagnostics;

namespace CSharpConcepts
{
    internal class OOPExercises
    {
        internal static void Run()
        {
//            UseDiary();
            UseBankAccount();
        }
        
        internal static void UseDiary()
        {
           Diary diary = new Diary("Bob Smith");
            Console.WriteLine(diary.Name);
            diary.AddEvent(new DateOnly(2022, 10, 11), 13, "woooo", "My place");
            diary.AddEvent(new DateOnly(2022, 10, 11), 9, "woooo", "My place");
            diary.AddEvent(new DateOnly(2022, 10, 11), 12, "woooo", "My place");
            diary.AddEvent(new DateOnly(2022, 10, 11), 11, "woooo", "My place");
            diary.AddEvent(new DateOnly(2022, 10, 11), 10, "woooo", "My place");
            diary.AddEvent(new DateOnly(2022, 10, 11), 21, "woooo", "My place");
            diary.AddEvent(new DateOnly(2022, 10, 13), 14, "woooo", "My place");
            diary.AddEvent(new DateOnly(2022, 10, 13), 9, "woooo", "My place");
            // Add some events to your diary

            //// Now check how many events you have on a particular day
            //Console.WriteLine(diary.CheckDiary(new DateOnly(2022, 10, 11)));
            //// Implement a new method in the Diary class to return the number of morning events on a particular day
            //// Call this method
            //Console.WriteLine(diary.CheckMorning(new DateOnly(2022, 10, 13)));
            
        }

        internal static void UseBankAccount()
        {
            // Implement your bank account class following the instructions in the BankAccount class
            BankAccount bankaccount = new BankAccount(new decimal(39.50), new DateTime(2022, 10, 11, 16, 50, 00));
            Debug.Assert(bankaccount.Balance == new decimal(39.50));
            Debug.Assert(bankaccount.Opendate == new DateTime(2022, 10, 11, 16, 50, 00));
            // Write calling code from here
        }
    }
}
