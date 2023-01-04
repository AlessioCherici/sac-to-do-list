
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
    if (menu == 1)
        {
        Console.WriteLine("prova");
        }


    if (menu == 0)
        {
        break;
        }

    }