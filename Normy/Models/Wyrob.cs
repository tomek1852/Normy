namespace Normy.Models;

public class Wyrob
{
    public int Id { get; set; }

    public string NumerWyrobu { get; set; } = "";
    public string NumerOperacji { get; set; } = "";
    public string NumerMaszyny { get; set; } = "";

    public string Status { get; set; } = "W trakcie";
    public double? WyliczonaNorma { get; set; }

    public DateTime DataUtworzenia { get; set; } = DateTime.Now;
}