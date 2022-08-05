// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using ClangSharp;
using ClangSharp.Interop;
using Silk.NET.SilkTouch.Scraper.Subagent;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Scraper;

/// <summary>
/// Primary entrypoint of the Scraper. This class defines logic to extract <see cref="Symbol"/>s using ClangSharp
/// </summary>
public sealed class ClangScraper
{
    private readonly ILoggerFactory                      _loggerFactory;
    private readonly IOptions<ClangScraperConfiguration> _options;
    /// <summary>
    /// Placeholder used in place of library paths
    /// </summary>
    public static readonly string LibraryPathPlaceholder = "LIBRARY_PATH";
    
    /// <summary>
    /// Placeholder used in place of library paths
    /// </summary>
    public static readonly string LibraryNamespacePlaceholder = "LIBRARY_NAMESPACE";

    /// <summary>
    /// Creates a ClangScraper given it's dependencies
    /// </summary>
    /// <param name="loggerFactory">A logger factory to create loggers from</param>
    /// <param name="options">an <see cref="IOptions{TOptions}"/> instance used to retrieve configuration. See <see cref="ClangScraperConfiguration"/></param>
    public ClangScraper(ILoggerFactory loggerFactory, IOptions<ClangScraperConfiguration> options)
    {
        _loggerFactory = loggerFactory;
        _options  = options;
    }

    /// <summary>
    /// Scrapes the given XML document for symbols
    /// </summary>
    /// <param name="document">A XML Document, the format is assumed to be similar to what ClangSharp would output.</param>
    /// <returns>Any number of symbols scraped from the given xml</returns>
    public IEnumerable<Symbol> ScrapeXML(XmlDocument document)
    {
        var bindings = document.ChildNodes.Cast<XmlNode>().OfType<XmlElement>().FirstOrDefault();

        if (bindings is null)
        {
            return Enumerable.Empty<Symbol>();
        }

        var visitor = new XmlVisitor(_loggerFactory.CreateLogger<XmlVisitor>());
        return visitor.Visit(bindings);
    }

    private string GetXCodeSdkPath()
    {
        var logger = _loggerFactory.CreateLogger("XCode SDK Resolver");
        var sdk = _options.Value.XcodeSdk;
        logger.LogTrace("Resolving XCode SDK using SDK {sdk}", sdk);
        var process = new Process();
        process.StartInfo = new ProcessStartInfo
            ("xcrun", "--show-sdk-path" + (sdk is null ? "" : $" --sdk {sdk}"))
        {
            RedirectStandardOutput = true
        };
        process.Start();
        process.WaitForExit();
        var path = process.StandardOutput.ReadToEnd();
        logger.LogInformation("Resolved XCode SDK to {path}", path);
        return path;
    }
    
    /// <summary>
    /// Resolves platform specific standard includes
    /// </summary>
    /// <returns>An enumerable of directories to include</returns>
    /// <remarks>
    /// On Windows, this attempts to use the Visual Studio Resolver
    /// On OSX, this attempts to run `xcrun --show-sdk-path` to get the SDK path, to then include /sdk path>/usr/include
    /// On other UNIX platforms, this simply defaults to /usr/include
    /// </remarks>
    public IEnumerable<string> ResolveStandardIncludes()
    {
        if (OperatingSystem.IsWindows())
        {
            var logger = _loggerFactory.CreateLogger("VS Info Resolver");
            if (VisualStudioResolver.TryGetVisualStudioInfo(out var info))
            {
                logger.LogInformation("Successfully resolved VS to {path}", info.InstallationBaseFolder);
                foreach (var include in info.MsvcToolsIncludes)
                {
                    yield return include;
                }
                foreach (var include in info.UcrtIncludes)
                {
                    yield return include;
                }
            }
            else
            {
                logger.LogWarning("Failed to resolve VS, but OS is Windows!");
            }
        }
        else
        {
            yield return "/usr/include";
            yield return "/usr/local/include";

            if (OperatingSystem.IsMacOS())
            {
                var logger = _loggerFactory.CreateLogger("Mac OS additional includes");
                var sdkPath = GetXCodeSdkPath();
                logger.LogTrace("Using SDK {sdk} as base", sdkPath);
                var p1 = Path.Combine(sdkPath, "usr/include");
                logger.LogTrace("Suggesting additional path {path}", p1);
                yield return p1;
                var p2 = Path.Combine(sdkPath, "usr/local/include");
                logger.LogTrace("Suggesting additional path {path}", p2);
                yield return p2;
            }
        }
    }

