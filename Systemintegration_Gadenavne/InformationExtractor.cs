using Microsoft.Extensions.Caching.Memory;
using Systemintegration_Gadenavne.Models;

namespace Systemintegration_Gadenavne;

public class InformationExtractor
{
    private readonly IMemoryCache _cache;
    
    public InformationExtractor(IMemoryCache cache)
    {
        _cache = cache;
    }
    
    public List<Record?> GetRecords()
    {
        if (_cache.TryGetValue("records", out List<Record>? cachedRecords))
        {
            return cachedRecords!;
        }
        
        var lines = File.ReadAllLines("A370715.txt");
        var records = lines.Select(ParseRecord).ToList();
        
        // invalidate the cached results every day, to make sure that updates are picked up
        _cache.Set("records", records, new DateTimeOffset(DateTime.Now.AddDays(1)));
        return records;
    }
    
    private Record? ParseRecord(string line)
    {
        var recordType = line.Substring(0, 3);
        switch (recordType)
        {
            case "001":
                return new AktVej(line);
            case "002":
                return new Bolig(line);
            case "003":
                return new Bynavn(line);
            case "004":
                return new PostDistrikt(line);
            case "005":
                return new NotatVej(line);
            case "006":
                return new ByFornyDistrikt(line);
            case "007": 
                return new DivDistrikt(line);
            case "008": 
                return new EvakuerDistrikt(line);
            case "009": 
                return new KirkeDistrikt(line);
            case "010": 
                return new SkoleDistrikt(line);
            case "011": 
                return new BefolkDistrikt(line);
            case "012": 
                return new SocialDistrikt(line);
            case "013": 
                return new SogneDistrikt(line);
            case "014": 
                return new ValgDistrikt(line);
            case "015": 
                return new VarmeDistrikt(line);
            default:
                return new UnknownRecord();
        }
    }
}