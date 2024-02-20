using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Sources;
using Silk.NET.SilkTouch.Workspace;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;
using Diagnostic = ClangSharp.Diagnostic;

namespace Silk.NET.SilkTouch;

/// <summary>
/// The main entry-point class for SilkTouch.
/// </summary>
/// <param name="scraper">The scraper.</param>
/// <param name="rspHandler">The response file handler.</param>
/// <param name="logger">The logger.</param>
/// <param name="mods">The mods to use.</param>
/// <param name="outputWriter">The output writer to use.</param>
/// <param name="inputResolver">The user path input resolver.</param>
/// <param name="cacheProvider">The cache provider.</param>
public class SilkTouchGenerator(
    ClangScraper scraper,
    ResponseFileHandler rspHandler,
    // ReSharper disable once SuggestBaseTypeForParameterInConstructor
    ILogger<SilkTouchGenerator> logger,
    IEnumerable<IMod> mods,
    IOutputWriter outputWriter,
    IInputResolver inputResolver,
    ICacheProvider cacheProvider
)
{
    private static readonly HashSet<string> ApplicableSkipIfs;

    static SilkTouchGenerator() =>
        ApplicableSkipIfs = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            // Windows-specific conditions
            OperatingSystem.IsWindows()
                ? "win"
                : "!win",
            OperatingSystem.IsWindowsVersionAtLeast(10) ? "win10" : "!win10",
            // Linux-specific conditions
            OperatingSystem.IsLinux()
                ? "linux"
                : "!linux",
            // macOS-specific conditions - .NET 6 doesn't support anything less than Mojave
            OperatingSystem.IsMacOS()
                ? "macos"
                : "!macos",
            OperatingSystem.IsMacOSVersionAtLeast(10, 14) ? "macos-mojave" : "!macos-mojave",
            OperatingSystem.IsMacOSVersionAtLeast(10, 15) ? "macos-catalina" : "!macos-catalina",
            OperatingSystem.IsMacOSVersionAtLeast(11) ? "macos-big-sur" : "!macos-big-sur",
            OperatingSystem.IsMacOSVersionAtLeast(12) ? "macos-monterey" : "!macos-monterey",
            // Others
            VisualStudioResolver.TryGetVisualStudioInfo(out _)
                ? "vs"
                : "!vs"
        };

    private AsyncLocal<SilkTouchConfiguration> _jobConfig = new();

    /// <summary>
    /// Gets the loaded mods for this generator instance.
    /// </summary>
    public IReadOnlyList<IMod> Mods { get; } = mods.ToArray();

    /// <summary>
    /// The current job.
    /// </summary>
    public SilkTouchConfiguration? Current => _jobConfig.Value;

    /// <summary>
    /// Generates binding syntax trees per the given configuration.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="jobConfig">The configuration, expected to be stored as <c>Jobs:{key}</c>.</param>
    /// <param name="parallelism">Maximum number of parallel executions.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    /// <returns>The generated bindings' syntax trees.</returns>
    public async Task<GeneratedSyntax> GenerateSyntaxAsync(
        string key,
        IConfigurationRoot jobConfig,
        int parallelism,
        CancellationToken ct = default
    )
    {
        var sw = Stopwatch.StartNew();
        var job =
            jobConfig.GetRequiredSection($"Jobs:{key}").Get<SilkTouchConfiguration>()
            ?? throw new InvalidOperationException("Configuration was null");
        job = await inputResolver.Resolve(job);
        _jobConfig.Value = job;
        // Prepare the mods
        var jobMods =
            job.Mods?.Select(x => Mods.First(y => y.GetType().Name == x)).ToArray()
            ?? Array.Empty<IMod>();
        foreach (var mod in jobMods)
        {
            logger.LogDebug("Using mod {0} for {1}", mod.GetType().Name, key);
            await mod.BeforeJobAsync(key, job);
        }

        // Read the response files
        logger.LogInformation("Reading response files for {0}, please wait...", key);
        var rsps = job
            .ClangSharpResponseFiles.SelectMany(file =>
                rspHandler.ReadResponseFiles(file, job.ClangSharpResponseFiles)
            )
            .ToList();
        var cacheKey = (
            string.Join(
                ',',
                jobConfig
                    .AsEnumerable()
                    .Where(x => x.Key.StartsWith($"Jobs:{key}", StringComparison.OrdinalIgnoreCase))
                    .OrderBy(x => x.Key)
            ) + string.Join(',', rsps.Select(x => x.FileHash).Order())
        )
            .Replace('\\', '/')
            .ToLower();
        logger.LogDebug("Cache key for job (before hashing): {}", cacheKey);
        cacheKey = Convert.ToHexString(XxHash64.Hash(Encoding.UTF8.GetBytes(cacheKey)));
        logger.LogDebug("Final cache key: {}", cacheKey);
        GeneratedBindings? rawBindings = null;
        var skip = (job.SkipScrapeIf?.Any(ApplicableSkipIfs.Contains)).GetValueOrDefault();
        Exception? innerException = null;
        // Mod the response files
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var mod in jobMods)
        {
            logger.LogInformation(
                "Applying {0} mod to response files for {1}...",
                mod.GetType().Name,
                key
            );
            rsps = await mod.BeforeScrapeAsync(key, rsps);
        }

        try
        {
            if (!skip)
            {
                // Resolve any foreign paths referenced in the response files
                await inputResolver.ResolveInPlace(rsps);

                // Run the scraper over the response files
                rawBindings = await scraper.ScrapeRawBindings(rsps, job, parallelism, ct);

                // Cache the bindings if we have a reason to
                if (
                    job.SkipScrapeIf?.Length > 0
                    && rawBindings.Diagnostics.All(x => x.Level != DiagnosticLevel.Error)
                )
                {
                    var dirOpt = await cacheProvider.GetDirectory(
                        cacheKey,
                        CacheIntent.StageIntermediateOutput,
                        CacheFlags.RequireNewLocked | CacheFlags.NoHostDirectory
                    );
                    if (dirOpt is not null)
                    {
                        foreach (var (path, contents) in rawBindings.Files)
                        {
                            await cacheProvider.CommitFile(
                                cacheKey,
                                CacheIntent.StageIntermediateOutput,
                                CacheFlags.RequireNewLocked | CacheFlags.NoHostDirectory,
                                path,
                                contents
                            );
                            contents.Seek(0, SeekOrigin.Begin);
                        }

                        await cacheProvider.CommitDirectory(
                            cacheKey,
                            CacheIntent.StageIntermediateOutput,
                            CacheFlags.RequireNewLocked | CacheFlags.NoHostDirectory
                        );
                    }
                }
            }
        }
        catch (Exception e)
        {
            logger.LogError(e, "Failed to scrape raw bindings, will attempt to use the cache...");
            skip = true;
            innerException = e;
        }
        finally
        {
            if (skip)
            {
                var dirOpt = await cacheProvider.GetDirectory(
                    cacheKey,
                    CacheIntent.StageIntermediateOutput,
                    CacheFlags.NoHostDirectory
                );
                if (dirOpt is not null)
                {
                    rawBindings = new GeneratedBindings(
                        new Dictionary<string, Stream>(),
                        Array.Empty<Diagnostic>()
                    );
                    foreach (
                        var file in await cacheProvider.GetFiles(
                            cacheKey,
                            CacheIntent.StageIntermediateOutput,
                            CacheFlags.NoHostDirectory
                        )
                    )
                    {
                        rawBindings.Files[file] = await cacheProvider.GetFile(
                            cacheKey,
                            CacheIntent.StageIntermediateOutput,
                            CacheFlags.NoHostDirectory,
                            file
                        );
                    }
                }
                else
                {
                    logger.LogError("Failed to retrieve cache.");
                }
            }
        }

        if (rawBindings is null)
        {
            throw new InvalidOperationException(
                "Unable to generate raw bindings and failed to find cached ClangSharp outputs.",
                innerException
            );
        }

        // Read the bindings as syntax trees
        logger.LogInformation("Parsing bindings for {0}...", key);
        var syntaxTrees = rawBindings.Files.ToDictionary(
            kvp => kvp.Key,
            kvp => CSharpSyntaxTree.ParseText(SourceText.From(kvp.Value)).GetRoot()
        );
        rawBindings.Files.Clear(); // GC ASAP
        var bindings = new GeneratedSyntax(syntaxTrees, rawBindings.Diagnostics);

        // Mod the bindings
        // ReSharper disable once LoopCanBeConvertedToQuery
        foreach (var mod in jobMods)
        {
            logger.LogInformation(
                "Applying {0} mod to syntax trees for {1}...",
                mod.GetType().Name,
                key
            );
            bindings = await mod.AfterScrapeAsync(key, bindings);
        }

        // Add a license header to files that don't have one
        if (job.DefaultLicenseHeader is not null)
        {
            var defaultLicenseHeaderTrivia = (
                await File.ReadAllLinesAsync(job.DefaultLicenseHeader, ct)
            )
                .Where(x => x.Length == 0 || x.StartsWith("//"))
                .Select(x => Comment(x.Trim()))
                .ToArray();
            foreach (var (file, node) in bindings.Files)
            {
                var shouldAddHeader =
                    !node.GetLeadingTrivia()
                        .Any(x => x.Kind() is SyntaxKind.SingleLineCommentTrivia)
                    || !(
                        node.ChildNodes()
                            .FirstOrDefault()
                            ?.GetLeadingTrivia()
                            .Any(x => x.Kind() is SyntaxKind.SingleLineCommentTrivia)
                    ).GetValueOrDefault();
                if (shouldAddHeader)
                {
                    bindings.Files[file] = node.WithLeadingTrivia(
                        defaultLicenseHeaderTrivia.Concat(node.GetLeadingTrivia())
                    );
                }
            }
        }

        // Output the generated bindings
        logger.LogDebug(
            "Bindings generation completed in {} seconds, writing to disk...",
            sw.Elapsed.TotalSeconds
        );
        return bindings;
    }

    /// <summary>
    /// Generates bindings and outputs them in accordance to the given configuration.
    /// </summary>
    /// <param name="key">The name of the current job (used as a configuration key).</param>
    /// <param name="jobConfig">The configuration, expected to be stored as <c>Jobs:{key}</c>.</param>
    /// <param name="parallelism">Maximum degree of parallelism for ClangSharp generation.</param>
    /// <param name="ct">Cancellation token (if any)</param>
    public async Task<IReadOnlyList<Diagnostic>> OutputBindingsAsync(
        string key,
        IConfigurationRoot jobConfig,
        int parallelism,
        CancellationToken ct = default
    )
    {
        var sw = Stopwatch.StartNew();
        // Generate syntax
        var result = await GenerateSyntaxAsync(key, jobConfig, parallelism, ct);
        if (result.Files.Count == 0)
        {
            logger.LogWarning("Not outputting as no files were generated.");
            return result.Diagnostics;
        }

        var job =
            jobConfig.GetRequiredSection($"Jobs:{key}").Get<SilkTouchConfiguration>()
            ?? throw new InvalidOperationException("Config was null");
        await outputWriter.OutputAsync(key, job, result, ct);
        logger.LogInformation(
            "Wrote generated bindings to disk, generation completed in {} seconds.",
            sw.Elapsed.TotalSeconds
        );
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
