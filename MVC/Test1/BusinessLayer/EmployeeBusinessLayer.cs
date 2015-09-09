using System.Collections.Generic;
using System.Linq;
using BusinessEntities;
using DataAccessLayer;

namespace BusinessLayer
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

        public void UploadEmployees(List<Employee> employees)
        {
            var salesDal = new SalesERPDAL();
            salesDal.Employees.AddRange(employees);
            salesDal.SaveChanges();
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