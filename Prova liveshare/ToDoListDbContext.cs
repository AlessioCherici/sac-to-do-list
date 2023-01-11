using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Prova_liveshare
{
    public class TodoListDbContext : DbContext
        {
        public DbSet<Attivita> Attivita { get; set; }
        //public DbSet<Utente> Utente { get; set; }

        public DbSet<ListaAttivita> ListaAttivita { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=ToDoListDatabase2;" +
            "Integrated Security=True;TrustServerCertificate=True");
            }
        }
    }

