using System;
namespace HelpDesk;

public class Categoria
{
    // Declaração de métodos
    public int id;
    public string nome;
    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public Categoria(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
    }
}