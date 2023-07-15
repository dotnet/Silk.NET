using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Logging;
using SilkTouchX.Clang;
using Diagnostic = ClangSharp.Diagnostic;

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
    /// Generates binding syntax trees per the given configuration.
    /// </summary>
    /// <param name="job">The configuration.</param>
    /// <returns>The generated bindings' syntax trees.</returns>
    public async Task<GeneratedSyntax> GenerateSyntaxAsync(SilkTouchConfiguration job)
    {
        // Read the response files
        var rsps = job.ClangSharpResponseFiles.SelectMany(file =>
                _rspHandler.ReadResponseFiles(file, job.ClangSharpResponseFiles))
            .ToList();

        // Figure out what the common root is so we can aggregate the file paths without collisions
        var srcRoot = job.InputSourceRoot ?? GetLongestCommonPath(rsps.Select(x => x.GeneratorConfiguration.OutputLocation));
        var testRoot = job.InputTestRoot ??
                       GetLongestCommonPath(rsps.Select(x => x.GeneratorConfiguration.TestOutputLocation));
        srcRoot = Path.GetFullPath(srcRoot);
        testRoot = Path.GetFullPath(testRoot);

        // TODO mod the response files

        // Run the scraper over the response files
        var aggregatedBindings = new ConcurrentDictionary<string, Stream>();
        var aggregatedDiagnostics = new ConcurrentBag<Diagnostic>();
        await Parallel.ForEachAsync(rsps,
            async (rsp, ct) => await Task.Run(() => {
                var rawBindings = _scraper.ScrapeRawBindings(rsp);
                foreach (var (k, v) in rawBindings.Files)
                {
                    string relativeKey;
                    if (k.StartsWith("sources/"))
                    {
                        relativeKey =
                            Path.Combine(
                                "sources",
                                Path.GetRelativePath(srcRoot, rsp.GeneratorConfiguration.OutputLocation),
                                k[8..]);
                    }
                    else if (k.StartsWith("tests/"))
                    {
                        relativeKey =
                            Path.Combine(
                                "tests",
                                Path.GetRelativePath(testRoot, rsp.GeneratorConfiguration.TestOutputLocation),
                                k[6..]);
                    }
                    else
                    {
                        throw new InvalidOperationException("Bad scraper output keys.");
                    }

                    relativeKey = relativeKey.Replace('\\', '/').TrimEnd('/');
                    if (!aggregatedBindings.TryAdd(relativeKey, v))
                    {
                        _logger.LogError("Failed to add {0} - are the response file outputs conflicting?", relativeKey);
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
            }, ct));

        // Read the bindings as syntax trees
        var syntaxTrees = aggregatedBindings.ToDictionary(kvp => kvp.Key,
            kvp => CSharpSyntaxTree.ParseText(SourceText.From(kvp.Value)).GetRoot());
        aggregatedBindings.Clear(); // GC ASAP

        // TODO mod the bindings
        // TODO convert the syntax trees back to streams

        // Output the generated bindings
        return new GeneratedSyntax(syntaxTrees, aggregatedDiagnostics.ToList());
    }

    /// <summary>
    /// Generates bindings and stores them in memory-mapped file streams.
    /// </summary>
    /// <param name="job">The generation configuration.</param>
    /// <returns>The generated bindings as memory-mapped streams.</returns>
    public async Task<GeneratedBindings> GenerateBindingsAsync(SilkTouchConfiguration job)
    {
        var result = await GenerateSyntaxAsync(job);
        return new GeneratedBindings(result.Files.ToDictionary(x => x.Key, x => {
            // Create a temporary stream - this will be copied into a mmap later to ensure that we don't eat RAM
            using var ms = new MemoryStream();
            using var sw = new StreamWriter(ms);
            x.Value.WriteTo(sw);
            sw.Flush();
            ms.Seek(0, SeekOrigin.Begin);

            // Create a memory-mapped file
            var mmf = MemoryMappedFile.CreateNew(null, ms.Length);
            using var stream = mmf.CreateViewStream();
            ms.CopyTo(stream);
            stream.Flush();

            // Return a read-only stream to ensure noone tries to write to it directly
            return (Stream)mmf.CreateViewStream(0, ms.Length, MemoryMappedFileAccess.Read);
        }), result.Diagnostics);
    }

    /// <summary>
    /// Generates bindings and outputs them in accordance to the given configuration.
    /// </summary>
    /// <param name="job">The generation configuration.</param>
    public async Task<IReadOnlyList<Diagnostic>> OutputBindingsAsync(SilkTouchConfiguration job)
    {
        var result = await GenerateSyntaxAsync(job);
        if (string.IsNullOrWhiteSpace(job.OutputSourceRoot))
        {
            _logger.LogWarning("Not outputting source files due to OutputSourceRoot being omitted.");
        }
        if (string.IsNullOrWhiteSpace(job.OutputTestRoot))
        {
            _logger.LogWarning("Not outputting test files due to OutputTestRoot being omitted.");
        }
        _logger.LogDebug("{0} files to write", result.Files.Count);
        foreach (var (path, syntax) in result.Files)
        {
            string outPath;
            if (path.StartsWith("sources/") && !string.IsNullOrWhiteSpace(job.OutputSourceRoot))
            {
                outPath = Path.Combine(job.OutputSourceRoot, path[8..]);
            }
            else if (path.StartsWith("tests/") && !string.IsNullOrWhiteSpace(job.OutputTestRoot))
            {
                outPath = Path.Combine(job.OutputTestRoot, path[6..]);
            }
            else
            {
                continue;
            }

            _logger.LogTrace("{0} -> {1}", path, outPath);
            if (!Directory.Exists(Path.GetDirectoryName(outPath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outPath) ??
                                          throw new ArgumentException("Bad generated binding keys."));
            }

            await using var sw = new StreamWriter(outPath);
            syntax.NormalizeWhitespace().WriteTo(sw);
            await sw.FlushAsync();
        }

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
        var ret = GetLongestCommonPrefix(s.Select(x => Path.GetFullPath(x.Replace('\\', '/').TrimEnd('/'))).ToArray());
        Debug.Assert(Directory.Exists(ret));
        return ret;
    }
}
