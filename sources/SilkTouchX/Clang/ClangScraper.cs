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
                throw new InvalidOperationException();
            }

            return files[fileName] = new MemoryStream();
        }

        using var pinvokeGenerator = new PInvokeGenerator(config.GeneratorConfiguration, OutputStreamFactory);
        var diagnostics = new List<Diagnostic>();
        foreach (var file in config.Files)
        {
            var filePath = Path.Combine(config.FileDirectory, file);

            var translationUnitError = CXTranslationUnit.TryParse(pinvokeGenerator.IndexHandle, filePath,
                config.ClangCommandLineArgs, Array.Empty<CXUnsavedFile>(), config.TranslationFlags, out var handle);
            var skipProcessing = false;

            if (translationUnitError != CXError_Success)
            {
                var msg = $"Parsing failed for '{filePath}' due to '{translationUnitError}'.";
                _logger.LogError(msg);
                diagnostics.Add(new Diagnostic(DiagnosticLevel.Error, msg));
                skipProcessing = true;
            }
            else if (handle.NumDiagnostics != 0)
            {
                _logger.LogInformation($"Diagnostics for '{filePath}':");

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
                _logger.LogError($"Skipping '{filePath}' due to one or more errors listed above.");
                continue;
            }

            try
            {
                using var translationUnit = TranslationUnit.GetOrCreate(handle);
                Debug.Assert(translationUnit is not null);

                _logger.LogInformation($"Generating raw bindings for '{filePath}'");
                pinvokeGenerator.GenerateBindings(translationUnit, filePath, config.ClangCommandLineArgs, config.TranslationFlags);
                _logger.LogDebug("Completed generation for {0}, file count: {1}", filePath, files.Count);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Unhandled exception when generating bindings");
                diagnostics.Add(new Diagnostic(DiagnosticLevel.Error,
                    $"Unhandled exception when generating for {filePath} ({e.GetType().Name}): {e.Message}"));
            }
        }

        return new GeneratedBindings(files.ToDictionary(kvp => kvp.Key, kvp => {
            // Copy the memory stream to a memory mapped file to ensure we don't eat RAM
            var mmf = MemoryMappedFile.CreateNew(null, ((MemoryStream)kvp.Value).Length);
            using var stream = mmf.CreateViewStream();
            kvp.Value.CopyTo(stream);
            kvp.Value.Dispose();

            // Return a read-only stream to ensure noone tries to write to it directly
            return (Stream)mmf.CreateViewStream(0, kvp.Value.Length, MemoryMappedFileAccess.Read);
        }), diagnostics);
    }
}
