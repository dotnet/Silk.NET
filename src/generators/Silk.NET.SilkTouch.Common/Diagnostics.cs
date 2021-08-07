// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch
{
    public class Diagnostics
    {
        public static DiagnosticDescriptor GeneralError { get; } = new
        (
            id: "ST0005",
            title: "General SilkTouch Error",
            messageFormat: "SilkTouch failed to execute due to a general error: \"{0}\"",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor MultipleConfigFiles { get; } = new
        (
            id: "ST0006",
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
            id: "ST0007",
            title: "No Configuration File",
            messageFormat: "No configuration file, SilkTouch will not run. To configure a path to a SilkTouch JSON " +
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
            id: "ST0008",
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
            id: "ST0009",
            title: "No Library Name",
            messageFormat: "Specify at least one library name " +
                           "(\"scraper\" > \"jobs\" > [{0}] > \"libraryNames\": [\"MyLibrary.dll\"])",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor NoWindowsSdk { get; } = new
        (
            id: "ST0010",
            title: "Windows-Specific SDK Not Found",
            messageFormat: !RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? "Include \"{0}\" could not be resolved, generation may fail. Consider " +
                  "adding a skipIf condition to prevent generation on non-Windows platforms " +
                  "(\"cliSkipIf\": [\"linux\", \"macos\"])"
                : "Include \"{0}\" could not be resolved, generation may fail.",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Warning,
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor NoHeaderText { get; } = new
        (
            id: "ST0011",
            title: "No Input Header Text",
            messageFormat: "Input C/C++ header source code is required to use SilkTouch Scraper. " +
                           "(\"scraper\" > \"jobs\" > [{0}] > \"headerText\": [\"#include \\\"example.h\\\"\"])",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor ClangSharpNonZeroExitCode { get; } = new
        (
            id: "ST0012",
            title: "ClangSharp Exited With Non-Zero Error Code",
            messageFormat: "ClangSharp exited with a non-zero exit code: {0}",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );

        public static DiagnosticDescriptor ClangSharpError { get; } = new
        (
            id: "ST0013",
            title: "ClangSharp Subagent Error Diagnostic",
            messageFormat: "{0}",
            category: "SilkTouch",
            defaultSeverity: DiagnosticSeverity.Error,
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );
    }
}
