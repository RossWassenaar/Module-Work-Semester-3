using Figgle;

namespace ATMSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomeScreen();

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your account number:");
            string accountNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(accountNumber))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name and account number are required.");
                Console.ResetColor();
                return;
            }

            User user = new User(name, accountNumber);
            BankAccount account = new BankAccount(1000);

            ATMService.ProcessATM(user, account);

        }

        public static void ShowWelcomeScreen()
        {
            Console.WriteLine(FiggleFonts.Blocks.Render("Welcome"));

            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║    ATM SIMULATOR    ║");
            Console.WriteLine("╚═════════════════════╝");
        }

        
    }
}
