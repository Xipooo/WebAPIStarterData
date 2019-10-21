namespace WebAPIStarterData.Models
{
    public class CustomerAddress
    {
        public long CustomerId { get; set; }
        public Customer Customer { get; set; }
        public long AddressId { get; set; }
        public Address Address { get; set; }
    }
}