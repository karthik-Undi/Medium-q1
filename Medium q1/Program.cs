using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_q1
{

    class Program
    {
        static int jeep;
        static void Main(string[] args)
        {
            
            List<EmployeePromotion> Elist = new List<EmployeePromotion>();
            for (; ; )
            {
                int id, age;
                string name;
                double salary;
                Console.WriteLine("Please enter the employee ID");
                id = Convert.ToInt32(Console.ReadLine());
                if (Data.Employees.ContainsKey(id))
                {
                    Console.WriteLine("Duplicate Employee ID!!!\nTry again ! ");

                }
                else
                {
                    Console.WriteLine("Please enter the employee name");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter the employee age");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the employee salary");
                    salary = Convert.ToDouble(Console.ReadLine());

                    Elist.Add(new EmployeePromotion(id, age, name, salary));

                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                        continue;
                    else if (choice == 0)
                    {
                        Data.DisplayData();
                        break;
                    }
                        
                    else
                        Console.WriteLine("Wrong input ");

                }
                


            }            
            
            
            Console.ReadKey();

        }
    }
}
