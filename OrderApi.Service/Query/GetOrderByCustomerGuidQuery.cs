using System;
using System.Collections.Generic;
using MediatR;
using OrderApi.Domain;

namespace OrderApi.Service.Query
{
    public class GetOrderByCustomerGuidQuery : IRequest<List<Order>>
    {
        public Guid CustomerId { get; set; }
    }
}