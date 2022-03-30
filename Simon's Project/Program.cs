using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon_s_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            Employee a = new Employee { name = "Jane", id = 1, gender = Gender.F };
            Employee b = new Employee { name = "Steve", id = 2, gender = Gender.X };
            Employee c = new Employee { name = "Garry", id = 3, gender = Gender.M };
            Employee d = new Employee { name = "Mia", id = 4, gender = Gender.F };

            employees.Add(a);
            employees.Add(b);
            employees.Add(c);
            employees.Add(d);
            foreach (Employee employ in employees)
            {
                Console.WriteLine(employ);
            }

            List<Employee> employeeGender = FilterByGender(employees, Gender.F);

            foreach (Employee emp in employeeGender)
            {
                Console.WriteLine(emp);
            }
           
        }
        public static List<Employee> FilterByGender(List<Employee> staff, Gender gender)
        {
            List<Employee> employeeGender = new List<Employee>();

            for (int i = 0; i < staff.Count; i++)
            {
                if(staff[i].gender == gender)
                {
                    employeeGender.Add(staff[i]);
                }
            }
            return employeeGender;
        }
        
    }
}
