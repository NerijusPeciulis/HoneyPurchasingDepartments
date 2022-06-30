using Business.Services;
using HoneyPurchasingDepartments.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HoneyPurchasingDepartments.Controllers
{
    [ApiController]
    public class HoneyPurchasingDepartmentsController : ControllerBase
    {
       // [Route("[Controller]")]

        [HttpPost("Create Honey Purschasing Department")]
        public void CreateDepartment(string country)
        {
            var result = new DepartmentServices();
            result.CreateDepartment(country);
        }

        [HttpGet("List of Departments")]

        public List<Department> GetDepartments()
        {
            DepartmentServices department = new DepartmentServices();
            var result = department.GetDepartments();
            return result;
        }

        [HttpPost("Create Buyer and add to Department")]
        public void CreateBuyer(string name, string adress, string email, int phoneNumber, int departmentId)
        {
            var result = new BuyerServices();
            result.CreateBuyer(name, adress, email, phoneNumber, departmentId);
        }

        [HttpGet("List of Buyers")]

        public List<Buyer> GetBuyers()
        {
            BuyerServices buyer = new BuyerServices();
            var result = buyer.GetBuyers();
            return result;
        }

        [HttpPost("Add Buyers to another Department")]

        public void AddBuyerToSpecificDepartment(int departmentId, int buyerId)
        {
            var result = new BuyerServices();
            result.AddBuyerToSpecificDepartment(departmentId, buyerId);
        }

        [HttpPost("Create Department with Buyers and Clients")]
        public void CreateDepartmentWithBuyersAndClients(string departmentCountry, int buyersNumber, int clientsNumber)
        {
            var result = new DepartmentServices();
            result.CreateDepartmentWithBuyersAndClients(departmentCountry, buyersNumber, clientsNumber);
        }

        [HttpPost("Create Client and add to Buyer")]
        public void CreateClient(string name, string surname, string adress, string email, int phoneNumber, int departmentId)
        {
            var result = new ClientServices();
            result.CreateClient(name, surname, adress, email, phoneNumber, departmentId);
        }

        [HttpGet("List of Clients")]
        public List<Client> GetClients()
        {
            ClientServices client = new ClientServices();
            var result = client.GetClients();
            return result;
        }
    }
}
