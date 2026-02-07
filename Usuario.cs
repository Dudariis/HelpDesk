using System;
namespace HelpDesk;

public abstract class Usuario
{
    // Declaração de métodos
    public int id;
    public string nome;
    public string email;
    

    public int Id 
    { 
        get { return id; } 
        set { id = value; } 
    }

    public string Email 
    { 
        get { return email; } 
        set { email = value; } 
    }

    public string Nome
    {
        get { return nome;}
        set { nome = value;}
    }

    public Usuario(int id, string nome, string email)
    {
        this.id = id;
        this.nome = nome;
        this.email = email;
    }

    public void ExibirDados()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
    }
}