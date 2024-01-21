using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public abstract class WaterCraft
    {
        public BaseInform BaseInfo;
        public WaterCraft(int velocity, int count, string name, double weight)
        {
            BaseInfo = new BaseInform(velocity, count, name, weight);
        }
        public void Swim()
        {
            Console.WriteLine("Я плыву");
        }
    }
}
