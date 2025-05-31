using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

public class EvolucaoPorPaciente
{
    [Key] public int Id {get; set;}

    [ForeignKey("Paciente")]
    public string CpfPaciente                      {get;set;}

    [ForeignKey("ProfissionalDeSaude")]
    [Required]
    public string CpfProfissional                  {get;set;} = string.Empty;

    public DateTime DataEvolucao                   {get;set;}
    public string Sintomas                         {get;set;} 
    public string Intervencao                      {get;set;}    
    public string Observacao                       {get;set;}    
    public string Setor                            {get;set;}
    public Paciente Paciente                       {get;set;}
    public ProfissionalDeSaude ProfissionalDeSaude {get;set;}

    // Construtor vazio (necessário para o EF Core)
    public EvolucaoPorPaciente()
    {
    }

    // Construtor personalizado
    public EvolucaoPorPaciente(
        string cpfPaciente,
        string cpfProfissional,
        DateTime dataEvolucao,
        string sintomas,
        string intervencao,
        string observacao,
        string setor)
    {
        CpfPaciente = cpfPaciente;
        CpfProfissional = cpfProfissional;
        DataEvolucao = dataEvolucao;
        Sintomas = sintomas;
        Intervencao = intervencao;
        Observacao = observacao;
        Setor = setor;
    }
}
