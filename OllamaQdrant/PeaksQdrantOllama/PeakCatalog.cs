using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using Microsoft.Extensions.VectorData;

 

public class Peak
{
    [VectorStoreRecordKey]
    public Guid Key { get; set; } = Guid.NewGuid();

    // Core RAG fields

    [VectorStoreRecordData]
    public string Name { get; set; } = null!;

    // One line provenance or source note
    [VectorStoreRecordData]
    public string Reference { get; set; } = null!;

    [VectorStoreRecordData]
    public string Description { get; set; } = null!;

    [VectorStoreRecordData]
    public double ElevationMeters { get; set; }

    // Extra structured fields for filtering

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

public static class PeakCatalog
{
    private static readonly IReadOnlyList<Peak> _peaks = new ReadOnlyCollection<Peak>(
        new List<Peak>
        {
            // Eight thousanders

            new Peak
            {
                Name = "Mount Everest",
                Description =
                    "Highest mountain on Earth, on the Nepal-China (Tibet) border in the Mahalangur Himal, climbed via classic routes from Nepal and from the Tibetan plateau.",
                ElevationMeters = 8848.86,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = true,
                Reference =
                    "Elevation and basic facts from Nepal and China 2020 surveys and standard Everest references."
            },

            new Peak
            {
                Name = "K2",
                Description =
                    "Second highest mountain in the world in the Karakoram on the Pakistan-China border, renowned for extreme technical difficulty and severe weather.",
                ElevationMeters = 8611.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Elevation and location from Pakistani and Chinese surveys as summarized in K2 mountaineering literature."
            },

            new Peak
            {
                Name = "Kangchenjunga",
                Description =
                    "Third highest mountain on the Nepal-India border, once believed to be the highest before early twentieth century surveys corrected Everest’s height.",
                ElevationMeters = 8586.0,
                Range = "Kangchenjunga Himalaya",
                CountryOrRegion = "Nepal / India",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Elevation and historical ranking from Himalayan survey data and standard world highest mountains lists."
            },

            new Peak
            {
                Name = "Lhotse",
                Description =
                    "Fourth highest peak, directly south of Everest, sharing the Khumbu Icefall and Western Cwm approach before splitting at the Lhotse Face.",
                ElevationMeters = 8516.0,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Height and route context from Himalayan mapping and standard Everest-Lhotse climbing accounts."
            },

            new Peak
            {
                Name = "Makalu",
                Description =
                    "Prominent pyramid shaped 8,000er southeast of Everest on the Nepal-China border with steep ridges and highly exposed summit approaches.",
                ElevationMeters = 8485.0,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Elevation and prominence from Nepal and Chinese surveys and consolidated high mountain reference lists."
            },

            new Peak
            {
                Name = "Cho Oyu",
                Description =
                    "Large glaciated peak west of Everest on the Nepal-China border, often regarded as one of the more attainable eight thousanders.",
                ElevationMeters = 8188.0,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Height and location from national surveys and international Himalayan databases."
            },

            new Peak
            {
                Name = "Dhaulagiri I",
                Description =
                    "Seventh highest peak rising abruptly above the Kali Gandaki gorge in central Nepal, once considered the highest mountain in the world.",
                ElevationMeters = 8167.0,
                Range = "Dhaulagiri Himalaya",
                CountryOrRegion = "Nepal",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Elevation and prominence from Nepal survey data and classical highest mountains listings."
            },

            new Peak
            {
                Name = "Manaslu",
                Description =
                    "High isolated eight thousander in west central Nepal with extensive glaciated faces and an approach that passes through culturally rich Manaslu valleys.",
                ElevationMeters = 8163.0,
                Range = "Manaslu Himalaya",
                CountryOrRegion = "Nepal",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Height and range assignment from Nepal government topographic mapping and Himalayan peak databases."
            },

            new Peak
            {
                Name = "Nanga Parbat",
                Description =
                    "Massive isolated peak in northern Pakistan, historically known as the Killer Mountain for early expedition fatalities and the vast Rupal Face.",
                ElevationMeters = 8126.0,
                Range = "Nanga Parbat Himalaya",
                CountryOrRegion = "Pakistan",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Elevation and historical nickname from Pakistani surveys and classic Himalayan mountaineering accounts."
            },

            new Peak
            {
                Name = "Annapurna I",
                Description =
                    "First eight thousand meter peak ever climbed, located in central Nepal and known for serious avalanche exposure and historically high fatality rates.",
                ElevationMeters = 8091.0,
                Range = "Annapurna Himalaya",
                CountryOrRegion = "Nepal",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Height and ascent history from Annapurna expedition records and consolidated eight thousander lists."
            },

            new Peak
            {
                Name = "Gasherbrum I",
                Description =
                    "Highest peak of the Gasherbrum group on the Pakistan-China border, sometimes called Hidden Peak, located deep in the Baltoro Karakoram.",
                ElevationMeters = 8080.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Elevation and alternative name from Karakoram survey data and standard eight thousander references."
            },

            new Peak
            {
                Name = "Broad Peak",
                Description =
                    "Long ridge like eight thousander near K2 with several tops along a broad crest, offering sustained high altitude climbing.",
                ElevationMeters = 8051.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Height and geographic setting from Pakistan and Chinese mapping and high peak catalogues."
            },

            new Peak
            {
                Name = "Gasherbrum II",
                Description =
                    "Second highest summit in the Gasherbrum group, often regarded as among the more straightforward eight thousanders but still a serious Karakoram climb.",
                ElevationMeters = 8035.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Elevation from Karakoram survey data and international eight thousander listings."
            },

            new Peak
            {
                Name = "Shishapangma",
                Description =
                    "Lowest of the fourteen eight thousanders, located entirely within Tibet with a complex summit ridge and distinct central and main summits.",
                ElevationMeters = 8027.0,
                Range = "Jugal / Langtang Himalaya",
                CountryOrRegion = "China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                Reference =
                    "Height and location from Chinese topographic surveys and standard Himalayan reference works."
            },

            // Seven Summits (including both Oceania variants)

            new Peak
            {
                Name = "Aconcagua",
                Description =
                    "Highest mountain in South America and in the Western and Southern Hemispheres, a high Andean massif in Argentina near the Chilean border.",
                ElevationMeters = 6962.0,
                Range = "Principal Cordillera, Andes",
                CountryOrRegion = "Argentina",
                Continent = "South America",
                IsEightThousander = false,
                IsSevenSummit = true,
                Reference =
                    "Elevation and Seven Summits status from Argentine survey results and standard Aconcagua guidebook sources."
            },

            new Peak
            {
                Name = "Denali",
                Description =
                    "Highest peak in North America in the Alaska Range, rising about five and a half kilometers above its base and known for very cold and stormy conditions.",
                ElevationMeters = 6190.0,
                Range = "Alaska Range",
                CountryOrRegion = "United States (Alaska)",
                Continent = "North America",
                IsEightThousander = false,
                IsSevenSummit = true,
                Reference =
                    "Official 6190 meter height from USGS remeasurement and major Seven Summits references."
            },

            new Peak
            {
                Name = "Mount Kilimanjaro",
                Description =
                    "Free standing stratovolcano in northern Tanzania and the highest peak in Africa, with rainforest, moorland and alpine desert zones below glaciated summit slopes.",
                ElevationMeters = 5895.0,
                Range = "Isolated volcanic massif",
                CountryOrRegion = "Tanzania",
                Continent = "Africa",
                IsEightThousander = false,
                IsSevenSummit = true,
                Reference =
                    "5895 meter elevation and descriptive overview from Tanzanian survey data and educational sources such as UNESCO and geographic texts."
            },

            new Peak
            {
                Name = "Mount Elbrus",
                Description =
                    "Dormant volcanic dome in the western Caucasus of Russia, generally regarded as the highest peak in Europe and a key Seven Summits objective.",
                ElevationMeters = 5642.0,
                Range = "Caucasus Mountains",
                CountryOrRegion = "Russia",
                Continent = "Europe",
                IsEightThousander = false,
                IsSevenSummit = true,
                Reference =
                    "Elevation and continental high point status from Russian mapping and Seven Summits literature."
            },

            new Peak
            {
                Name = "Mount Vinson",
                Description =
                    "Highest mountain in Antarctica, part of the Vinson Massif in the Sentinel Range, noted for extreme cold, remoteness and logistical challenges.",
                ElevationMeters = 4892.0,
                Range = "Sentinel Range, Ellsworth Mountains",
                CountryOrRegion = "Antarctica",
                Continent = "Antarctica",
                IsEightThousander = false,
                IsSevenSummit = true,
                Reference =
                    "Height and description from Antarctic survey data and expedition accounts used in Seven Summits discussions."
            },

            new Peak
            {
                Name = "Carstensz Pyramid",
                Description =
                    "Also known as Puncak Jaya, a steep limestone and dolomite peak in the Sudirman Range of New Guinea, considered the highest point of Oceania in the Messner Seven Summits list.",
                ElevationMeters = 4884.0,
                Range = "Sudirman Range",
                CountryOrRegion = "Indonesia (Papua)",
                Continent = "Oceania",
                IsEightThousander = false,
                IsSevenSummit = true,
                Reference =
                    "Elevation and Seven Summits role from Indonesian mapping data and widely cited Seven Summits references."
            },

            new Peak
            {
                Name = "Mount Kosciuszko",
                Description =
                    "Rounded summit in New South Wales that forms the highest point on the Australian mainland and the summit used in the Bass Seven Summits variant.",
                ElevationMeters = 2228.0,
                Range = "Snowy Mountains, Great Dividing Range",
                CountryOrRegion = "Australia",
                Continent = "Australia",
                IsEightThousander = false,
                IsSevenSummit = true,
                Reference =
                    "Height and high point status from Australian survey data and discussions comparing Kosciuszko with Carstensz Pyramid in Seven Summits lists."
            }
        }
    );

    public static IReadOnlyList<Peak> GetPeaks() => _peaks;
}
