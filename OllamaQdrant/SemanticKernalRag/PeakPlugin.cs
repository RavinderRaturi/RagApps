using Microsoft.SemanticKernel;
using System.ComponentModel;
using System.Globalization;
using System.Text;

 

public class PeakPlugin
{
    private readonly PeakApiService _peakApiService;
    private static readonly List<Peak> Peaks = PeakDatabase.GetPeaks();

    public PeakPlugin(PeakApiService peakApiService)
    {
        _peakApiService = peakApiService;
    }

    [KernelFunction, Description("Get the current date and time")]
    public string Now()
    {
        return DateTime.Now.ToString("f");
    }

    [KernelFunction, Description("Compare two mountain peaks side by side")]
    public async Task<string> ComparePeaks(
        [Description("First peak name")] string peakName1,
        [Description("Second peak name")] string peakName2)
    {
        var peak1 = Peaks.FirstOrDefault(p =>
            p.Name.Equals(peakName1, StringComparison.OrdinalIgnoreCase));
        var peak2 = Peaks.FirstOrDefault(p =>
            p.Name.Equals(peakName2, StringComparison.OrdinalIgnoreCase));

        var extraPeak1Data = await _peakApiService.GetPeakDetailsAsync(peakName1);
        var extraPeak2Data = await _peakApiService.GetPeakDetailsAsync(peakName2);

        var sb = new StringBuilder();
        sb.AppendLine($"\nComparison between '{peakName1}' and '{peakName2}':\n");

        sb.AppendLine($"Name: {peakName1.PadRight(30)} | {peakName2}");

        sb.AppendLine(
            $"Description: {((peak1?.Description ?? "N/A").PadRight(30))} | {peak2?.Description ?? "N/A"}");

        sb.AppendLine(
            $"First ascent year: {((peak1?.IdentificationDate.ToString(CultureInfo.InvariantCulture) ?? "N/A").PadRight(30))} | {peak2?.IdentificationDate.ToString(CultureInfo.InvariantCulture) ?? "N/A"}");

        sb.AppendLine(
            $"Elevation (m): {((peak1?.ElevationMeters.ToString("F1", CultureInfo.InvariantCulture) ?? "N/A").PadRight(30))} | {peak2?.ElevationMeters.ToString("F1", CultureInfo.InvariantCulture) ?? "N/A"}");

        sb.AppendLine(
            $"Range: {((peak1?.Range ?? "N/A").PadRight(30))} | {peak2?.Range ?? "N/A"}");

        sb.AppendLine(
            $"Country / Region: {((peak1?.CountryOrRegion ?? "N/A").PadRight(30))} | {peak2?.CountryOrRegion ?? "N/A"}");

        sb.AppendLine(
            $"Continent: {((peak1?.Continent ?? "N/A").PadRight(30))} | {peak2?.Continent ?? "N/A"}");

        sb.AppendLine(
            $"Categories: {(
                string.Join(", ", extraPeak1Data?.Categories ?? ["N/A"]).PadRight(30)
            )} | {string.Join(", ", extraPeak2Data?.Categories ?? ["N/A"])}");

        sb.AppendLine(
            $"Additional regions: {(
                string.Join(", ", extraPeak1Data?.CountriesOrRegions ?? ["N/A"]).PadRight(30)
            )} | {string.Join(", ", extraPeak2Data?.CountriesOrRegions ?? ["N/A"])}");

        sb.AppendLine(
            $"More Info: {((peak1?.Reference ?? "N/A").PadRight(30))} | {peak2?.Reference ?? "N/A"}");

        return sb.ToString();
    }
}
