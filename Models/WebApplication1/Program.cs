using DesafioProjetoHospedagem.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        // Criando a lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>
        {
            new Pessoa("Hospede", "Um"),
            new Pessoa("Hospede", "Dois")
        };

        // Criando a suíte
        Suite suite = new Suite("Master", 4, 40M);

        // Criando e configurando a reserva
        Reserva reserva = new Reserva(10);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Obtendo quantidade de hóspedes e valor da diária
        Console.WriteLine($"Quantidade de Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor da Diária: {reserva.CalcularValorDiaria()}");
    }
}
