using System.Linq;

namespace TestApp2
{
    internal class Actions
    {
        public static int IntSum(string enteredMessage) => CheckForNumber.value + enteredMessage.Length;
        
        public static char[] StringReverse(string enteredMessage) => enteredMessage.Reverse().ToArray();
    }
}
