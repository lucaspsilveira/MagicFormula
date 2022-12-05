namespace MagicFormula.Models;

public class ScoredStock : Stock
{
    public ScoredStock(Stock stock)
    {
        this.companyId = stock.companyId;
        this.companyName = stock.companyName;
        this.ticker = stock.ticker;
        this.price = stock.price;
        this.p_L = stock.p_L;
        this.dy = stock.dy;
        this.p_VP = stock.p_VP;
        this.p_Ebit = stock.p_Ebit;
        this.p_Ativo = stock.p_Ativo;
        this.eV_Ebit = stock.eV_Ebit;
        this.margemBruta = stock.margemBruta;
        this.margemEbit = stock.margemEbit;
        this.margemLiquida = stock.margemLiquida;
        this.p_SR = stock.p_SR;
        this.p_CapitalGiro = stock.p_CapitalGiro;
        this.p_AtivoCirculante = stock.p_AtivoCirculante;
        this.giroAtivos = stock.giroAtivos;
        this.roe = stock.roe;
        this.roa = stock.roa;
        this.roic = stock.roic;
        this.dividaliquidaPatrimonioLiquido = stock.dividaliquidaPatrimonioLiquido;
        this.dividaLiquidaEbit = stock.dividaLiquidaEbit;
        this.pl_Ativo = stock.pl_Ativo;
        this.passivo_Ativo = stock.passivo_Ativo;
        this.liquidezCorrente = stock.liquidezCorrente;
        this.peg_Ratio = stock.peg_Ratio;
        this.receitas_Cagr5 = stock.receitas_Cagr5;
        this.lucros_Cagr5 = stock.lucros_Cagr5;
        this.liquidezMediaDiaria = stock.liquidezMediaDiaria;
        this.vpa = stock.vpa;
        this.lpa = stock.lpa;
        this.valorMercado = stock.valorMercado;
    }
    public int RentabilidadeRanking { get; set; }
    public int PrecoRanking { get; set; }
    public int PosicaoFinal { get; set; }
}