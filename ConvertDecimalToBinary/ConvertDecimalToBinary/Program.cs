using System;

namespace ConvertDecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            string output;

            Console.Write("Ange ett nummer: ");
            input = Console.ReadLine();

            int nr = Convert.ToInt32(input);
            output = "";

            while (nr > 1)
            {
                int rmd = nr % 2;
                output = Convert.ToString(rmd) + output;
                nr /= 2;
            }

            output = Convert.ToString(nr) + output;
            Console.WriteLine(" Resultat i Binary: {0}", output);
            Console.ReadKey();
        }
    }
}
