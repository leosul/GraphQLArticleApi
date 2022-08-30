using Bogus;
using GraphQLApi.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLApi.Data.Seeders;

public class DbInitializer
{
    private readonly ModelBuilder _modelBuilder;
    public DbInitializer(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        var customers = new Faker<Customer>("pt_PT")
            .StrictMode(false)
            .CustomInstantiator(s => new Customer("", false))
            .RuleFor("Id", s => s.Random.Guid())
            .RuleFor("Name", s => s.Name.FullName())
            .RuleFor("IsActive", s => s.Random.Bool())
            .Generate(50);

        _modelBuilder.Entity<Customer>().HasData(customers);

        var invoices = new Faker<Invoice>("pt_PT")
            .StrictMode(false)
            .CustomInstantiator(s => new Invoice("", 0, 0, DateTime.Now, Guid.NewGuid()))
            .RuleFor("Id", s => s.Random.Guid())
            .RuleFor("InvoiceNumber", s => s.Random.AlphaNumeric(8).ToUpper())
            .RuleFor("GrossValue", s => Math.Round(s.Random.Decimal(15), 2))
            .RuleFor("NetValue", s => Math.Round(s.Random.Decimal(8)))
            .RuleFor("InvoiceDate", s => s.Date.Past(3))
            .RuleFor("CustomerId", f => f.PickRandom(customers).Id)
            .Generate(300);

        _modelBuilder.Entity<Invoice>().HasData(invoices);
    }
}
