using OOP_Practice___Polymorphism.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice___Polymorphism.Class
{
    internal class TeacherFixContract : Employee, ICalculations
    {
        public decimal BonusCalculator()
        {
            throw new NotImplementedException();
        }
        public override decimal SalaryCalculator()
        {
            throw new NotImplementedException();
        }
    }
}
