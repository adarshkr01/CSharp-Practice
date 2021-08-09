using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersPractice
{
    public class Company
    {
        List<Employee> employees = new List<Employee>();

        public Company()
        {
            employees.Add(new Employee() { Id = 1, Name = "Mike", Dept = Department.Cloud, Salary = 5000000 });
            employees.Add(new Employee() { Id = 2, Name = "John", Dept = Department.Development, Salary = 4000000 });
            employees.Add(new Employee() { Id = 3, Name = "Kiera", Dept = Department.Marketing, Salary = 850000 });
            employees.Add(new Employee() { Id = 4, Name = "Jack", Dept = Department.Development, Salary = 7000000 });
            employees.Add(new Employee() { Id = 5, Name = "Davy", Dept = Department.Cloud, Salary = 5200000 });
        }

        public string this[int Id]
        {
            get
            {
                return employees.FirstOrDefault(e => e.Id == Id).Name;
            }
            set
            {
                employees.FirstOrDefault(e => e.Id == Id).Name = value;
            }
        }

        public string this[int Id, Department department]
        {
            get
            {
                return employees.FirstOrDefault(e => e.Id == Id && e.Dept == department).Name;
            }
            set
            {
                employees.FirstOrDefault(e => e.Id == Id && e.Dept == department).Name = value;
            }
        }

        public string this[Department department]
        {
            get 
            {
                return employees.FirstOrDefault(e => e.Dept == department).Name;
            }
            set 
            {
                employees.FirstOrDefault(e => e.Dept == department).Name = value;
            }
        }
    }
}
