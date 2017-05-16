using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Employee
    {
        public const long BASIC_SALARY = 100000000;

        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime YearOfBirth { get; set; }
        public JobTitle JobPosition { get; set; }
        public Department DepartmentPostion { get; set; }
        public long Payroll
        {
            get
            {
                if(JobPosition == JobTitle.DIRECTOR)
                    return BASIC_SALARY + (long)(BASIC_SALARY * 0.25);
                if(JobPosition == JobTitle.DEPARTMENT_MANAGER)
                    return BASIC_SALARY + (long)(BASIC_SALARY * 0.15);
                if (JobPosition == JobTitle.DEPUTY_MANAGER)
                    return BASIC_SALARY + (long)(BASIC_SALARY * 0.05);
                return BASIC_SALARY;
            }

        }
        public override string ToString()
        {
            return this.EmployeeID+"\t"
                +this.EmployeeName+"\t"
                +this.JobPosition+"\t==>"
                +this.Payroll;
        }
    }
}
