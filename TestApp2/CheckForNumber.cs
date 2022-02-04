
namespace TestApp2
{
    class CheckForNumber
    {
        public static int value;

        public bool IsNumber(string str)
        {
            return int.TryParse(str, out  value);
        }
    }
}
