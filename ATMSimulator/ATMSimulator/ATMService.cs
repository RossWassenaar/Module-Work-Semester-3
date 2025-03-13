using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    class ATMService
    {
        public static void ShowMenu()
        {
            Console.WriteLine("               MENU               ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔════════════════════════════════╗");
            Console.WriteLine("║       1. Check Balance         ║");
            Console.WriteLine("║       2. Deposit               ║");
            Console.WriteLine("║       3. Withdraw              ║");
            Console.WriteLine("║       4. Exit                  ║");
            Console.WriteLine("╚════════════════════════════════╝");
            Console.ResetColor();
            Console.Write("\nChoose an option:");
        }

        public static void ProcessATM(User user, BankAccount account)
        {
            string choice;
            do
            {
                ShowMenu();
                choice = Console.ReadLine().Trim();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Check Balance");
                        Console.WriteLine($"Hello {user.Name}, Your current balance is ${account.Balance}");
                        break;
                    case "2":
                        Console.WriteLine("Deposit");
                        Console.Write("Enter amount to deposit: ");
                        if (double.TryParse(Console.ReadLine(), out double deposit) && deposit > 0)
                        {
                            account.Deposit(deposit);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Successfully deposited ${deposit}. New Balance: ${account.Balance}");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid deposit. Please enter a valid amount for your deposit.");
                            Console.ResetColor();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Withdraw Money");
                        Console.Write("Enter amount to withdraw: ");
                        if (double.TryParse(Console.ReadLine(), out double withdraw) && withdraw > 0)
                        {
                            if (account.Withdraw(withdraw))
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Successfully withdrew ${withdraw}. New Balance: ${account.Balance}");
                                Console.ResetColor();
                            }
                            else 
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Insufficient Funds");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Invalid withdrawal. Please enter a valid amount for your withdrawal.");
                            Console.ResetColor();
                        }
                        break;
                    case "4":
                        Console.WriteLine("Thank you for using the ATM");
                        Console.WriteLine("Have a great day!");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid option. Please choose a valid option from the menu.");
                        Console.ResetColor();
                        break;
                }
                Console.WriteLine("\nPress Enter to continue");
                Console.ReadLine();
            } while (choice != "4");
        }
    }
}
