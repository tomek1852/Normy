namespace Normy.Models;

public class DodatkowaCzynnosc
{
    public int Id { get; set; }
    public int WyrobId { get; set; }

    public string Nazwa { get; set; } = "";
    public int CoIleSztuk { get; set; } = 1;

    public double Pomiar1 { get; set; }
    public double Pomiar2 { get; set; }
    public double Pomiar3 { get; set; }
    public double Pomiar4 { get; set; }
    public double Pomiar5 { get; set; }

    public string WybranaCzynnoscZPomiarow { get; set; } = "";

    public double Srednia
    {
        get
        {
            var pomiary = new[] { Pomiar1, Pomiar2, Pomiar3, Pomiar4, Pomiar5 }
                .Where(x => x > 0)
                .ToList();

            return pomiary.Any() ? Math.Round(pomiary.Average(), 2) : 0;
        }
    }

    public double CzasNaSztuke =>
        CoIleSztuk > 0 ? Math.Round(Srednia / CoIleSztuk, 4) : 0;
}