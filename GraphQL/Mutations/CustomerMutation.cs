using GraphQLApi.Interfaces;
using GraphQLApi.Models;
using GraphQLApi.ViewModels;

namespace GraphQLApi.GraphQL.Mutations;

public class CustomerMutation
{
    public async Task<CustomerPayload> AddCustomerAsync(CustomerViewModel customerViewModel, [Service] ICustomerService customerService)
    {
        var customer = new Customer(customerViewModel.Name, customerViewModel.IsActive);

        return new CustomerPayload(await customerService.AddCustomerAsync(customer));
    }

    public async Task<InvoicePayload> AddInvoiceAsync(InvoiceViewModel invoiceViewModel, [Service] ICustomerService customerService)
    {
        var invoice = new Invoice(
            invoiceViewModel.InvoiceNumber,
            invoiceViewModel.GrossValue,
            invoiceViewModel.NetValue,
            invoiceViewModel.InvoiceDate,
            invoiceViewModel.CustomerId);

        return new InvoicePayload(await customerService.AddInvoiceAsync(invoice));
    }

    public async Task<Customer> UpdateCustomerAsync(Guid id, CustomerViewModel customer, [Service] ICustomerService customerService)
    {
        var customerupdate = await customerService.FindCustomerByIdAsync(id);

        customerupdate.Update(customer.Name, customer.IsActive);

        return await customerService.UpdateCustomerAsync(customerupdate);
    }

    public async Task<Customer> DeleteCustomerByIdAsync(Guid id, [Service] ICustomerService customerService)
    {
        var customer = await customerService.FindCustomerByIdAsync(id);

        await customerService.RemoveCustomerByIdAsync(id);

        return customer;
    }

    //Return Payload
    public record CustomerPayload(Customer Record);

    public record InvoicePayload(Customer Record);
}
