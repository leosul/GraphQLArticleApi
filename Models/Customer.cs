using GraphQLApi.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GraphQLApi.Models;

public class Customer : IAggregateRoot
{
    protected Customer() { }

    public Customer(string name, bool isActive)
    {
        Id = Guid.NewGuid();
        Name = name;
        IsActive = isActive;
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }

    public void AddInvoice(ICollection<Invoice> invoices) => Invoices = invoices;

    public void Update(string name, bool isActive)
    {
        Name = name;
        IsActive = isActive;
    }

    [Key]
    public Guid Id { get; private set; }

    [Required(ErrorMessage = "Name is required")]
    public string Name { get; private set; }
    public bool IsActive { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }

    /*EF Relation*/
    public ICollection<Invoice> Invoices { get; private set; }
}

