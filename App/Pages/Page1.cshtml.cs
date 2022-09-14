using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace test_actions.Pages;

public class Page1Model : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public Page1Model(ILogger<IndexModel> logger)
    {
        _logger = logger;

        Property1 = "あいうえお";
    }

    public string Property1 { get; set; } = string.Empty;
}
