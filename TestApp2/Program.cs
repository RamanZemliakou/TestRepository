using System;

namespace TestApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            Actions actions = new();
            do
            {
                ConsoleWorker.WriteMessage("Input field string/int: ");
                var enteredMessage = ConsoleWorker.ReadMessage();

                
                actions.ParseMessage(enteredMessage);

                ConsoleWorker.WriteMessage("Press any key to continue or Esc to exit");
                ConsoleWorker.WriteMessage("----------------------------------------");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
