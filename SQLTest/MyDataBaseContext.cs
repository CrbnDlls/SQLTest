using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SQLTest;

public partial class MyDataBaseContext : DbContext
{
    public MyDataBaseContext()
    {
    }

    public MyDataBaseContext(DbContextOptions<MyDataBaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Emission> Emissions { get; set; }

    public virtual DbSet<Source> Sources { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-GLAT3MS\\SQLEXPRESS;Initial Catalog=MyDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Emission>(entity =>
        {
            entity.HasKey(e => e.IdEmission);

            entity.ToTable("Emission");

            entity.Property(e => e.IdEmission).HasColumnName("ID_Emission");
            entity.Property(e => e.Count).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.IdSource).HasColumnName("ID_Source");
            entity.Property(e => e.Text).HasMaxLength(500);

            entity.HasOne(d => d.IdSourceNavigation).WithMany(p => p.Emissions)
                .HasForeignKey(d => d.IdSource)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Emission_Source");
        });

        modelBuilder.Entity<Source>(entity =>
        {
            entity.HasKey(e => e.IdSource);

            entity.ToTable("Source");

            entity.Property(e => e.IdSource).HasColumnName("ID_Source");
            entity.Property(e => e.Address).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
