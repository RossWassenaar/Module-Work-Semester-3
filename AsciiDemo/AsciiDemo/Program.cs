using Figgle;
namespace AsciiDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowWelcomeScreen();
        }

        static void DrawBorder(string title)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string('=', 30));
            Console.WriteLine(new string($"= {title.PadRight(26)}="));
            Console.WriteLine(new string('=', 30));
            Console.ResetColor();
        }

        static void ShowWelcomeScreen()
        {
            Console.Clear();
            DrawBorder("Learn Console Design");
            Console.ForegroundColor = ConsoleColor.Red;
            //Automatically generate ascii font using figgle fonts
            Console.WriteLine(FiggleFonts.FireFontK.Render("I'VE      GOT      ACUTE       HEMMOROIDS"));
            Console.ResetColor();
        }
    }
}
