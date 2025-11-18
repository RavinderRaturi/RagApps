using Microsoft.Extensions.VectorData; 

namespace SemanticKernalRag;
public class Peak
{
   [ Microsoft.Extensions.VectorData.VectorStoreRecordKey]
 
    public Guid Key { get; set; } = Guid.NewGuid();

    // Core metadata

    [VectorStoreRecordData]
    public string Name { get; set; } = null!;

    [VectorStoreRecordData]
    public string Reference { get; set; } = null!;

    // Year of first ascent
    [VectorStoreRecordData]
    public int IdentificationDate { get; set; }

    [VectorStoreRecordData]
    public string Description { get; set; } = null!;

    // Extra structured fields for filtering and explanations

    [VectorStoreRecordData]
    public double ElevationMeters { get; set; }

    [VectorStoreRecordData]
    public string Range { get; set; } = null!;

    [VectorStoreRecordData]
    public string CountryOrRegion { get; set; } = null!;

    [VectorStoreRecordData]
    public string Continent { get; set; } = null!;

    [VectorStoreRecordData]
    public bool IsEightThousander { get; set; }

    [VectorStoreRecordData]
    public bool IsSevenSummit { get; set; }

    [VectorStoreRecordVector(768, DistanceFunction = DistanceFunction.CosineSimilarity)]
    public ReadOnlyMemory<float>? DescriptionEmbedding { get; set; }
}


//public class PeakApiService
//{
//    private readonly List<PeakDetails> _peakDetails =
//    [
//        // Eight-thousanders

//        new()
//        {
//            Name = "Mount Everest",
//            CountriesOrRegions = ["Nepal", "China (Tibet Autonomous Region)"],
//            ElevationMeters = 8848.86,
//            Range = "Mahalangur Himalaya",
//            Description = "Highest mountain on Earth on the crest of the Mahalangur Himal, forming part of the border between Nepal and Tibet.",
//            IdentificationDate = 1953,
//            Categories = ["Eight-thousander", "Seven Summit", "Himalaya"]
//        },

//        new()
//        {
//            Name = "K2",
//            CountriesOrRegions = ["Pakistan", "China"],
//            ElevationMeters = 8611.0,
//            Range = "Baltoro Karakoram",
//            Description = "Second highest mountain in the world in the Karakoram range known for extreme technical difficulty and severe weather.",
//            IdentificationDate = 1954,
//            Categories = ["Eight-thousander", "Karakoram"]
//        },

//        new()
//        {
//            Name = "Kangchenjunga",
//            CountriesOrRegions = ["Nepal", "India"],
//            ElevationMeters = 8586.0,
//            Range = "Kangchenjunga Himalaya",
//            Description = "Third highest mountain in the world on the border between eastern Nepal and the Indian state of Sikkim.",
//            IdentificationDate = 1955,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Lhotse",
//            CountriesOrRegions = ["Nepal", "China (Tibet Autonomous Region)"],
//            ElevationMeters = 8516.0,
//            Range = "Mahalangur Himalaya",
//            Description = "Fourth highest mountain on Earth directly south of Mount Everest sharing much of the same approach route.",
//            IdentificationDate = 1956,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Makalu",
//            CountriesOrRegions = ["Nepal", "China (Tibet Autonomous Region)"],
//            ElevationMeters = 8485.0,
//            Range = "Mahalangur Himalaya",
//            Description = "Prominent pyramid shaped peak southeast of Everest noted for steep ridges and technically demanding climbing.",
//            IdentificationDate = 1955,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Cho Oyu",
//            CountriesOrRegions = ["Nepal", "China (Tibet Autonomous Region)"],
//            ElevationMeters = 8188.0,
//            Range = "Mahalangur Himalaya",
//            Description = "High glaciated Himalayan peak west of Everest often considered one of the more attainable eight thousanders.",
//            IdentificationDate = 1954,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Dhaulagiri I",
//            CountriesOrRegions = ["Nepal"],
//            ElevationMeters = 8167.0,
//            Range = "Dhaulagiri Himalaya",
//            Description = "Massive isolated peak in central Nepal rising sharply above the Kali Gandaki gorge.",
//            IdentificationDate = 1960,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Manaslu",
//            CountriesOrRegions = ["Nepal"],
//            ElevationMeters = 8163.0,
//            Range = "Manaslu Himalaya",
//            Description = "Remote Himalayan peak in west central Nepal with large glaciated faces and a culturally rich approach.",
//            IdentificationDate = 1956,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Nanga Parbat",
//            CountriesOrRegions = ["Pakistan"],
//            ElevationMeters = 8126.0,
//            Range = "Nanga Parbat Himalaya",
//            Description = "Isolated giant in the western Himalaya famed for the huge Rupal Face and a history of difficult expeditions.",
//            IdentificationDate = 1953,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Annapurna I",
//            CountriesOrRegions = ["Nepal"],
//            ElevationMeters = 8091.0,
//            Range = "Annapurna Himalaya",
//            Description = "First eight thousand meter peak ever climbed located in central Nepal and known for serious avalanche risk.",
//            IdentificationDate = 1950,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        new()
//        {
//            Name = "Gasherbrum I",
//            CountriesOrRegions = ["Pakistan", "China"],
//            ElevationMeters = 8080.0,
//            Range = "Baltoro Karakoram",
//            Description = "Highest summit of the Gasherbrum group sometimes called Hidden Peak situated deep in the Karakoram.",
//            IdentificationDate = 1958,
//            Categories = ["Eight-thousander", "Karakoram"]
//        },

