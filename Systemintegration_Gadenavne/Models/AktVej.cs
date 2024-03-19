namespace Systemintegration_Gadenavne.Models;

public class AktVej : Record
{
    public string Vejadresseringsnavn { get; set; }
    public string Vejnavn { get; set; }
    public string TilKommunekode { get; set; }
    public string FraKommunekode { get; set; }
    public string TilVejkode { get; set; }
    public string FraVejkode { get; set; }
    
    public AktVej(string line) : base(line)
    {
        Vejkode = line.Substring(7, 4);
        Timestamp = line.Substring(11, 12);
        TilKommunekode = line.Substring(23, 4);
        FraKommunekode = line.Substring(31, 4);
        TilVejkode = line.Substring(27, 4);
        FraVejkode = line.Substring(35, 4);
        Startdato = line.Substring(39, 12);
        Vejadresseringsnavn = line.Substring(51, 20);
        Vejnavn = line.Substring(71, 40);
    }
}