using System;
using System.Diagnostics;
using MediatR;
using OrderApi.Service.Command;
using OrderApi.Service.Models;
using OrderApi.Service.Query;

namespace OrderApi.Service.Services
{
    public class CustomerNameUpdateService : ICustomerNameUpdateService
    {
        private readonly IMediator _mediator;

        public CustomerNameUpdateService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async void UpdateCustomerNameInOrders(UpdateCustomerNameModel updateCustomerFullNameModel)
        {
            try
            {
                var ordersOfCustomer = await _mediator.Send(new GetOrderByCustomerGuidQuery
                {
                    CustomerId = updateCustomerFullNameModel.Id
                });

                if (ordersOfCustomer.Count != 0)
                {
                    ordersOfCustomer.ForEach(x => x.CustomerName = $"{updateCustomerFullNameModel.FirstName} {updateCustomerFullNameModel.LastName}");
                }

                await _mediator.Send(new UpdateOrderCommand
                {
                    Orders = ordersOfCustomer
                });
            }
            catch (Exception ex)
            {
               // log an error message here

               Debug.WriteLine(ex.Message);
            }
        }
    }
}