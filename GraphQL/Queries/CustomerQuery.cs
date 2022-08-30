using GraphQLApi.Data;
using GraphQLApi.Interfaces;
using GraphQLApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLApi.GraphQL.Queries;

public class CustomerQuery
{
    private readonly ICustomerService _customerService;
    public CustomerQuery(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    //FIND
    public async Task<IEnumerable<Customer>> FindAllCustomersAsync()
    {
        return await _customerService.FindAllCustomersAsync();
    }

    [UseDbContext(typeof(CustomerDbContext))]
    [UseOffsetPaging(IncludeTotalCount = true, DefaultPageSize = 10)]
    public IQueryable<Customer> FindAllCustomersPagedAsync([ScopedService] CustomerDbContext context)
    {
        return context.Customers.AsNoTracking();
    }

    public async Task<Customer> FindCustomerByIdAsync(Guid id)
    {
        return await _customerService.FindCustomerByIdAsync(id);
    }
    public async Task<IEnumerable<Customer>> FindCustomersByNameAsync(string name)
    {
        return await _customerService.FindCustomersByNameAsync(name);
    }
}
