namespace ConvertToUnits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Выьерите, введя число в какую систему си вы бы хотели перевести число");
            Console.Write("1 Метры в футы");
            Console.Write("2 Сантиметры в километры");
            Console.Write("3 Километры в метры");
            Console.Write("4 Сантиметры в метры");

            int num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                int number = 0;
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите число ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 2:
                        Console.WriteLine("Введите число ");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Введите число ");
                        number = Convert.ToInt32(Console.ReadLine());
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
