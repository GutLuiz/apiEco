using System.ComponentModel.DataAnnotations;

namespace api.model
{
    public class agendamento
    {
        [Key]

        public int idagendamento { get; set; }
        public string nome { get; set; }
        public string modelo_carro { get; set; }
        public  string placa_carro { get; set; }
        public DateTime? data_hora { get; set; }


        public agendamento( string nome, string modelo_carro, string placa_carro, DateTime? data_hora)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.modelo_carro = modelo_carro ?? throw new ArgumentNullException(nameof(modelo_carro));
            this.placa_carro = placa_carro ?? throw new ArgumentNullException(nameof(placa_carro));
            this.data_hora = data_hora ?? throw new ArgumentNullException(nameof(data_hora));
        }
    }
}
