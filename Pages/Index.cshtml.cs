﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Quiz1_PBKK_0221.Pages;

public class IndexsModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexsModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        
    }
}
