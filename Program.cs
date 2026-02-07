using System;
using System.Net;
namespace HelpDesk;

class Program
{
    static void Main(string[] args)
    {
        // ---- Dados dos usuários----
        Tecnico tecnico = new Tecnico(1, "João", "joao@email.com", "Em andamento", "TEC-123");
        Cliente cliente = new Cliente(2, "Maria", "maria@email.com", "4002-8922", "Sim", "Em andamento");
        Chamado chamado = new Chamado(1, "Problema com o computador", "Em andamento", cliente.Id, tecnico.Id, 1);

      
        // ---- Registros do usuário ----
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

 
        // ---- Data e Hora ----
        DateTime agora = DateTime.Now;
        Console.WriteLine($"Horário de mudança de status: {agora}");
        

        // ---- Status do chamado ----
        Console.WriteLine("\n=======");
        Console.WriteLine($"CHAMADO #{chamado.Id} - {chamado.Id}");
        Console.WriteLine($"TÉCNICO RESPONSÁVEL: {chamado.idTecnico}");
        Console.WriteLine("---------");
        Console.WriteLine("HISTÓRICO DE ATENDIMENTO:");

        foreach (var registro in HistoricoChamada) {
        Console.WriteLine($"[{registro.Data:dd/MM HH:mm}] - {registro.Descricao}");
}
        
}
}