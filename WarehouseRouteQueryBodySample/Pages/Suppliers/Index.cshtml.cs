using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WarehouseRouteQueryBodySample.Pages.Suppliers;

public class Index : PageModel
{
    public List<Supplier>? Suppliers { get; private set; }
    
    public void OnGet()
    {
        Suppliers = new List<Supplier>()
        {
            new Supplier {Id = 1, Name = "Apples"},
            new Supplier {Id = 2, Name = "Milk"},
            new Supplier {Id = 3, Name = "Bacon"},
        };

    }
}

public class Supplier
{
    public int Id { get; set; }
    public string Name { get; set; }
}