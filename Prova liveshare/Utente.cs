using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_liveshare
{
    [Table("Utenti")]
    public class Utente
    {
        [Key]
        public int IdUtente { get; set; }
        [Required]
        [Column("nome")]
        public string NomeUtente { get; set; }
        [Required]
        [Column("cognome")]
        public string CognomeUtente { get; set; }
        [Required]
        [Column("email")]
        public string EmailUtente { get; set; }
        [Column("numero_telefono")]
        public string NumeroTelefonoUtente { get; set; }

        public Utente()
        {

        }
        public Utente(string nome, string cognome, string emailUtente, string numeroTelefonoUtente)
        {
            this.NomeUtente = nome;
            this.CognomeUtente = cognome;
            this.EmailUtente = emailUtente;
            this.NumeroTelefonoUtente = numeroTelefonoUtente;
        }

        // -------------------------- Metodi Get --------------------------
        public string getNomeUtente()
        {
            return this.NomeUtente;
        }

        public string getCognomeUtente()
        {
            return this.CognomeUtente;
        }

        public string getEmailUtente()
        {
            return this.EmailUtente;
        }


        public string getNumeroTelefonoUtente()
        {
            return this.NumeroTelefonoUtente;
        }

        // -------------------------- Metodi Set --------------------------

        public void SetNomeUtente(string nome)
        {
            this.NomeUtente = nome;
        }

        public void SetEmailUtente(string emailUtente)
        {
            this.EmailUtente = emailUtente;
        }

        public void SetCognomeUtente(string cognome)
        {
            this.CognomeUtente = cognome;
        }

        public void SetNumeroTelefonoUtente(string numeroTelefonoUtente)
        {
            this.NumeroTelefonoUtente = numeroTelefonoUtente;
        }



    }
}
