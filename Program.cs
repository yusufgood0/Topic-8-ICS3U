using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Topic_8
{
    public class Program
    {
        
            
        public static void Main(string[] args)
        {
            //run
            int run;
            int numOfParts = 2;

            //part 1
            string[] ColorsArray = new string[5];

            //part 2
            List<int> values = new List<int>();
            int numberCount;
            int minimum;
            int maximum;
            int search_number;
            int search_number_found = 0;

            Random generator = new Random();


            while (true) {
            {
                Console.WriteLine("what part would you like to run?");
                for (int i = 0; i < numOfParts; i++) 
                    {
                        Console.WriteLine($"for part {i+1} enter '{i+1}'");
                    }

                while (!int.TryParse(Console.ReadLine(), out run))
                    {
                        Console.WriteLine("invalid input, input a number");
                    }
                Console.Clear();
                if (run == 1)
                {
                    //part 1
                    //here I used arrays (as they are more efficient), for part 2 I will use lists to show my understanding

                        Console.WriteLine($"input {ColorsArray.Length} colors");
                    for (int i = 0; i < ColorsArray.Length; i++)
                        {
                            ColorsArray[i] = Console.ReadLine();
                        }
                    Console.Write("The colors you inputted: ");

                    for (int i = 0; i < ColorsArray.Length; i++)
                        {
                            Console.Write($"{ColorsArray[i]}, ");
                        }
                    Console.WriteLine();
                    Console.Write($"A random color from that list: {ColorsArray[generator.Next(ColorsArray.Length)]}");


                    }
                else if (run == 2)
                {
                    //part 2
                    

                    Console.WriteLine("How many numbers do you need?");
                    while (!Int32.TryParse(Console.ReadLine(), out numberCount))
                        {
                            Console.WriteLine("INVALID INPUT!");
                        }

                    Console.WriteLine("What is your maximum value?");
                    while (!Int32.TryParse(Console.ReadLine(), out maximum))
                        {
                            Console.WriteLine("INVALID INPUT!");
                        }

                    Console.WriteLine("What is your minimum value?");
                    while (!Int32.TryParse(Console.ReadLine(), out minimum))
                        {
                            Console.WriteLine("INVALID INPUT!");
                        }

                    //generate random numbers
                    for (int i = 0; i < numberCount; i++)
                        {
                            values.Add(generator.Next(maximum-minimum+1) + minimum);
                        }

                    //print list in one line
                    Console.WriteLine(string.Join(", ", values));

                    Console.WriteLine();

                    Console.WriteLine("Search for number.");
                    while (!Int32.TryParse(Console.ReadLine(), out search_number))
                        {
                            Console.WriteLine("INVALID INPUT!");
                        }

                    for (int i = 0; i < values.Count; i++)
                        {
                            if (values[i] == search_number)
                            {
                                search_number_found++;
                            }
                        }
                    Console.WriteLine($"your number was found, {search_number_found} times.");

                    Console.WriteLine();

                    Console.WriteLine("Search for number.");
                    while (!Int32.TryParse(Console.ReadLine(), out search_number))
                        {
                            Console.WriteLine("INVALID INPUT!");
                        }
                    for (int i = 0; i < values.Count; i++)
                        {
                            if (values[i] == search_number)
                            {
                                values[i] = 0;
                            }
                        }
                    Console.WriteLine(string.Join(", ", values));
                    for (int i = 0; i < values.Count; i++)
                        {
                            values[i] = 0;
                        }
                        Console.WriteLine(string.Join(", ", values));

                    }

                }
                Console.WriteLine();
                Console.Write("press enter to continue");
                Console.ReadLine();
                Console.Clear();

            }
        }
    }
}
