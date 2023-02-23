using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollServices
{
    public class EmployeePayroll
    {
        public int Employeeid { get; set; }
        public string Employeename { get; set; }
        public long Salary { get; set; }
        public DateTime Startdate { get; set; }
        public long PhoneBumber { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public Char Gender { get; set; }
        public long Basic_Pay { get; set; }
        public long Deduction { get; set; }
        public long Taxable_Pay { get; set; }
        public long Income_Tax { get; set; }
        public long Net_Pay { get; set; }
    }
}
