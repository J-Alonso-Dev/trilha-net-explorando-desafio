namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() 
        {
//            Suite = new Suite();
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade da suíte é menor que o número de hóspedes.");
            }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados*Suite.ValorDiaria;

            if (DiasReservados >= 10)
            {
                valor *= 0.9m; // Concede um desconto de 10%
            }
            return valor;
        }
    }
}