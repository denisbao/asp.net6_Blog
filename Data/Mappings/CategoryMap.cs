using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.Models;

namespace Blog.Data.Mappings
{
  public class CategoryMap : IEntityTypeConfiguration<Category>
  {
    public void Configure(EntityTypeBuilder<Category> builder)
    {
      // Tabela:
      builder.ToTable("Categories");

      // Chave Primária:
      builder.HasKey(x => x.Id);

      // Identity:
      builder.Property(x => x.Id)
        .ValueGeneratedOnAdd()
        .UseIdentityColumn();

      // Propriedades:
      builder.Property(x => x.Name)
        .IsRequired()
        .HasColumnName("Name")
        .HasColumnType("NVARCHAR")
        .HasMaxLength(80);

      builder.Property(x => x.Slug)
        .IsRequired()
        .HasColumnName("Slug")
        .HasColumnType("VARCHAR")
        .HasMaxLength(80);

      // Índice':
      builder.HasIndex(x => x.Slug, "IX_Category_Slug")
        .IsUnique();
    }
  }
}