// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Clang;

public interface IEnumTypeContext
{
    /// <summary>
    /// A <see cref="TypeSyntax"/> which represents this type
    /// </summary>
    TypeSyntax Syntax { get; }

    /// <summary>
    /// The name of the file that contains this type
    /// </summary>
    string FileName { get; }

    /// <summary>
    /// The name of the type
    /// </summary>
    string Name { get; }

    /// <summary>
    /// The containing type context
    /// </summary>
    IBaseTypeContext? Parent { get; }

    /// <summary>
    /// The SyntaxNode representing this type
    /// </summary>
    EnumDeclarationSyntax? Node { get; }

    /// <summary>
    /// Attempts to retrieve information about a enum member
    /// </summary>
    /// <param name="memberName"></param>
    /// <param name="member"></param>
    /// <returns></returns>
    bool TryGetEnumMember(string memberName, out EnumMemberDeclarationSyntax? member);

    /// <summary>
    /// Attempts to Add or overwrites existing enum member within this type
    /// </summary>
    /// <param name="node"></param>
    /// <returns></returns>
    bool TryAddEnumMember(EnumMemberDeclarationSyntax node);

    /// <summary>
    /// Removes the enum member with the given name within this type
    /// </summary>
    /// <param name="name"></param>
    void RemoveEnumMember(string name);

    /// <summary>
    /// All enumerable members contained within this type
    /// </summary>
    IEnumerable<(string, EnumMemberDeclarationSyntax)> EnumMembers { get; }

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

    /// <summary>
    /// Converts this type to a complete <see cref="MemberDeclarationSyntax"/>
    /// </summary>
    /// <returns></returns>
    MemberDeclarationSyntax? ToCompletedNode();

    /// <summary>
    /// Changes the parent for this type
    /// </summary>
    /// <param name="parent"></param>
    void SetParent(IBaseTypeContext? parent);

    /// <summary>
    /// Does this type inherit from the given type
    /// </summary>
    /// <param name="baseType"></param>
    /// <returns></returns>
    bool HasBaseType(string baseType);

    /// <summary>
    /// Does this type inherit from the given type
    /// </summary>
    /// <param name="baseType"></param>
    /// <returns></returns>
    bool HasBaseType(BaseTypeSyntax baseType);

    /// <summary>
    /// All types this type derives from
    /// </summary>
    IEnumerable<(string, BaseTypeSyntax, IBaseTypeContext)> BaseTypes { get; }
}
