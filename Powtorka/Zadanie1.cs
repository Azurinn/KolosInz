//Korzystając ze wzorca singleton przygotuj klasę, która implementuje globalny
//licznik posiadający metodę Inkrementuj zwiększającą wartość licznika o jeden i
//własność Wartość, która pozwala odczytać bieżącą warość licznika. Można również
//dodać metodę Resetuj ustawiającą licznik na zero.

namespace Powtorka;

public sealed class Zadanie1_GlobalnyLicznik
{
    private static Zadanie1_GlobalnyLicznik _instancja; // Instancja
    private static readonly object _lock = new(); // Blokada zeby nie robic nowych watkow

    private Zadanie1_GlobalnyLicznik() // Konstruktor
    {
    }

    public static Zadanie1_GlobalnyLicznik Instancja // Tworzenie instancji jeżeli nie ma takowej
    {
        get
        {
            lock (_lock)
            {
                if (_instancja == null) _instancja = new Zadanie1_GlobalnyLicznik();
            }

            return _instancja;
        }
    }

    public int Wartosc { get; private set; }

    public void Inkrementuj()
    {
        Wartosc++;
    }

    public void Resetuj()
    {
        Wartosc = 0;
    }
}