namespace Systemintegration_Gadenavne.Models;

public class NotatVej : Record
{
    public string NotatNummer { get; set; }
    public string NotatLinje { get; set; }
    
    public NotatVej(string line) : base(line)
    {
        NotatNummer = line.Substring(11, 2);
        NotatLinje = line.Substring(13, 40);
        Timestamp = line.Substring(53, 12);
        Startdato = line.Substring(65, 12);
    }
}