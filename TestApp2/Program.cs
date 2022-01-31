using System;

namespace TestApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ConsoleWorker.WriteMessage("Input field string/int: ");
                var enteredMessage = ConsoleWorker.ReadMessage();

                Actions actions = new();
                actions.ParseMessage(enteredMessage);

                ConsoleWorker.WriteMessage("Press any key to continue or Esc to exit");
                ConsoleWorker.WriteMessage("----------------------------------------");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
