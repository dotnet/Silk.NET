// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using ClangSharp;
using ClangSharp.Interop;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Scraper;

/// <summary>
/// Primary entrypoint of the Scraper. This class defines logic to extract <see cref="Symbol"/>s using ClangSharp
/// </summary>
public sealed class ClangScraper
{
    /// <summary>
    /// Placeholder used in place of library paths
    /// </summary>
    public static readonly string LibraryPathPlaceholder = "LIBRARY_PATH";
    
    /// <summary>
    /// Placeholder used in place of library paths
    /// </summary>
    public static readonly string LibraryNamespacePlaceholder = "LIBRARY_NAMESPACE";

    /// <summary>
    /// Scrapes the given XML document for symbols
    /// </summary>
    /// <param name="document">A XML Document, the format is assumed to be similar to what ClangSharp would output.</param>
    /// <returns>Any number of symbols scraped from the given xml</returns>
    public IEnumerable<Symbol> ScrapeXML(XmlDocument document)
    {
        var bindings = document.ChildNodes.Cast<XmlNode>().FirstOrDefault(x => x.LocalName == "bindings" && x is XmlElement) as XmlElement;

        if (bindings is null)
        {
            return Enumerable.Empty<Symbol>();
        }

        var visitor = new XmlVisitor();
        visitor.Visit(bindings);

        return visitor.Symbols;
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


        var commandLineArgs = new string[3 + definedMacros.Length + includeDirectories.Length];
        commandLineArgs[0] = "--language=c++";
        commandLineArgs[1] = "--std=c++17";
        commandLineArgs[2] = "-Wno-pragma-once-outside-header";
        
        for (int i = 0; i < definedMacros.Length; i++)
        {
            commandLineArgs[3 + i] = "--define-macro=" + definedMacros[i];
        }

        for (int i = 0; i < includeDirectories.Length; i++)
        {
            commandLineArgs[3 + definedMacros.Length] = "--include-directory=" + definedMacros[i];
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
                GenerateBindings(pinvokeGenerator, headerFile, commandLineArgs, translationFlags);
            
            foreach (var (name, stream) in files)
            {
                Console.WriteLine(name);
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
        CXTranslationUnit_Flags translationFlags
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
                if (diagnostic.Level > DiagnosticLevel.Warning)
                {
                    Console.WriteLine(diagnostic.Message);
                }
            }
        }
        finally
        {
            // handle.Dispose();
        }
    }
}
