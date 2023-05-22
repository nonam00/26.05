using System;

namespace _26._05
{
    //for task 2
    internal class Percent
    {
        private double value;
        public double Value
        {
            get { return value; }
            set 
            {
                if (value > 25)
                    throw new Exception("Нельзя половжить вклад под процент больше 25\n");
                else if (value <= 0)
                    throw new Exception("Процент не может быть меньше или равен 0\n");
                else
                    this.value = value / 100 + 1;
            }
        }
    }
}
