// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch
{
    internal static class Diagnostics
    {
        private const string IssueLink =
            "https://github.com/dotnet/Silk.NET/issues/new?assignees=HurricanKai&labels=bug,area-SilkTouch";

        public static DiagnosticDescriptor ProcessClassFailure { get; } = new DiagnosticDescriptor
        (
            id: "ST0001",
            title: "ProcessClass failure",
            messageFormat: "ProcessClass failed. Exception: '{0}'",
            category: "SilkTouch.Internal",
            defaultSeverity: DiagnosticSeverity.Error, 
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: IssueLink,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );
        
        public static DiagnosticDescriptor MethodClassFailure { get; } = new DiagnosticDescriptor
        (
            id: "ST0002",
            title: "MethodClass failure",
            messageFormat: "MethodClass failed. Exception: '{0}'",
            category: "SilkTouch.Internal",
            defaultSeverity: DiagnosticSeverity.Error, 
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: IssueLink,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );
      
        public static DiagnosticDescriptor SilkNetCoreMissing { get; } = new DiagnosticDescriptor
        (
            id: "ST0003",
            title: "Silk.NET.Core is missing",
            messageFormat: "Silk.NET.Core is missing from references. You should use SilkTouch with Silk.NET.Core",
            category: "SilkTouch.Internal",
            defaultSeverity: DiagnosticSeverity.Info,
            isEnabledByDefault: true,
            description: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
          
        );
      
        public static DiagnosticDescriptor BuildInfo { get; } = new DiagnosticDescriptor
        (
            id: "ST0004",
            title: "Build Info",
            messageFormat: "GCSlotCount: '{0}', Time: '{1}'",
            category: "SilkTouch.Internal",
            defaultSeverity: DiagnosticSeverity.Warning, 
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.Telemetry
        );
    }
}
