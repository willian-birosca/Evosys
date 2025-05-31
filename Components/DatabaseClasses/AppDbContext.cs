using Microsoft.EntityFrameworkCore;
using Evosys.Components; // Altere para o namespace onde estão suas classes (Paciente, ProfissionalDeSaude, etc)

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    public DbSet<Paciente> Pacientes
    {
        get; set;
    }
    public DbSet<ProfissionalDeSaude> ProfissionaisDeSaude
    {
        get; set;
    }
    public DbSet<EvolucaoPorPaciente> EvolucoesPorPaciente
    {
        get; set;
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Definindo CPF como chave primária
        modelBuilder.Entity<Paciente>().HasKey(p => p.Cpf);
        modelBuilder.Entity<ProfissionalDeSaude>().HasKey(p => p.Cpf);

        // Relacionamento: Evolução → Paciente
        modelBuilder.Entity<EvolucaoPorPaciente>()
            .HasOne(e => e.Paciente)
            .WithMany(p => p.Evolucoes)
            .HasForeignKey(e => e.CpfPaciente)
            .HasPrincipalKey(p => p.Cpf);

        // Relacionamento: Evolução → Profissional
        modelBuilder.Entity<EvolucaoPorPaciente>()
            .HasOne(e => e.ProfissionalDeSaude)
            .WithMany()
            .HasForeignKey(e => e.CpfProfissional)
            .HasPrincipalKey(p => p.Cpf);
    }
}