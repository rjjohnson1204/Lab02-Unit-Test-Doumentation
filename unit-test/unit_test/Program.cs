using System;


namespace unit_test
{
    public class Program
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
                finally
                {
                    ATM();
                }


            }
            void MenuSelection(int selection)
            {

                //switch is a selection statement that chooses a single switch section to execute from a list of candidates based on a pattern match with the match expression.
                switch (selection)
                {
                    //Display balance
                    case 1:
                        // Clears the console buffer and corresponding console window of display information.
                        Console.Clear();
                        // tells user current balance
                        Console.WriteLine($"Your current balance is {MyBalance}");
                        break;

                    //Make withdrawl from MyBalance
                    case 2:
                        int withdrawlAmount;
                        // Clears the console buffer and corresponding console window of display information.

                        Console.Clear();
                        //ask user how much they would like to withdraw
                        Console.WriteLine("How much would you like to withdraw?");
                        // converts user input of a  string into an int
                        withdrawlAmount = Convert.ToInt32(Console.ReadLine());
                        if (withdrawlAmount > MyBalance)
                        {
                            // tells user they cannot with draw this amount
                            Console.WriteLine(" Insufficient funds. ");
                            // Clears the console buffer and corresponding console window of display information.
                            Console.Clear();
                        }
                        else
                        {
                            MyBalance = Withdrawl(MyBalance, withdrawlAmount);
                            Console.Clear();
                            // withdraws amount from MyBalance
                            Console.WriteLine($"{withdrawlAmount} has been withdrawn from your account.");

                        }
                        break;

                    case 3:
                        //Make Deposit into MyBalance

                        int addAmount;
                        // Clears the console buffer and corresponding console window of display information.

                        Console.Clear();
                        // ask user how much they would like to deposit
                        Console.WriteLine("How much would you like to depsit?");
                        // converts user entry from string to int
                        addAmount = Convert.ToInt32(Console.ReadLine());
                        // creates new balance afrer addition 
                        MyBalance = Deposit(MyBalance, addAmount);
                        Console.WriteLine($"${addAmount} has been added to your account. ");

                        break;

                    case 4:
                        //Loss of retirement fund. Identity Stolen. BANKRUPCY!

                        Console.ReadKey();

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
                                             GAME OVER    ");

                        Console.ReadKey();

                        // Clears the console buffer and corresponding console window of display information.
                        Console.Clear();
                        break;

                    case 5:

                        Console.Clear();
                        Console.Write(" Thank you for your business.");
                        Console.ReadKey();
                        // Clears the console buffer and corresponding console window of display information.
                        break;

                }


            }

        }           // method to subtract amount from balance
        public static int Withdrawl(int MyBalance, int amount)
        {
            return MyBalance - amount;
        }
        // method to add amount to balance 
        public static int Deposit(int MyBalance, int amount)
        {
            return MyBalance + amount;
        }


    }
}