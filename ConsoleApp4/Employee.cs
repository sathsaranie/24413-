using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public double basicSalary { get; set; }



        public void show()
        {

            Console.WriteLine("name:" + firstName + lastName + "salary:" + basicSalary);
        }
              
    }

}
