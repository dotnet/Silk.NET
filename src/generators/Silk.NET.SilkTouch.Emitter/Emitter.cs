// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Symbols;
using SymbolVisitor = Microsoft.CodeAnalysis.SymbolVisitor;

namespace Silk.NET.SilkTouch.Emitter;

/// <summary>
/// The primary entrypoint for all C# related emission
/// </summary>
public sealed class CSharpEmitter
{
    /// <summary>
    /// Create a new <see cref="CSharpEmitter"/> from dependencies. This should generally be called by DI.
    /// </summary>
    public CSharpEmitter()
    {
        
    }
    
    /// <summary>
    /// Transforms the given <see cref="Symbol"/> into a <see cref="CSharpSyntaxNode"/>
    /// </summary>
    /// <param name="symbol">The symbol to transform</param>
    /// <returns>A syntax node, containing syntax depending on the symbol. The syntax node should produce valid C# code.</returns>
    /// <remarks>
    /// The returned syntax node may not be ideal and is not optimized for code size.
    /// In general it will contain code that is optimized for performance and clarity, this is not a guarantee though.
    /// It may contain comments that may be stripped for better code size.
    /// The returned node will never contain line comments, but other C# language feature may still rely on whitespace and/or newlines.
    /// Note that (block) comments will never be used to replace such whitespace, even if this is valid to allow a potential comment stripping to be a simple as possible.
    /// </remarks>
    public CSharpSyntaxNode Transform(Symbol symbol)
    {
        var visitor = new Visitor();
        visitor.Visit(symbol); // the result is ignored. This allows us to optimize the visitor in some cases.
        var syntax = visitor.Syntax;
        if (syntax is null)
            throw new NotImplementedException
                ("Resulting Syntax was null. This suggests some unimplemented root Symbol in the Visitor.");
        return syntax;
    }
    
    private class Visitor : Silk.NET.SilkTouch.Symbols.SymbolVisitor
    {
        public CSharpSyntaxNode? Syntax => _syntax;
        private CSharpSyntaxNode? _syntax = null;
    }
}
