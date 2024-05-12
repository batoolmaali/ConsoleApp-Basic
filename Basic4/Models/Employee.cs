using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic4.Models
{
    public class Employee
    {
        // method total salary
        public string calcSalary(string _name, double _salary, double _sales, int _OverTime)
        {


            double TotalSalary = 0;
            double hourJD = (_salary / 30 )/ 8;
            double i = _OverTime * 1.5;
            double AfterOvertime = (i * hourJD) + _salary;

            if (_sales >= 15000)
            {
                TotalSalary = _salary + (_sales * 0.09);
            }
            else if (_sales < 15000 && _sales >= 10000)
            {
                TotalSalary = _salary + (_sales * 0.06);
            }
            else if (_sales < 10000 && _sales >= 5000)
            {
                TotalSalary = _salary +( _sales * 0.04);
            }
            else if (_sales < 5000 && _sales >= 1000)
            {
                TotalSalary = _salary + (_sales * 0.02);
            }
            else
            {
                TotalSalary = _salary;
            }

            return "the employee :" + _name +'\n'+ " the total salary+ commission = " + TotalSalary + '\n' + "the salary + overtime =" + AfterOvertime;
        }
    }



}
