using System;

namespace _26._05
{
    internal class Task3 : Task
    {
        private int a;
        private int b;
        public override void Do()
        {
            Console.WriteLine("Введите значения: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 0)
                throw new Exception("Число должно иметь значение больше 0");
            b = Convert.ToInt32(Console.ReadLine());
            if (b <= 0)
                throw new Exception("Число должно иметь значение больше 0");
            else if (b < a)
                throw new Exception("Значение B должно быть больше A");
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
        }
    }
}
