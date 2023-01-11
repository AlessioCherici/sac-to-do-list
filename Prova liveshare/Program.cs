
using Prova_liveshare;
bool chiudiProgramma = true;
Console.WriteLine("Manager eventi      Copyright Nikola Krstevski 1995 :)");
while (chiudiProgramma)
{
    Console.WriteLine();
    Console.WriteLine($"inserisci l'opzione da scegliere: " +
        $"\n1 - visualizzare la lista delle attività  " +
        $"\n2 - aggiungere una nuova attività alla lista " +
        $"\n3 - rimuovere un'attività dalla lista " +
        $"\n4 - modificare la descrizione di un'attività inserita precedentemente " +
        $"\n5 - modificare lo stato di un'attività inserita precedentemente " +
        $"\n6 - aggiungere o modificare una data ad un'attività inserita precedentemente " +
        $"\n7 - visualizzare solo le attività ancora da fare " +
        $"\n0 - chiudere il programma");
    
    int menu = int.Parse(Console.ReadLine());
    ListaAttivita listaativita = new ListaAttivita();
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

            
            Console.WriteLine("Aggiungi una nuova attività: ");

            using (TodoListDbContext db = new TodoListDbContext())
            {
                Console.Write("Inserisci il nome: ");
                string Nome = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Inserisci lo Stato (da fare / fatto / in corso): ");
                string Stato = Console.ReadLine().ToLower();
                while (Stato != "da fare" && Stato != "fatto" && Stato != "in corso")
                {
                    Console.WriteLine("L'input non è valido! Inseriscilo di nuovo!" + "\n");
                    Console.Write("Inserisci il Stato (da fare / fatto / in corso): ");
                    Stato = Console.ReadLine().ToLower();
                }
                    
                Console.WriteLine();
                Console.Write("Inserisci il nome del creatore: ");
                string Creatore = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Inserisci la Descrizione: ");
                string Descrizione = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Inserisci la Data (gg/mm/aaaa): ");
                DateTime data = DateTime.Parse(Console.ReadLine());                                                   

                Attivita nuovaAttivita =
                new Attivita { Nome = Nome, Stato = Stato, Creatore = Creatore, Descrizione = Descrizione ,DataAttivita = data };
                listaativita.AggiungiAttivita(nuovaAttivita);
                db.Add(nuovaAttivita);
                db.SaveChanges();
                Console.WriteLine("\n Attività aggiunta con successo! ");
                Console.WriteLine();
            }
                break;

        case 3:
            Console.WriteLine("Scegli un'attività da rimuovere usando il numero corrispondente nella lista: ");

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

                Console.WriteLine("\nAttività rimossa con successo!");
                Console.WriteLine();
            }
            break;

        case 4:
            Console.WriteLine("Scegli la descrizione di un'attività da modificare dall'elenco usando il numero corrispondente nella lista: ");

            using (TodoListDbContext db = new TodoListDbContext())
            {
                List<Attivita> listaAttivita = db.Attivita.ToList();

                foreach (Attivita attivita in listaAttivita)
                {
                    Console.WriteLine(listaAttivita.IndexOf(attivita) + " - " + attivita.Nome);
                }

                int attivitaDaModificare = int.Parse(Console.ReadLine());

                Console.WriteLine("Ora modifica la descrizone: ");    
                string nuovaDescrizione = Console.ReadLine();

                listaAttivita[attivitaDaModificare].Descrizione = nuovaDescrizione;
                db.SaveChanges();
                Console.WriteLine("\nDescrizione Attività modificata con successo!");
                Console.WriteLine();
                }
            break;

        case 5:
            Console.WriteLine("Scegli lo stato di un'attività da modificare dall'elenco usando il numero corrispondente nella lista: ");

            using (TodoListDbContext db = new TodoListDbContext())
                {
                List<Attivita> listaAttivita = db.Attivita.ToList();

                Console.WriteLine();
                Console.WriteLine("lista delle attività:");
                foreach (Attivita attivita in listaAttivita)
                {
                    Console.WriteLine(listaAttivita.IndexOf(attivita) + " - " + attivita.Nome);
                }

                Console.WriteLine();

                int sceltaAttivita = int.Parse(Console.ReadLine());

                Console.WriteLine("inserisci lo stato dell'attività da modificare (da fare / fatto / in corso): ");
                listaAttivita[sceltaAttivita].Stato = Console.ReadLine().ToLower();
                while (listaAttivita[sceltaAttivita].Stato != "da fare" && listaAttivita[sceltaAttivita].Stato != "fatto" && listaAttivita[sceltaAttivita].Stato != "in corso")
                {
                    Console.WriteLine("L'imput non è valido! Inseriscilo di nuovo!" + "\n");
                    Console.Write("Inserisci il Stato (da fare / fatto / in corso): ");
                    listaAttivita[sceltaAttivita].Stato = Console.ReadLine().ToLower();
                }
                db.SaveChanges();
                Console.WriteLine("\nStato Attività modificato con successo!");
                Console.WriteLine();
                }

            break;

        case 6:
            Console.WriteLine("Scegli la data di un'attività da modificare dall'elenco usando il numero corrispondente nella lista: ");

            using (TodoListDbContext db = new TodoListDbContext())
            {
                List<Attivita> listaAttivita =  (from lista in db.Attivita
                  where lista.Stato == "da fare"
                  select lista).ToList<Attivita>();

                Console.WriteLine();
                Console.WriteLine("lista delle attività:");
                foreach (Attivita attivita in listaAttivita)
                {
                    Console.WriteLine(listaAttivita.IndexOf(attivita) + " - " + attivita.Nome);
                }

                Console.WriteLine();
                int sceltaAttivita = int.Parse(Console.ReadLine());
                Console.WriteLine("inserisci la nuova data dell'attività");
                listaAttivita[sceltaAttivita].DataAttivita = DateTime.Parse(Console.ReadLine());

                db.SaveChanges();
                Console.WriteLine("\nData Attività modificata con successo!");
                Console.WriteLine();
            }

            break;

        case 7:
            Console.WriteLine("Lista delle attività ancora da fare: ");

            using (TodoListDbContext db = new TodoListDbContext())
            {
                List<Attivita> listaAttivita = db.Attivita.ToList();

                foreach (Attivita attivita in listaAttivita)
                {
                    if (attivita.Stato == "da fare")
                    {
                        Console.WriteLine(attivita);
                    }
                }
            }

            break;

        case 0:
            Console.WriteLine("Fine programma");
            chiudiProgramma = false;
            break;
            
        }
    
    }