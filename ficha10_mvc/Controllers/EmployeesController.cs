using Microsoft.AspNetCore.Mvc;
using ficha10.Controllers;
using System.Net.Mime;
using System.Text.Json;
using ficha10;
using ficha10_mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ficha10.Controllers
{
    [Route("[controller]")] //here is the indication of the path
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        
        private readonly IEmployees employees;

        /*public EmployeesController()
        {

            employees = JsonLoader.LoadEmployees();
        }*/

        public EmployeesController(IEmployees employees)
        {
            this.employees = employees;
        }

      


        // GET: api/<ValuesController>       
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees.EmployeesList;
        }
        
        // POST api/<ValuesController>
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)] //we can call whatever we want ex: a pdf, an image, a zip
        [ProducesResponseType(StatusCodes.Status201Created)] //type of result we want to produce, here is: create something
        [ProducesResponseType(StatusCodes.Status400BadRequest)] //here we want to produce also an eror response

        public IActionResult Post([FromBody] Employee emp)
        {

            if (employees.EmployeesList.Count == 0)
            {
                emp.UserId = 1;
                employees.EmployeesList.Add(emp);
            }
            else
            {
                var lastEmployee = employees.EmployeesList.LastOrDefault(); 
                emp.UserId = lastEmployee.UserId + 1;
                employees.EmployeesList.Add(emp);
            }
            return Ok(emp);

        }
            
        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Delete (int id)
        {
            int removed = employees.EmployeesList.RemoveAll(e => e.UserId == id);
            if (removed == 0)
            {
                return NotFound(String.Format("Id {0} was not found", id));

            }
            else
            {
                return Ok(String.Format("Employee with this id {0} was deleted", id));

            }

        }



        // GET api/<ValuesController>/5

        [HttpGet("{id}", Name ="GetById")]
        [ProducesResponseType(StatusCodes.Status200OK, Type=typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetById (int id)
        {
           Employee? emp = employees.EmployeesList.Find(c => c.UserId == id);
            if (emp == null)
            {
                return NotFound(String.Format("Id {0} was not found", id));
            }
            else
            {
                return Ok(emp);
            }
            
        }

        

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Employee))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Put(int id, Employee empFromBody)
        {
            Employee? employee = employees.EmployeesList.Find(ch => ch.UserId == id);
            if (employees.EmployeesList.Count == 0)
            {
                return NotFound(String.Format("Id {0} was not found", id));
            }
            else
            {
                employee.FirstName = empFromBody.FirstName;
                employee.LastName = empFromBody.LastName;
                employee.EmployeeCode = empFromBody.EmployeeCode;
                employee.Region = empFromBody.Region;
                employee.PhoneNumber = empFromBody.PhoneNumber;
                employee.EmailAddress = empFromBody.EmailAddress;


                return Ok(String.Format("Character with id {0} was updated to {1}", id, empFromBody));
            }

        }

        // GET api/<ValuesController>/5

        [HttpGet("region/{region}", Name = "GetByRegion")] //name tem de ser igual
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetByRegion(string region)
        {
            List<Employee> EmployeesList = employees.EmployeesList.FindAll(r => r.Region == region);
            if (EmployeesList.Count == 0)
            {
                return NotFound(String.Format("Id {0} was not found", region));
            }
            else
            {
                return Ok(EmployeesList);
            }

        }

       /*[HttpGet("/download", Name = "Download")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult Download()
        {
            string emplooyee = JsonSerializer.Serialize(employees.EmployeesList); //serialize as normal into a string
            System.IO.File.WriteAllText("./Characteres.json", emplooyee); //gets the class file of the System IO(namespace)

            try
            {
                byte[] bytes = System.IO.File.ReadAllBytes("employeesList.json");
                return File(bytes, "application/json", "employeesList.json");
            }
            catch (FileNotFoundException e)
            {
                return NotFound(e.Message);
            }


        }*/


    }
}
