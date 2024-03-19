namespace Systemintegration_Gadenavne.Models;

public class ByFornyDistrikt : Record
{
    public string ByFornyKode { get; set; }
    
    public ByFornyDistrikt(string line) : base(line)
    {
        ByFornyKode = line.Substring(32, 6);
        DistriktTekst = line.Substring(38, 30);
    }
}