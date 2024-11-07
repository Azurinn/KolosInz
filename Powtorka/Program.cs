namespace Powtorka;

internal class Program
{
    private static void Main()
    {
        // Zadanie 1
        Console.WriteLine(Zadanie1_GlobalnyLicznik.Instancja.Wartosc);
        Zadanie1_GlobalnyLicznik.Instancja.Inkrementuj();
        Console.WriteLine(Zadanie1_GlobalnyLicznik.Instancja.Wartosc);
        Zadanie1_GlobalnyLicznik.Instancja.Resetuj();
        Console.WriteLine(Zadanie1_GlobalnyLicznik.Instancja.Wartosc);
        // Zadanie 2
        Zadanie2.Tree tree = new Zadanie2.Spurce();
        tree = new Zadanie2.Chains(tree);
        tree = new Zadanie2.Lights(tree);
        tree = new Zadanie2.Bauble(tree, "Black");
        Console.WriteLine(tree.Describe());
        // Zadanie 3
        var fabryka = new Zadanie3.FabrykaLodów();
        var lody1 = fabryka.StworzLody(Zadanie3.SmakiLodów.Czekoladowe);
        lody1.Smak();
        var lody2 = fabryka.StworzLody(Zadanie3.SmakiLodów.Waniliowe);
        lody2.Smak();
        // Zadanie 4
        var flinta = new Zadanie4.Flinta();
        var spust = new Zadanie4.Spust();

        // Dodanie metody Wystrzał jako obserwatora do zdarzenia PociągnijEvent
        spust.PociągnijEvent += flinta.Wystrzał;

        // Wywołanie metody Pociągnij
        spust.Pociągnij();
    }
}