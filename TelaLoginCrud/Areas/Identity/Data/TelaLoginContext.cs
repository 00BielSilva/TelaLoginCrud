using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TelaLoginCrud.Areas.Identity.Data;

namespace TelaLoginCrud.Areas.Identity.Data;

public class TelaLoginContext : IdentityDbContext<Usuario>
{
    public TelaLoginContext(DbContextOptions<TelaLoginContext> options)
        : base(options)
    {
    }
    public DbSet<Venda> Vendas { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new ConfigUser());
    }
    
    public class ConfigUser : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Nome).HasMaxLength(100);
            builder.Property(x => x.Sobrenome).HasMaxLength(100);
        }
    }
}

