using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraphQLApi.Models;

public class Invoice
{
    protected Invoice() { }

    public Invoice(string invoiceNumber, decimal grossValue, decimal netValue, DateTime invoiceDate, Guid customerId)
    {
        Id = Guid.NewGuid();
        InvoiceNumber = invoiceNumber;
        GrossValue = grossValue;
        NetValue = netValue;
        InvoiceDate = invoiceDate;
        CustomerId = customerId;
    }

    [Key]
    public Guid Id { get; private set; }

    [Required(ErrorMessage = "Invoice Number is required")]
    public string InvoiceNumber { get; private set; }

    [Required(ErrorMessage = "Gross Value is required")]
    public decimal GrossValue { get; private set; }

    [Required(ErrorMessage = "Net Value is required")]
    public decimal NetValue { get; private set; }

    [Required(ErrorMessage = "Invoice Date is required")]
    public DateTime InvoiceDate { get; private set; }

    [ForeignKey("CustomerId")]
    public Guid CustomerId { get; private set; }
    public Customer Customer { get; private set; }
}

