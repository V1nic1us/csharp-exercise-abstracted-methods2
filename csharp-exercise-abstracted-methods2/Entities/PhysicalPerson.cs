using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercise_abstracted_methods2.Entities
{
    internal class PhysicalPerson: Person
    {
        public double HealthExpenditures { get; set; }

        public PhysicalPerson(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnnualIncome < 20000)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
