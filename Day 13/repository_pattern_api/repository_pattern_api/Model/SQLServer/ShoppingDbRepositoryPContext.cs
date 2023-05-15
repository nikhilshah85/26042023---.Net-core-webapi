using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace repository_pattern_api.Model.SQLServer;

public partial class ShoppingDbRepositoryPContext : DbContext
{
    public ShoppingDbRepositoryPContext()
    {
    }

    public ShoppingDbRepositoryPContext(DbContextOptions<ShoppingDbRepositoryPContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductSql> ProductSqls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=shoppingDB_repositoryP;integrated security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductSql>(entity =>
        {
            entity.HasKey(e => e.PId).HasName("PK__productS__DD36D562E8D0EFD8");

            entity.ToTable("productSQL");

            entity.Property(e => e.PId)
                .ValueGeneratedNever()
                .HasColumnName("pId");
            entity.Property(e => e.PCategory)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pCategory");
            entity.Property(e => e.PIsInStock).HasColumnName("pIsInStock");
            entity.Property(e => e.PName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("pName");
            entity.Property(e => e.PPrice).HasColumnName("pPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
