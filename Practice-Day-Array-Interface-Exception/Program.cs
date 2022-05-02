using Practice_Day_Array_Interface_Exception.CustomException;
using Practice_Day_Array_Interface_Exception.Models;
using System;

namespace Practice_Day_Array_Interface_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region Employees

                Employee employee1 = new Employee("Loghman", 20, 350.31);

                Employee employee2 = new Employee("Yusif", 21, 289.00);

                Employee employee3 = new Employee("Murad", 20, 150.69);

                Employee employee4 = new Employee("Elon", 27, 1500.69);

            #endregion

            #region Departments


                Department department = new Department("Software Development", 3);

            try
            {
                department.AddEmployee(employee1);
                department.AddEmployee(employee2);
                department.AddEmployee(employee3);
                ////also run the program enabling the following line of code to see thrown exception.
                //department.AddEmployee(employee4);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            #endregion

        }
    }
}
