namespace Systemintegration_Gadenavne.Models;

public class KirkeDistrikt : Record
{
    public string Kirkekode { get; set; }
    
    public KirkeDistrikt(string line) : base(line)
    {
        Kirkekode = line.Substring(32, 2);
        DistriktTekst = line.Substring(34, 30);
    }
}