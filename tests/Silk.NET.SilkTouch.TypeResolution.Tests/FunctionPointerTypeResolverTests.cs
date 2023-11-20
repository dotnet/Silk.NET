// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution.Annotations;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public class FunctionPointerTypeResolverTests
{
    [Theory, Trait("Category", "Type Resolution"),
     InlineData("delegate* unmanaged<A>", "A", new string[0]),
     InlineData("delegate* unmanaged<A, B, C>", "C", new[] { "A", "B"}),
     InlineData("delegate* unmanaged[Cdecl]<A>", "A", new string[0]),
     InlineData("delegate* unmanaged[Cdecl]<A, B, C>", "C", new[] { "A", "B"}),
     InlineData("delegate* unmanaged<A, B,C>", "C", new[] { "A", "B"}),
     InlineData("delegate* unmanaged[Cdecl]<A,B, C>", "C", new[] { "A", "B"}),
     InlineData("delegate* unmanaged[Cdecl, SupressGCTransition]<A>", "A", new string[0]),
     InlineData("delegate* unmanaged[Cdecl, SupressGCTransition]<A, B, C>", "C", new[] { "A", "B"}),
    ]
    public void ShouldMatch(string text, string returnString, string[] parameters)
    {
        var serviceProvider = Helpers.CreateServiceProvider();
        var result = new FunctionPointerTypeResolver
            (serviceProvider.GetRequiredService<ILogger<FunctionPointerTypeResolver>>(), new TypeStore()).Visit
            (new UnresolvedTypeReference(text, ImmutableArray<ISymbolAnnotation>.Empty));
        
        var fptr = Assert.IsType<FunctionPointerTypeReference>(result);
        Assert.Equal(text, Assert.IsType<ResolvedFromAnnotation>(Assert.Single(fptr.Annotations)).OriginalString);
        Assert.Equal(returnString, Assert.IsType<UnresolvedTypeReference>(fptr.ReturnType).Text);
        Assert.Collection
        (
            fptr.ParameterTypes,
            parameters.Select
                (
                    x => new Action<TypeReference>(r => Assert.Equal(x, Assert.IsType<UnresolvedTypeReference>(r).Text))
                )
                .ToArray()
        );
    }
    
    
    [Theory, Trait("Category", "Type Resolution"),
     InlineData(""),
     InlineData("a"),
     InlineData("*"),
     InlineData("a.b.c"),
     InlineData("longType"),
     InlineData("int"),
     InlineData("using"),
     InlineData("delegate*"),
    InlineData("delegate* unmanaged<>"),
    ]
    public void ShouldNotMatch(string text)
    {
        var serviceProvider = Helpers.CreateServiceProvider();
        var result = new FunctionPointerTypeResolver
            (serviceProvider.GetRequiredService<ILogger<FunctionPointerTypeResolver>>(), new TypeStore()).Visit
            (new UnresolvedTypeReference(text, ImmutableArray<ISymbolAnnotation>.Empty));

        Assert.IsNotType<FunctionPointerTypeReference>(result);
    }
}
