
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
            
            break;
        case 2:
            Console.WriteLine("Aggiungi una nuova attività:");
            break;
        case 3:
            Console.WriteLine("Scegli un attività da rimuovere:");
            break;
        case 4:
            Console.WriteLine("Scegli un'attività da modificare dall'elenco (testo):");
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