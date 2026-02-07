using System;
namespace HelpDesk;

public class Tecnico : Usuario
{
    // Declaração de métodos
    public string mudarStatus;
    public string matricula;


    public string MudarStatus
    {
        get { return mudarStatus; }
        set { mudarStatus = value; }
    }

    public string matriculaTecnico
    {
        get { return matricula; }
        set { matricula = value; }
    }


    public Tecnico(int id, string nome, string email, string mudarStatus, string matriculaTecnico) : base(id, nome, email)
    {
        this.mudarStatus = mudarStatus;
        this.matricula = matriculaTecnico;
    }

    public new void ExibirDados()
    {
        base.ExibirDados();
        Console.WriteLine($"Mudar Status: {mudarStatus}");
        Console.WriteLine($"Matrícula: {matricula}");
    }
}