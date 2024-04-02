using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task101
{
    internal class Car
    {
        public int Id { get; }
        public string Name { get; }
        public int Speed { get; }
        public string CarCode { get; }

        public Car(int id, string name, int speed, string carCode)
        {
            Id = id;
            Name = name;
            Speed = speed;
            CarCode = carCode.Substring(0, 2).ToUpper() + id.ToString();
        }
    }
}
