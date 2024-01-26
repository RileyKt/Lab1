using System;

namespace StudentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are in your class?");
            var studentCount = int.Parse(Console.ReadLine());

            var studentInfo = new string[studentCount, 2];

            for (int i= 0; i < studentCount; i++)
            {
                Console.WriteLine("Enter the name of student "+(i+1)+":");
                studentInfo[i,0] = Console.ReadLine();

                Console.WriteLine("Student Grade: ");
                studentInfo[i, 1] = Console.ReadLine();
            }

            for (int i=0; i<studentCount; i++)
            {
                Console.WriteLine("Name: " + studentInfo[i,0] + ", Grade: " + studentInfo[i,1]);
            }
        }
    }
}
