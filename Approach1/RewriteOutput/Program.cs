using System;

namespace RewriteOutput
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            Console.Write("Who are you?"); //print "Who are you?"
            Console.SetCursorPosition(0, Console.CursorTop); //move the cursor to start of line
            Console.Write("How are you?"); //rewrite "How are you?"
        }
    }
}
