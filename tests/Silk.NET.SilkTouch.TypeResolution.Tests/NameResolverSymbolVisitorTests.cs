// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public class NameResolverSymbolVisitorTests
{
    [Fact, Trait("Category", "Type Resolution")]
    public void SelfTypeIsResolvedCorrectly()
    {
        var testType = new StructSymbol(TypeId.CreateNew(), new IdentifierSymbol("a"), new FieldSymbol[]
        {
            new(new UnresolvedTypeReference("a"), new IdentifierSymbol("someField"))
        }.ToImmutableArray());
        var resolutionScope = new TypeResolutionScope
        (
            new Dictionary<TypeSymbol, TypeResolutionScope>
            {
                [testType] = new TypeResolutionScope(new())
            }
        );
        var serviceProvider = Helpers.CreateServiceProvider();
        var visitor = new NameResolverSymbolVisitor
        (
            serviceProvider.GetRequiredService<ILoggerFactory>().CreateLogger<NameResolverSymbolVisitor>(),
            resolutionScope,
            new TypeStore()
        );

        var resultType = visitor.Visit(testType);

        var @struct = Assert.IsType<StructSymbol>(resultType);
        Assert.StrictEqual(testType.Identifier, @struct.Identifier);
        var field = Assert.Single(@struct.Fields);
        Assert.StrictEqual(testType.Fields[0].Identifier, @field.Identifier);
        var reference = Assert.IsType<InternalTypeReference>(field.Type);
        Assert.StrictEqual(@struct.Id, reference.ReferencedTypeId);
    }
}
