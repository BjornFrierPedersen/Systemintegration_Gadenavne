namespace Systemintegration_Gadenavne.Models;

public class DivDistrikt : Record
{
    public string DisType { get; set; }
    public string DivDistriktKode { get; set; }
    
    public DivDistrikt(string line) : base(line)
    {
        DisType = line.Substring(32, 2);
        DivDistriktKode = line.Substring(34, 4);
        DistriktTekst = line.Substring(38, 30);
    }
}