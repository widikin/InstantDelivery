﻿using System;
using System.Collections.Generic;
using System.Linq;
using InstantDelivery.Core.Entities;

namespace InstantDelivery.Core.Repositories
{
    public class EmployeeService : IDisposable
    {
        private readonly InstantDeliveryContext context = new InstantDeliveryContext();
        public int Total => context.Employees.Count();

        public IList<Employee> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Reload(Employee employee)
        {
            context.Entry(employee).Reload();
        }

        public void RemoveEmployee(Employee employee)
        {
            context.Employees.Remove(employee);
            context.SaveChanges();
        }

        public IList<Employee> Page(int pageNumber, int pageSize)
        {
            return context.Employees.OrderBy(e => e.EmployeeId)
                                    .Skip(pageSize * (pageNumber - 1))
                                    .Take(pageSize).ToList();
        }

        public void AddEmployee(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

    }
}
