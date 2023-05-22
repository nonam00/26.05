using System;

namespace _26._05
{
    internal class Task2 : Task
    {
        public override void Do()
        {
            double contribution = 10000;
            double percent;
            Console.WriteLine("Введите процент, под который вы совершаете вклад");
            percent = Convert.ToDouble(Console.ReadLine());
            if (percent > 25)
                throw new Exception("Нельзя половжить вклад под процент больше 25\n");
            else if (percent <= 0)
                throw new Exception("Процент не может быть меньше или равен 0\n");
            else
                percent = percent / 100 + 1;
            int months = 1;
            while (contribution <= 11000)
            {
                months++;
                contribution = 10000 * (Math.Pow(percent, months - 1));
            }
            Console.WriteLine($"Потребовалось {months} месяцев, чтобы вклад был больше 11000");
            Console.WriteLine($"Конечная сумма вклада - {contribution}");
        }
    }
}
