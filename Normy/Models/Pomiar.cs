namespace Normy.Models;

public class Pomiar
{
    public int Id { get; set; }

    public int WyrobId { get; set; }
    public Wyrob? Wyrob { get; set; }

    public int Typ { get; set; } // 1, 2, 3

    public DateTime Data { get; set; }
    public string Zmiana { get; set; } = "";
    public string Pracownik { get; set; } = "";

    public DateTime? GodzinaStart { get; set; }
    public DateTime? GodzinaStop { get; set; }

    public int LicznikStart { get; set; }
    public int LicznikStop { get; set; }

    public List<PomiarCzasu> Czasy { get; set; } = new();
}