using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice___Polymorphism.Base
{
    public abstract class Employee
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public abstract decimal SalaryCalculator();
    }
}