//        new()
//        {
//            Name = "Broad Peak",
//            CountriesOrRegions = ["Pakistan", "China"],
//            ElevationMeters = 8051.0,
//            Range = "Baltoro Karakoram",
//            Description = "Long ridge like peak near K2 with several tops along a broad snow and rock crest.",
//            IdentificationDate = 1957,
//            Categories = ["Eight-thousander", "Karakoram"]
//        },

//        new()
//        {
//            Name = "Gasherbrum II",
//            CountriesOrRegions = ["Pakistan", "China"],
//            ElevationMeters = 8035.0,
//            Range = "Baltoro Karakoram",
//            Description = "Major summit of the Gasherbrum group often regarded as one of the more straightforward eight thousanders.",
//            IdentificationDate = 1956,
//            Categories = ["Eight-thousander", "Karakoram"]
//        },

//        new()
//        {
//            Name = "Shishapangma",
//            CountriesOrRegions = ["China (Tibet Autonomous Region)"],
//            ElevationMeters = 8027.0,
//            Range = "Jugal / Langtang Himalaya",
//            Description = "Lowest of the fourteen eight thousanders and the only one located entirely within Tibet.",
//            IdentificationDate = 1964,
//            Categories = ["Eight-thousander", "Himalaya"]
//        },

//        // Seven Summits

//        new()
//        {
//            Name = "Aconcagua",
//            CountriesOrRegions = ["Argentina"],
//            ElevationMeters = 6962.0,
//            Range = "Principal Cordillera, Andes",
//            Description = "Highest mountain in South America and the highest peak in the Americas.",
//            IdentificationDate = 1897,
//            Categories = ["Seven Summit", "Andes"]
//        },

//        new()
//        {
//            Name = "Denali",
//            CountriesOrRegions = ["United States (Alaska)"],
//            ElevationMeters = 6190.0,
//            Range = "Alaska Range",
//            Description = "Highest peak in North America rising dramatically above the surrounding Alaska Range.",
//            IdentificationDate = 1913,
//            Categories = ["Seven Summit", "Alaska Range"]
//        },

//        new()
//        {
//            Name = "Mount Kilimanjaro",
//            CountriesOrRegions = ["Tanzania"],
//            ElevationMeters = 5895.0,
//            Range = "Kilimanjaro Massif",
//            Description = "Free standing stratovolcano and the highest mountain in Africa with distinct ecological zones.",
//            IdentificationDate = 1889,
//            Categories = ["Seven Summit", "Volcano"]
//        },

//        new()
//        {
//            Name = "Mount Elbrus",
//            CountriesOrRegions = ["Russia"],
//            ElevationMeters = 5642.0,
//            Range = "Caucasus Mountains",
//            Description = "Dormant volcanic dome in the western Caucasus widely regarded as the highest peak in Europe.",
//            IdentificationDate = 1874,
//            Categories = ["Seven Summit", "Caucasus"]
//        },

//        new()
//        {
//            Name = "Mount Vinson",
//            CountriesOrRegions = ["Antarctica"],
//            ElevationMeters = 4892.0,
//            Range = "Sentinel Range, Ellsworth Mountains",
//            Description = "Highest mountain in Antarctica located in a remote and extremely cold region.",
//            IdentificationDate = 1966,
//            Categories = ["Seven Summit", "Antarctica"]
//        },

//        new()
//        {
//            Name = "Carstensz Pyramid",
//            CountriesOrRegions = ["Indonesia (Papua)"],
//            ElevationMeters = 4884.0,
//            Range = "Sudirman Range",
//            Description = "Limestone peak in New Guinea often used as the highest point of Oceania in the Seven Summits list.",
//            IdentificationDate = 1962,
//            Categories = ["Seven Summit", "Oceania"]
//        },

//        new()
//        {
//            Name = "Mount Kosciuszko",
//            CountriesOrRegions = ["Australia"],
//            ElevationMeters = 2228.0,
//            Range = "Snowy Mountains",
//            Description = "Highest summit on the Australian mainland with a broad rounded summit area.",
//            IdentificationDate = 1840,
//            Categories = ["Seven Summit (Bass list)", "Australia"]
//        }
//    ];

//    public async Task<PeakDetails?> GetPeakDetailsAsync(string name)
//    {
//        await Task.Delay(50);
//        return _peakDetails.FirstOrDefault(
//            p => string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));
//    }
//}
