using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Logging;
using SilkTouchX.Clang;
using SilkTouchX.Mods;
using SilkTouchX.Workspace;
using Diagnostic = ClangSharp.Diagnostic;

namespace SilkTouchX;

/// <summary>
/// The main entry-point class for SilkTouch.
/// </summary>
public class SilkTouchGenerator
{
    private readonly IReadOnlyList<IMod> _mods;
    private readonly ClangScraper _scraper;
    private readonly ResponseFileHandler _rspHandler;
    private readonly ILogger<SilkTouchGenerator> _logger;
    private readonly IOutputWriter _outputWriter;

    /// <summary>
    /// Creates an instance with the given underlying scraper, response file handler, and logger.
    /// </summary>
    /// <param name="scraper">The scraper.</param>
    /// <param name="rspHandler">The response file handler.</param>
    /// <param name="logger">The logger.</param>
    /// <param name="mods">The mods to use.</param>
    /// <param name="outputWriter">The output writer to use.</param>
    public SilkTouchGenerator(
        ClangScraper scraper,
        ResponseFileHandler rspHandler,
        ILogger<SilkTouchGenerator> logger,
        IEnumerable<IMod> mods,
        IOutputWriter outputWriter
    ) =>
        (_scraper, _rspHandler, _logger, _mods, _outputWriter) = (
            scraper,
            rspHandler,
            logger,
            mods.ToArray(),
            outputWriter
        );

    /// <summary>
    /// Generates binding syntax trees per the given configuration.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="job">The configuration.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    /// <returns>The generated bindings' syntax trees.</returns>
    public async Task<GeneratedSyntax> GenerateSyntaxAsync(
        string key,
        SilkTouchConfiguration job,
        CancellationToken ct = default
    )
    {
        // Prepare the mods
        foreach (var mod in _mods)
        {
            _logger.LogDebug("Using mod {0} for {1}", mod.GetType().Name, key);
            await mod.BeforeJobAsync(key, job);
        }

        // Read the response files
        _logger.LogInformation("Reading response files for {0}, please wait...", key);
        var rsps = job.ClangSharpResponseFiles
            .SelectMany(file => _rspHandler.ReadResponseFiles(file, job.ClangSharpResponseFiles))
            .ToList();

        // Figure out what the common root is so we can aggregate the file paths without collisions
        var srcRoot =
            job.InputSourceRoot
            ?? GetLongestCommonPath(rsps.Select(x => x.GeneratorConfiguration.OutputLocation));
        var testRoot =
            job.InputTestRoot
            ?? GetLongestCommonPath(rsps.Select(x => x.GeneratorConfiguration.TestOutputLocation));
        srcRoot = Path.GetFullPath(srcRoot);
        testRoot = Path.GetFullPath(testRoot);

        // Mod the response files
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var mod in _mods)
        {
            _logger.LogInformation(
                "Applying {0} mod to response files for {1}...",
                mod.GetType().Name,
                key
            );
            rsps = await mod.BeforeScrapeAsync(key, rsps);
        }

        // Run the scraper over the response files
        var aggregatedBindings = new ConcurrentDictionary<string, Stream>();
        var aggregatedDiagnostics = new ConcurrentBag<Diagnostic>();
        await Parallel.ForEachAsync(
            rsps,
            ct,
            async (rsp, innerCt) =>
                await Task.Run(
                    () =>
                    {
                        var rawBindings = _scraper.ScrapeRawBindings(rsp);
                        foreach (var (k, v) in rawBindings.Files)
                        {
                            string relativeKey;
                            if (k.StartsWith("sources/"))
                            {
                                relativeKey = Path.Combine(
                                    "sources",
                                    Path.GetRelativePath(
                                        srcRoot,
                                        rsp.GeneratorConfiguration.OutputLocation
                                    ),
                                    k[8..]
                                );
                            }
                            else if (k.StartsWith("tests/"))
                            {
                                relativeKey = Path.Combine(
                                    "tests",
                                    Path.GetRelativePath(
                                        testRoot,
                                        rsp.GeneratorConfiguration.TestOutputLocation
                                    ),
                                    k[6..]
                                );
                            }
                            else
                            {
                                throw new InvalidOperationException("Bad scraper output keys.");
                            }

                            relativeKey = relativeKey.Replace('\\', '/').TrimEnd('/');
                            if (
                                !aggregatedBindings.TryAdd(
                                    relativeKey,
                                    job.ManualOverrides?.TryGetValue(relativeKey, out var @override)
                                    ?? false
                                        ? File.OpenRead(@override)
                                        : v
                                )
                            )
                            {
                                _logger.LogError(
                                    "Failed to add {0} - are the response file outputs conflicting?",
                                    relativeKey
                                );
                            }
                            else
                            {
                                _logger.LogTrace("ClangSharp generated {0}", relativeKey);
                            }
                        }

                        foreach (var diag in rawBindings.Diagnostics)
                        {
                            aggregatedDiagnostics.Add(diag);
                        }
                    },
                    innerCt
                )
        );

        // Read the bindings as syntax trees
        _logger.LogInformation("Parsing bindings for {0}...", key);
        var syntaxTrees = aggregatedBindings.ToDictionary(
            kvp => kvp.Key,
            kvp => CSharpSyntaxTree.ParseText(SourceText.From(kvp.Value)).GetRoot()
        );
        aggregatedBindings.Clear(); // GC ASAP
        var bindings = new GeneratedSyntax(syntaxTrees, aggregatedDiagnostics.ToList());

        // Mod the bindings
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var mod in _mods)
        {
            _logger.LogInformation(
                "Applying {0} mod to syntax trees for {1}...",
                mod.GetType().Name,
                key
            );
            bindings = await mod.AfterScrapeAsync(key, bindings);
        }

        // Output the generated bindings
        return bindings;
    }

    /// <summary>
    /// Generates bindings and outputs them in accordance to the given configuration.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="job">The generation configuration.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    public async Task<IReadOnlyList<Diagnostic>> OutputBindingsAsync(
        string key,
        SilkTouchConfiguration job,
        CancellationToken ct = default
    )
    {
        // Generate syntax
        var result = await GenerateSyntaxAsync(key, job, ct);
        if (result.Files.Count == 0)
        {
            _logger.LogWarning("Not outputting as no files were generated.");
            return result.Diagnostics;
        }

        await _outputWriter.OutputAsync(key, job, result, ct);
        return result.Diagnostics;
    }

    internal static string GetLongestCommonPrefix(string[] s)
    {
        var k = s[0].Length;
        for (var i = 1; i < s.Length; i++)
        {
            k = Math.Min(k, s[i].Length);
            for (var j = 0; j < k; j++)
            {
                if (s[i][j] == s[0][j])
                {
                    continue;
                }

                k = j;
                break;
            }
        }
        return s[0][..k];
    }

    internal static string GetLongestCommonPath(IEnumerable<string> s)
    {
        var ret = GetLongestCommonPrefix(
            s.Select(x => Path.GetFullPath(x.Replace('\\', '/').TrimEnd('/'))).ToArray()
        );
        Debug.Assert(Directory.Exists(ret));
        return ret;
    }
}
