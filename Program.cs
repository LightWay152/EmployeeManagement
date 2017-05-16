using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class Program
    {
        static List<Department> lstDepartment = new List<Department>();
        static void TestEmployeeManagement()
        {
            Department departmentHR = new Department();
            departmentHR.DepartmentID = 1;
            departmentHR.DepartmentName = "HR Department";
            lstDepartment.Add(departmentHR);

            Employee teo = new Employee();
            teo.EmployeeID = 1;
            teo.EmployeeName = "Em Teo";
            teo.JobPosition = JobTitle.DEPARTMENT_MANAGER;
            departmentHR.AddEmployee(teo);

            Employee ty = new Employee();
            ty.EmployeeID = 2;
            ty.EmployeeName = "Anh Ty";
            ty.JobPosition = JobTitle.EMPLOYEE;
            departmentHR.AddEmployee(ty);

            Employee meo = new Employee();
            meo.EmployeeID = 100;
            meo.EmployeeName = "Em Meo";
            meo.JobPosition = JobTitle.EMPLOYEE;
            departmentHR.AddEmployee(meo);

            Department accountingDepartment = new Department();
            accountingDepartment.DepartmentID = 2;
            accountingDepartment.DepartmentName = "Accounting Department";
            lstDepartment.Add(accountingDepartment);

            Employee bin = new Employee();
            bin.EmployeeID = 3;
            bin.EmployeeName = "Bin";
            bin.JobPosition = JobTitle.DEPUTY_MANAGER;
            accountingDepartment.AddEmployee(bin);

            Console.WriteLine("The whole list of employees in the company is:");

            foreach(Department dep in lstDepartment)
            {
                Console.WriteLine(dep.DepartmentName);
                dep.DisplayAllEmployees();
            }

            Employee oldEmp = accountingDepartment.SearchEmployee(3);
            if (oldEmp != null)
            {
                oldEmp.EmployeeName = "Bun";
            }

            Console.WriteLine("\nThe whole list of employees in the company after edit is:");

            foreach (Department dep in lstDepartment)
            {
                Console.WriteLine(dep.DepartmentName);
                dep.DisplayAllEmployees();
            }

            if (departmentHR.DeleteEmployee(113)==false)
            {
                Console.WriteLine("\nDid'nt find out employee have id=113 ==> Failed delete!");
            }
            else
            {
                Console.WriteLine("\nThe whole list of employees in the company after delete is:");
            }
            

            foreach (Department dep in lstDepartment)
            {
                Console.WriteLine(dep.DepartmentName);
                dep.DisplayAllEmployees();
            }

            Console.WriteLine("\nList of employee in HR Department is:");
            departmentHR.DisplayAllEmployees();
            departmentHR.SortEmployees();
            Console.WriteLine("\nList of employee in HR Department after soft is:");
            departmentHR.DisplayAllEmployees();

            long sum = 0;
            foreach (Department dep in lstDepartment)
                sum += dep.TotalSalary();
            Console.WriteLine("Total salary have to pay in a month = {0}", sum);

        }
        static void Main(string[] args)
        {
            TestEmployeeManagement();
            Console.ReadLine();
        }
    }
}
