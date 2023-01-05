using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_liveshare
{
    public class ListaAttivita
    {
        [Key]
        public int IdLista { get; set; }
        public string NomeLista { get; set; }
        public List<Attivita> Task { get; set; } = new List<Attivita>();
        public Attivita Attivita { get; set; }
        public int IdAttivita { get; set; }

        public ListaAttivita()
        {

        }
        public ListaAttivita(string Nome, List<Attivita> task)
        {
            this.NomeLista = Nome;
            this.Task = task;
        }

        public void AggiungiAttivita(Attivita attivita)
        {
            Task.Add(attivita);
        }




    }
}



