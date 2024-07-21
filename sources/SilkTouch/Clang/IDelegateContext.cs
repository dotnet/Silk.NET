// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A representation of a Delegate in a SyntaxContext
/// </summary>
public interface IDelegateContext
{
    /// <summary>
    /// The name of the delegate
    /// </summary>
    string Name { get; }

    /// <summary>
    /// The syntax node
    /// </summary>
    DelegateDeclarationSyntax? Node { get; }

    /// <summary>
    /// The containing parent type if this delegate is contained within a type
    /// </summary>
    IBaseTypeContext? Parent { get; }

    /// <summary>
    /// The number of GenericParameters
    /// </summary>
    int GenericParameterCount { get; }

    /// <summary>
    /// A representation of each of the parameters
    /// </summary>
    IEnumerable<(string, IBaseTypeContext.MethodParameter)> Parameters { get; }

    /// <summary>
    /// Rewrites the current type with a given rewriter and some metadata
    /// </summary>
    /// <param name="rewriter"></param>
    /// <param name="ns">current namespace</param>
    /// <param name="file">file this type is in</param>
    /// <returns></returns>
    TypeContainer? Rewrite(ContextCSharpSyntaxRewriter rewriter, string ns, string file);

    /// <summary>
    /// Visits the current type with a given visitor and some metadata
    /// </summary>
    /// <param name="visitor"></param>
    void Visit(ContextCSharpSyntaxVisitor visitor);
}
