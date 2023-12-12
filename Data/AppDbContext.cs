using System;
using MeuTodo5.Models; //
using Microsoft.EntityFrameworkCore; //


namespace MeuTodo5.Data
{   //Representação do banco de dados
    // Mapea o modelo Todo para o banco de dados
    public class AppDbContext : DbContext
	{
        public DbSet<Todo> Todos { get; set; } //Representa a tabela Todo no banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {   // Connection string
            optionsBuilder.UseSqlite(connectionString:"Data Source=app.db; Cache=Shared");
        }
    }
}


