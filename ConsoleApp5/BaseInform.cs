using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class BaseInform
    {
        private int velocity;
        private double weight;
        private int count;
        private string name;

        public int Velocity
        {
            set { velocity = value > 0 ? value : 0; }
            get { return velocity; }
        }
        public double Weight
        {
            set { weight = value > 0 ? value : 1; }
            get { return weight; }
        }
        public int Count
        {
            set { count = value > 0 ? value : 0; }
            get { return count; }
        }
        public string Name
        {
            set { name = value == null ? "NULL" : value ; }
            get { return name; }
        }

        public BaseInform(int velocity, int count, string name, double weight)
        {
            Velocity = velocity;
            Weight = weight;
            Count = count;
            Name = name;
        }
        public override string ToString()
        {
            return $"Velocity: {velocity}\tCount: {count}\tName: {name}\tWeight: {weight}";
        }
    }
}
