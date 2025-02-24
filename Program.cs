using System.Diagnostics.Metrics;

namespace Topic_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int run;
            int numOfParts = 2;
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
                    string[] ColorsArray = new string[5];

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
                    List<int> values = new List<int> ();
                    int numberCount;

                    Console.WriteLine("How many numbers do you need?");
                    while (Int32.TryParse(values.ToString(), out numberCount))
                        {
                            values.Add (Console.ReadLine());
                        }

                    for (int i = 0; i < values.Count; i++)
                        {

                        }


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
