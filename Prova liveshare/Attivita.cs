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
        public string Creatore { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataAttivita { get; set; }



        //costruttori
        public Attivita()
            {

            }
        public Attivita(string nome, string stato, string creatore, string descrizione, DateTime dataAttivita)
            {
            this.Nome = nome;
            this.Stato = stato;
            this.Creatore = creatore;
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

        public string getCreatore()
            {
            return this.Creatore;
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

        public void setCreatore(string creatore)
            {
            this.Creatore = creatore;
            }

        //metodi
        public void DueDate()
            {
            DateTime today = DateTime.Now;
            bool res = DateTime.Equals(DataAttivita, today);
            if (res)
                {
                Console.WriteLine("\n" + Nome + "\n" + Stato + "\n" + Descrizione + "\n" +Creatore+ "\n" + DataAttivita.ToString("dd/MM/yyyy"));
                }
            }

        public override string ToString()
            {
            return "\n" + "Nome dell'attività: " + Nome + "\nStato: " + Stato + "\nDescrizione: " + Descrizione + "\nNome del Creatore: " + Creatore + "\nData attività: " +  DataAttivita.ToString("dd/MM/yyyy");
            }

        }
    }
