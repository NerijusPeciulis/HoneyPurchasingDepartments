using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HoneyPurchasingDepartments.Models
{
    public class Buyer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Adress { get; set; }
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public List <Client> Clients { get; set; }

        public Buyer(string name, string adress, string email, int phoneNumber)
        {
            Name = name;
            Adress = adress;
            Email = email;
            PhoneNumber = phoneNumber;
            Clients = new List<Client>();
        }
    }
}
