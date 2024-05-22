using DesafioProjetoHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; } = new List<Pessoa>();
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva() { }

    public Reserva(int diasReservados) => DiasReservados = diasReservados;

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite!= null && Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Capacidade da suíte é menor que o número de hóspedes ou a suíte não foi cadastrada.");
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
        if (Suite == null)
        {
            throw new Exception("A suíte não foi cadastrada.");
        }

        decimal valor = DiasReservados * Suite.ValorDiaria;

        if (DiasReservados >= 10)
        {
            valor *= 0.90M; // Conceder desconto de 10%
        }

        return valor;
    }
}

internal class Respublic
{
    // This class is empty, you might want to remove it or add some implementation
}