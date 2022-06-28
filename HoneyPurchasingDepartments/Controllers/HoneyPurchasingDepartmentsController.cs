using HoneyPurchasingDepartments.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HoneyPurchasingDepartments.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoneyPurchasingDepartmentsController : ControllerBase
    {
        [Route("[Controller]")]

        [HttpPost]
        public void CreateDepartment(string country)
        {
            var result = new Department();
            result.CreateDepartment(country);
        }
    }
}
