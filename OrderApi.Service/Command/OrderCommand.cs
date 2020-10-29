using MediatR;
using OrderApi.Domain;

namespace OrderApi.Service.Command
{
   public class OrderCommand : IRequest<Order>
    {
        public Order Order { get; set; }
    }
}
