// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using ClangSharp;
using ClangSharp.Interop;
using Microsoft.Extensions.Logging;
using static ClangSharp.Interop.CXErrorCode;
using static ClangSharp.Interop.CXDiagnosticSeverity;

namespace SilkTouchX.Clang;

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

        using var pinvokeGenerator = new PInvokeGenerator(config.GeneratorConfiguration, OutputStreamFactory);
        var diagnostics = new List<Diagnostic>();
        foreach (var file in config.Files)
        {
            var filePath = Path.Combine(config.FileDirectory, file);
            var fileName = Path.GetFileName(file);
            _logger.LogTrace("About to process {0} in accordance with the rsp from {1}",
                filePath,
                config.FileDirectory);

            var translationUnitError = CXTranslationUnit.TryParse(pinvokeGenerator.IndexHandle, filePath,
                config.ClangCommandLineArgs, Array.Empty<CXUnsavedFile>(), config.TranslationFlags, out var handle);
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

                    _logger.Log(diagnostic.Severity switch {
                           CXDiagnostic_Ignored => LogLevel.Trace,
                           CXDiagnostic_Note => LogLevel.Debug,
                           CXDiagnostic_Warning => LogLevel.Warning,
                           CXDiagnostic_Error => LogLevel.Error,
                           CXDiagnostic_Fatal => LogLevel.Critical,
                            _ => LogLevel.Trace
                        }, "    {0}",
                        diagnostic.Format(CXDiagnostic.DefaultDisplayOptions).ToString());

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
                pinvokeGenerator.GenerateBindings(translationUnit, filePath, config.ClangCommandLineArgs, config.TranslationFlags);
                pinvokeGenerator.Close();
                _logger.LogDebug("Completed generation for {0}, file count: {1}", filePath, files.Count);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Unhandled exception when generating bindings");
                diagnostics.Add(new Diagnostic(DiagnosticLevel.Error,
                    $"Unhandled exception when generating for {filePath} ({e.GetType().Name}): {e.Message}"));
            }
        }

        return new GeneratedBindings(files.ToDictionary(
            kvp => IsSubPathOf(kvp.Key, config.GeneratorConfiguration.TestOutputLocation)
                ? $"tests/{Path.GetRelativePath(config.GeneratorConfiguration.TestOutputLocation, kvp.Key)}"
                : $"sources/{Path.GetRelativePath(config.GeneratorConfiguration.OutputLocation, kvp.Key)}",
            kvp => {
            // Copy the memory stream to a memory mapped file to ensure we don't eat RAM
            var arr = ((MemoryStream)kvp.Value).ToArray();
            var mmf = MemoryMappedFile.CreateNew(null, arr.Length);
            using var stream = mmf.CreateViewStream();
            stream.Write(arr);
            stream.Flush();
            kvp.Value.Dispose();

            // Return a read-only stream to ensure noone tries to write to it directly
            return (Stream)mmf.CreateViewStream(0, arr.Length, MemoryMappedFileAccess.Read);
        }), diagnostics);
    }

    /// <summary>
    /// Returns true if <paramref name="path"/> starts with the path <paramref name="baseDirPath"/>.
    /// The comparison is case-insensitive, handles / and \ slashes as folder separators and
    /// only matches if the base dir folder name is matched exactly ("c:\foobar\file.txt" is not a sub path of "c:\foo").
    /// </summary>
    private static bool IsSubPathOf(string path, string baseDirPath)
    {
        var normalizedPath = Path.GetFullPath(path.Replace('\\', '/')
            .TrimEnd('/'));

        var normalizedBaseDirPath = Path.GetFullPath(baseDirPath.Replace('\\', '/')
            .TrimEnd('/'));

        return normalizedPath.StartsWith(normalizedBaseDirPath, StringComparison.OrdinalIgnoreCase);
    }
}
