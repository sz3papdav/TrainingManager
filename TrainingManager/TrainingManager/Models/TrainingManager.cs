using System;

namespace TrainingManagerProject.Models
{
    public enum Edzok { SzemelyEdzo, CsapatEdzo, Jatekos}

    public class TrainingManager
    {
        public string Vezeteknev { get; set; }
        public string Keresztnev { get; set; }
        public DateTime SzuletesiIdo { get; set; }
        public string Korosztaly { get; set; }
        public string Poszt { get; set; }

        public TrainingManager(string vezeteknev, string keresztnev, DateTime szuletesiIdo, string korosztaly, string poszt)
        {
            Vezeteknev = vezeteknev;
            Keresztnev = keresztnev;
            SzuletesiIdo = szuletesiIdo;
            Korosztaly = korosztaly;
            Poszt = poszt;
        }
        public TrainingManager()
        {
            Vezeteknev = string.Empty;
            Keresztnev = string.Empty;
            SzuletesiIdo = new DateTime();
            Korosztaly = string.Empty;
            Poszt = string.Empty;
        }

        public override string ToString()
        {
            return $"{Vezeteknev} {Keresztnev} {Korosztaly} ({String.Format("{0:yyyy.MM.dd.}", SzuletesiIdo)}";
        }
    }
}
