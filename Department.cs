using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    public class Department
    {
        private List<Employee> lstEmployee = new List<Employee>();
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public Employee DepartmentManager { get; set; }
        public bool AddEmployee(Employee emp)
        {
            bool duplicateEmployeeID = false;
            foreach(Employee oldEmployee in lstEmployee)
                if(oldEmployee.EmployeeID==emp.EmployeeID)
                {
                    duplicateEmployeeID = true;
                    break;
                }
            if (duplicateEmployeeID == true)
                return false;
            emp.DepartmentPostion = this;
            lstEmployee.Add(emp);
            return true;
        }
        public void DisplayAllEmployees()
        {
            foreach(Employee emp in lstEmployee)
            {
                Console.WriteLine(emp);
            }
        }
        public Employee SearchEmployee(int empID)
        {
            foreach (Employee oldEmp in lstEmployee)
                if (oldEmp.EmployeeID == empID)
                    return oldEmp;
            return null;
        }
        public bool DeleteEmployee(int empID)
        {
            Employee emp = SearchEmployee(empID);
            if (emp == null) return false;
            lstEmployee.Remove(emp);
            return true;
        }
        private int compare(Employee emp1,Employee emp2)
        {
            int resultCompareName = string.Compare(emp1.EmployeeName, emp2.EmployeeName, true);
            if(resultCompareName==0)
            {
                if (emp1.EmployeeID < emp2.EmployeeID)
                    return 1;
                if (emp1.EmployeeID > emp2.EmployeeID)
                    return -1;
                return 0;
            }
            return resultCompareName;
        }
        public void SortEmployees()
        {
            lstEmployee.Sort(compare);
        }
        public long TotalSalary()
        {
            long sum = 0;
            foreach (Employee emp in lstEmployee)
                sum += emp.Payroll;
            return sum;
        }
    }
}
