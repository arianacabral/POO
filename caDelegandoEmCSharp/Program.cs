using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDelegandoEmCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declare a Func variable and assign a lambda expression to the
            // variable. The method takes a string and converts it to uppercase.
            Func<string, string> selector = str => str.ToUpper();

            // Create an array of strings.
            string[] words = { "orange", "apple", "Article", "elephant" };

            // Query the array and select strings according to the selector method.
            IEnumerable<String> aWords = words.Select(selector);

            // Output the results to the console.
            foreach (String word in aWords)
                Console.WriteLine(word);

            Console.ReadLine();
            Console.Clear();

            ///////////////////////////////////////////////////////////////////////////

            Func<int, int> sum = value_ => value_ + 1;

            int[] set = {1,2,3,4};

            IEnumerable<int> new_set = set.Select(sum);

            Console.Write("Original set: {");

            foreach(int i in set)
            {
                Console.Write(i + (i == set.Length ? "" : ", "));
            }

            Console.Write("} \n");

            Console.Write("New set: {");

            foreach (int i in new_set)
            {
                Console.Write(i + (i == new_set.ToList().LastOrDefault() ? "" : ", "));
            }

            Console.Write("}\n");

            Console.ReadLine();
            Console.Clear();

            ///////////////////////////////////////////////////////////////////////////

            Func<double, double, double> Compute = Add;

            double res = Compute(2.5,1.5);
            Console.WriteLine("Resulte of 2.5 + 1.5: " + res);
            Console.ReadLine();

        }

        private static double Add(double v1, double v2)
        {
            return v1 + v2;
        }
    }
}
