namespace Systemintegration_Gadenavne.Models;

public class BefolkDistrikt : Record
{
    public string BefolkKode { get; set; }
    
    public BefolkDistrikt(string line) : base(line)
    {
        BefolkKode = line.Substring(32, 4);
        DistriktTekst = line.Substring(36, 30);
    }
}