using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class Converter
    {
        private int IntSum(string enteredMessage)
        {
            return CheckForNumber.value + enteredMessage.Length;
        }

        private char[] StringReverse(string enteredMessage)
        {
            return enteredMessage.Reverse().ToArray();
        }
        public void ParseInput(int message)
        {
            var intResult = IntSum(message).ToString();
            ConsoleWorker.WriteMessage(intResult);
        }

        private object IntSum(int value)
        {
            throw new NotImplementedException();
        }

        public void ParseInput(string message)
        {
            var stringResult = new string(StringReverse(message));
            ConsoleWorker.WriteMessage(stringResult);
        }
    }
}
