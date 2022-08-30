using GraphQLApi.Data;
using GraphQLApi.Interfaces;
using GraphQLApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLApi.Services;

public class CustomerService : ICustomerService
{
    private readonly CustomerDbContext _context;

    public CustomerService(CustomerDbContext context)
    {
        _context = context;
    }

    //ADD
    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();

        return customer;
    }

    public async Task<Customer> AddInvoiceAsync(Invoice invoice)
    {
        await _context.Invoices.AddAsync(invoice);
        await _context.SaveChangesAsync();

        return await _context.Customers.AsNoTracking().Include(s => s.Invoices).AsNoTracking().FirstOrDefaultAsync(s => s.Id == invoice.CustomerId);
    }

    //FIND
    public async Task<IEnumerable<Customer>> FindAllCustomersAsync()
    {
        return await _context.Customers.AsNoTracking().Include(s => s.Invoices).AsNoTracking().ToListAsync();
    }
    public async Task<Customer> FindCustomerByIdAsync(Guid id)
    {
        return await _context.Customers.AsNoTracking().Include(s => s.Invoices).AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
    }

    public async Task<IEnumerable<Customer>> FindCustomersByNameAsync(string name)
    {
        return await _context.Customers.AsNoTracking().Include(s => s.Invoices).AsNoTracking().Where(s => s.Name.Contains(name)).ToListAsync();
    }

    //EDIT
    public async Task<Customer> UpdateCustomerAsync(Customer customer)
    {
        _context.Customers.Update(customer);
        await _context.SaveChangesAsync();

        return customer;
    }

    //DELETE
    public async Task<Customer> RemoveCustomerByIdAsync(Guid id)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == id);

        _context.Customers.Remove(customer);
        await _context.SaveChangesAsync();

        return customer;
    }
}
