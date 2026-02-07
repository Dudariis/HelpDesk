using System;
using System.Collections.Generic; // Necessário para usar List<>

namespace HelpDesk
{
    // --- CLASSE PROGRAM ---
    class Program
    {
        static void Main(string[] args)
        {
            // Criando os objetos base 
            Tecnico tecnico = new Tecnico(1, "João", "joao@email.com", "Em andamento", "TEC-123");
            Cliente cliente = new Cliente(2, "Maria", "maria@email.com", "4002-8922", "Sim", "Em andamento");
            Chamado chamado = new Chamado(1, "Problema com o computador", "Em andamento", cliente.Id, tecnico.Id, 1);
            cliente.senha = "1234";   
        
        
            //  CRIANDO A LISTA DE HISTÓRICO
            List<HistoricoChamada> listaDeHistoricos = new List<HistoricoChamada>();

            // Adicionando alguns registros de exemplo na lista
            listaDeHistoricos.Add(new HistoricoChamada("REG01", "Abertura do chamado", DateTime.Now.AddHours(-2)));
            listaDeHistoricos.Add(new HistoricoChamada("REG02", "Técnico analisando hardware", DateTime.Now.AddHours(-1)));

            // EXIBIÇÃO
            Console.WriteLine("Dados do Técnico:");
            tecnico.ExibirDados();

            Console.WriteLine("\nDados do Cliente:");
            cliente.ExibirDados();

            Console.WriteLine("\n=======");
            Console.WriteLine($"CHAMADO #{chamado.Id}");
            Console.WriteLine($"TÉCNICO RESPONSÁVEL: {tecnico.Nome}");
            Console.WriteLine("---------");
            Console.WriteLine("HISTÓRICO DE ATENDIMENTO:");

            // Laço de repetição
            foreach (var registro in listaDeHistoricos) 
            {
                // Uso de DataRegistro
                Console.WriteLine($"[{registro.DataRegistro:dd/MM HH:mm}] - {registro.Descricao}");
            }
        }
    }
}