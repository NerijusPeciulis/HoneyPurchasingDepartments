using HoneyPurchasingDepartments.Models;
using Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class DepartmentServices
    {
        public void CreateDepartment(string country)
        {
            var context = new DepartmentDbContext();
            Department department = new Department(country);
            context.Departments.Add(department);
            context.SaveChanges();
        }

        public List<Department> GetDepartments()
        {
            var context = new DepartmentDbContext();
            var returnData = context.Departments.ToList();
            return returnData;
        }

        public void CreateDepartmentWithBuyersAndClients(string departmentCountry, int buyersNumber, int clientsNumber)
        {
            var context = new DepartmentDbContext();

            List<Buyer> buyers = new List<Buyer>();

            for (int i = 0; i < buyersNumber; i++)
            {
                buyers.Add(new Buyer($"Buyer{i}", $"Adress{i}", $"Email{i}", 860000000+i));
            }

            List<Client> clients = new List<Client>();

            for (int i = 0; i < clientsNumber; i++)
            {
                clients.Add(new Client($"Name{i}", $"Surname{i}", $"Email{i}", $"Adress{i}", 860000001 + i));
            }

            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Buyers.AddRange(buyers);
            }

            context.Departments.Add(new Department(departmentCountry, buyers, clients));
            context.SaveChanges();
        }

        



    }
}
