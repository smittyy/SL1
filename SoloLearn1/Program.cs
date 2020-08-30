using System;
using System.Threading;

namespace SoloLearn1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("So I can write text like this, and it gets printed out!");

            var Bad_Name = "This is a bad Variable";
            int number = 13;

            Console.WriteLine(Bad_Name);

            Console.WriteLine("How are you?");
            string urDay = Console.ReadLine();

            //The next 2 lines will blow your mind
            /*This is a
             multi line comment*/

            var num = "is a string";
            var word = 16;

            const string change = "Can not be changes!";

            int y = 14;
            int x = 5;
            Console.WriteLine(x - y);

            int u = 1;
            int u += 5;
            int t = 3;
            Console.WriteLine(u);
            Console.WriteLine(++t);
        }
    }
}
