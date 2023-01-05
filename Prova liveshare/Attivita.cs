using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_liveshare
{   
    public class Attivita
    {
        //proprietà
        [Key]
        public int IdAttivita { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Stato { get; set; }
        public Utente Utente { get; set; } //nuova Classe
        public int IdUtente { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataAttivita { get; set; }

        //costruttori
        public Attivita()
        {

        }
        public Attivita(string nome, string stato, Utente utente, string descrizione, DateTime dataAttivita)
        {
            this.Nome = nome;
            this.Stato = stato;
            this.Utente = utente;
            this.Descrizione = descrizione;
            this.DataAttivita = dataAttivita;
        }

        // -------------------------- Metodi Get --------------------------
        public string getNome()
        {
            return this.Nome;
        }

        public string getStato()
        {
            return this.Stato;
        }

        public string getDescrizione()
        {
        return this.Descrizione;        
        }
        
        public Utente getUtente()
        {
            return this.Utente;
        }

        public DateTime getDataAttivita()
        {
            return this.DataAttivita;
        }

        // -------------------------- Metodi Set --------------------------
        public void setDescrizione(string descrizione)
        {
            this.Descrizione = descrizione;
        }

        public void setDataAttivita(DateTime dataAttivita)
        {
            this.DataAttivita = dataAttivita;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public void setStato(string stato)
        {
            this.Stato = stato;
        }
   
        //metodi
        public void DueDate()
        {
            DateTime today = DateTime.Now;
            bool res = DateTime.Equals(DataAttivita,today);
            if (res) 
            {
                Console.WriteLine("\n" + Nome + "\n" + Stato + "\n" + Utente.getNomeUtente() + "\n" + Descrizione + "\n" + DataAttivita);
            }    
        }

        public override string ToString()
        {
            return "\n" + Nome + "\n" + Stato + "\n" + Utente.getNomeUtente() + "\n" + Descrizione + "\n" + DataAttivita;
        }

    }
}
