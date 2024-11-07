namespace Powtorka;
//Napisz klasę fabryki generującej lody (obiekty implementujące interfejs ILody).
//Można wybrać smak waniliowy lub czekoladowy - powstaną odpowiednio nowe instancje klas
//LodyWaniliowe i LodyCzekoladowe.
//Typ wskazywany jest za pomocą typu wyliczeniowego SmakiLodów.

public class Zadanie3
{
    public enum SmakiLodów
    {
        Waniliowe,
        Czekoladowe
    }

    public interface ILody
    {
        void Smak();
    }

    public class LodyCzekoladowe : ILody
    {
        public void Smak()
        {
            Console.WriteLine("Lody Czekoladowe");
        }
    }

    public class LodyWaniliowe : ILody
    {
        public void Smak()
        {
            Console.WriteLine("Lody Waniliowe");
        }
    }

    public class FabrykaLodów
    {
        public ILody StworzLody(SmakiLodów smak)
        {
            switch (smak)
            {
                case SmakiLodów.Czekoladowe:
                    return new LodyCzekoladowe();
                case SmakiLodów.Waniliowe:
                    return new LodyWaniliowe();
                default:
                    throw new ArgumentException("Nieznany smak lodów");
            }
        }
    }
}