// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// <see cref="CSharpSyntaxRewriter"/> which contains a queryable current context
/// </summary>
/// <param name="visitIntoStructuredTrivia"></param>
public abstract class ContextCSharpSyntaxRewriter(bool visitIntoStructuredTrivia = false)
    : CSharpSyntaxRewriter(visitIntoStructuredTrivia)
{
    /// <summary>
    /// The current type being visited
    /// </summary>
    public IBaseTypeContext? CurrentContext { get; internal set; }

    /// <summary>
    /// The list of the namespaces being used
    /// </summary>
    public List<string> Usings { get; internal set; } = [];

    /// <summary>
    /// The namespace of the current context
    /// </summary>
    public string CurrentNamespace { get; internal set; } = string.Empty;

    /// <summary>
    /// The currently SyntaxContext
    /// </summary>
    public SyntaxContext? Context { get; internal set; }
}
