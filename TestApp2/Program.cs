using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    class InputValue
    {
        public void GetValue()
        {
            Console.WriteLine("Input field string/int: ");
            var inputValue = Console.ReadLine();
            Console.WriteLine(inputValue.GetType());

            char[] reverse = inputValue.Reverse().ToArray();
            Console.WriteLine(reverse);

            int strLength = inputValue.Length;
            int inputNumber;
            int.TryParse(inputValue, out inputNumber);
            Console.WriteLine(inputNumber + strLength);
        }
    }

    class StringWork : InputValue
    {
        public void ReverseOutput()
        {
            Console.WriteLine();
        }
    }

    class IntWork : InputValue
    {
        public void CharSum()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            InputValue inputValue = new InputValue();
            inputValue.GetValue();

            Console.WriteLine("asd");
            //for string:
            //char[] reverse = inputValue.Reverse().ToArray();
            //Console.WriteLine(reverse);

            //for int:
            //int strLength = inputValue.Length;
            //int inputNumber;
            //int.TryParse(inputValue, out inputNumber);
            //Console.WriteLine(inputNumber + strLength);
        }
    }
}
