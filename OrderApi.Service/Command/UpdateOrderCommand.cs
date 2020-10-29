using System.Collections.Generic;
using MediatR;
using OrderApi.Domain;

namespace OrderApi.Service.Command
{
    public class UpdateOrderCommand : IRequest
    {
        public List<Order> Orders { get; set; }
    }
}