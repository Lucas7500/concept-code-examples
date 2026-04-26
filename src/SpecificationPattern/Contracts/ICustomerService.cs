using SpecificationPattern.Models;

namespace SpecificationPattern.Contracts;

/// <summary>
/// Defines the capability of releasing credit limits, abstracted to compare different implementation strategies.
/// </summary>
internal interface ICustomerService
{
    void ReleaseCreditLimit(Customer customer);
}