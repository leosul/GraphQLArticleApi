using GraphQLApi.Models;

namespace GraphQLApi.Interfaces;

public interface ICustomerService
{
    /*ADD*/
    Task<Customer> AddCustomerAsync(Customer customer);
    Task<Customer> AddInvoiceAsync(Invoice invoice);

    /*FIND*/
    Task<IEnumerable<Customer>> FindAllCustomersAsync();
    Task<Customer> FindCustomerByIdAsync(Guid id);
    Task<IEnumerable<Customer>> FindCustomersByNameAsync(string name);

    /*EDIT*/
    Task<Customer> UpdateCustomerAsync(Customer customer);

    /*DELETE*/
    Task<Customer> RemoveCustomerByIdAsync(Guid id);
}
