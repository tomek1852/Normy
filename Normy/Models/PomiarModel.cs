namespace Normy.Models
{
    public class PomiarModel
    {
        public DateTime Data { get; set; } = DateTime.Today;
        public string Zmiana { get; set; } = "I";
        public string Pracownik { get; set; } = "";

        public DateTime? GodzinaStart { get; set; }
        public DateTime? GodzinaStop { get; set; }

        public int LicznikStart { get; set; }
        public int LicznikStop { get; set; }
    }
}
