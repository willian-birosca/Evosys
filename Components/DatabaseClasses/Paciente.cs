using System.ComponentModel.DataAnnotations;

public class Paciente
{
    [Key]
    public string Cpf
    {
        get; set;
    } // Chave primária
    public bool Ativo
    {
        get; set;
    }
    public string Nome
    {
        get; set;
    }
    public DateTime DataNascimento
    {
        get; set;
    } // 🔥 Troca Idade por Data de Nascimento
    public string Sexo
    {
        get; set;
    }
    public string Endereco
    {
        get; set;
    }
    public DateTime DataAdmissao
    {
        get; set;
    }
    public DateTime DataAlta
    {
        get; set;
    }
    public string Gravidade
    {
        get; set;
    }

    public ICollection<EvolucaoPorPaciente> Evolucoes { get; set; } = new List<EvolucaoPorPaciente>();

    // 🔹 Construtor padrão (obrigatório para o EF)
    public Paciente()
    {
    }

    // 🔹 Construtor com parâmetros
    public Paciente(string cpf, string nome, DateTime dataNascimento, string sexo, DateTime dataAdmissao, string gravidade, string endereco)
    {
        Ativo = true;
        Cpf = cpf;
        Nome = nome;
        DataNascimento = dataNascimento;
        Sexo = sexo;
        DataAdmissao = dataAdmissao;
        Gravidade = gravidade;
        Endereco = endereco;
        DataAlta = DateTime.MinValue;

        Evolucoes = new List<EvolucaoPorPaciente>();
    }

    // 🔥 Método auxiliar opcional para calcular idade
    public int CalcularIdade()
    {
        var hoje = DateTime.Today;
        var idade = hoje.Year - DataNascimento.Year;
        if (DataNascimento.Date > hoje.AddYears(-idade))
            idade--;
        return idade;
    }
}
