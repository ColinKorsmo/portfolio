using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using final_project.Models;

namespace final_project.Pages;

public class IndexModel : PageModel
{
    private readonly FinalProjectDbContext _context;
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(FinalProjectDbContext context, ILogger<IndexModel> logger)
    {
        _context = _context;
        _logger = logger;
    }

    public void OnGet()
    {

    }
}
