namespace Systemintegration_Gadenavne.Models;

public class Bynavn : Record
{
    public string Navn { get; set; }
    
    public Bynavn(string line) : base(line)
    {
        Navn = line.Substring(32, 34);
    }
}