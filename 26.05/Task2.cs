using System;

namespace _26._05
{
    internal class Task2 : Task
    {
        public override void Do()
        {
            double contribution = 10000;
            Percent percent = new Percent();
            Console.WriteLine("Введите процент, под который вы совершаете вклад");
            try
            {
                percent.Value = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            int months = 1;
            while (contribution <= 11000)
            {
                months++;
                contribution = 10000 * (Math.Pow(percent.Value, months - 1));
            }
            Console.WriteLine($"Потребовалось {months} месяцев, чтобы вклад был больше 11000");
            Console.WriteLine($"Конечная сумма вклада - {contribution}");
        }
    }
}
