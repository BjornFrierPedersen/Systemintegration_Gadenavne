namespace Systemintegration_Gadenavne.Models;

public class PostDistrikt : Record
{
    public string Postnummer { get; set; }
    public string PostDistriktTekst { get; set; }
    
    public PostDistrikt(string line) : base(line)
    {
        Postnummer = line.Substring(32, 4);
        PostDistriktTekst = line.Substring(36, 20);
    }
}