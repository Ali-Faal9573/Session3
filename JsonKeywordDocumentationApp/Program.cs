using Newtonsoft.Json;
using JsonKeywordDocumentationLibrary;

namespace JsonKeywordDocumentationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("C# Modifier Keyword Documentation");
            Console.ResetColor();

            bool isValid = true;

            while (isValid)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(KeyWordList.showstartingtext());
                Console.ResetColor();
                string keyword = Console.ReadLine().ToLower();
                if (keyword == "exit")
                {
                    isValid = false;
                    break;
                }
                string keywordinfo = SelectKeyword.keywordinfo(keyword);
                if (keywordinfo != null)
                {
                    ReadAndConvertFile file = new ReadAndConvertFile(keywordinfo);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(file.convert().keyword);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(file.convert().description);
                    Console.ResetColor();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine("Keyword not recognized.");
                    Console.ResetColor();
                }

            }
        }
    }
}