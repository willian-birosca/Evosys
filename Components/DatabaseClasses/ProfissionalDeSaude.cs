using System.ComponentModel.DataAnnotations;

public class ProfissionalDeSaude
{
    [Key]
    public string Cpf            {get; set;} // Chave primária
    public string Nome           {get; set;}
    public string Email          {get; set;}
    public int    Idade          {get; set;}
    public string Sexo           {get; set;}
    public string Senha          {get; set;}
    public string Endereco       {get; set;}
    public string Situacao       {get; set;}
    public string Cargo          {get; set;}
    public int    NivelPermissao {get; set;}

    // Construtor vazio (necessário para o EF Core funcionar corretamente)
    public ProfissionalDeSaude()
    {
    }
    // Construtor personalizado
    public ProfissionalDeSaude(
        string cpf            ,
        string nome           ,
        string email          ,
        int    idade          ,
        string sexo           ,
        string senha          ,
        string endereco       ,
        string situacao       ,
        string cargo          ,
        int    nivelPermissao )
    {
        Cpf = cpf;
        Nome = nome;
        Email = email;
        Idade = idade;
        Sexo = sexo;
        Senha = senha;
        Endereco = endereco;
        Situacao = situacao;
        Cargo = cargo;
        NivelPermissao = nivelPermissao;
    }
}