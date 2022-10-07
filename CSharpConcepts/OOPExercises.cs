using CSharpConcepts.Classes.Exercises.BankAccount;
using CSharpConcepts.Classes.Exercises.Diary;

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
            //BankAccount bankaccount = new BankAccount(new decimal(39.50), new DateTime(2022, 10, 11, 16, 50, 00), new decimal(200));
            //Debug.Assert(bankaccount.Balance == new decimal(39.50));
            //Debug.Assert(bankaccount.Opendate == new DateTime(2022, 10, 11, 16, 50, 00));
            //Debug.Assert(bankaccount.Overdraft == new decimal(200));
            //seems to work

            decimal balance = 300;
            DateTime day = new DateTime(2022, 10, 11, 5, 20, 00);
            decimal overdraft = 500;
            BankAccount bankAccount = new BankAccount(balance, day, overdraft);
            bankAccount.AddAction(balance, day, overdraft);
            Console.WriteLine("What action do you wish to do?\n1. Deposit\n2. Withdraw\n3. Set (new Overdraft)\n4. View (current balance)\nTo exit, type 'Exit'");
            string input = Console.ReadLine();
            while (input != "Exit")
            {
                if (input == "1" || input.ToLower() == "deposit")
                {
                    Console.WriteLine("How much? ");
                    decimal deposit = Convert.ToDecimal(0);
                    while (deposit <= 0)
                    {
                        deposit = Convert.ToDecimal(Console.ReadLine());
                        if (deposit <= 0)
                        {
                            Console.WriteLine("Can not deposit negative or zero amount");
                        }
                    }

                    day = Convert.ToDateTime(DateTime.Now);
                    balance = balance + deposit;
                    bankAccount.AddAction(balance, day, overdraft);
                }
                else if (input == "2" || input.ToLower() == "withdraw")
                {
                    decimal max = -1*overdraft;
                    Console.WriteLine("How much? ");
                    decimal withdraw = Convert.ToDecimal(0);
                    while (withdraw <= 0 || withdraw > max)
                    {
                        withdraw = Convert.ToDecimal(Console.ReadLine());
                        if (withdraw <= 0)
                        {
                            Console.WriteLine("Can not withdraw negative or zero amount");
                        }
                        if (withdraw > max)
                        {
                            Console.WriteLine("Withdrawal surpasses your Overdraft!");
                        }
                    }

                    day = Convert.ToDateTime(DateTime.Now);
                    balance = balance - withdraw;
                    bankAccount.AddAction(balance, day, overdraft);
                }
                else if (input == "3" || input.ToLower() == "Set")
                {
                    Console.WriteLine($"Current overdraft is:{overdraft}\nSetting new overdraft");
                    decimal newover = Convert.ToDecimal(Console.ReadLine());
                    day = Convert.ToDateTime(DateTime.Now);
                    overdraft = newover;
                    bankAccount.AddAction(balance, day, overdraft);
                }
                else if (input == "4" || input.ToLower() == "view")
                {
                    Console.WriteLine("Viewing last action");
                    Console.WriteLine($"Balance: {balance}");
                    Console.WriteLine($"Date of last action: {day}");
                    Console.WriteLine($"Current Overdraft Limit: {overdraft}");
                }
                else
                {
                    Console.WriteLine("Invalid choice, try again!");
                }
                Console.WriteLine();
                Console.WriteLine("What action do you wish to do?\n1. Deposit\n2.Withdraw\n3.View\nTo exit, type 'Exit'");
                input = Console.ReadLine();

            }
            //Having just realised that I had entirely misread the question, heres take 2   




        }


    }
}
