using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebAPIProject.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [Route("employees/all")]
        public string GetAllEmployees()
        {
            return "All Employees";
        }

        [Route("employees/{id:int}")]
        public string GetEmployeeById(int id)
        {
            return "Employee Id: " + id;
        }

        [Route("emps/{id:int}")]
        public string GetEmployeeDetails(int id)
        {
            return "Employee Details: " + id;
        }

        [Route("emps/{name:alpha}")]
        public string GetEmployeeDetails(string name)
        {
            return "Employee Details: " + name;
        }
    }
}
