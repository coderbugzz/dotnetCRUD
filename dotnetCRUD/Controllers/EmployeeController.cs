using dotnetCRUD.CRUDService;
using dotnetCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dotnetCRUD.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Read readEmployee = new Read();
            var employees = readEmployee.GetEmployees();

            return View(employees);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Create addEmployee = new Create();
                var employees = addEmployee.AddEmployee(employee);
                return RedirectToAction("Index");
            }
           
            return View(employee);
        }

        public ActionResult Edit(int id)
        {
            Read readEmployee = new Read();
            var employee = readEmployee.GetEmployeeById(id);
            
            return View(employee);
        }
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                Update updateEmployee = new Update();
                updateEmployee.UpdateEmployee(employee);
               return RedirectToAction("Index");
            }
           
            return View(employee);
        }

        public ActionResult Delete(int id)
        {
            Delete deleteEmployee = new Delete();
            deleteEmployee.DeleteEmployee(id);
            return RedirectToAction("Index");

        }

        public ActionResult Details(int id)
        {
            Read readEmployee = new Read();
            var employee = readEmployee.GetEmployeeById(id);
            return View(employee);
        }

    }
}