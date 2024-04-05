using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herancaCsharp.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee(){}
        public OutsourceEmployee(string name, int hours, double valuePH, double outSource)
            :base(name, hours, valuePH)
        {
            AdditionalCharge = outSource;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
