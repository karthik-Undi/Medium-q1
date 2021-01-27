using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_q1
{
    class EmployeePromotion
    {
        int id, age;
        string name;
        double salary;

        public EmployeePromotion()
        {
        }

        public EmployeePromotion(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
            Console.WriteLine("\nAdding to Dictionary............");
            AddToDictionary(id, age, name, salary);
            
    
        }
        public void AddToDictionary(int a,int b,string c,double d)
        {
            Console.WriteLine("\nChecking for duplicate keys................\n\n");
            if (!Data.Employees.ContainsKey(a))
                Data.Employees.Add(a, new Employee(a, b, c, d));
            else
                Console.WriteLine("Duplicate Employee ID");

        }

    }
}
