using System;

namespace _26._05
{
    internal class Task1 : Task
    {
        public override void Do()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int B = Convert.ToInt32(Console.ReadLine());
            int C = Convert.ToInt32(Console.ReadLine());
            if (A <= 0 || B <= 0 || C <= 0)
                throw new Exception("Сторона должна быть больше 0");
            if (C > A || C > B)
            {
                Console.WriteLine("Ни одного квадрата в прямоугольнике расположить нельзя");
            }
            else
            {
                Console.WriteLine("В прямоугольнике можно разместить {0} квадратов со стороной {1}, что составляет {2}", (A / C) * (B / C), C, (A / C) * (B / C) * C * C);
                Console.WriteLine("Площадь незанятой площади равна {0}, а общая {1}", A * B - (A / C) * (B / C) * C * C, A * B);
            }
        }
    }
}
