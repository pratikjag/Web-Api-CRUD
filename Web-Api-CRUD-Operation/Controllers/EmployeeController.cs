using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_Api_CRUD_Operation.Controllers
{
    public class EmployeeController : ApiController
    {
        DatabaseContext db;
        public EmployeeController()
        {
            db = new DatabaseContext();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return db.Employees.ToList();
        }

        // POST api/Employee
        public IHttpActionResult AddEmployee(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return Created("DefaultApi", employee);
        }
    }
}
