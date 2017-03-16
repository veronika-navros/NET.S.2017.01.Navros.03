using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;

namespace Test.CUI
{
    class Program
    {
        static void Main()
        {
            //Task1 testing
            try
            {
                int? index = ArrayExtension.GetMiddleIndex(new[] {1, 100, 50, -51, 1, 1});
                Console.WriteLine(index == null ? "No such index found" : index.ToString());
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array's null reference");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Empty or too huge array");
            }

            //Task2 testing
            try
            {
                Console.WriteLine(StringExtension.Concatenate("xyaabbbccccdefww",
                    "xxxxyyyyabklmopqhij"));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("String's null reference");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Not allowed symbols are used");
            }

            //Task3 testing
            try
            {
                Console.WriteLine(BitOperationsExtension.InsertByPosition(15, int.MaxValue, 3, 5));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Wrong arguments");
            }

            Console.ReadKey();
        }
    }
}


