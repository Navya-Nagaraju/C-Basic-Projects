using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employeeObj = new Employee();
            var emps = employeeObj.GetEmployees();

            State stateObj = new State();

            Console.WriteLine("Enter the state name to filter employees:");
            string stateFilter = Console.ReadLine();

            //Read the values from input.
            //Validate the input data.
            //Assign the value to filter condition.
            //Verify the result.
            //Employee and State.

            #region Joins
            var states = stateObj.GetStates();
          


            var empStateData = from emp in emps
                                join state in states on emp.StateId equals state.Id
                                where state.Name == stateFilter
                                select new
                                {
                                    EmployeeName = emp.FirstName,
                                    EmployeeLastName = emp.LastName,
                                    StateName = state.Name,
                                    EmpSalary = emp.Salary,
                                    StateId = state.Id
                                };

            foreach (var item in empStateData)
            {
                Console.WriteLine($"Employee: {item.EmployeeName}, State: {item.StateName}");
            }

            Console.ReadLine();

            #endregion


            Employee employee = new Employee();

            Console.WriteLine("Enter the value to sort by first name 1. Ascending  2. Decending");
            var sortValue = Console.ReadLine();

            bool result = false;

            if (sortValue == "1")
            {
                result = true;
            }

            var employees = employee.SortEmployees(result);

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName}\n");
            }

            Console.ReadLine();

            var joinDate = employee.GetMaxSalary();

            Console.WriteLine($"Employee last join date: {joinDate}");
            Console.ReadLine();
            // Department depart = new Department();




        }
    }
}
