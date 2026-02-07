using System;
namespace HelpDesk;

public class Chamado : HistoricoChamada
{
    public int id;
    public string descricao;
    public string status;
    public int idCliente;
    public int idTecnico;
    public int categoria;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Descricao
    {
        get { return descricao; }
        set { descricao = value; }
    }

    public string Status
    {
        get { return status; }
        set { status = value; }
    }

    public int IdCliente
    {
        get { return idCliente; }
        set { idCliente = value; }
    }

    public int IdTecnico
    {
        get { return idTecnico; }
        set { idTecnico = value; }
    }

    public int Categoria
    {
        get { return categoria; }
        set { categoria = value; }
    }

    public Chamado(int id, string descricao, string status, int idCliente, int idTecnico, int categoria) : base ( "registro", descricao, DateTime.Now)
    {
        this.id = id;
        this.descricao = descricao;
        this.status = status;
        this.idCliente = idCliente;
        this.idTecnico = idTecnico;
        this.categoria = categoria;
    }
}