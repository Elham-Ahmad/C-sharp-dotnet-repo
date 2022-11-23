using DapperCRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace DapperCRUD.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly EmployeeRepository employeeRepository;

        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }



        //Get All
        [HttpGet]
        [Route("Get")]
        public IEnumerable<Employee> GetAll()
        {
            return employeeRepository.GetAll();
        }

        //Get By Id 
        [HttpGet]
        [Route("Get/{id}")]
        public Employee GetById(int id)
        {
            return (Employee)employeeRepository.GetById(id);
        }

        // Insert 
        [HttpPost]

        public void Post([FromBody]Employee employee)
        {
            if (ModelState.IsValid)
                employeeRepository.Add(employee);
        }

        //update 

        [HttpPut("/{id}")]

        public void Put(int id , [FromBody] Employee employee)
        {
            employee.Id = id;

            if (ModelState.IsValid)
                employeeRepository.Update(employee);
        }


        //Delete

        [HttpDelete]

        public void Delete(int id)
        {
          
                employeeRepository.Delete(id);
        }

    }
}
