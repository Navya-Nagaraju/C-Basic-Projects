using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoins
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public long Salary { get; set; }
        public DateTime JoinDate { get; set; }
        public int StateId { get; set; }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                Id = 1000,
                FirstName = "Navya",
                LastName = "Nagaraju",
                Gender = "F",
                Salary = 30000,
                JoinDate = DateTime.Now,
                StateId = 1
            });

            employees.Add(new Employee
            {
                Id = 1000,
                FirstName = "Madhu",
                LastName = "Nagaraju",
                Gender = "M",
                Salary = 40000,
                JoinDate = DateTime.Now,
                StateId = 2
            });

            employees.Add(new Employee
            {
                Id = 1000,
                FirstName = "Gowthami",
                LastName = "Nagaraju",
                Gender = "F",
                Salary = 50000,
                JoinDate = DateTime.Now.AddDays(-20),
                StateId = 3
            });

            employees.Add(new Employee
            {
                Id = 1000,
                FirstName = "Balaram",
                LastName = "Nagaraju",
                Gender = "M",
                Salary = 60000,
                JoinDate = DateTime.Now.AddDays(-30),
                StateId = 4
            });

            employees.Add(new Employee
            {
                Id = 1000,
                FirstName = "Radhika",
                LastName = "Kunamneni",
                Gender = "F",
                Salary = 30000,
                JoinDate = DateTime.Now.AddDays(-10),
                StateId = 5
            });

            return employees;

        }
        public DateTime GetMaxSalary()
        {
            var employees = GetEmployees();
            var response = employees.Min(x => x.JoinDate);
            return response;
        }

        public List<Employee> SortEmployees(bool value)
        {
            if (value)
            {
                return GetEmployees().OrderBy(x => x.FirstName).ToList();
            }

            return GetEmployees().OrderByDescending(x => x.FirstName).ToList();
        }


        public Employee GetEmployee()
        {
            //Throws exception when more than one element exists.
            return GetEmployees().SingleOrDefault(x => x.Id == 1000);
        }

    
    }
}

