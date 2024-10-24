using Funcionario_WebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace Funcionario_WebApi.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<FuncionarioModel>? Funcionarios { get; set; }
}
