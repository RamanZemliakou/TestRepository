
namespace TestApp2
{
    internal class CheckForNumber
    {
        public static int value;

        public static bool IsNumber(string str)
        {
            return int.TryParse(str, out value);
        }
    }
}
