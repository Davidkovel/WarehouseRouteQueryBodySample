using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WarehouseRouteQueryBodySample.Pages.Products;

public class Details : PageModel
{
    public string BodyContent { get; set; }
    public Product? Product { get; set; }
    
    public void OnGet()
    {
        var routId = Request.RouteValues["id"];
        var mode = Request.RouteValues["mode"];
        var showReviews = Request.RouteValues["showReviews"];
    }

    public async Task OnPost()
    {
        using var reader = new StreamReader(Request.Body, Encoding.UTF8);
        BodyContent = await reader.ReadToEndAsync();
        var headers = Request.Headers;
        
    }
}