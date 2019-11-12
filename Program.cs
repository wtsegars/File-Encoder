using System;
using System.Text;
using System.IO;
using static System.Environment;
using static System.Console;
using static System.IO.Path;

namespace File_Encoder
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Encodings:");
            WriteLine(" [1] ASCII");
            WriteLine(" [2] UTF-7");
            WriteLine(" [3] UTF-8");
            WriteLine(" [4] UTF-16 (Unicode)");
            WriteLine(" [5] UTF-32");
            WriteLine(" [any other key] Defaults");

            Write("Press a number to choose an encoding: ");
            ConsoleKey number = ReadKey(false).Key;
            WriteLine();
            WriteLine();

            Encoding encoder;
            switch (number)
            {
                case ConsoleKey.D1:
                    encoder = Encoding.ASCII;
                    break;
                case ConsoleKey.D2:
                    encoder = Encoding.UTF7;
                    break;
                case ConsoleKey.D3:
                    encoder = Encoding.UTF8;
                    break;
                case ConsoleKey.D4:
                    encoder = Encoding.Unicode;
                    break;
                case ConsoleKey.D5:
                    encoder = Encoding.UTF32;
                    break;
                default:
                    encoder = Encoding.Default;
                    break;
            }

            Write("Enter the text that you would like to encode: ");
            string textToConvert = ReadLine();

            WriteLine(textToConvert);
        }
    }
}
