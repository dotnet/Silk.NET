// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Mods.Transformation;

namespace Silk.NET.SilkTouch.UnitTests;

public class DummyTransformationContext : ITransformationContext
{
    public string? JobKey { get; set; } = "Test";
    public MethodDeclarationSyntax? Original { get; set; }
    public IFunctionTransformer[]? Transformers { get; set; } = [];
    public Predicate<UsingDirectiveSyntax> OnAddUsing = _ => true;

    public bool AddUsing(UsingDirectiveSyntax use) => OnAddUsing.Invoke(use);
}
