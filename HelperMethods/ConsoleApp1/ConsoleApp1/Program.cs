using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach (char item in messageArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}
