using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIStarterData.Models
{
    public class Address
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Line1 { get; set; }

        [MaxLength(100)]
        public string Line2 { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string StateProvince { get; set; }

        [MaxLength(10)]
        public string Zipcode { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        public int AddressTypeId { get; set; }

        [ForeignKey("AddressTypeId")]
        public AddressType AddressType { get; set; }

        public IList<CustomerAddress> CustomerAddresses { get; set; }
    }
}