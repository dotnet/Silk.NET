using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ClangSharp;
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
        var regexes = _config.Get(key).Mappings?.Select(kvp => (new Regex(kvp.Key), kvp.Value)).ToArray() ??
                      Array.Empty<(Regex, string)>();
        var tmp = Path.GetTempFileName();
        for (var i = 0; i < rsps.Count; i++)
        {
            var rsp = rsps[i];
            var def = ModUtils.GroupedRegexReplace(regexes, rsp.GeneratorConfiguration.DefaultNamespace);
            var with = new Dictionary<string, string>();
            foreach (var (symbol, toNamespace) in rsp.GeneratorConfiguration.WithNamespaces)
            {
                with[symbol] = ModUtils.GroupedRegexReplace(regexes, toNamespace);
            }

            File.WriteAllText(tmp, rsp.GeneratorConfiguration.HeaderText);
            rsps[i] = rsp with {
                GeneratorConfiguration = new PInvokeGeneratorConfiguration(rsp.GeneratorConfiguration.Language,
                    rsp.GeneratorConfiguration.LanguageStandard,
                    def,
                    rsp.GeneratorConfiguration.OutputLocation,
                    tmp,
                    rsp.GeneratorConfiguration.OutputMode,
                    rsp.GeneratorConfiguration.ReconstructOptions())
                {
                    DefaultClass = rsp.GeneratorConfiguration.DefaultClass,
                    ExcludedNames = rsp.GeneratorConfiguration.ExcludedNames,
                    IncludedNames = rsp.GeneratorConfiguration.IncludedNames,
                    LibraryPath = rsp.GeneratorConfiguration.LibraryPath,
                    MethodPrefixToStrip = rsp.GeneratorConfiguration.MethodPrefixToStrip,
                    NativeTypeNamesToStrip = rsp.GeneratorConfiguration.NativeTypeNamesToStrip,
                    RemappedNames = rsp.GeneratorConfiguration.RemappedNames,
                    TraversalNames = rsp.GeneratorConfiguration.TraversalNames,
                    TestOutputLocation = rsp.GeneratorConfiguration.TestOutputLocation,
                    WithAccessSpecifiers = rsp.GeneratorConfiguration.WithAccessSpecifiers,
                    WithAttributes = rsp.GeneratorConfiguration.WithAttributes,
                    WithCallConvs = rsp.GeneratorConfiguration.WithCallConvs,
                    WithClasses = rsp.GeneratorConfiguration.WithClasses,
                    WithGuids = rsp.GeneratorConfiguration.WithGuids,
                    WithLibraryPaths = rsp.GeneratorConfiguration.WithLibraryPaths,
                    WithManualImports = rsp.GeneratorConfiguration.WithManualImports,
                    WithNamespaces = with,
                    WithSetLastErrors = rsp.GeneratorConfiguration.WithSetLastErrors,
                    WithSuppressGCTransitions = rsp.GeneratorConfiguration.WithSuppressGCTransitions,
                    WithTransparentStructs = rsp.GeneratorConfiguration.WithTransparentStructs,
                    WithTypes = rsp.GeneratorConfiguration.WithTypes,
                    WithUsings = rsp.GeneratorConfiguration.WithUsings,
                    WithPackings = rsp.GeneratorConfiguration.WithPackings,
                }
            };
        }

        File.Delete(tmp);
        return Task.FromResult(rsps);
    }
}
