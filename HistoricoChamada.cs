using System;
namespace HelpDesk;

public class HistoricoChamada
{
    public string registro;
    public string descricao;
    public DateTime dataRegistro;

    public string Registro
    {
        get { return registro; }
        set { registro = value; }
    }

    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }


    public DateTime DataRegistro
    {
        get { return dataRegistro; }
        set { dataRegistro = value; }
    }

    public HistoricoChamada(string registro, string descricao, DateTime dataRegistro)
    {
        this.registro = registro;
        this.descricao = descricao;
        this.dataRegistro = dataRegistro;
    }
}