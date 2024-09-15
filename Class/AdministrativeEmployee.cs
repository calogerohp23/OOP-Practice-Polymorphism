using OOP_Practice___Polymorphism.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice___Polymorphism.Class
{
    public class AdministrativeEmployee : Employee, ICalculations
    {
        public double Productivity {  get; set; }

        public override decimal SalaryCalculator()
        {
            base.BaseSalary = 50000m;
            return base.BaseSalary;
        }
        public decimal BonusCalculator()
        {
            if(Productivity >= 80)
            {
                return base.BaseSalary;
            }
            else
            {
                return base.BaseSalary/2;
            }
        }


    }
}
