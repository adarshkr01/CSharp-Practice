using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharpPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2000, 02, 01);
            DateTime dt2 = new DateTime(2021, 07, 21);
            Console.WriteLine(DateTime.Today);

            TimeSpan ts = dt2 - dt;
            Console.WriteLine(ts.TotalHours);

            List<Employees> employees = new List<Employees>()
            {
                new Employees() { Id = 1, Name = "Mike", Salary = 50000, Years = 2, DepId = 1 },
                new Employees() { Id = 2, Name = "John", Salary = 40000, Years = 7, DepId = 2 },
                new Employees() { Id = 3, Name = "Denish", Salary = 45000, Years = 5, DepId = 1 },
                new Employees() { Id = 4, Name = "Loki", Salary = 74000, Years = 1, DepId = 3 },
                new Employees() { Id = 5, Name = "Thor", Salary = 85000, Years = 0, DepId = 3 },
                new Employees() { Id = 5, Name = "Thor", Salary = 85000, Years = 0, DepId = 5 }
            };

            List<Department> departments = new List<Department>()
            {
                new Department() { Id = 1, Name = "HR"},
                new Department() { Id = 2, Name = "Managerial"},
                new Department() { Id = 3, Name = "Dev"}
            };

            var devGuys = from e in employees
                          join d in departments
                          on e.DepId equals d.Id into JoinGroup
                          from jg in JoinGroup.DefaultIfEmpty()
                          select new 
                          { 
                              EmpName = e.Name,
                              Dept = (jg == null) ? "NULL" : jg.Name 
                          };

            var depGuys = from e in employees
                          join d in departments
                          on e.DepId equals d.Id into groupGuys
                          from gg in groupGuys.DefaultIfEmpty()
                          select new
                          {
                              Name = (e == null) ? "NULL" : e.Name,
                              Dept = gg.Name
                          };

            foreach (var d in devGuys)
            {
                Console.WriteLine(d.EmpName + " " + d.Dept);
            }

            //foreach (Employees employee in employees)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Years: {3}",
            //        employee.Id, employee.Name, employee.Salary, employee.Years);
            //}

            //IEnumerable<Employees> newSalary = from e in employees
            //                                   where e.Salary >= 50000
            //                                   orderby e.Salary descending
            //                                   select e;

            //IEnumerable<string> newsal = employees.Where(e => e.Salary >= 50000)
            //                                .Select(e => e.Name);

            //foreach (var employee in newSalary)
            //{
            //    Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, Years: {3}",
            //        employee.Id, employee.Name, employee.Salary, employee.Years);
            //}
        }
    }
}
