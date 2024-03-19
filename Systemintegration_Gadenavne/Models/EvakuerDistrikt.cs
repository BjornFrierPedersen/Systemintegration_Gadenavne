namespace Systemintegration_Gadenavne.Models;

public class EvakuerDistrikt : Record
{
    public string EvakuerKode { get; set; }
    
    public EvakuerDistrikt(string line) : base(line)
    {
        EvakuerKode = line.Substring(32, 1);
        DistriktTekst = line.Substring(33, 30);
    }
}