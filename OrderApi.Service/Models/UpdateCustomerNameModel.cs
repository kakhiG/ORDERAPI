using System;

namespace OrderApi.Service.Models
{
    public class UpdateCustomerNameModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
