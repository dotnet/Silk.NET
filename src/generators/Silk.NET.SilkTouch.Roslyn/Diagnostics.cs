// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;

namespace Silk.NET.SilkTouch.Roslyn
{
    public class Diagnostics
    {
        public static DiagnosticDescriptor MultipleConfigFiles { get; } = new
        (
            id: "ST0005",
            title: "Multiple Configuration Files Detected",
            messageFormat: $"Multiple configuration files detected. Using \"{{0}}\" instead, to use \"{{1}}\" configure the \"{Constants.ConfigFileEditorconfigOption}\"",
            category: "SilkTouch.Internal",
            defaultSeverity: DiagnosticSeverity.Warning, 
            isEnabledByDefault: true,
            description: null,
            helpLinkUri: null,
            customTags: WellKnownDiagnosticTags.AnalyzerException
        );
    }
}
