using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Model;
using WebAPIDemo.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPIDemo.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeEFController : ControllerBase
    {

        private readonly IEmployeeservice service;

        public EmployeeEFController(IEmployeeservice service)
        {
            this.service = service;
        }

        // GET: api/<BookController/getbooks
        [HttpGet]
        [Route("GetAll")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetAll();
                return new ObjectResult(model);
            }
            catch
            {
                return StatusCode(StatusCodes.Status204NoContent);
            }
        }


        /// delete

        // GET api/book/getbookbyid
        [HttpGet]
        [Route("Get EmployeeById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetEmployeeById(id);
                if (model != null)
                    return new ObjectResult(model);
                else
                    return new ObjectResult(model);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }



        // POST api/<Book/Addbook
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Post([FromBody] Employee employee)
        {
            try
            {
                int result = service.AddEmployee(employee);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status201Created);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }




        //update
        [HttpPut]
        [Route("UpdateEmployee")]
        public IActionResult Put([FromBody] Employee employeeEF)
        {
            try
            {
                int result = service.UpdateEmployee(employeeEF);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status500InternalServerError);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }





        // DELETE api/<EmployeeEFController>/5
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                int result = service.DeleteEmployee(id);
                if (result >= 1)
                {
                    return StatusCode(StatusCodes.Status200OK);
                }
                else
                {
                    return StatusCode(StatusCodes.Status400BadRequest);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
