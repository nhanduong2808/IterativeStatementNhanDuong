using System;

namespace IterativeStatementNhanDuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int user_input, prefix;
            Console.WriteLine("Hello, this is Nhan Duong!");
            Console.Write("Please enter an interger between 2 and 10: ");

            while(!int.TryParse(Console.ReadLine(), out user_input))
            {
                Console.Clear();
                Console.Write("Please enter an integer between 2 and 10: ");
            }

            if (user_input%2 == 0 && user_input >= 2 && user_input <= 10)
            {
                user_input += 1;
                prefix = 1;
                while (user_input > 0)
                {
                    Console.WriteLine(prefix.ToString() + ". You have entered an even number");
                    user_input -= 1;
                    prefix += 1;
                }
            }
            else if(user_input%2 == 1 && user_input >= 2 && user_input <= 10)
            {
                user_input -= 1;
                prefix = 1;
                while (user_input > 0)
                {
                    Console.WriteLine(prefix.ToString() + ". You have entered an odd number");
                    user_input -= 1;
                    prefix += 1;
                }
            }
            else
            {
                Console.WriteLine("Only an integer between 2 and 10 works!");
            }
        }
    }
}
