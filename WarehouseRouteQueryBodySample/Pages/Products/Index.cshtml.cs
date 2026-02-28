using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WarehouseRouteQueryBodySample.Pages.Products;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public List<Product> Products { get; set; } = new();

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Products = new List<Product>
        {
            new Product { Id = 1, Name = "Pizza", Price = 10 },
            new Product { Id = 2, Name = "Bacon", Price = 20 },
            new Product { Id = 3, Name = "Pizza", Price = 30 }
        };
    }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
}