using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SilkTouchX.Clang;

namespace SilkTouchX.Mods;

/// <summary>
/// A mod that changes namespaces in response files. It is assumed that there will be no other sources of variance with
/// regards to namespaces.
/// </summary>
[ModConfiguration<Configuration>]
public class ChangeNamespace : IMod
{
    private readonly ILogger<ChangeNamespace> _logger;
    private readonly IOptionsSnapshot<Configuration> _config;

    /// <summary>
    /// The configuration for the change namespace mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// A mapping of namespace regexes to replacements.
        /// </summary>
        public required Dictionary<string, string>? Mappings { get; init; }
    }

    /// <summary>
    /// Creates an instance of this mod.
    /// </summary>
    /// <param name="logger">The logger.</param>
    /// <param name="config">Configuration snapshot.</param>
    public ChangeNamespace(ILogger<ChangeNamespace> logger, IOptionsSnapshot<Configuration> config)
        => (_logger, _config) = (logger, config);

    /// <inheritdoc />
    public Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        _logger.LogInformation("num mappings: {0}", _config.Get(key).Mappings?.Count);
        return Task.FromResult(rsps);
    }
}
