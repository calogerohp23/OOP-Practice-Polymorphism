using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Practice___Polymorphism.Base;

namespace OOP_Practice___Polymorphism.Class
{
    public class TeacherPerHour : Employee
    {
        public int Hour {  get; set; }
        
        public override decimal SalaryCalculator()
        {
            throw new NotImplementedException();
        }
    }
}
