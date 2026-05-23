// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO.Hashing;
using System.Runtime.InteropServices;
using ClangSharp;
using ClangSharp.Interop;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Caching;
using Silk.NET.SilkTouch.Mods;
using Silk.NET.SilkTouch.Sources;
using static ClangSharp.Interop.CXDiagnosticSeverity;
using static ClangSharp.Interop.CXErrorCode;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Primary entrypoint of the Scraper. This class defines logic to extract symbols using ClangSharp
/// </summary>
/// <param name="rspHandler">
/// The handler of response file (.rsp) files i.e. configuration for the ClangSharp generator.
/// </param>
/// <param name="config">The configuration to use.</param>
/// <param name="logger">The logger to use.</param>
/// <param name="inputResolver">The input resolver to use.</param>
/// <param name="responseFileMods">The mods that modify response files before they are fed to ClangSharp.</param>
/// <param name="cacheProvider">The cache provider into which ClangSharp outputs are cached.</param>
[ModConfiguration<Configuration>]
public sealed class ClangScraper(
    ResponseFileHandler rspHandler,
    IOptionsSnapshot<ClangScraper.Configuration> config,
    ILogger<ClangScraper> logger,
    IInputResolver inputResolver,
    ICacheProvider? cacheProvider = null,
    IEnumerable<IJobDependency<IResponseFileMod>>? responseFileMods = null
) : IMod
{
    // TODO add Windows SDK and Xcode configuration

    /// <summary>
    /// Configuration for the <see cref="ClangScraper"/> mod.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The response files to read.
        /// </summary>
        public required string[] ClangSharpResponseFiles { get; init; }

        /// <summary>
        /// Manual overrides for ClangSharp outputs (i.e. manual tweaks of generated output) that should still flow through
        /// the SilkTouch pipeline as if it came from ClangSharp.
        /// </summary>
        public Dictionary<string, string>? ManualOverrides { get; init; }

        /// <summary>
        /// The root output directory as defined in the response files.
        /// </summary>
        public string? InputSourceRoot { get; init; }

        /// <summary>
        /// The test output directory as defined in the response files.
        /// </summary>
        public string? InputTestRoot { get; init; }

        /// <summary>
        /// The number of ClangSharp jobs to run in parallel.
        /// </summary>
        public int Parallelism { get; init; }

        /// <summary>
        /// Skips generation if any of the given strings are in the applicable "skip ifs" are set.
        /// </summary>
        // TODO document
        public string[]? SkipScrapeIf { get; init; }

        /// <summary>
        /// Forces the scraper to use cache. Best used on the command line.
        /// </summary>
        public bool ForceCache { get; init; }
    }

    /// <summary>
    /// Runs ClangSharp to obtain the raw bindings for the given response file.
    /// </summary>
    /// <param name="config">The ClangSharp configuration.</param>
    private (
        IEnumerable<KeyValuePair<string, Stream>> Sources,
        IEnumerable<KeyValuePair<string, Stream>> Tests,
        bool HasErrors
    ) ScrapeRawBindings(ResponseFile config)
    {
        var files = new Dictionary<string, Stream>();

        Stream OutputStreamFactory(string fileName)
        {
            if (files.ContainsKey(fileName))
            {
                logger.LogWarning("ClangSharp has requested to overwrite {0}!", fileName);
            }

            return files[Path.ChangeExtension(fileName, ".gen.cs")] = new MemoryStream();
        }

        LogConfiguration(config);
        using var pinvokeGenerator = new PInvokeGenerator(
            config.GeneratorConfiguration,
            OutputStreamFactory
        );
        var hasErrors = false;
        foreach (var file in config.Files)
        {
            var filePath = Path.Combine(config.FileDirectory, file);
            var fileName = Path.GetFileName(file);
            logger.LogTrace(
                "About to process {0} in accordance with the rsp from {1}",
                filePath,
                config.FileDirectory
            );
            logger.LogTrace(
                "Clang command line args: {0}",
                string.Join(" ", config.ClangCommandLineArgs)
            );

            var translationUnitError = CXTranslationUnit.TryParse(
                pinvokeGenerator.IndexHandle,
                filePath,
                config.ClangCommandLineArgs,
                Array.Empty<CXUnsavedFile>(),
                config.TranslationFlags,
                out var handle
            );
            var skipProcessing = false;

            if (translationUnitError != CXError_Success)
            {
                var msg = $"Parsing failed for '{fileName}' due to '{translationUnitError}'.";
                logger.LogError(msg);
                skipProcessing = true;
            }
            else if (handle.NumDiagnostics != 0)
            {
                logger.LogInformation($"Diagnostics for '{fileName}':");

                for (uint i = 0; i < handle.NumDiagnostics; ++i)
                {
                    using var diagnostic = handle.GetDiagnostic(i);

                    logger.Log(
                        diagnostic.Severity switch
                        {
                            CXDiagnostic_Ignored => LogLevel.Trace,
                            CXDiagnostic_Note => LogLevel.Debug,
                            CXDiagnostic_Warning => LogLevel.Warning,
                            CXDiagnostic_Error => LogLevel.Error,
                            CXDiagnostic_Fatal => LogLevel.Critical,
                            _ => LogLevel.Trace,
                        },
                        "    {0}",
                        diagnostic.Format(CXDiagnostic.DefaultDisplayOptions).ToString()
                    );

                    skipProcessing |= diagnostic.Severity == CXDiagnostic_Error;
                    skipProcessing |= diagnostic.Severity == CXDiagnostic_Fatal;
                }
            }

            if (skipProcessing)
            {
                logger.LogError($"Skipping '{fileName}' due to one or more errors listed above.");
                hasErrors = true;
                continue;
            }

            try
            {
                using var translationUnit = TranslationUnit.GetOrCreate(handle);
                Debug.Assert(translationUnit is not null);

                logger.LogInformation("Generating raw bindings for '{0}'", fileName);
                pinvokeGenerator.GenerateBindings(
                    translationUnit,
                    filePath,
                    config.ClangCommandLineArgs,
                    config.TranslationFlags
                );
                pinvokeGenerator.Close();
                logger.LogDebug(
                    "Completed generation for {0}, file count: {1}",
                    filePath,
                    files.Count
                );
            }
            catch (Exception e)
            {
                logger.LogError(e, "Unhandled exception when generating bindings for {}", filePath);
            }
        }

        var testKeys = files
            .Keys.Where(x => IsSubPathOf(x, config.GeneratorConfiguration.TestOutputLocation))
            .ToHashSet();
        return (
            files.Where(x => !testKeys.Contains(x.Key)),
            testKeys.Select(x => new KeyValuePair<string, Stream>(x, files[x])),
            hasErrors
        );
    }

    /// <summary>
    /// Runs ClangSharp for each of the given response files and aggregates the raw outputs.
    /// </summary>
    /// <param name="rsps">The response files.</param>
    /// <param name="job">The job context.</param>
    /// <param name="cfg">The configuration.</param>
    /// <param name="cacheKey">The cache key.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <exception cref="InvalidOperationException">The scraper output wasn't as expected.</exception>
    private async Task ScrapeBindingsAsync(
        IReadOnlyList<ResponseFile> rsps,
        IModContext job,
        Configuration cfg,
        string cacheKey,
        CancellationToken ct = default
    )
    {
        var parallelism = cfg.Parallelism;
        if (parallelism == 0)
        {
            parallelism = Environment.ProcessorCount;
        }

        // Figure out what the common root is so we can aggregate the file paths without collisions
        var srcRoot =
            cfg.InputSourceRoot
            ?? SilkTouchGenerator.GetLongestCommonPath(
                rsps.Select(x => x.GeneratorConfiguration.OutputLocation)
            );
        var testRoot =
            cfg.InputTestRoot
            ?? SilkTouchGenerator.GetLongestCommonPath(
                rsps.Select(x => x.GeneratorConfiguration.TestOutputLocation)
            );
        srcRoot = Path.GetFullPath(srcRoot);
        testRoot = Path.GetFullPath(testRoot);

        // Generate all the sources and tests.
        var aggregatedSources = new ConcurrentDictionary<string, SyntaxTree>();
        var aggregatedTests = new ConcurrentDictionary<string, SyntaxTree>();
        await using var cacheDir = await (
            cacheProvider?.GetDirectoryAsync(
                cacheKey,
                CacheIntent.StageIntermediateOutput,
                CacheFlags.RequireNew,
                FileAccess.Write
            ) ?? ValueTask.FromResult<ICacheDirectory?>(null)
        );
        await Parallel.ForEachAsync(
            rsps,
            new ParallelOptions { CancellationToken = ct, MaxDegreeOfParallelism = parallelism },
            async (rsp, innerCt) =>
                await Task.Run(
                    async () =>
                    {
                        // Generate the raw bindings.
                        var (sources, tests, hasErrors) = ScrapeRawBindings(rsp);
                        static MemoryStream Reopen(MemoryStream ms) =>
                            ms.TryGetBuffer(out var buff) && buff.Array is not null
                                ? new MemoryStream(buff.Array, buff.Offset, buff.Count)
                                : new MemoryStream(buff.ToArray());

                        // Parse and optionally cache the files for the compilation.
                        foreach (
                            var (isTest, (path, stream)) in sources
                                .Select(x => (false, x))
                                .Concat(tests.Select(x => (true, x)))
                                .Select(x => (x.Item1, (x.x.Key, Reopen((MemoryStream)x.x.Value))))
                        )
                        {
                            // Make the path relative as above.
                            var relativeKey = Path.GetRelativePath(
                                    isTest ? testRoot : srcRoot,
                                    path
                                )
                                .Replace('\\', '/')
                                .TrimEnd('/');

                            // Cache the output.
                            if (!hasErrors)
                            {
                                await (
                                    cacheDir?.AddFileAsync(
                                        $"{(isTest ? "tests" : "sources")}/{relativeKey}",
                                        stream
                                    ) ?? ValueTask.CompletedTask
                                );
                                stream.Seek(0, SeekOrigin.Begin);
                            }

                            // Add it to the dictionary.
                            if (
                                !(isTest ? aggregatedTests : aggregatedSources).TryAdd(
                                    relativeKey,
                                    CSharpSyntaxTree.ParseText(
                                        SourceText.From(
                                            cfg.ManualOverrides?.TryGetValue(
                                                $"{(isTest ? "tests" : "sources")}/{relativeKey}",
                                                out var @override
                                            ) ?? false
                                                ? File.OpenRead(
                                                    await inputResolver.ResolvePath(@override)
                                                )
                                                : stream
                                        ),
                                        path: relativeKey
                                    )
                                )
                            )
                            {
                                logger.LogError(
                                    "Failed to add {0} - are the response file outputs conflicting?",
                                    relativeKey
                                );
                            }
                            else
                            {
                                logger.LogTrace("ClangSharp generated {0}", relativeKey);
                            }
                        }
                    },
                    innerCt
                )
        );

        await (cacheDir?.CommitAsync() ?? ValueTask.CompletedTask);

        var src = job.SourceProject;
        foreach (var (fname, tree) in aggregatedSources)
        {
            src = src
                ?.AddDocument(
                    Path.GetFileName(fname),
                    await tree.GetRootAsync(ct),
                    filePath: src.FullPath(fname)
                )
                .Project;
        }

        job.SourceProject = src;
        var test = job.TestProject;
        foreach (var (fname, tree) in aggregatedTests)
        {
            test = test
                ?.AddDocument(
                    Path.GetFileName(fname),
                    await tree.GetRootAsync(ct),
                    filePath: test.FullPath(fname)
                )
                .Project;
        }

        job.TestProject = test;
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        if (ctx.ConfigurationDirectory is null)
        {
            throw new NotSupportedException("I/O not available.");
        }

        var applicableSkipIfs = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
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
                : "!vs",
        };

        // Read the configuration.
        var cfg = await inputResolver.Resolve(config.Get(ctx.JobKey));

        // Read the response files.
        logger.LogInformation("Reading response files for {}, please wait...", ctx.JobKey);
        var rsps = rspHandler
            .ReadResponseFiles(ctx.ConfigurationDirectory, cfg.ClangSharpResponseFiles)
            .ToList();

        // Apply modifications. This is done before the cache key as modifications to the rsps result in different
        // outputs.
        foreach (var mod in responseFileMods?.SelectMany(x => x.Get(ctx.JobKey)) ?? [])
        {
            rsps = await mod.BeforeScrapeAsync(ctx.JobKey, rsps);
        }

        // Resolve any foreign paths referenced in the response files
        await inputResolver.ResolveInPlace(rsps);

        // Should we completely skip running ClangSharp (e.g. we can't get Windows SDK bindings on macOS)
        var skip = (cfg.SkipScrapeIf?.Any(applicableSkipIfs.Contains)).GetValueOrDefault();
        var cacheKey = $"{ctx.JobKey}-ClangSharp";
        Exception? innerException = null;
        try
        {
            if (!skip)
            {
                // Run the scraper over the response files
                await ScrapeBindingsAsync(rsps, ctx, cfg, cacheKey, ct);
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
            if (skip && cacheProvider is not null)
            {
                await using var cacheDir = await cacheProvider.GetDirectoryAsync(
                    cacheKey,
                    CacheIntent.StageIntermediateOutput,
                    CacheFlags.None,
                    FileAccess.Read
                );
                var src = ctx.SourceProject;
                var tst = ctx.TestProject;
                await foreach (
                    var file in (
                        cacheDir?.GetCommittedFilesAsync() ?? AsyncEnumerable.Empty<string>()
                    ).WithCancellation(ct)
                )
                {
                    await cacheDir!.GetCommittedFileAsync(file);
                    var isSource = file.StartsWith("sources");
                    var isTest = file.StartsWith("tests");
                    if (!isSource && !isTest)
                    {
                        continue;
                    }

                    // Have to do this if statement this way as we can't have a ref var over an await point
                    if ((isSource && src is null) || (isTest && tst is null))
                    {
                        continue;
                    }

                    var rel = file[(isSource ? "sources".Length : "tests".Length)..]
                        .TrimStart('/', '\\');
                    var content = await cacheDir.GetCommittedFileAsync(file);
                    var root = await CSharpSyntaxTree
                        .ParseText(SourceText.From(content), path: rel, cancellationToken: ct)
                        .GetRootAsync(ct);
                    ref var proj = ref isSource ? ref src : ref tst;
                    var filePath = proj!.FullPath(rel);
                    proj = proj
                        ?.AddDocument(Path.GetFileName(file), root, filePath: filePath)
                        .Project;
                }

                skip = cacheDir is not null;
                if (!skip)
                {
                    ctx.SourceProject = src;
                    ctx.TestProject = tst;
                }
            }
        }

        // CA2219: Do not raise exceptions in exception clauses
        if (skip)
        {
            if (innerException is not null)
            {
                throw new AggregateException(
                    "Bindings generation was unable to complete as intended, and there was no cache "
                        + "available to fall back on.",
                    innerException
                );
            }

            throw new InvalidOperationException(
                "Bindings generation has been requested to be skipped despite there being no cache to "
                    + "fall back on."
            );
        }
    }

    /// <summary>
    /// Returns true if <paramref name="path"/> starts with the path <paramref name="baseDirPath"/>.
    /// The comparison is case-insensitive, handles / and \ slashes as folder separators and
    /// only matches if the base dir folder name is matched exactly ("c:\foobar\file.txt" is not a sub path of "c:\foo").
    /// </summary>
    private static bool IsSubPathOf(string path, string baseDirPath)
    {
        var normalizedPath = Path.GetFullPath(path.Replace('\\', '/').TrimEnd('/'));

        var normalizedBaseDirPath = Path.GetFullPath(baseDirPath.Replace('\\', '/').TrimEnd('/'));

        return normalizedPath.StartsWith(normalizedBaseDirPath, StringComparison.OrdinalIgnoreCase);
    }

    private void LogConfiguration(ResponseFile cfg)
    {
        if (!logger.IsEnabled(LogLevel.Trace))
        {
            return;
        }

        logger.LogTrace(
            """
            === Generator configuration ===
            DefaultClass: {0}
            DontUseUsingStaticsForEnums: {1}
            ExcludeAnonymousFieldHelpers: {2}
            ExcludeComProxies: {3}
            ExcludeEmptyRecords: {4}
            ExcludeEnumOperators: {5}
            ExcludeFnptrCodegen: {6}
            ExcludeFunctionsWithBody: {7}
            ExcludeNIntCodegen: {8}
            GenerateAggressiveInlining: {9}
            GenerateCompatibleCode: {10}
            GenerateCppAttributes: {11}
            GenerateDocIncludes: {12}
            GenerateExplicitVtbls: {13}
            GenerateFileScopedNamespaces: {14}
            GenerateGuidMember: {15}
            GenerateHelperTypes: {16}
            GenerateLatestCode: {17}
            GenerateMacroBindings: {18}
            GenerateMarkerInterfaces: {19}
            GenerateMultipleFiles: {20}
            GenerateNativeBitfieldAttribute: {21}
            GenerateNativeInheritanceAttribute: {22}
            GeneratePreviewCode: {23}
            GenerateSetsLastSystemErrorAttribute: {24}
            GenerateSourceLocationAttribute: {25}
            GenerateTemplateBindings: {26}
            GenerateTestsNUnit: {27}
            GenerateTestsXUnit: {28}
            GenerateTrimmableVtbls: {29}
            GenerateUnixTypes: {30}
            GenerateUnmanagedConstants: {31}
            GenerateVtblIndexAttribute: {32}
            HeaderText: {33}
            LibraryPath: {34}
            LogExclusions: {35}
            LogPotentialTypedefRemappings: {36}
            LogVisitedFiles: {37}
            MethodPrefixToStrip: {38}
            DefaultNamespace: {39}
            OutputMode: {40}
            OutputLocation: {41}
            Language: {42}
            LanguageStandard: {43}
            TestOutputLocation: {44}
            ExcludedNames:
                {45}
            IncludedNames:
                {46}
            NativeTypeNamesToStrip:
                {47}
            ForceRemappedNames:
                {48}
            TraversalNames:
                {49}
            WithManualImports:
                {50}
            WithSetLastErrors:
                {51}
            WithSuppressGCTransitions:
                {52}
            RemappedNames:
                {53}
            WithAccessSpecifiers:
                {54}
            WithCallConvs:
                {55}
            WithClasses:
                {56}
            WithGuids:
                {57}
            WithLibraryPaths:
                {58}
            WithNamespaces:
                {59}
            WithTypes:
                {60}
            WithPackings:
                {61}
            WithTransparentStructs:
                {62}
            WithAttributes:
                {63}
            WithUsings:
                {64}
            """,
            cfg.GeneratorConfiguration.DefaultClass,
            cfg.GeneratorConfiguration.DontUseUsingStaticsForEnums,
            cfg.GeneratorConfiguration.ExcludeAnonymousFieldHelpers,
            cfg.GeneratorConfiguration.ExcludeComProxies,
            cfg.GeneratorConfiguration.ExcludeEmptyRecords,
            cfg.GeneratorConfiguration.ExcludeEnumOperators,
            cfg.GeneratorConfiguration.ExcludeFnptrCodegen,
            cfg.GeneratorConfiguration.ExcludeFunctionsWithBody,
            cfg.GeneratorConfiguration.ExcludeNIntCodegen,
            cfg.GeneratorConfiguration.GenerateAggressiveInlining,
            cfg.GeneratorConfiguration.GenerateCompatibleCode,
            cfg.GeneratorConfiguration.GenerateCppAttributes,
            cfg.GeneratorConfiguration.GenerateDocIncludes,
            cfg.GeneratorConfiguration.GenerateExplicitVtbls,
            cfg.GeneratorConfiguration.GenerateFileScopedNamespaces,
            cfg.GeneratorConfiguration.GenerateGuidMember,
            cfg.GeneratorConfiguration.GenerateHelperTypes,
            cfg.GeneratorConfiguration.GenerateLatestCode,
            cfg.GeneratorConfiguration.GenerateMacroBindings,
            cfg.GeneratorConfiguration.GenerateMarkerInterfaces,
            cfg.GeneratorConfiguration.GenerateMultipleFiles,
            cfg.GeneratorConfiguration.GenerateNativeBitfieldAttribute,
            cfg.GeneratorConfiguration.GenerateNativeInheritanceAttribute,
            cfg.GeneratorConfiguration.GeneratePreviewCode,
            cfg.GeneratorConfiguration.GenerateSetsLastSystemErrorAttribute,
            cfg.GeneratorConfiguration.GenerateSourceLocationAttribute,
            cfg.GeneratorConfiguration.GenerateTemplateBindings,
            cfg.GeneratorConfiguration.GenerateTestsNUnit,
            cfg.GeneratorConfiguration.GenerateTestsXUnit,
            cfg.GeneratorConfiguration.GenerateTrimmableVtbls,
            cfg.GeneratorConfiguration.GenerateUnixTypes,
            cfg.GeneratorConfiguration.GenerateUnmanagedConstants,
            cfg.GeneratorConfiguration.GenerateVtblIndexAttribute,
            cfg.GeneratorConfiguration.HeaderText,
            cfg.GeneratorConfiguration.LibraryPath,
            cfg.GeneratorConfiguration.LogExclusions,
            cfg.GeneratorConfiguration.LogPotentialTypedefRemappings,
            cfg.GeneratorConfiguration.LogVisitedFiles,
            cfg.GeneratorConfiguration.MethodPrefixToStrip,
            cfg.GeneratorConfiguration.DefaultNamespace,
            cfg.GeneratorConfiguration.OutputMode,
            cfg.GeneratorConfiguration.OutputLocation,
            cfg.GeneratorConfiguration.Language,
            cfg.GeneratorConfiguration.LanguageStandard,
            cfg.GeneratorConfiguration.TestOutputLocation,
            string.Join("\n    ", cfg.GeneratorConfiguration.ExcludedNames),
            string.Join("\n    ", cfg.GeneratorConfiguration.IncludedNames),
            string.Join("\n    ", cfg.GeneratorConfiguration.NativeTypeNamesToStrip),
            string.Join("\n    ", cfg.GeneratorConfiguration.ForceRemappedNames),
            string.Join("\n    ", cfg.GeneratorConfiguration.TraversalNames),
            string.Join("\n    ", cfg.GeneratorConfiguration.WithManualImports),
            string.Join("\n    ", cfg.GeneratorConfiguration.WithSetLastErrors),
            string.Join("\n    ", cfg.GeneratorConfiguration.WithSuppressGCTransitions),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.RemappedNames.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithAccessSpecifiers.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithCallConvs.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithClasses.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithGuids.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithLibraryPaths.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithNamespaces.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithTypes.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithPackings.Select(x => $"{x.Key} = {x.Value}")
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithTransparentStructs.Select(x =>
                    $"{x.Key} = {x.Value}"
                )
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithAttributes.Select(x =>
                    $"{x.Key} = {string.Join(", ", x.Value)}"
                )
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithUsings.Select(x =>
                    $"{x.Key} = {string.Join(", ", x.Value)}"
                )
            )
        );
    }
}
