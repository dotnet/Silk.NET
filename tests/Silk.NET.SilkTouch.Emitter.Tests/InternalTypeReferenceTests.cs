// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Immutable;
using System.ComponentModel;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Emitter.Tests;

public class InternalTypeReferenceTests : EmitterTest
{
    [Fact, Trait("Category", "Type Resolution"), Trait("Category", "Symbols")]
    public void StringTest()
    {
        var typeStore = new TypeStore();

        var typeId = TypeId.CreateNew();
        var actualType = new StructSymbol
        (
            typeId,
            new IdentifierSymbol("Identifier", ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray<MemberSymbol>.Empty,
            ImmutableArray<ISymbolAnnotation>.Empty
        );
        typeStore.Store(actualType);
        var symbol = new InternalTypeReference(typeId, ImmutableArray<ISymbolAnnotation>.Empty);

        var transformed = Transform(symbol, typeStore);

        Assert.Equal("Identifier", transformed.ToFullString());
    }
}
