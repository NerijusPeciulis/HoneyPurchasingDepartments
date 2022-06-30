using HoneyPurchasingDepartments.Models;
using Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class ClientServices
    {
        public void CreateClient(string name, string surname, string email, string adress, int phoneNumber, int departmentId)
        {
            var context = new DepartmentDbContext();
            Client client = new Client(name, surname, email, adress, phoneNumber, departmentId);
            context.Clients.Add(client);
            context.SaveChanges();
        }

        public List<Client> GetClients()
        {
            var context = new DepartmentDbContext();
            var returnData = context.Clients.ToList();
            return returnData;
        }

    }
}
