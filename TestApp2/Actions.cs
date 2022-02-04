using System;
using System.Linq;

namespace TestApp2
{
    class Actions
    {
        public int IntSum(string enteredMessage)
        {
            return CheckForNumber.value + enteredMessage.Length;
        }

        public char[] StringReverse(string enteredMessage)
        {
            return enteredMessage.Reverse().ToArray();
        }

        public void ParseMessage(string enteredMessage)
        {
            if (CheckForNumber.IsNumber(enteredMessage))
            {
                var intResult = IntSum(enteredMessage).ToString();
                ConsoleWorker.WriteMessage(intResult);
            }
            else
            {
                var stringResult = new string(StringReverse(enteredMessage));
                ConsoleWorker.WriteMessage(stringResult);
            }
        }
    }
}
