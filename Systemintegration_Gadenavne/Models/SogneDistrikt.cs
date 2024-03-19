namespace Systemintegration_Gadenavne.Models;

public class SogneDistrikt : Record
{
    public string Myndighedskode { get; set; }
    public string Myndighedsnavn { get; set; }
    
    public SogneDistrikt(string line) : base(line)
    {
        Myndighedskode = line.Substring(32, 4);
        Myndighedsnavn = line.Substring(36, 20);
    }
}