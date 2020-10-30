using System;
namespace Week1_DecimalNumbers
{
    class Program
    {
        static void Main(String[] args_)
        {
            var decimalNumber = 239;
            //Step one you need to get each digit
            //The first Step is to Convert it to Value to String -> Character
            //So that you can get to each charecter 2 3 and 9

            var characterArray = decimalNumber.ToString().ToCharArray();

            //Test to see fi this is what you want
            foreach( var item in characterArray)
            {
                //now print each character to console
                Console.WriteLine(item);
            }
        }
    }
}