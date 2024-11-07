namespace Powtorka;

//Napisz klasy Flinta i Spust, które pełnią rolę obserwatora i obserwabli.
//Wywołanie metody Spust.Pociągnij, której towarzysy wyświetlenie napisu "Pif" w konsoli,
//powinno wywołać metodę Flinta.Wystrzał, która powoduje pokazanie napisu "Paf".
// 
public class Zadanie4
{
    public class Flinta // Obserwator
    {
        // Metoda, która wywołuje wystrzał
        public void Wystrzał()
        {
            Console.WriteLine("Paf");
        }
    }

    public class Spust // Obserwabla
    {
        // Delegat dla zdarzenia
        public event Action PociągnijEvent;

        // Metoda, która wywołuje zdarzenie
        public void Pociągnij()
        {
            Console.WriteLine("Pif");
            PociągnijEvent?.Invoke();
        }
    }
}