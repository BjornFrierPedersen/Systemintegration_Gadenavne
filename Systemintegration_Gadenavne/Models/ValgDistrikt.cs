namespace Systemintegration_Gadenavne.Models;

public class ValgDistrikt : Record
{
    public string Valgkode { get; set; }
    
    public ValgDistrikt(string line) : base(line)
    {
        Valgkode = line.Substring(32, 2);
        DistriktTekst = line.Substring(34, 30);
    }
}