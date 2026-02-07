using System;
namespace HelpDesk;

class Program
{
    static void Main(string[] args)
    {
        Tecnico tecnico = new Tecnico(1, "João", "Suporte Técnico");
        Cliente cliente = new Cliente(2, "Maria", "Cliente");
        Chamado chamado = new Chamado(1, "Problema com o computador", "Aberto", cliente.Id, tecnico.Id, 1);


        Console.WriteLine("Dados do Técnico:");
        tecnico.ExibirDados();


        Console.WriteLine("\nDados do Cliente:");
        cliente.ExibirDados();

        
        Console.WriteLine("\nDados do Chamado:");
        Console.WriteLine($"ID: {chamado.Id}");
        Console.WriteLine($"Descrição: {chamado.Descricao}");
        Console.WriteLine($"Status: {chamado.Status}");
        Console.WriteLine($"ID do Cliente: {chamado.IdCliente}");
        Console.WriteLine($"ID do Técnico: {chamado.IdTecnico}");
        Console.WriteLine($"Categoria: {chamado.Categoria}");
    }
}