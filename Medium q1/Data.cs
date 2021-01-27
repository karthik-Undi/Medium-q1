using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_q1
{
    class Data
    {
        public static Dictionary<int, Employee> Employees = new Dictionary<int, Employee>();

        public static void DisplayData()
        {
            Console.WriteLine("----------Please enter the employee ID----------");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Employees[key]);
        }
    }
}
