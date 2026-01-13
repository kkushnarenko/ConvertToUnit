namespace ConvertToUnits
{
    internal class Program
    {
        static double ConvertMeterToFeet(float number)
        {
            double result = number * 3.28084;
            return result;
        }

        static double ConvertSmToKm(float number)
        {
            float result = number / 100000;
            return result;
        }

        static double ConvertKmToMeter(float number)
        {
            float result = number * 1000;
            return result;
        }

        

        static void Main(string[] args)
        {
            Console.WriteLine("Выьерите, введя число в какую систему си вы бы хотели перевести число");
            Console.WriteLine("1 Метры в футы");
            Console.WriteLine("2 Сантиметры в километры");
            Console.WriteLine("3 Километры в метры");
            Console.WriteLine("4 Сантиметры в метры");

            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                float number = 0;
                double result = 0;
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите число ");
                        number = Convert.ToInt32(Console.ReadLine());
                        result = ConvertMeterToFeet(number);
                        Console.WriteLine(result);
                        break;

                    case 2:
                        Console.WriteLine("Введите число ");
                        ConvertSmToKm(number);
                        result = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(result);
                        break;

                    case 3:
                        Console.WriteLine("Введите число ");
                        number = Convert.ToInt32(Console.ReadLine());
                        result = ConvertKmToMeter(number);
                        Console.WriteLine(result);
                        break;

                    case 4:
                        Console.WriteLine("Введите число ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        num = 0;
                        break;
                }


            }
        }
    }
}
