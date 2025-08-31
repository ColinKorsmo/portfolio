using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_3_ColinKorsmo.Pages;
public class TimeModel : PageModel
{
    private readonly ILogger<TimeModel> _logger;
    public string Message {get; set;} = string.Empty;

    public List<int> LuckyNumbers {get; set;} = new List<int>();

    public TimeModel(ILogger<TimeModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        Message = "The current time is: " + DateTime.Now;

        _logger.LogCritical("Page was accessed at " + DateTime.Now);

        LuckyNumbers = new List<int> {3, 15, 33, 62};
    }
}