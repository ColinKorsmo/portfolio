using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using homework_7_ColinKorsmo.Models;

namespace homework_7_ColinKorsmo.Pages;

public class IndexModel : PageModel
{
    private readonly OrderDbContext _context;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(OrderDbContext context, ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
