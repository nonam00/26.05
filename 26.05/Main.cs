using System;

namespace _26._05
{
    internal class Program : Task2
    {
        public static void Main(string[] args)
        {
            Task task;
            Console.WriteLine("Выберете задание: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 2:
                    task = new Task2();
                    break;
                case 4:
                    task = new Task4();
                    break;
                default:
                    throw new Exception("Такого задания не существует");
            }
            task.Do();
        }
    }
}
