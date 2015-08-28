﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test1.DataAccessLayer;

namespace Test1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            var salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();
        }

        public Employee SaveEmployee(Employee e)
        {
            var salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }

        public UserStatus GetUserValidity(UserDetails u)
        {
            if (u.UserName == "Admin" && u.Password == "Admin")
            {
                return UserStatus.AuthenticatedAdmin;
            }
            return u.UserName == "Sukesh" && u.Password == "Sukesh" ? UserStatus.AuthentucatedUser : UserStatus.NonAuthenticatedUser;
        }
    }
}