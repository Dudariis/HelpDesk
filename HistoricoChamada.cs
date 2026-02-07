using System;
namespace HelpDesk;

  public class HistoricoChamada
    {
        // Declaração de métodos
        public string Registro { get; set; }
        public string Descricao { get; set; }
        public DateTime DataRegistro { get; set; }

        public HistoricoChamada(string registro, string descricao, DateTime dataRegistro)
        {
            this.Registro = registro;
            this.Descricao = descricao;
            this.DataRegistro = dataRegistro;
        }
    }
    