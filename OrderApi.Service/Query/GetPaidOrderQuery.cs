using System.Collections.Generic;
using MediatR;
using OrderApi.Domain;

namespace OrderApi.Service.Query
{
    public class GetPaidOrderQuery : IRequest<List<Order>>
    {
    }
}