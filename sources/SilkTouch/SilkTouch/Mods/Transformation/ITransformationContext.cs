// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Mods.Transformation;

/// <summary>
/// Provides functionality for <see cref="IFunctionTransformer"/>s for influencing outside of the scope of the specific
/// function they're transforming.
/// </summary>
public interface ITransformationContext
{
    /// <summary>
    /// The original method signature.
    /// </summary>
    public MethodDeclarationSyntax? Original { get; set; }

    /// <summary>
    /// The transformers in use.
    /// </summary>
    public IFunctionTransformer[] Transformers { get; set; }

    /// <summary>
    /// The document factory in use.
    /// </summary>
    /// <remarks>
    /// Main purpose is for adding using statements.
    /// </remarks>
    public DocumentFactory DocumentFactory { get; set; }
}
