using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Barge : WaterCraft
    {
        private int crew_count;
        private string type;
        public string Type
        {
            init { type = value == null ? "NULL" : value; ; }
            get { return type; }
        }
        public int Crew_count
        {
            set { crew_count = value > 0 ? crew_count : 1; }
            get { return crew_count; }
        }
        public Barge(int velocity, int count, string name, double weight, int crew_count, string type) : base(velocity, count, name, weight)
        {
            Crew_count = crew_count;
            Type = type;
        }
        public override string ToString()
        {
            return $"Velocity: {BaseInfo.Velocity}\tCount: {BaseInfo.Count}\tName: {BaseInfo.Name}\tWeight: {BaseInfo.Weight}\tType: {Type}\tCrew Count: {Crew_count}";
        }
    }
}
