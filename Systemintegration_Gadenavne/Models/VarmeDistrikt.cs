namespace Systemintegration_Gadenavne.Models;

public class VarmeDistrikt : Record
{
    public string Varmekode { get; set; }
    
    public VarmeDistrikt(string line) : base(line)
    {
        Varmekode = line.Substring(32, 4);
        DistriktTekst = line.Substring(36, 30);
    }
}