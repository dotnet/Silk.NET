// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch
{
    internal static class Diagnostics
    {
        private const string IssueLink =
            "https://github.com/Ultz/Silk.NET/issues/new?assignees=HurricanKai&labels=bug,area-SilkTouch";

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
    }
}
