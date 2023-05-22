using System;

namespace _26._05
{
    internal class Task4 : Task
    {
        public override void Do()
        {
            string value = Console.ReadLine();

            if (Convert.ToInt32(value) < 0)
                throw new Exception("Число не может быть меньше 0");

            char[] array = value.ToCharArray();
            Array.Reverse(array);
            value = new string(array);
            Console.WriteLine(value);
        }
    }
}
