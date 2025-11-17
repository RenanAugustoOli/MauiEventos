namespace MauiEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int NumeroParticipantes { get; set; }
        public string Local { get; set; }
        public double CustoPorParticipante { get; set; }

        public int DuracaoDias
        {
            get => (DataFim - DataInicio).Days;
        }

        public double CustoTotal
        {
            get => NumeroParticipantes * CustoPorParticipante;
        }
    }
}
