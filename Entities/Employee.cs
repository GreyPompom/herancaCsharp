using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace herancaCsharp.Entities
{
    class Employee
    {
        public String Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee() { }
        public Employee(String name, int hours, double valuePH)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePH;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            StringBuilder cs = new StringBuilder();
            cs.AppendLine(Name + " - $ "+ Payment().ToString("F2", CultureInfo.InvariantCulture));
            return cs.ToString();
        }
    }
}
