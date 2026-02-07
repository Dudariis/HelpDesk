using System;
namespace HelpDesk;

  public class HistoricoChamada
    {
        // Use propriedades simplificadas para o código ficar mais limpo
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
    