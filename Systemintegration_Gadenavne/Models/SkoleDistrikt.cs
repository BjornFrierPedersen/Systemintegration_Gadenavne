namespace Systemintegration_Gadenavne.Models;

public class SkoleDistrikt : Record
{
    public string Skolekode { get; set; }
    
    public SkoleDistrikt(string line) : base(line)
    {
        Skolekode = line.Substring(32, 2);
        DistriktTekst = line.Substring(34, 30);
    }
}