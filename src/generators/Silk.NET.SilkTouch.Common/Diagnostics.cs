// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch
{
    public class Diagnostics
    {
        public static DiagnosticDescriptor MultipleConfigFiles { get; } = new
        (
            id: "ST0005",
            title: "Multiple Configuration Files Detected",
            messageFormat: "Multiple configuration files detected. Using \"{0}\", to use \"{1}\" instead configure " +
                           $"the \"{Constants.ConfigFileEditorconfigOption}\" editorconfig option.",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Warning, 
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor NoConfigFile { get; } = new
        (
            id: "ST0006",
            title: "No Configuration File",
            messageFormat: "No configuration file, SilkTouch will not run.. To configure a path to a SilkTouch JSON " +
                           $"Configuration file, use the \"{Constants.ConfigFileEditorconfigOption}\" editorconfig " +
                           "option.",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Info, 
            isEnabledByDefault: false,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor NoAssemblyName { get; } = new
        (
            id: "ST0007",
            title: "Couldn't Determine Assembly Name",
            messageFormat: "Couldn't determine \"AssemblyName\", SilkTouch will not run.",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Info, 
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor NoLibraryName { get; } = new
        (
            id: "ST0008",
            title: "No Library Name",
            messageFormat: "Specify at least one library name " + 
                           "(\"projects\" > \"{0}\" > \"scraper\" > \"libraryNames\")",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Error, 
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );
    }
}
