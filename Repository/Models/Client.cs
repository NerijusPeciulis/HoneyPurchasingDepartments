using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HoneyPurchasingDepartments.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Email { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public List<Buyer> Buyers { get; set; }

        public Client(string name, string surname, string email, string adress, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Adress = adress;
            PhoneNumber = phoneNumber;
            Buyers = new List<Buyer>();
        }

        public Client(string name, string surname, string email, string adress, int phoneNumber, int departmentId)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Adress = adress;
            PhoneNumber = phoneNumber;
            DepartmentId = departmentId;
            Buyers = new List<Buyer>();
        }
    }
}
