// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Silk.NET.SilkTouch.Clang.IBaseTypeContext;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Represents a namespace within a SyntaxContext
/// </summary>
public interface INamespaceContext
{
    /// <summary>
    /// The parent namespace if one exists
    /// </summary>
    INamespaceContext? Parent { get; }
    /// <summary>
    /// The full namespace within this namespace object
    /// </summary>
    string FullNamespace { get; }
    /// <summary>
    /// Name of the current namespace (just the final element)
    /// </summary>
    string Name { get; }

    /// <summary>
    /// The Syntax node representing this namespace
    /// </summary>
    BaseNamespaceDeclarationSyntax? Node { get; }

    /// <summary>
    /// Adds the namespace declaration 
    /// </summary>
    /// <param name="syntax"></param>
    /// <param name="rewriter"></param>
    void AddNamespace(BaseNamespaceDeclarationSyntax syntax, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Removes a namespace with the given name within this namespace
    /// </summary>
    /// <param name="name"></param>
    void RemoveNamespace(string name);

    /// <summary>
    /// Attempt to get a namespace with the given name within this namespace
    /// </summary>
    /// <param name="name"></param>
    /// <param name="ns"></param>
    /// <returns></returns>
    bool TryGetNamespace(string name, out INamespaceContext? ns);

    /// <summary>
    /// All the namespaces contained within this namespace
    /// </summary>
    IEnumerable<(string, INamespaceContext)> Namespaces { get; }

    /// <summary>
    /// Attempts to get Type object that is contained within this namespace
    /// </summary>
    /// <param name="typeName"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    /// <param name="genericParameterCount"></param>
    bool TryGetType(string typeName, out TypeContainer type, int genericParameterCount = 0);

    /// <summary>
    /// Attempts to Add or overwrites a sub type within this namespace
    /// </summary>
    /// <param name="node"></param>
    /// <param name="rewriter"></param>
    bool TryAddType(BaseTypeDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Attempts to Add or overwrites a sub type within this namespace
    /// </summary>
    /// <param name="node"></param>
    /// <param name="rewriter"></param>
    bool TryAddType(DelegateDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Removes the subtype with the given name and number of parameters within this namespace
    /// </summary>
    /// <param name="name"></param>
    /// <param name="genericParameterCount"></param>
    void RemoveType(string name, int genericParameterCount = 0);

    /// <summary>
    /// Removes all subtypes with the given name within this namespace
    /// </summary>
    /// <param name="name"></param>
    void RemoveTypes(string name);

    /// <summary>
    /// All types contained within this namespace
    /// </summary>
    IEnumerable<(string, IEnumerable<TypeContainer>)> Types { get; }

    /// <summary>
    /// Merges the members of the given namespace into this one
    /// </summary>
    /// <param name="ns"></param>
    /// <param name="rewriter"></param>
    void Merge(BaseNamespaceDeclarationSyntax ns, ContextCSharpSyntaxRewriter rewriter)
    {
        foreach (var mem in ns.Members)
        {
            if (mem is BaseNamespaceDeclarationSyntax subNs)
            {
                AddNamespace(subNs, rewriter)
            }
            else if (mem is BaseTypeDeclarationSyntax ty)
            {
                TryAddType(ty, rewriter);
            }
            else if (mem is DelegateDeclarationSyntax del)
            {
                TryAddType(del, rewriter);
            }
        }
    }

    /// <summary>
    /// Returns a complete version of this node if possible
    /// </summary>
    /// <returns></returns>
    BaseNamespaceDeclarationSyntax? ToCompletedNode() => null;
}
