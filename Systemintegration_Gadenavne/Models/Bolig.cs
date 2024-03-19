namespace Systemintegration_Gadenavne.Models;

public class Bolig : Record
{
    public string Filler1A { get; set; }
    public string Filler12N { get; set; }
    public string Lokalitet { get; set; }
    public string? Etage { get; set; }
    public string? Sidedoer { get; set; }
    
    public Bolig(string line) : base(line)
    {
        Husnummer = line.Substring(11, 4);
        Etage = line.Substring(15, 2);
        Sidedoer = line.Substring(17, 4);
        Timestamp = line.Substring(21, 12);
        Filler1A = line.Substring(33, 1);
        Filler12N = line.Substring(46, 12);
        Startdato = line.Substring(34, 12);
        Lokalitet = line.Substring(58, 34);
    }
}

