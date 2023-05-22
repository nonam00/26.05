using System;

namespace _26._05
{
    internal class Task4 : Task
    {
        private int a;
        private int b;
        public override void Do()
        {
            Console.WriteLine("Введите значения: ");
            try
            {
                A = Convert.ToInt32(Console.ReadLine());
                B = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(i);
                Console.WriteLine();
            }
        }
        public int A
        {
            get { return a; }
            set
            {
                if (value <= 0)
                    throw new Exception("Число должно иметь значение больше 0");
                else
                    a = value;
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 0)
                    throw new Exception("Число должно иметь значение больше 0");
                else if (value < b)
                    throw new Exception("Значение B должно быть больше A");
                else
                    b = value;
            }
        }
    }
}
