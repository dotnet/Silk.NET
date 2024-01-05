// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ClangSharp;
using ClangSharp.Interop;
using Microsoft.Extensions.Logging;
using static ClangSharp.Interop.CXDiagnosticSeverity;
using static ClangSharp.Interop.CXErrorCode;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Primary entrypoint of the Scraper. This class defines logic to extract symbols using ClangSharp
/// </summary>
public sealed class ClangScraper
{
    private readonly ILogger<ClangScraper> _logger;

    // TODO add Windows SDK and Xcode configuration

    /// <summary>
    /// Creates a ClangScraper given it's dependencies
    /// </summary>
    public ClangScraper(ILogger<ClangScraper> logger) => _logger = logger;

    /// <summary>
    /// Runs ClangSharp to obtain the raw bindings for the given response file.
    /// </summary>
    /// <param name="config"></param>
    /// <returns></returns>
    public GeneratedBindings ScrapeRawBindings(ResponseFile config)
    {
        var files = new Dictionary<string, Stream>();

        Stream OutputStreamFactory(string fileName)
        {
            if (files.ContainsKey(fileName))
            {
                _logger.LogWarning("ClangSharp has requested to overwrite {0}!", fileName);
            }

            return files[Path.ChangeExtension(fileName, ".gen.cs")] = new MemoryStream();
        }

        LogConfiguration(config);
        using var pinvokeGenerator = new PInvokeGenerator(
            config.GeneratorConfiguration,
            OutputStreamFactory
        );
        var diagnostics = new List<Diagnostic>();
        foreach (var file in config.Files)
        {
            var filePath = Path.Combine(config.FileDirectory, file);
            var fileName = Path.GetFileName(file);
            _logger.LogTrace(
                "About to process {0} in accordance with the rsp from {1}",
                filePath,
                config.FileDirectory
            );
            _logger.LogTrace(
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
                _logger.LogError(msg);
                diagnostics.Add(new Diagnostic(DiagnosticLevel.Error, msg));
                skipProcessing = true;
            }
            else if (handle.NumDiagnostics != 0)
            {
                _logger.LogInformation($"Diagnostics for '{fileName}':");

                for (uint i = 0; i < handle.NumDiagnostics; ++i)
                {
                    using var diagnostic = handle.GetDiagnostic(i);

                    _logger.Log(
                        diagnostic.Severity switch
                        {
                            CXDiagnostic_Ignored => LogLevel.Trace,
                            CXDiagnostic_Note => LogLevel.Debug,
                            CXDiagnostic_Warning => LogLevel.Warning,
                            CXDiagnostic_Error => LogLevel.Error,
                            CXDiagnostic_Fatal => LogLevel.Critical,
                            _ => LogLevel.Trace
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
                _logger.LogError($"Skipping '{fileName}' due to one or more errors listed above.");
                continue;
            }

            try
            {
                using var translationUnit = TranslationUnit.GetOrCreate(handle);
                Debug.Assert(translationUnit is not null);

                _logger.LogInformation("Generating raw bindings for '{0}'", fileName);
                pinvokeGenerator.GenerateBindings(
                    translationUnit,
                    filePath,
                    config.ClangCommandLineArgs,
                    config.TranslationFlags
                );
                pinvokeGenerator.Close();
                _logger.LogDebug(
                    "Completed generation for {0}, file count: {1}",
                    filePath,
                    files.Count
                );
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Unhandled exception when generating bindings");
                diagnostics.Add(
                    new Diagnostic(
                        DiagnosticLevel.Error,
                        $"Unhandled exception when generating for {filePath} ({e.GetType().Name}): {e.Message}"
                    )
                );
            }
        }

        return new GeneratedBindings(
            files.ToDictionary(
                kvp =>
                    IsSubPathOf(kvp.Key, config.GeneratorConfiguration.TestOutputLocation)
                        ? $"tests/{Path.GetRelativePath(config.GeneratorConfiguration.TestOutputLocation, kvp.Key)}"
                        : $"sources/{Path.GetRelativePath(config.GeneratorConfiguration.OutputLocation, kvp.Key)}",
                kvp =>
                {
                    // Copy the memory stream to a memory mapped file to ensure we don't eat RAM
                    var arr = ((MemoryStream)kvp.Value).ToArray();
                    var mmf = MemoryMappedFile.CreateNew(null, arr.Length);
                    using var stream = mmf.CreateViewStream();
                    stream.Write(arr);
                    stream.Flush();
                    kvp.Value.Dispose();

                    // Return a read-only stream to ensure noone tries to write to it directly
                    return (Stream)mmf.CreateViewStream(0, arr.Length, MemoryMappedFileAccess.Read);
                }
            ),
            diagnostics
        );
    }

    /// <summary>
    /// Runs ClangSharp for each of the given response files and aggregates the raw outputs.
    /// </summary>
    /// <param name="rsps">The response files.</param>
    /// <param name="job">The job configuration.</param>
    /// <param name="parallelism">The number of response files to process in parallel.</param>
    /// <param name="ct">The cancellation token.</param>
    /// <returns>The aggregated bindings.</returns>
    /// <exception cref="InvalidOperationException">The scraper output wasn't as expected.</exception>
    public async Task<GeneratedBindings> ScrapeRawBindings(
        IReadOnlyList<ResponseFile>? rsps,
        SilkTouchConfiguration job,
        int parallelism = 0,
        CancellationToken ct = default
    )
    {
        if (parallelism == 0)
        {
            parallelism = Environment.ProcessorCount;
        }

        // Figure out what the common root is so we can aggregate the file paths without collisions
        var srcRoot =
            job.InputSourceRoot
            ?? SilkTouchGenerator.GetLongestCommonPath(
                rsps?.Select(x => x.GeneratorConfiguration.OutputLocation)
                    ?? Enumerable.Empty<string>()
            );
        var testRoot =
            job.InputTestRoot
            ?? SilkTouchGenerator.GetLongestCommonPath(
                rsps?.Select(x => x.GeneratorConfiguration.TestOutputLocation)
                    ?? Enumerable.Empty<string>()
            );
        srcRoot = Path.GetFullPath(srcRoot);
        testRoot = Path.GetFullPath(testRoot);

        var aggregatedBindings = new ConcurrentDictionary<string, Stream>();
        var aggregatedDiagnostics = new ConcurrentBag<Diagnostic>();
        await Parallel.ForEachAsync(
            rsps ?? Enumerable.Empty<ResponseFile>(),
            new ParallelOptions { CancellationToken = ct, MaxDegreeOfParallelism = parallelism },
            async (rsp, innerCt) =>
                await Task.Run(
                    () =>
                    {
                        var rawBindings = ScrapeRawBindings(rsp);
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

        return new GeneratedBindings(
            aggregatedBindings.ToDictionary(x => x.Key, x => x.Value),
            aggregatedDiagnostics.ToArray()
        );
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
        if (!_logger.IsEnabled(LogLevel.Trace))
        {
            return;
        }

        _logger.LogTrace(
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
                cfg.GeneratorConfiguration.WithTransparentStructs.Select(
                    x => $"{x.Key} = {x.Value}"
                )
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithAttributes.Select(
                    x => $"{x.Key} = {string.Join(", ", x.Value)}"
                )
            ),
            string.Join(
                "\n    ",
                cfg.GeneratorConfiguration.WithUsings.Select(
                    x => $"{x.Key} = {string.Join(", ", x.Value)}"
                )
            )
        );
    }
}
