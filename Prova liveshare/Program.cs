
using Prova_liveshare;

Console.WriteLine("Hello, World!");
while (true)
{
        Console.WriteLine($"inserisci l'opzione da scegliere: " +
        $"\n1 - visualizzare la lista delle attività  " +
        $"\n2 - aggiungere una nuova attività alla lista " +
        $"\n3 - rimuovere un'attività dalla lista " +
        $"\n4 - modificare il testo di un'attività inserita precedentemente " +
        $"\n5 - modificare lo stato di un'attività inserita precedentemente " +
        $"\n6 - aggiungere o modificare una data ad un'attività inserita precedentemente " +
        $"\n7 - visualizzare solo le attività ancora da fare " +
        $"\n0 - chiudere il programma");
    
    int menu = int.Parse(Console.ReadLine());
   
    switch (menu)
    {
        case 1:
            Console.WriteLine("Lista delle attività inserite:");
            using (TodoListDbContext db = new TodoListDbContext())
            {
                List<Attivita> listaAttivita = db.Attivita.ToList();

                foreach(Attivita attivita in listaAttivita)
                {
                    Console.WriteLine(attivita);
                }
            }
                break;

        case 2:

            string nome_Utente;
            string cognome_Utente;
            string emailUtente;
            string numeroTelefono;
            Console.WriteLine("Aggiungi una nuova attività:");

            using (TodoListDbContext db = new TodoListDbContext())
            {
                Console.WriteLine("Inserire le informazioni dell' utente: ");
                Console.Write("Inserisci il nome: ");
                nome_Utente = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Inserisci il cognome: ");
                cognome_Utente = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Inserisci il email: ");
                emailUtente = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Inserisci il numero di telefono: ");
                numeroTelefono = Console.ReadLine();
                Console.WriteLine();
                Utente utente = new Utente(nome_Utente, cognome_Utente, emailUtente, numeroTelefono);
                db.Add(utente);

                Console.WriteLine("Inserire le informazioni delle attività: ");


            }
                break;

        case 3:
            Console.WriteLine("Scegli un'attività da rimuovere:");

            using (TodoListDbContext db = new TodoListDbContext())
            {
                List<Attivita> listaAttivita = db.Attivita.ToList();

                foreach (Attivita attivita in listaAttivita)
                {
                    Console.WriteLine(listaAttivita.IndexOf(attivita) + attivita.Nome); 
                }

                int attivitaDaRimuovere = int.Parse(Console.ReadLine());

                db.Remove(listaAttivita[attivitaDaRimuovere]);
                db.SaveChanges();

                Console.WriteLine("l'attività è stata rimossa");
            }
            break;

        case 4:
            Console.WriteLine("Scegli un'attività da modificare dall'elenco (testo):");

            using (TodoListDbContext db = new TodoListDbContext())
            {
                List<Attivita> listaAttivita = db.Attivita.ToList();

                foreach (Attivita attivita in listaAttivita)
                {
                    Console.WriteLine(listaAttivita.IndexOf(attivita) + attivita.Nome);
                }

                int attivitaDaModificare = int.Parse(Console.ReadLine());

                string nuovaDescrizione = Console.ReadLine();
                listaAttivita[attivitaDaModificare].Descrizione = nuovaDescrizione;
            }
            break;

        case 5:
            Console.WriteLine("Scegli un'attività da modificare dall'elenco (stato):");
            break;
        case 6:
            Console.WriteLine("Scegli un'attività da modificare dall'elenco (data):");
            break;
        case 7:
            Console.WriteLine("Lista delle attività ancora da fare:");
            break;
        case 0:
            Console.WriteLine("Fine programma");
            break;
    }
}