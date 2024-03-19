namespace Systemintegration_Gadenavne.Models;

public abstract class Record
{
    public string RecordType { get; set; }
    public string Kommunekode { get; set; }
    public string Vejkode { get; set; }
    public string Timestamp { get; set; }
    public string? Startdato { get; set; }
    public string? Husnummer { get; set; }
    public string? HusnummerFra { get; set; }
    public string? HusnummerTil { get; set; }
    public string? LigeUlige { get; set; }
    public string? DistriktTekst { get; set; }

    public Record(string line)
    {
        RecordType = line.Substring(0, 3);
        Kommunekode = line.Substring(3, 4);
        Vejkode = line.Substring(7, 4);
        HusnummerFra = line.Substring(11, 4);
        HusnummerTil = line.Substring(15, 4);
        LigeUlige = line.Substring(19, 1);
        Timestamp = line.Substring(20, 12);
    }
}