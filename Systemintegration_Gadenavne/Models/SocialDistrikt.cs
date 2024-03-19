namespace Systemintegration_Gadenavne.Models;

public class SocialDistrikt : Record
{
    public string Socialkode { get; set; }
    
    public SocialDistrikt(string line) : base(line)
    {
        Socialkode = line.Substring(20, 12);
        DistriktTekst = line.Substring(34, 30);
    }
}