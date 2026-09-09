class Kosc
{
    public static int liczba_instancji = 0;

    public string[] nazwy_Plikow =
    {
        "kosc0.png",
        "kosc1.png",
        "kosc2.png",
        "kosc3.png",
        "kosc4.png",
        "kosc5.png",
        "kosc6.png"
    };

    public int liczba_oczek;

    public int id_pliku;

    public bool dostepna;

    public Kosc(int wartosc)
    {
        if (wartosc < 1 || wartosc > 6)
        {
            wartosc = 0;
        }

        liczba_oczek = wartosc;
        id_pliku = wartosc;
        dostepna = true;

        liczba_instancji++;
    }

    public Kosc()
    {
        Random random = new Random();
        int wartosc = random.Next(1, 7);

        liczba_oczek = wartosc;
        id_pliku = wartosc;
        dostepna = true;

        liczba_instancji++;
    }

    public void Rzut()
    {
        if (dostepna)
        {
            Random random = new Random();
            int wartosc = random.Next(1, 7);

            liczba_oczek = wartosc;
            id_pliku = wartosc;
        }
    }

    public void Zablokuj()
    {
        dostepna = false;
    }

    public string PobierzWynik()
    {
        switch (liczba_oczek)
        {
            case 1:
                return "jeden";
            case 2:
                return "dwa";
            case 3:
                return "trzy";
            case 4:
                return "cztery";
            case 5:
                return "pięć";
            case 6:
                return "sześć";
            default:
                return "zero";
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę oczek: ");
        int liczba = int.Parse(Console.ReadLine());

        Kosc kosc1 = new Kosc(liczba);

        Console.WriteLine("Liczba utworzonych instancji: " + Kosc.liczba_instancji);
        Console.WriteLine("Wynik rzutu: " + kosc1.liczba_oczek);
        Console.WriteLine("Wynik słownie: " + kosc1.PobierzWynik());
        Console.WriteLine("Plik: " + kosc1.nazwy_Plikow[kosc1.id_pliku]);

        Console.WriteLine();

        Kosc kosc2 = new Kosc();

        Console.WriteLine("Liczba utworzonych instancji: " + Kosc.liczba_instancji);
        Console.WriteLine("Wynik rzutu: " + kosc2.liczba_oczek);
        Console.WriteLine("Wynik słownie: " + kosc2.PobierzWynik());
        Console.WriteLine("Plik: " + kosc2.nazwy_Plikow[kosc2.id_pliku]);
    }
}