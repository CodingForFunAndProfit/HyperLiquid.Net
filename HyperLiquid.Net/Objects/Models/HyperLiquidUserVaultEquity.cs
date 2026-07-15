using CryptoExchange.Net.Converters.SystemTextJson;
using System;
using System.Text.Json.Serialization;

namespace HyperLiquid.Net.Objects.Models;

/// <summary>
/// User Vault Equity
/// </summary>
[SerializationModel]
public record HyperLiquidUserVaultEquity
{
    /// <summary>
    /// ["<c>vaultAddress</c>"] Vault address
    /// </summary>
    [JsonPropertyName("vaultAddress")]
    public string VaultAddress { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>equity</c>"] Equity
    /// </summary>
    [JsonPropertyName("equity")]
    public string Equity { get; set; } = string.Empty;
    /// <summary>
    /// ["<c>lockedUntilTimestamp</c>"] Locked until timestamp
    /// </summary>
    [JsonPropertyName("lockedUntilTimestamp")]
    public DateTime LockedUntilTimestamp { get; set; }
}
