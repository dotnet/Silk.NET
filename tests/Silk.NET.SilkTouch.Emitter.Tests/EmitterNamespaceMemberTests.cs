// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class EmitterNamespaceMemberTests : EmitterTest
{
    [Fact]
    public void NamespaceIntegration()
    {
        var syntax = Transform(new NamespaceSymbol(new IdentifierSymbol("Test"), (new []
        {
            (TypeSymbol)new StructSymbol(new IdentifierSymbol("Test2"), StructLayout.Empty)
        }).ToImmutableArray()));

        var result = syntax.ToFullString();
        Assert.Equal("namespace Test\n{\n[StructLayout(LayoutKind.Explicit)]\npublic struct Test2\n{\n}}", result);
    }
}
