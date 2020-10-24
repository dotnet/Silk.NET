// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch
{
    public interface INativeContextOverride
    {
        TypeDeclarationSyntax Type(string name, string lib, EntryPoint[] entrypoints);
    }
}
