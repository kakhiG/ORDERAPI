using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrderApi.Data.Repository;
using OrderApi.Domain;

namespace OrderApi.Service.Command
{
    public class OrderCommandHandler : IRequestHandler<OrderCommand, Order>
    {
        private readonly IOrderRepository _orderRepository;

        public OrderCommandHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> Handle(OrderCommand request, CancellationToken cancellationToken)
        {
            return await _orderRepository.UpdateAsync(request.Order);
        }
    }
}