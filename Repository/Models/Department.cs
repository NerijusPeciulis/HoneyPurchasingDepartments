using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HoneyPurchasingDepartments.Models
{
    public class Department
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public List <Client> Clients{ get; set; }
        public List <Buyer> Buyers { get; set; }

        public Department(string country)
        {
            Country = country;
            Clients = new List<Client>();
            Buyers = new List<Buyer>();
        }
    }
}
