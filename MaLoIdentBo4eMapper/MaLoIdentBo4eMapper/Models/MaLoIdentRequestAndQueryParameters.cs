using System.Text.Json.Serialization;
using MaLoIdentModels;

namespace MaLoIdentBo4eMapper.Models;

/// <summary>
/// combines the information from a MaLoIdent request body with the query parameters and all metadata that are relevant internally
/// </summary>
public class MaLoIdentRequestAndQueryParameters
{
    /// <summary>
    /// Primary Key, only used to save instances of this type to a relational database
    /// </summary>
    [JsonIgnore]
    public Guid? Id { get; set; } = null;

    /// <summary>
    /// <inheritdoc cref="MaLoIdentModels.IdentificationParameter"/>
    /// from the original Lief request body
    /// </summary>
    [JsonPropertyName("identificationParameter")]
    public required IdentificationParameter IdentificationParameter { get; init; }

    /// <summary>
    /// transaction ID from the original Lief request query parameter
    /// </summary>
    [JsonPropertyName("transactionId")]
    public required Guid TransactionId { get; init; }

    /// <summary>
    /// creation date and time from the original Lief request query parameter
    /// </summary>
    [JsonPropertyName("creationDateTime")]
    public required DateTimeOffset CreationDateTime { get; init; }

    /// <summary>
    /// optional initial transaction ID from the original Lief request query parameter
    /// </summary>
    [JsonPropertyName("initialTransactionId")]
    public Guid? InitialTransactionId { get; init; } = null;
}
