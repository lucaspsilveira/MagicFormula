using MagicFormula.Models;
using MagicFormula.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MagicFormula.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly StocksDataService _stocksDataService;
    
    public List<Stock> StocksData { get; private set; } = new();
    public List<ScoredStock> ScoredStocksData { get; private set; } = new();
    
    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        _stocksDataService = new StocksDataService();
    }

    public async Task OnGet()
    {
        StocksData = await _stocksDataService.GetStocks();
        var magic = new MagicFormulaService();
        ScoredStocksData = magic.OrderStocks(StocksData);
    }
}