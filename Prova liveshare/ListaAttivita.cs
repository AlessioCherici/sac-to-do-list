using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_liveshare
    {
    internal class ListaAttivita
        {
        private string NomeLista;
        List<Attivita> Task = new List<Attivita>();

        public ListaAttivita(List<Attivita> task)
            {
            Task = task;
            }
        }
    }
