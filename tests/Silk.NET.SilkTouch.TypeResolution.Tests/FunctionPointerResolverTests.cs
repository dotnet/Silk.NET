// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Linq;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public class FunctionPointerResolverTests
{
    [Theory, Trait("Category", "Type Resolution"),
     InlineData("delegate* unmanaged<A>", "A", new string[0]),
     InlineData("delegate* unmanaged<A, B, C>", "C", new[] { "A", "B"}),
     InlineData("delegate* unmanaged[Cdecl]<A>", "A", new string[0]),
     InlineData("delegate* unmanaged[Cdecl]<A, B, C>", "C", new[] { "A", "B"}),
    ]
    public void ShouldMatch(string text, string returnString, string[] parameters)
    {
        var result = new FunctionPointerResolver(new TypeStore()).Visit(new UnresolvedTypeReference(text));

        var fptr = Assert.IsType<FunctionPointerTypeReference>(result);
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
     InlineData("delegate*")
    ]
    public void ShouldNotMatch(string text)
    {
        var result = new FunctionPointerResolver(new TypeStore()).Visit(new UnresolvedTypeReference(text));

        Assert.IsNotType<FunctionPointerTypeReference>(result);
    }
}
