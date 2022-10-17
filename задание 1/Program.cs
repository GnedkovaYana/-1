using System;
namespace ex1
{
    public static class Program
    {
        public static void Main()
        {
            float comparson = float.NaN;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                string number = Console.ReadLine();

                bool intNumber = int.TryParse(number, out int intNum);
                if (intNumber)
                {
                    Console.WriteLine((char)intNum);
                    break;
                }
                bool floatnumber = float.TryParse(number, out float floNum);
                if (floatnumber)
                {
                    if (floNum == comparson)
                    {
                        break;
                    }
                    else
                    {
                        comparson = floNum;
                    }
                }
                else if (number == "q")
                {
                    break;
                }
            }
        }
    }
}