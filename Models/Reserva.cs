namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(){}

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade da suíte é maior ou igual ao número de hóspedes
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Cálculo: DiasReservados X Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor *= 0.9M;
            }

            return valor;
        }
    }
}



























































































// namespace DesafioProjetoHospedagem.Models
// {
//     public class Reserva
//     {
//         public List<Pessoa> Hospedes { get; set; }
//         public Suite Suite { get; set; }
//         public int DiasReservados { get; set; }

//         public Reserva() { }

//         public Reserva(int diasReservados)
//         {
//             DiasReservados = diasReservados;
//         }

//         public void CadastrarHospedes(List<Pessoa> hospedes)
//         {


            
//             if (hospedes.Count <= Suite.Capacidade)
//             {
//                 Hospedes = hospedes;
//             }
//             else
//             {

//                 throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
//             }
//         }

//         public void CadastrarSuite(Suite suite)
//         {
//             Suite = suite;
//         }

//         public int ObterQuantidadeHospedes()
//         {
            
//             return Hospedes.Count;
//         }

//         public decimal CalcularValorDiaria()
//         {
            
//             decimal valor = DiasReservados * Suite.ValorDiaria;

            
//             if (DiasReservados >= 10)
//             {
//                 valor *= 0.9M;
//             }

//             return valor;
//         }
//     }
// }