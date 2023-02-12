// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution.Annotations;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public class NameResolverSymbolVisitorTests
{
    [Fact, Trait("Category", "Type Resolution")]
    public void SelfTypeIsResolvedCorrectly()
    {
        var testType = new StructSymbol
        (
            TypeId.CreateNew(),
            new IdentifierSymbol("a", ImmutableArray<ISymbolAnnotation>.Empty),
            ImmutableArray.Create
            (
                (MemberSymbol)new FieldSymbol
                (
                    new UnresolvedTypeReference("a", ImmutableArray<ISymbolAnnotation>.Empty),
                    new IdentifierSymbol("someField", ImmutableArray<ISymbolAnnotation>.Empty),
                    ImmutableArray<ISymbolAnnotation>.Empty
                )
            ),
            ImmutableArray<ISymbolAnnotation>.Empty
        );
        var typeStore = new TypeStore();
        typeStore.Store(testType);
        var resolutionScope = new TypeResolutionScope
        (
            new Dictionary<TypeId, TypeResolutionScope>
            {
                [testType.Id] = new TypeResolutionScope(new())
            }
        );
        var serviceProvider = Helpers.CreateServiceProvider();
        var visitor = new NameResolverSymbolVisitor
        (
            serviceProvider.GetRequiredService<ILoggerFactory>().CreateLogger<NameResolverSymbolVisitor>(),
            resolutionScope,
            typeStore
        );

        var resultType = visitor.Visit(testType);

        var @struct = Assert.IsType<StructSymbol>(resultType);
        Assert.StrictEqual(testType.Identifier, @struct.Identifier);
        var member = Assert.Single(@struct.Members);
        var field  = Assert.IsType<FieldSymbol>(member);
        Assert.StrictEqual(field.Identifier, @field.Identifier);
        var reference = Assert.IsType<InternalTypeReference>(field.Type);
        Assert.StrictEqual(@struct.Id, reference.ReferencedTypeId);
        Assert.Equal("a", Assert.IsType<ResolvedFromAnnotation>(Assert.Single(reference.Annotations)).OriginalString);
    }
}
