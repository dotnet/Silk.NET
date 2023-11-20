// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public abstract class EmitterTest
{
    protected CSharpEmitter CreateEmitter()
    {
        return new CSharpEmitter();
    }

    protected CSharpSyntaxNode Transform(Symbol symbol, TypeStore? typeStore = null)
    {
        return CreateEmitter().Transform(symbol, typeStore ?? new TypeStore());
    }
}
