using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    internal class Actions
    {
        private static int IntSum(string enteredMessage)
        {
            return CheckForNumber.value + enteredMessage.Length;
        }

        private static char[] StringReverse(string enteredMessage)
        {
            return enteredMessage.Reverse().ToArray();
        }

        public static void ParseMessage(string enteredMessage)
        {

            if (!CheckForNumber.IsNumber(enteredMessage))
            {
                var stringResult = StringReverse(enteredMessage).ToString();
                ConsoleWorker.WriteMessage(stringResult);
                
            }
            else
            {
                var intResult = IntSum(enteredMessage).ToString();
                ConsoleWorker.WriteMessage(intResult);
            }
            return;
        }
    }
}
