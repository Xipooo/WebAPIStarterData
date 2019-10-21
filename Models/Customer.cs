using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPIStarterData.Models
{
    public class Customer
    {
        public long Id { get; set; }

        [MaxLength(25)]
        public string FirstName { get; set; }

        [MaxLength(25)]
        public string LastName { get; set; }
        public string Email { get; set; }

        public IList<CustomerAddress> CustomerAddresses { get; set; }
    }
}