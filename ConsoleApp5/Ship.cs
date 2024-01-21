using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Ship : WaterCraft
    {
        private int crew_count;
        private int sail_distance;
        public int Sail_distance
        {
            init { sail_distance = value > 0 ? value : 100; }
            get { return sail_distance; }
        }
        public int Crew_count
        {
            set { crew_count = value > 0 ? value:  1; }
            get { return crew_count; }
        }
        public Ship(int velocity, int count, string name, double weight, int sail_distance, int crew_count) : base(velocity, count, name, weight)
        {
            Sail_distance = sail_distance;
            Crew_count = crew_count;
        }
        public override string ToString()
        {
            return $"Velocity: {BaseInfo.Velocity}\tCount: {BaseInfo.Count}\tName: {BaseInfo.Name}\tWeight: {BaseInfo.Weight}\tCrew Count: {Crew_count}\tSail Distance: {Sail_distance}";
        }
    }
}
