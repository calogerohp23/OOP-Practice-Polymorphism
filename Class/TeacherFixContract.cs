using OOP_Practice___Polymorphism.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice___Polymorphism.Class
{
    public class TeacherFixContract : Employee, ICalculations
    {
        public decimal Bonus { get; set; }
        public double AcademicAverage { get; set; }      
        public override decimal SalaryCalculator()
        {
            base.BaseSalary = 200000m;
            return BaseSalary;
        }

        public bool GoalAchievement()
        {
            if (AcademicAverage >= 85)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public decimal BonusCalculator()
        {
            if(GoalAchievement() == true)
            {
                Bonus = this.BaseSalary;
                return Bonus;
            }
            else
            {
                Bonus = this.BaseSalary / 2;
                return Bonus;
            }
        }
    }
}
