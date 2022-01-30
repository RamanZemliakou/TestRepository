using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleWorker.WriteMessage("Input field string/int: ");
            var enteredMessage = ConsoleWorker.ReadMessage();

            Actions.ParseMessage(enteredMessage);
        }
    }
}