    /// <summary>
    /// Calls into Clang to generate XML used to scrape symbols.
    /// </summary>
    /// <param name="headerFile">The root header file to scrape</param>
    /// <param name="includedNames">Names to traverse</param>
    /// <param name="excludedNames">Names to exclude</param>
    /// <param name="includeDirectories">Directories to include other files from</param>
    /// <param name="definedMacros">Macros to define during scraping. Do not include platform specific macros.</param>
    /// <returns>The XMLDocument containing nodes representing code in the given header file. Null if generation failed for some reason.</returns>
    /// <exception cref="InvalidOperationException">Will be thrown when errors during parsing are encountered</exception>
    public XmlDocument? GenerateXML(string headerFile, string[] includedNames, string[] excludedNames, string[] includeDirectories, string[] definedMacros)
    {
        var logger = _loggerFactory.CreateLogger("ClangScraper.ScrapeXML");
        var opts = PInvokeGeneratorConfigurationOptions.None;
        opts |= PInvokeGeneratorConfigurationOptions.NoDefaultRemappings;

        var config = new PInvokeGeneratorConfiguration
        (
            LibraryNamespacePlaceholder, LibraryPathPlaceholder, null, // TODO: "License Header File"?
            PInvokeGeneratorOutputMode.Xml, opts
        );

        var files = new Dictionary<string, MemoryStream>();

        Stream OutputStreamFactory(string fileName)
        {
            if (files.ContainsKey(fileName))
            {
                throw new InvalidOperationException();
            }

            return files[fileName] = new MemoryStream();
        }

        var commandLineArgs = new List<string>();
        commandLineArgs.Add("--language=c++");
        commandLineArgs.Add("--std=c++17");
        commandLineArgs.Add("--stdlib=libc++");
        commandLineArgs.Add("-Wno-pragma-once-outside-header");
        
        for (int i = 0; i < definedMacros.Length; i++)
        {
            commandLineArgs.Add("--define-macro=" + definedMacros[i]);
        }

        for (int i = 0; i < includeDirectories.Length; i++)
        {
            commandLineArgs.Add("--include-directory=" + includeDirectories[i]);
        }

        var translationFlags = CXTranslationUnit_Flags.CXTranslationUnit_None;
        // ReSharper disable BitwiseOperatorOnEnumWithoutFlags
        translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_IncludeAttributedTypes;
        translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_VisitImplicitAttributes;
        translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_DetailedPreprocessingRecord;
        translationFlags |= CXTranslationUnit_Flags.CXTranslationUnit_KeepGoing;
        // ReSharper restore BitwiseOperatorOnEnumWithoutFlags

        try
        {
            using (var pinvokeGenerator = new PInvokeGenerator(config, OutputStreamFactory))
                GenerateBindings(pinvokeGenerator, headerFile, commandLineArgs.ToArray(), translationFlags, logger);
            
            foreach (var (name, stream) in files)
            {
                logger.LogTrace("Outputting File \"{name}\"", name);
                var doc = new XmlDocument();
                stream.Position = 0;
                doc.Load(stream);
                return doc;
            }
        }
        finally
        {
            foreach (var (_, stream) in files)
            {
                stream.Dispose();
            }
        }

        return null;
    }

    private static void GenerateBindings
    (
        PInvokeGenerator pinvokeGenerator,
        string headerFile,
        string[] commandLineArgs,
        CXTranslationUnit_Flags translationFlags,
        ILogger logger
    )
    {
        var result = CXTranslationUnit.TryParse
        (
            pinvokeGenerator.IndexHandle, headerFile, commandLineArgs, Array.Empty<CXUnsavedFile>(), translationFlags,
            out var handle
        );

        try
        {
            
            if (result != CXErrorCode.CXError_Success)
            {
                if (handle.NumDiagnostics > 0)
                {
                    for (uint i = 0; i < handle.NumDiagnostics; i++)
                    {
                        var x = handle.GetDiagnostic(i);
                        if (x.Severity > CXDiagnosticSeverity.CXDiagnostic_Warning)
                        {
                            throw new Exception($"Diagnostic raised while parsing c: {x.Category} \"{x.Format(0)}\"");
                        }
                    }
                }
                
                throw new Exception($"Could not parse translational unit. {Enum.GetName(result)}");
            }
            
            
            using var translationUnit = TranslationUnit.GetOrCreate(handle);

            pinvokeGenerator.GenerateBindings(translationUnit, headerFile, commandLineArgs, translationFlags);

            foreach (var diagnostic in pinvokeGenerator.Diagnostics)
            {
                if (diagnostic.Message == "Unsupported cursor: 'macro definition'. Generated bindings may be incomplete.")
                    continue;

                logger.Log
                (
                    diagnostic.Level switch
                    {
                        DiagnosticLevel.Info    => LogLevel.Debug,
                        DiagnosticLevel.Warning => LogLevel.Information,
                        DiagnosticLevel.Error   => LogLevel.Warning,
                        _                       => LogLevel.Debug
                    },
                    "Clang Diagnostic: {level} at: {location} \"{message}\"",
                    diagnostic.Level,
                    diagnostic.Level,
                    diagnostic.Message
                );
            }
        }
        finally
        {
            // handle.Dispose();
        }
    }
}
