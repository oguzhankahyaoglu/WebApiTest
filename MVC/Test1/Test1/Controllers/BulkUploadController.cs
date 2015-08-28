using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Filters;
using Test1.Models;
using Test1.ViewModels;

namespace Test1.Controllers
{
    public class BulkUploadController : Controller
    {
        [HeaderFooterFilter]
        [AdminFilter]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }

        public ActionResult Upload(FileUploadViewModel model)
        {
            var employees = GetEmployees(model);
            var bal = new EmployeeBusinessLayer();
            bal.UploadEmployees(employees);
            return RedirectToAction("Index", "Employee");
        }

        private List<Employee> GetEmployees(FileUploadViewModel model)
        {
            var employees = new List<Employee>();
            using (var reader = new StreamReader(model.fileUpload.InputStream))
            {
                reader.ReadLine(); //assuming first line is header
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var e = new Employee { FirstName = values[0], LastName = values[1], Salary = int.Parse(values[2]) };
                    employees.Add(e);
                }
            }
            return employees;
        }
    }
}