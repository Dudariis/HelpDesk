using System;
namespace HelpDesk;

public class Cliente : Usuario
{
    public string abrirChamado;
    public string visualizarStatus;


    public string AbrirChamado
    {
        get { return abrirChamado; }
        set { abrirChamado = value; }
    }

    public string VisualizarStatus
    {
        get { return visualizarStatus; }
        set { visualizarStatus = value; }
    }

    public Cliente(int id, string nome, string email, string telefone, string abrirChamado, string visualizarStatus) : base(id, nome, email)
    {
        this.abrirChamado = abrirChamado;
        this.visualizarStatus = visualizarStatus;
    }

    public new void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Abrir Chamado: {abrirChamado}");
        Console.WriteLine($"Visualizar Status: {visualizarStatus}");
    }
}