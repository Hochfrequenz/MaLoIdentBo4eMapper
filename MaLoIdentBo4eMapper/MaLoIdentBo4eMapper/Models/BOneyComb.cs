using System.Text.Json.Serialization;
using BO4E.BO;

namespace MaLoIdentBo4eMapper.Models;

/// <summary>
/// BOneyComb is the BO4E representation of a marktnachricht as it is used by various services
/// </summary>
public class BOneyComb
{
    /// <summary>
    /// BO4E business objects
    /// </summary>
    [JsonPropertyName("stammdaten")]
    [JsonPropertyOrder(1)]
    public List<BusinessObject>? Stammdaten { get; set; }

    /// <summary>
    /// transaktionsdaten, e.g. containing the Prüfidentikator or metadata of the Marktnachricht/Transaktion
    /// </summary>
    [JsonPropertyName("transaktionsdaten")]
    [JsonPropertyOrder(2)]
    public Dictionary<string, string>? Transaktionsdaten { get; set; }

    /// <summary>
    /// links between various business objects in <see cref="Stammdaten"/>
    /// </summary>
    [JsonPropertyName("links")]
    [JsonPropertyOrder(3)]
    public Dictionary<string, List<string>>? Links { get; set; }
}
