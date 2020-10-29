using System;
using MediatR;
using OrderApi.Domain;

namespace OrderApi.Service.Query
{
   public class GetOrderByIdQuery : IRequest<Order>
    {
        public Guid Id { get; set; }
    }
}
