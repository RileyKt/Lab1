using System;

namespace LoopCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var j =0; j<5; j++ )
            {
                for(var i =1; i<10;i++)
                {
                       Console.WriteLine(i);
                }
            }
        }
    }
}
