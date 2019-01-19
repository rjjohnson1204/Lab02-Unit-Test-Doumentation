﻿using System;

namespace unit_test
{
    class Program
    {
        static void Main(string[] args)
        {

             int MyBalance = 5000;

            ATM();
            
            void ATM()
            {
                //intro to atm//
                Console.WriteLine("                                     ");
                Console.WriteLine("                $$ Welcome to Shady ATM $$");
                Console.WriteLine("                                     ");
                Console.WriteLine("                                     ");
                Console.WriteLine("           $$ Enter Social Sec...I mean...PIN $$");
                Console.WriteLine("                                     ");
                Console.WriteLine("                 -----------------------");
                Console.WriteLine("                                     ");
                // ask user to make a selection//
                Console.WriteLine("                                     ");
                Console.WriteLine("                    Make a Selection       ");
                Console.WriteLine("                                     ");
                Console.WriteLine("                   1. Check Balance");
                Console.WriteLine("                   2. Make a Withdrawl");
                Console.WriteLine("                   3. Make a Deposit");
                Console.WriteLine("                   4. Donation to Nigerian Prince flee from presecution  ");
                Console.WriteLine("                   5. Exit ");

                Console.WriteLine("                   Please choose 1, 2, 3, 4, or 5             ");
                Console.WriteLine("                                     ");


                try
                {
                    int selection = Convert.ToInt32(Console.ReadLine());
                    MenuSelection(selection);
                }

                catch (Exception)
                {
                    Console.Write("Improper selection. Make another selection");
                    Console.Clear();
                }


            }
             void MenuSelection(int selection)
            {

                //switch is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression.
                switch (selection)
                {
                 case 1:
                     //Display balance
                     Console.Clear();
                     // Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
                     Console.WriteLine($"Your current balance is {MyBalance}");
                     // Clears the console buffer and corresponding console window of display information.
                     break;

                 case 2:
                     //Make withdrawl from MyBalance

                     int withdrawlAmount;
                     Console.Clear();
                     //ask user how much they would like to withdraw
                     Console.WriteLine("How much would you like to withdraw?");
                     withdrawlAmount = Convert.ToInt32(Console.ReadLine());

                     // Clears the console buffer and corresponding console window of display information.
                     if (withdrawlAmount > MyBalance)
                     {
                         Console.Clear();
                         Console.WriteLine(" Insufficient funds. ");
                     }
                     else
                     {
                         MyBalance = Withdrawl(MyBalance, withdrawlAmount);
                         Console.Clear();
                         Console.WriteLine($"{withdrawlAmount} has been withdrawn from your account.");

                     }
                     break;

                 case 3:
                        //Make Deposit into MyBalance

                        int addAmount;
                        Console.Clear();
                        // ask user how much they would like to deposit
                        Console.WriteLine("How much would you like to depsit?");
                        // converts user entry from string to int
                        addAmount = Convert.ToInt32(Console.ReadLine());
                        // creates new balance afrer addition 
                        MyBalance = Deposit(MyBalance, addAmount);
                        Console.WriteLine($"${addAmount} has been added to your account. ")
                               
                        break;

                 case 4:
                        //Loss of retirement fund. Identity Stolen. BANKRUPCY!

                       
                      Console.WriteLine($@"
                  
                  
                            Loss of retirement fund. Identity Stolen.
                    ´´´´´´´´´´´´´´´´´´´ ¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶´´´´´´´´´´´´´´´´´´´`
                    ´´´´´´´´´´´´´´´´´¶¶¶¶¶¶´´´´´´´´´´´´´¶¶¶¶¶¶¶´´´´´´´´´´´´´´´´
                    ´´´´´´´´´´´´´¶¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´´´´´´´´´´´
                    ´´´´´´´´´´´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´´´´´´´´´´
                    ´´´´´´´´´´´¶¶´´´´´´´´´´´´´´´´´´´´´`´´´´´´´´´´´¶¶´´´´´´´´´´`
                    ´´´´´´´´´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´´´´´´´´´
                    ´´´´´´´´´´¶¶´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´¶¶´´´´´´´´´´
                    ´´´´´´´´´´¶¶´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶´´´´´´´´´´
                    ´´´´´´´´´´¶¶´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶´´´´´´´´´´
                    ´´´´´´´´´´¶¶´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´¶¶´´´´´´´´´´
                    ´´´´´´´´´´¶¶´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶¶´´´´´´´´´´
                    ´´´´´´´´´´´¶¶´¶¶´´´¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶´´´¶¶´¶¶´´´´´´´´´´´
                    ´´´´´´´´´´´´¶¶¶¶´¶¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶¶¶´¶¶¶¶¶´´´´´´´´´´´
                    ´´´´´´´´´´´´´¶¶¶´¶¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶¶¶´¶¶¶´´´´´´´´´´´´´
                    ´´´´¶¶¶´´´´´´´¶¶´´¶¶¶¶¶¶¶¶´´´´´´´¶¶¶¶¶¶¶¶¶´´¶¶´´´´´´¶¶¶¶´´´
                    ´´´¶¶¶¶¶´´´´´¶¶´´´¶¶¶¶¶¶¶´´´¶¶¶´´´¶¶¶¶¶¶¶´´´¶¶´´´´´¶¶¶¶¶¶´´
                    ´´¶¶´´´¶¶´´´´¶¶´´´´´¶¶¶´´´´¶¶¶¶¶´´´´¶¶¶´´´´´¶¶´´´´¶¶´´´¶¶´´
                    ´¶¶¶´´´´¶¶¶¶´´¶¶´´´´´´´´´´¶¶¶¶¶¶¶´´´´´´´´´´¶¶´´¶¶¶¶´´´´¶¶¶´
                    ¶¶´´´´´´´´´¶¶¶¶¶¶¶¶´´´´´´´¶¶¶¶¶¶¶´´´´´´´¶¶¶¶¶¶¶¶¶´´´´´´´´¶¶
                    ¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶´´´´¶¶¶¶¶¶¶´´´´¶¶¶¶¶¶¶¶´´´´´´¶¶¶¶¶¶¶¶
                    ´´¶¶¶¶´¶¶¶¶¶´´´´´´¶¶¶¶¶´´´´´´´´´´´´´´¶¶¶´¶¶´´´´´¶¶¶¶¶¶´¶¶¶´
                    ´´´´´´´´´´¶¶¶¶¶¶´´¶¶¶´´¶¶´´´´´´´´´´´¶¶´´¶¶¶´´¶¶¶¶¶¶´´´´´´´´
                    ´´´´´´´´´´´´´´¶¶¶¶¶¶´¶¶´¶¶¶¶¶¶¶¶¶¶¶´¶¶´¶¶¶¶¶¶´´´´´´´´´´´´´´
                    ´´´´´´´´´´´´´´´´´´¶¶´¶¶´¶´¶´¶´¶´¶´¶´¶´¶´¶¶´´´´´´´´´´´´´´´´´
                    ´´´´´´´´´´´´´´´´¶¶¶¶´´¶´¶´¶´¶´¶´¶´¶´¶´´´¶¶¶¶¶´´´´´´´´´´´´´´
                    ´´´´´´´´´´´´¶¶¶¶¶´¶¶´´´¶¶¶¶¶¶¶¶¶¶¶¶¶´´´¶¶´¶¶¶¶¶´´´´´´´´´´´´
                    ´´´´¶¶¶¶¶¶¶¶¶¶´´´´´¶¶´´´´´´´´´´´´´´´´´¶¶´´´´´´¶¶¶¶¶¶¶¶¶´´´´
                    ´´´¶¶´´´´´´´´´´´¶¶¶¶¶¶¶´´´´´´´´´´´´´¶¶¶¶¶¶¶¶´´´´´´´´´´¶¶´´´
                    ´´´´¶¶¶´´´´´¶¶¶¶¶´´´´´¶¶¶¶¶¶¶¶¶¶¶¶¶¶¶´´´´´¶¶¶¶¶´´´´´¶¶¶´´´´
                    ´´´´´´¶¶´´´¶¶¶´´´´´´´´´´´¶¶¶¶¶¶¶¶¶´´´´´´´´´´´¶¶¶´´´¶¶´´´´´´
                    ´´´´´´¶¶´´¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶´´¶¶´´´´´´
                    ´´´´´´´¶¶¶¶´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´¶¶¶¶´´´´´´´ 
                          ");


                     // Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
                        Console.ReadLine();
                     // Clears the console buffer and corresponding console window of display information.
                     Console.Clear();
                     break;

                 case 5:
                     //Exit of ATM

                     //Exit();
                     // Obtains the next character or function key pressed by the user. The pressed key is displayed in the console window.
                     Console.ReadKey();
                     // Clears the console buffer and corresponding console window of display information.
                     Console.Clear();
                     break;

                }


             }

        }
                  public static int Withdrawl(int MyBalance, int amount)
                  {
                      return MyBalance - amount;
                  }

                 public static int Deposit(int MyBalance, int amount)
                 {
                      return MyBalance + amount;
                 }


    }
}





       

    


