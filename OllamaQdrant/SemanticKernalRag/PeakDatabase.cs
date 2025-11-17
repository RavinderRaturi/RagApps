using System.Collections.Generic;

 

public static class PeakDatabase
{
    public static List<Peak> GetPeaks()
    {
        var peakData = new List<Peak>
        {
            new()
            {
                Name = "Mount Everest",
                Description = "Highest mountain on Earth located on the crest of the Mahalangur Himal, forming part of the border between Nepal and Tibet.",
                Reference = "https://en.wikipedia.org/wiki/Mount_Everest",
                ElevationMeters = 8848.86,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = true,
                IdentificationDate = 1953
            },
            new()
            {
                Name = "K2",
                Description = "Second highest mountain in the world in the Karakoram range, known for extreme technical difficulty and severe weather.",
                Reference = "https://en.wikipedia.org/wiki/K2",
                ElevationMeters = 8611.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1954
            },
            new()
            {
                Name = "Kangchenjunga",
                Description = "Third highest mountain in the world, located on the border between eastern Nepal and the Indian state of Sikkim.",
                Reference = "https://en.wikipedia.org/wiki/Kangchenjunga",
                ElevationMeters = 8586.0,
                Range = "Kangchenjunga Himalaya",
                CountryOrRegion = "Nepal / India",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1955
            },
            new()
            {
                Name = "Lhotse",
                Description = "Fourth highest mountain on Earth, immediately south of Mount Everest and sharing much of the same standard approach.",
                Reference = "https://en.wikipedia.org/wiki/Lhotse",
                ElevationMeters = 8516.0,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1956
            },
            new()
            {
                Name = "Makalu",
                Description = "Prominent pyramid-shaped peak southeast of Everest, known for steep ridges and demanding climbing.",
                Reference = "https://en.wikipedia.org/wiki/Makalu",
                ElevationMeters = 8485.0,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1955
            },
            new()
            {
                Name = "Cho Oyu",
                Description = "High glaciated Himalayan peak west of Everest, often regarded as one of the more attainable eight-thousanders.",
                Reference = "https://en.wikipedia.org/wiki/Cho_Oyu",
                ElevationMeters = 8188.0,
                Range = "Mahalangur Himalaya",
                CountryOrRegion = "Nepal / China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1954
            },
            new()
            {
                Name = "Dhaulagiri I",
                Description = "Massive isolated peak in central Nepal that rises sharply above the Kali Gandaki gorge.",
                Reference = "https://en.wikipedia.org/wiki/Dhaulagiri",
                ElevationMeters = 8167.0,
                Range = "Dhaulagiri Himalaya",
                CountryOrRegion = "Nepal",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1960
            },
            new()
            {
                Name = "Manaslu",
                Description = "Remote Himalayan peak in west-central Nepal with extensive glaciated faces and a culturally rich approach region.",
                Reference = "https://en.wikipedia.org/wiki/Manaslu",
                ElevationMeters = 8163.0,
                Range = "Manaslu Himalaya",
                CountryOrRegion = "Nepal",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1956
            },
            new()
            {
                Name = "Nanga Parbat",
                Description = "Isolated giant in the western Himalaya, famous for the immense Rupal Face and a difficult mountaineering history.",
                Reference = "https://en.wikipedia.org/wiki/Nanga_Parbat",
                ElevationMeters = 8126.0,
                Range = "Nanga Parbat Himalaya",
                CountryOrRegion = "Pakistan",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1953
            },
            new()
            {
                Name = "Annapurna I",
                Description = "First eight-thousand-meter peak ever climbed, located in central Nepal and known for serious avalanche exposure.",
                Reference = "https://en.wikipedia.org/wiki/Annapurna",
                ElevationMeters = 8091.0,
                Range = "Annapurna Himalaya",
                CountryOrRegion = "Nepal",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1950
            },
            new()
            {
                Name = "Gasherbrum I",
                Description = "Highest summit of the Gasherbrum group in the Karakoram, sometimes called Hidden Peak.",
                Reference = "https://en.wikipedia.org/wiki/Gasherbrum_I",
                ElevationMeters = 8080.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1958
            },
            new()
            {
                Name = "Broad Peak",
                Description = "Long ridge-like peak near K2, named for its broad summit crest with several tops.",
                Reference = "https://en.wikipedia.org/wiki/Broad_Peak",
                ElevationMeters = 8051.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1957
            },
            new()
            {
                Name = "Gasherbrum II",
                Description = "Major summit of the Gasherbrum group, often considered one of the more straightforward eight-thousanders.",
                Reference = "https://en.wikipedia.org/wiki/Gasherbrum_II",
                ElevationMeters = 8035.0,
                Range = "Baltoro Karakoram",
                CountryOrRegion = "Pakistan / China",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1956
            },
            new()
            {
                Name = "Shishapangma",
                Description = "Lowest of the fourteen eight-thousanders and the only one located entirely within Tibet.",
                Reference = "https://en.wikipedia.org/wiki/Shishapangma",
                ElevationMeters = 8027.0,
                Range = "Jugal / Langtang Himalaya",
                CountryOrRegion = "China (Tibet Autonomous Region)",
                Continent = "Asia",
                IsEightThousander = true,
                IsSevenSummit = false,
                IdentificationDate = 1964
            },
            new()
            {
                Name = "Aconcagua",
                Description = "Highest mountain in South America and the highest peak in the Americas, located in the Andes of Argentina.",
                Reference = "https://en.wikipedia.org/wiki/Aconcagua",
                ElevationMeters = 6962.0,
                Range = "Principal Cordillera, Andes",
                CountryOrRegion = "Argentina",
                Continent = "South America",
                IsEightThousander = false,
                IsSevenSummit = true,
                IdentificationDate = 1897
            },
            new()
            {
                Name = "Denali",
                Description = "Highest peak in North America, located in the Alaska Range and known for extreme cold and severe storms.",
                Reference = "https://en.wikipedia.org/wiki/Denali",
                ElevationMeters = 6190.0,
                Range = "Alaska Range",
                CountryOrRegion = "United States (Alaska)",
                Continent = "North America",
                IsEightThousander = false,
                IsSevenSummit = true,
                IdentificationDate = 1913
            },
            new()
            {
                Name = "Mount Kilimanjaro",
                Description = "Free-standing stratovolcano and the highest mountain in Africa, with distinct ecological zones from rainforest to alpine desert.",
                Reference = "https://en.wikipedia.org/wiki/Mount_Kilimanjaro",
                ElevationMeters = 5895.0,
                Range = "Kilimanjaro Massif",
                CountryOrRegion = "Tanzania",
                Continent = "Africa",
                IsEightThousander = false,
                IsSevenSummit = true,
                IdentificationDate = 1889
            },
            new()
            {
                Name = "Mount Elbrus",
                Description = "Dormant volcanic dome in the western Caucasus, widely regarded as the highest peak in Europe.",
                Reference = "https://en.wikipedia.org/wiki/Mount_Elbrus",
                ElevationMeters = 5642.0,
                Range = "Caucasus Mountains",
                CountryOrRegion = "Russia",
                Continent = "Europe",
                IsEightThousander = false,
                IsSevenSummit = true,
                IdentificationDate = 1874
            },
            new()
            {
                Name = "Mount Vinson",
                Description = "Highest mountain in Antarctica, located in the remote Sentinel Range of the Ellsworth Mountains.",
                Reference = "https://en.wikipedia.org/wiki/Vinson_Massif",
                ElevationMeters = 4892.0,
                Range = "Sentinel Range, Ellsworth Mountains",
                CountryOrRegion = "Antarctica",
                Continent = "Antarctica",
                IsEightThousander = false,
                IsSevenSummit = true,
                IdentificationDate = 1966
            },
            new()
            {
                Name = "Carstensz Pyramid",
                Description = "Limestone peak in the Sudirman Range of New Guinea, often treated as the highest point of Oceania in Seven Summits lists.",
                Reference = "https://en.wikipedia.org/wiki/Puncak_Jaya",
                ElevationMeters = 4884.0,
                Range = "Sudirman Range",
                CountryOrRegion = "Indonesia (Papua)",
                Continent = "Oceania",
                IsEightThousander = false,
                IsSevenSummit = true,
                IdentificationDate = 1962
            },
            new()
            {
                Name = "Mount Kosciuszko",
                Description = "Highest summit on the Australian mainland, with a broad rounded summit area in the Snowy Mountains.",
                Reference = "https://en.wikipedia.org/wiki/Mount_Kosciuszko",
                ElevationMeters = 2228.0,
                Range = "Snowy Mountains",
                CountryOrRegion = "Australia",
                Continent = "Australia",
                IsEightThousander = false,
                IsSevenSummit = true,
                IdentificationDate = 1840
            }
        };

        return peakData;
    }
}
