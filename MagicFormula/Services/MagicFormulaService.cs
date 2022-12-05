using MagicFormula.Models;

namespace MagicFormula.Services;

public class MagicFormulaService
{
    public List<ScoredStock> OrderStocks(List<Stock> stocks)
    {
        var stocksCopy = new List<Stock>(stocks);
        stocksCopy = stocksCopy.Where(a => a.p_L > 0 && a.roe is > 0 and < 100).ToList();
        var stocksOrdenated = stocksCopy.OrderByDescending(a => a.roe).Select((a, i) =>
        {
            var scored = new ScoredStock(a)
            {
                RentabilidadeRanking = i + 1
            };
            return scored;
        }).ToList();
        
        stocksOrdenated = stocksOrdenated.OrderBy(a => a.p_L).Select((a, i) =>
        {
            a.PrecoRanking = i + 1;
            a.PosicaoFinal = a.PrecoRanking + a.RentabilidadeRanking;
            return a;
        }).ToList();
        return stocksOrdenated.OrderBy(a => a.PosicaoFinal).ToList();
    }
}