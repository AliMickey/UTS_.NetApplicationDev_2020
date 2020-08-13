using System;
using System.Collections.Generic;
namespace Week4LabProgram
{
    class SplitChars
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a line: ");
            string input = Console.ReadLine();   
            //char[] words = input.ToCharArray(); 

            List<int> NumberArray = new List<int>();
            List<char> OperatorArray = new List<char>();
            List<char> AlphabetArray = new List<char>();
            
            foreach (char i in input)
            {
                if (Char.IsNumber(i)){
                    NumberArray.Add(Convert.ToInt32(i));
                }

                else if (Char.IsSymbol(i)){
                    OperatorArray.Add(i);
                }

                else if (Char.IsLetter(i)){
                    AlphabetArray.Add(i);
                }
            }

            Console.WriteLine("Number Array: ");
            NumberArray.ForEach(Console.Write);

            Console.WriteLine();

            Console.WriteLine("Operator Array: ");
            OperatorArray.ForEach(Console.Write);
            
            Console.WriteLine();
            
            Console.WriteLine("Alphabet Array: ");
            AlphabetArray.ForEach(Console.Write);

            Console.WriteLine();
        }
    }
}
