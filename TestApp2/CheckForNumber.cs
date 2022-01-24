
namespace TestApp2
{
    internal class CheckForNumber
    {
        public static int value;

        public static bool IsNumber(string str) => int.TryParse(str, out value);
    }
}
