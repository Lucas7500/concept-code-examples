using SpecificationPattern.Models;

namespace SpecificationPattern.Contracts
{
    internal interface ICustomerService
    {
        void ReleaseCreditLimit(Customer customer);
    }
}
