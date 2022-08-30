namespace GraphQLApi.ViewModels;

public class CustomerViewModel
{
    public string Name { get; set; }
    public bool IsActive { get; set; }
    public ICollection<InvoiceViewModel> Invoices { get; set; }
}
