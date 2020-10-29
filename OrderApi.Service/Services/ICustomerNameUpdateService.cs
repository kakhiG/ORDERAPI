using OrderApi.Service.Models;

namespace OrderApi.Service.Services
{
    public interface ICustomerNameUpdateService
    {
        void UpdateCustomerNameInOrders(UpdateCustomerNameModel updateCustomerFullNameModel);
    }
}