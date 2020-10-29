// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Microsoft.CodeAnalysis;

namespace Silk.NET.Maths.GenericsGenerator
{
    public class DiagnosticException : Exception
    {
        public Diagnostic Diagnostic { get; }

        public DiagnosticException(Diagnostic diagnostic)
        {
            Diagnostic = diagnostic;
        }
    }
}
