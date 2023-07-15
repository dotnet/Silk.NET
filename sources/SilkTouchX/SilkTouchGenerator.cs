using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.Extensions.Logging;
using SilkTouchX.Clang;

namespace SilkTouchX;

/// <summary>
/// The main entry-point class for SilkTouch.
/// </summary>
public class SilkTouchGenerator
{
    private readonly ClangScraper _scraper;
    private readonly ResponseFileHandler _rspHandler;
    private readonly ILogger<SilkTouchGenerator> _logger;

    /// <summary>
    /// Creates an instance with the given underlying scraper, response file handler, and logger.
    /// </summary>
    /// <param name="scraper">The scraper.</param>
    /// <param name="rspHandler">The response file handler.</param>
    /// <param name="logger">The logger.</param>
    public SilkTouchGenerator(ClangScraper scraper, ResponseFileHandler rspHandler, ILogger<SilkTouchGenerator> logger) =>
        (_scraper, _rspHandler, _logger) = (scraper, rspHandler, logger);

    /// <summary>
    /// Generates bindings per the given configuration.
    /// </summary>
    /// <param name="job">The configuration.</param>
    /// <returns>The generated bindings.</returns>
    public async Task<GeneratedBindings> GenerateBindings(SilkTouchConfiguration job)
    {
        var aggregatedBindings = new ConcurrentDictionary<string, Stream>();
        var aggregatedDiagnostics = new ConcurrentBag<Diagnostic>();
        await Parallel.ForEachAsync(job.ClangSharpResponseFiles,
            async (file, ct) =>
                await Parallel.ForEachAsync(_rspHandler.ReadResponseFiles(file, job.ClangSharpResponseFiles), ct,
                    async (rsp, innerCt) => await Task.Run(() => {
                        var rawBindings = _scraper.ScrapeRawBindings(rsp);
                        foreach (var (k, v) in rawBindings.Files)
                        {
                            if (!aggregatedBindings.TryAdd(k, v))
                            {
                                _logger.LogError("Failed to add {0} - are the response file outputs conflicting?", k);
                            }
                            else
                            {
                                _logger.LogDebug("ClangSharp generated {0}", k);
                            }
                        }

                        foreach (var diag in rawBindings.Diagnostics)
                        {
                            aggregatedDiagnostics.Add(diag);
                        }
                    }, innerCt)));
        return new GeneratedBindings(aggregatedBindings.ToDictionary(kvp => kvp.Key, kvp => kvp.Value),
            aggregatedDiagnostics.ToList());
    }
}
