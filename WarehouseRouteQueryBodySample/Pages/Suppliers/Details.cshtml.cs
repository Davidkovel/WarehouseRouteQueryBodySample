using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WarehouseRouteQueryBodySample.Pages.Suppliers;

public class Details : PageModel
{
    public int Id { get; private set; }
    public string? Mode {get; set;}
    public string? PostResult {get; set;}
    
    public void OnGet(int id, string mode)
    {
        Id = id;
        Mode = mode;
    }

    // public void OnGet(int id, string mode, string postResult)
    // {
    //     Id = id;
    //     Mode = mode;
    //     PostResult = postResult;
    // }

    public void OnPost(int id, string noteText)
    {
        PostResult = noteText;
    }
}