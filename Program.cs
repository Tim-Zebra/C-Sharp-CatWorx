﻿using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
    {
        static void Main(string[] args)
        {
            // This is our employee-getting code now
            List<Employee> employees = GetEmployees();

            // Prints list of employees
            Util.PrintEmployees(employees);
            // Saves list of employees
            Util.MakeCSV(employees);
        }

        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while(true) 
            {
            // Move the initial prompt inside the loop, so it repeats for each employee
            Console.WriteLine("Enter first name (leave empty to exit): ");

            // change input to firstName
            string firstName = Console.ReadLine();
            if (firstName == "") 
            {
                break;
            }

            // add a Console.ReadLine() for each value
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter ID: ");
            int id = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Photo URL:");
            string photoUrl = Console.ReadLine();
            Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
            employees.Add(currentEmployee);
            }

            return employees;
        }
    }
}