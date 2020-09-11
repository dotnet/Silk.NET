// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Microsoft.CodeAnalysis;

namespace GenericMathsGenerator
{
    public static class Diagnostics
    {
        public static DiagnosticDescriptor UnsupportedOperator { get; } = new DiagnosticDescriptor
        (
            "GM0001",
            "Unsupported Operator", 
            "{0} is unsupported, please file an issue",
            "Internal",
            DiagnosticSeverity.Error,
            true,
            null,
            null,
            WellKnownDiagnosticTags.AnalyzerException
        );
    }
}
