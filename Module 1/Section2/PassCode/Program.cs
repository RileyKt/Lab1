using System;

namespace PassCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var secret = "secret";
            var exit = 0;
            while(exit == 0){ 
                Console.WriteLine("What is the pass code?");
                var code = Console.ReadLine();

                if(code == secret)
                {
                    Console.WriteLine("Authenticated");
                    Console.WriteLine("What is the new pass code?");
                    secret = Console.ReadLine();
                    Console.WriteLine("Would you like to continue? (y/n)");
                    var answer = Console.ReadLine();
                    if(answer == "n")
                    {
                        exit = 1;
                    }
                    else
                    {
                        exit = 0;
                    }
                    
                                        

                }
                else
                {
                    Console.WriteLine("Not Authenticated");
                }
            }
        }
    }
}
