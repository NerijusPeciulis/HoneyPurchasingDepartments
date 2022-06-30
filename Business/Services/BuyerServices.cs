using HoneyPurchasingDepartments.Models;
using Microsoft.EntityFrameworkCore;
using Repository.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class BuyerServices
    {
        public void CreateBuyer(string name, string adress, string email, int phoneNumber, int departmentId)
        {
            var context = new DepartmentDbContext();
            Buyer buyer = new Buyer(name, adress, email, phoneNumber, departmentId);
            context.Buyers.Add(buyer);
            context.SaveChanges();
        }

        public List<Buyer> GetBuyers()
        {
            var context = new DepartmentDbContext();
            var returnData = context.Buyers.ToList();
            return returnData;
        }

        public void AddBuyerToSpecificDepartment(int departmentId, int buyerId)
        {
            var context = new DepartmentDbContext();
            var department = context.Departments.Where(x => x.Id == departmentId).SingleOrDefault();
            var buyer = context.Buyers.Where(x => x.Id == buyerId).SingleOrDefault();
            department.Buyers.Add(buyer);
            context.SaveChanges();

        }
    }
}
