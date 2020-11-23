using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebDb1.Data;
using WebDb1.Models;
using WebDb1.Repositories;
using System.Web;
using System.Data;
using WebDb1;
using Microsoft.AspNetCore.Identity;

namespace WebDb1.Controllers
{
    
    public class EmployeesController : Controller
    {
        private IEmployeeRepository EmployeeRepository;
        //private readonly ApplicationDbContext _context;

        //public EmployeesController()
        //{

        //}

        public EmployeesController(IEmployeeRepository EmployeeRepository)
        {
            this.EmployeeRepository = new EmployeeRepository(new ApplicationDbContext());
            this.EmployeeRepository = EmployeeRepository;
        }

        //
        // GET: /Employee/

        public ViewResult Index()
        {

            //check privilages then assign searchstring
            //var searchString = "";
            //searchString = User.Identity.Name.ToString();
            //var search = "";
            //if (searchString.Contains("Employee"))
            //{
            //    for(int i =0; i< searchString.Length; i++)
            //    {
            //        if (Char.IsDigit(searchString[i]))
            //            search += searchString[i];
            //    }

            //}
            //else
            //{
            //    Response.Redirect("/Home");
            //}
            //var userrole = "Manager";
            //if (User.IsInRole("Admin"))
            //    userrole = "Admin";
            //if (User.IsInRole("Manager"))
            //    userrole = "Manager";
            //if (User.IsInRole("User"))
            //    userrole = "User";

            int search = -1;
            var userrole = "Manager";
            if(User.Identity.IsAuthenticated)
            {
                userrole = "Manager";
                search = 2;
            }
            ViewBag.CurrentFilter = search;

            var Employees = from s in EmployeeRepository.GetEmployees()
                            select s;
            
                Employees = Employees.Where(s => s.AccessLevel.ToUpper().Contains(userrole.ToUpper())
                                       || s.EmployeeNum.Equals(search));
            

            return View(Employees);
        }

        //
        // GET: /Employee/Details/5

        public ViewResult Details(int id)
        {
            Employee Employee = EmployeeRepository.GetEmployeeByID(id);
            return View(Employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
           [Bind("EmployeeNum , Department , JobRole , BusinessTravel,EmployeeCount ,Attrition ,WorkLifeBalance ,PerformanceRating ,AccessLevel")]
           Employee Employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeRepository.InsertEmployee(Employee);
                    EmployeeRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(Employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id)
        {
            Employee Employee = EmployeeRepository.GetEmployeeByID(id);
            return View(Employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit([Bind("Id,EmployeeNumber,Age,DistanceFromHome,Gender,MartialStatus,Over18,RelationshipSatisfacion,AccessLevel")] Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    EmployeeRepository.UpdateEmployee(employee);
                    EmployeeRepository.Save();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                ModelState.AddModelError(string.Empty, "Unable to save changes. Try again, and if the problem persists contact your system administrator.");
            }
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(bool? saveChangesError = false, int id = 0)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }
            Employee Employee = EmployeeRepository.GetEmployeeByID(id);
            return View(Employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                Employee Employee = EmployeeRepository.GetEmployeeByID(id);
                EmployeeRepository.DeleteEmployee(id);
                EmployeeRepository.Save();
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name after DataException and add a line here to write a log.
                return RedirectToAction("Delete", new { id = id, saveChangesError = true });
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            EmployeeRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}