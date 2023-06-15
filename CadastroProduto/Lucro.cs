using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Net.Http.Headers;
using System.Windows.Forms;

public class Lucro
{
    private double valor;
    private double icms;
    private double confins;
    private double pis;
    private double lucro;
    public string unidade;
    public Lucro(double valor, double icms, double pis, double confins, double lucro)
    {
        this.valor = valor;
        this.icms = icms;
        this.pis = pis;
        this.confins = confins;
        this.lucro = lucro;
    }

    public void SetValor(double valor) 
    {
        this.valor = valor;
    }

    public void SetIcms(double icms)
    {
        this.icms = icms;
    }

    public void SetPis(double pis)
    {
        this.pis = pis;
    }

    public void SetConfins(double confins)
    {
        this.confins = confins;
    }

    public void SetLucro(double lucro)
    {
        this.lucro = lucro;
    }


    public double GetValor()
    {
        return this.valor ;
    }

    public double GetIcms()
    {
        return this.icms;
    }

    public double GetPis()
    {
        return this.pis;
    }

    public double GetLucro()
    {
        return this.lucro;
    }
    public double GetConfins()
    {
        return this.confins;
    }


    public double CalcularImposto(double valor, double icms, double pis, double confins, double lucro)
    {
        double valor2 = (valor * (icms / 100)) + (valor * (pis / 100)) + (valor * (confins / 100));
        valor = valor + valor2;

        lucro = lucro + valor;
        double valorfinal;

        valorfinal = lucro;

        return valorfinal;
    }
}
