using System;
using System.Collections.Generic;
using System.Linq;

namespace BinaryConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Input();
            ProcessDictionary(input);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ReadLine();
        }

        static string Input()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("'BİNARY'nin asıl amacı girilen bir veriyi doğrudan makine diline çevirmektir.\nASCII Alfabesi kullanılarak bu işlem gerçekleşir.\nPowered By: Donmwz");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Veri giriniz: ");
            return Console.ReadLine();
        }

        static void ProcessDictionary(string input)
        {
            Dictionary<char, int> keys = new Dictionary<char, int>()
            {
                [' '] = 0,
                ['!'] = 33,
                ['"'] = 34,
                ['#'] = 35,
                ['$'] = 36,
                ['%'] = 37,
                ['&'] = 38,
                [','] = 44,
                ['-'] = 45,
                ['.'] = 46,
                ['/'] = 47,
                ['^'] = 94,
                ['_'] = 95,
                ['{'] = 123,
                ['|'] = 124,
                ['}'] = 125,
                ['0'] = 48,
                ['1'] = 49,
                ['2'] = 50,
                ['3'] = 51,
                ['4'] = 52,
                ['5'] = 53,
                ['6'] = 54,
                ['7'] = 55,
                ['8'] = 56,
                ['9'] = 57,
                ['A'] = 65,
                ['B'] = 66,
                ['C'] = 67,
                ['Ç'] = 67,
                ['D'] = 68,
                ['E'] = 69,
                ['F'] = 70,
                ['G'] = 71,
                ['H'] = 72,
                ['I'] = 73,
                ['İ'] = 73,
                ['J'] = 74,
                ['K'] = 75,
                ['L'] = 76,
                ['M'] = 77,
                ['N'] = 78,
                ['O'] = 79,
                ['Ö'] = 79,
                ['P'] = 80,
                ['Q'] = 81,
                ['R'] = 82,
                ['S'] = 83,
                ['T'] = 84,
                ['U'] = 85,
                ['V'] = 86,
                ['W'] = 87,
                ['X'] = 88,
                ['Y'] = 89,
                ['Z'] = 90,
                ['a'] = 97,
                ['b'] = 98,
                ['c'] = 99,
                ['ç'] = 99,
                ['d'] = 100,
                ['e'] = 101,
                ['f'] = 102,
                ['g'] = 103,
                ['h'] = 104,
                ['ı'] = 105,
                ['i'] = 105,
                ['j'] = 106,
                ['k'] = 107,
                ['l'] = 108,
                ['m'] = 109,
                ['n'] = 110,
                ['o'] = 111,
                ['ö'] = 111,
                ['p'] = 112,
                ['q'] = 113,
                ['r'] = 114,
                ['s'] = 115,
                ['t'] = 116,
                ['u'] = 117,
                ['v'] = 118,
                ['w'] = 119,
                ['x'] = 120,
                ['y'] = 121,
                ['z'] = 122
            };

            List<string> binaryResults = new List<string>(); 

            foreach (var j in input)
            {
                if (keys.ContainsKey(j))
                {
                    int ascii = keys[j];

                    List<int> numeric = new List<int>();

                    while (ascii > 0)
                    {
                        int remainder = ascii % 2;
                        numeric.Add(remainder);
                        ascii = ascii / 2;
                    }

                    // Binary sayısını 8 bit'e tamamlamak
                    if (numeric.Count < 8)
                    {
                        numeric.Reverse();
                        Console.ForegroundColor = ConsoleColor.Green;
                        binaryResults.Add(new string('0', 8 - numeric.Count) + string.Join("", numeric));
                    }
                    else
                    {
                        numeric.Reverse();
                        Console.ForegroundColor = ConsoleColor.Green;
                        binaryResults.Add(string.Join("", numeric));
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"'<<{j}>>' ASCII'de bulunmuyor.");
                    Console.ReadLine();
                    return;
                }
            }

            // Binary sayıları yan yana boşluk ile ekliyoruz
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{input} verisinin makine diline çevrilmiş hali: " + string.Join(" ", binaryResults));
        }
    }
}
