﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository: IEmployeeRepository
    {
        private List<Employee> _employeeList;
        
        public MockEmployeeRepository() {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Mary", Department = "HR", Email = "mary@gmail.com" },
                new Employee(){ Id = 2, Name = "Mary 2", Department = "IT", Email = "mary2@gmail.com" },
                new Employee(){ Id = 3, Name = "Mary 3", Department = "Admin", Email = "mary3@gmail.com" }
            };

        }

        public Employee GetEmployee(int id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}