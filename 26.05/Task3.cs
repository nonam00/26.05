using System;

namespace _26._05
{
    internal abstract class Task3
    {
        public static void Do3()
        {
            double contribution = 10000;
            Percent percent = new Percent();
            Console.WriteLine("Введите процент, под который вы совершаете вклад");
            try
            {
                percent.Value = Convert.ToDouble(Console.ReadLine());
                int months = 1;
                while (contribution <= 11000)
                {
                    months++;
                    contribution = 10000 * (Math.Pow(percent.Value, months - 1));
                }
                Console.WriteLine($"Потребовалось {months} месяцев, чтобы вклад был больше 11000");
                Console.WriteLine($"Конечная сумма вклада - {contribution}");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
