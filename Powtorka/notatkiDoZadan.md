## Zadania

### Zadanie1

Wzorzec Singleton jest używany w klasie GlobalnyLicznik. Singleton to wzorzec projektowy, który gwarantuje, że dana
klasa ma tylko jedną instancję i dostarcza globalny punkt dostępu do niej.
W klasie GlobalnyLicznik, Singleton jest implementowany w następujący sposób:
Prywatny konstruktor: Konstruktor GlobalnyLicznik() jest prywatny, co oznacza, że nie można go wywołać bezpośrednio z
zewnątrz klasy.
Statyczna instancja: Zmienna _instancja jest statyczna, co oznacza, że istnieje tylko jedna kopia tej zmiennej dla całej
klasy, niezależnie od liczby utworzonych obiektów.
Publiczny dostęp do instancji: Właściwość Instancja jest publiczna i statyczna, co umożliwia globalny dostęp do
instancji klasy. Jeśli instancja nie istnieje (jest null), tworzona jest nowa instancja. Jeśli instancja już istnieje,
zwracana jest istniejąca instancja. Mechanizm blokady (lock) zapewnia, że tylko jeden wątek na raz może utworzyć
instancję, co jest ważne w środowiskach wielowątkowych.
Dzięki temu, niezależnie od tego, ile razy wywołasz GlobalnyLicznik.Instancja, zawsze otrzymasz tę samą instancję klasy
GlobalnyLicznik. Pozwala to na globalne i spójne zarządzanie stanem, takim jak nasz licznik.

### Zadanie 2

Wzorzec dekoratora jest używany w tym kodzie do dodawania nowych funkcjonalności (ozdób) do obiektu Tree (choinki) w
czasie wykonywania, bez wpływania na inne instancje tego samego typu.
Klasa TreeDecorator jest klasą bazową dla wszystkich dekoratorów i dziedziczy po klasie Tree. Każdy dekorator zawiera
referencję do obiektu Tree, który dekoruje (ozdabia), a metoda Describe() każdego dekoratora dodaje do opisu choinki
dodatkowy element (ozdobę).
Na przykład, klasa Lights jest dekoratorem, który dodaje do opisu choinki informację o lampkach. Kiedy wywołujesz
tree.Describe(), otrzymujesz opis choinki z wszystkimi dodanymi ozdobami.
Wzorzec dekoratora pozwala na dynamiczne i elastyczne dodawanie nowych funkcjonalności do obiektów, zachowując
jednocześnie zasadę otwarte-zamknięte (klasy powinny być otwarte na rozszerzenia, ale zamknięte na modyfikacje). Dzięki
temu możemy dodawać nowe ozdoby do choinki bez konieczności modyfikacji istniejących klas choinki.

### Zadanie 3
