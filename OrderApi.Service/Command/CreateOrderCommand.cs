using MediatR;
using OrderApi.Domain;

namespace OrderApi.Service.Command
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public Order Order { get; set; }
    }
}
