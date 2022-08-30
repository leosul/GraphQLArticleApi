namespace GraphQLApi.ViewModels;

public class InvoiceViewModel
{
    public string InvoiceNumber { get; set; }

    public decimal GrossValue { get; set; }

    public decimal NetValue { get; set; }

    public DateTime InvoiceDate { get; set; }

    public Guid CustomerId { get; set; }
}
