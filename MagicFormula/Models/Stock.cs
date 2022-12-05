namespace MagicFormula.Models;

public class Stock
{
    public int companyId { get; set; }
    public string companyName { get; set; }
    public string ticker { get; set; }
    public double price { get; set; }
    public double p_L { get; set; }
    public double dy { get; set; }
    public double p_VP { get; set; }
    public double p_Ebit { get; set; }
    public double p_Ativo { get; set; }
    public double eV_Ebit { get; set; }
    public double margemBruta { get; set; }
    public double margemEbit { get; set; }
    public double margemLiquida { get; set; }
    public double p_SR { get; set; }
    public double p_CapitalGiro { get; set; }
    public double p_AtivoCirculante { get; set; }
    public double giroAtivos { get; set; }
    public double roe { get; set; }
    public double roa { get; set; }
    public double roic { get; set; }
    public double dividaliquidaPatrimonioLiquido { get; set; }
    public double dividaLiquidaEbit { get; set; }
    public double pl_Ativo { get; set; }
    public double passivo_Ativo { get; set; }
    public double liquidezCorrente { get; set; }
    public double peg_Ratio { get; set; }
    public double receitas_Cagr5 { get; set; }
    public double lucros_Cagr5 { get; set; }
    public double liquidezMediaDiaria { get; set; }
    public double vpa { get; set; }
    public double lpa { get; set; }
    public double valorMercado { get; set; }
}