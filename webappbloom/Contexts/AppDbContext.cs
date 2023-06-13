namespace WebAppBloom.Context;
using WebAppBloom.Models;
using Microsoft.EntityFrameworkCore;


//DbContext --> Banco
//DbSet --> Tabela

//banco ":" herança
public class AppDbContext:DbContext{
//tabela - Criar tabela
//DbSet<Competencia>

public DbSet <Competencia> Competencias=> Set<Competencia>();//tabela

    //override - sobrescrita -polimorfismo
    //mesmo método sobrescrito
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer ("Server=LAB-F08-16;Database=WebAppBloom;User Id=sa;Password=senai@123;TrustServerCertificate=True;");
    }

}

