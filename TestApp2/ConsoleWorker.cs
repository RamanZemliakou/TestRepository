using System;

namespace TestApp2
{
    internal class ConsoleWorker
    {
        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static string ReadMessage()
        {
            return Console.ReadLine();
        }        
    }
}
