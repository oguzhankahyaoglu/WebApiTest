using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Filters;
using Test1.Models;
using Test1.ViewModels;

namespace Test1.Controllers
{
    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }

    public class EmployeeController : Controller
    {
        // GET: Test
        [Authorize]
        public ActionResult Index()
        {
            var employeeListViewModel = new EmployeeListViewModel();
            employeeListViewModel.UserName = User.Identity.Name;
            employeeListViewModel.FooterData = new FooterViewModel { CompanyName = "Hostamedia", Year = DateTime.Now.Year.ToString() };

            var empBal = new EmployeeBusinessLayer();
            var employees = empBal.GetEmployees();
            var empViewModels = new List<EmployeeViewModel>();

            foreach (Employee emp in employees)
            {
                var empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary != null ? emp.Salary.Value.ToString("C") : "";
                if (emp.Salary > 15000)
                    empViewModel.SalaryColor = "yellow";
                else
                    empViewModel.SalaryColor = "green";
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            //employeeListViewModel.UserName = "Admin";
            return View("Index", employeeListViewModel);
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address1";
            return c;
        }

        [ChildActionOnly]
        public ActionResult GetAddNewLink()
        {
            if (Convert.ToBoolean(Session["IsAdmin"]))
            {
                return PartialView("AddNewLink");
            }
            return new EmptyResult();
        }

        [AdminFilter]
        public ActionResult AddNew()
        {
            return View("CreateEmployee", new CreateEmployeeViewModel());
        }

        [AdminFilter]
        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                    if (ModelState.IsValid)
                    {
                        var empBal = new EmployeeBusinessLayer();
                        empBal.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        var vm = new CreateEmployeeViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;
                        if (e.Salary.HasValue)
                        {
                            vm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            vm.Salary = ModelState["Salary"].Value.AttemptedValue;
                        }
                        return View("CreateEmployee", vm); // Day 4 Change - Passing e here
                    }
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
    }
}