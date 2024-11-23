using System;
using System.ComponentModel.DataAnnotations;

namespace api.model
{
    public class agendamento
    {
        [Key]
        public int idagendamento { get; set; }

        [Required] 
        public string nome { get; set; }

        [Required] 
        public string modelo { get; set; }

        [Required] 
        public string placa { get; set; }

        public DateTime data_hora { get; set; } 

       
        public agendamento(string nome, string modelo, string placa, DateTime data_hora)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.modelo = modelo ?? throw new ArgumentNullException(nameof(modelo));
            this.placa = placa ?? throw new ArgumentNullException(nameof(placa));
            this.data_hora = data_hora; 
        }
    }
}
