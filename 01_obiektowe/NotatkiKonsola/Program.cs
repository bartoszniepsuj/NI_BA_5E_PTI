/* 
 * nazwa klasy: Notatka
 * opis: Klasa reprezentuje notatkę zawierającą unikalny identyfikator,
 *       tytuł, treść oraz statyczny licznik wszystkich utworzonych notatek.
 *       pola: licznik - statyczny licznik przechowywany w pamięci dla wszystkich obiektów
 *       id - unikalny identyfikator konkretnej notatki
 *       tytul - tytuł notatki
 *       tresc - treść notatki
 *       numer autora - 9 Bartosz Niepsuj
 */
class Notatka
{
    private static int licznik;
    private int id;
    protected string tytul;

    protected string tresc;

    public Notatka(string tytul, string tresc)
    {
        licznik++;

        this.id = licznik;

        this.tytul = tytul; 

        this.tresc = tresc;
    }
    public void WyswietlNotatke()
    {
        Console.WriteLine($"Tytuł: {tytul}");

        Console.WriteLine($"Treść: {tresc}");
    }
    public void WyswietlDiagnostycznie()
    {
        Console.WriteLine($"{id}; {tytul}; {tresc}; {licznik};");
    }
}
class Program
{

    static void Main(string[] args)
    {
        Notatka notatka1 = new Notatka("Lista zakupów", "Mleko, chleb, masło, jabłka");
        Notatka notatka2 = new Notatka("Spotkanie z klientem", "Omówienie wymagań projektu o godzinie 14:00");



        Console.WriteLine("NOTATKA 1");

        Console.WriteLine("[Wyświetlenie czytelne]");

        notatka1.WyswietlNotatke();

        Console.WriteLine("[Wyświetlenie diagnostyczne]");

        notatka1.WyswietlDiagnostycznie();




        Console.WriteLine("NOTATKA 2");

        Console.WriteLine("[Wyświetlenie czytelne]");

        notatka2.WyswietlNotatke();

        Console.WriteLine("[Wyświetlenie diagnostyczne]");

        notatka2.WyswietlDiagnostycznie();
    }
}
