using System;

namespace TestApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            var converter = new Converter();
            var checkForNumber = new CheckForNumber();

            do
            {
                ConsoleWorker.WriteMessage("Input field string/int: ");
                var enteredMessage = ConsoleWorker.ReadMessage();
                var isNumber = checkForNumber.IsNumber(enteredMessage);

                if (isNumber)
                {
                    converter.ParseInput(Int32.Parse(enteredMessage));
                }
                else
                {
                    converter.ParseInput(enteredMessage);
                }

                ConsoleWorker.WriteMessage("Press any key to continue or Esc to exit");
                ConsoleWorker.WriteMessage("----------------------------------------");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
