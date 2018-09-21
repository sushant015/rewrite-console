using System;

namespace RewriteOutput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            Console.Write("Good morning!!"); //print "Good morning!!"
            string backStr = new string('\b', 9); //generate 9 times backspaces
            Console.Write(backStr+ "afternoon!!"); //move cursor back 9 times and write "afternoon!!"
        }
    }
}
