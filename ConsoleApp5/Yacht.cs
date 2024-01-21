using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Yacht : WaterCraft
    {
        private string type;
        private int sail_distance;

        public string Type
        {
            init { type = value == null ? "NULL" : value; }
            get { return type; }
        }
        public int Sail_distance
        {
            init { sail_distance = value > 0 ? value : 100; }
            get { return sail_distance; }
        }
        public Yacht(int velocity, int count, string name, double weight, string type, int sail_distancestring) : base(velocity, count, name, weight)
        {
            Sail_distance = sail_distance;
            Type = type;
        }
        public override string ToString()
        {
            return $"Velocity: {BaseInfo.Velocity}\tCount: {BaseInfo.Count}\tName: {BaseInfo.Name}\tWeight: {BaseInfo.Weight}\tType: {Type}\tSail Distance: {Sail_distance}";
        }
    }
}
