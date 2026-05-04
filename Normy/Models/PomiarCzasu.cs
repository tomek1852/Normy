namespace Normy.Models;

public class PomiarCzasu
{
    public int Id { get; set; }

    public int PomiarId { get; set; }
    public Pomiar? Pomiar { get; set; }

    public int Numer { get; set; }
    public double Czas { get; set; }

    public string Uwagi { get; set; } = "";

    public bool Wykluczony { get; set; }
    public bool DodatkowaCzynnosc { get; set; }
}