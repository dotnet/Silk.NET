// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// A queryable representation of a <see cref="BaseTypeDeclarationSyntax"/>
/// </summary>
public interface IBaseTypeContext
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
    /// The number of GenericParameters
    /// </summary>
    int GenericParameterCount { get; }

    /// <summary>
    /// The SyntaxNode representing this type
    /// </summary>
    BaseTypeDeclarationSyntax? Node { get; }

    /// <summary>
    /// Attempts to get Type object that is contained within this type
    /// </summary>
    /// <param name="typeName"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    /// <param name="genericParameterCount"></param>
    bool TryGetSubType(string typeName, out SubType type, int genericParameterCount = 0);

    /// <summary>
    /// Attempts to Add or overwrites a sub type within this type
    /// </summary>
    /// <param name="node"></param>
    /// <param name="rewriter"></param>
    bool TryAddSubType(BaseTypeDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Removes the subtype with the given name and number of parameters within this type
    /// </summary>
    /// <param name="name"></param>
    /// <param name="genericParameterCount"></param>
    void RemoveSubType(string name, int genericParameterCount = 0);

    /// <summary>
    /// Removes all subtypes with the given name within this type
    /// </summary>
    /// <param name="name"></param>
    void RemoveSubTypes(string name);

    /// <summary>
    /// All subtypes contained within this type
    /// </summary>
    IEnumerable<(string, IEnumerable<SubType>)> SubTypes { get; }

    /// <summary>
    /// Attempts to get the type and pointer depth of the field in this type
    /// </summary>
    /// <param name="fieldName"></param>
    /// <param name="field"></param>
    /// <returns></returns>
    bool TryGetField(string fieldName, out Field field);

    /// <summary>
    /// Attempts to Add or overwrites a field within this type
    /// </summary>
    /// <param name="node"></param>
    /// <param name="rewriter"></param>
    bool TryAddField(BaseFieldDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Removes the field with the given name within this type
    /// </summary>
    /// <param name="name"></param>
    void RemoveField(string name);

    /// <summary>
    /// All Fields contained within this tyoe
    /// </summary>
    IEnumerable<(string, Field)> Fields { get; }

    /// <summary>
    /// Attempts to get the type and pointer depth of the property in this type
    /// </summary>
    /// <param name="propertyName"></param>
    /// <param name="property"></param>
    /// <returns></returns>
    bool TryGetProperty(string propertyName, out Property property);

    /// <summary>
    /// Attempts to Add or overwrites a property with the given name within this type
    /// </summary>
    /// <param name="node"></param>
    /// <param name="rewriter"></param>
    bool TryAddProperty(BasePropertyDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Removes the property with the given name within this type
    /// </summary>
    /// <param name="name"></param>
    void RemoveProperty(string name);

    /// <summary>
    /// All Properties contained within this type
    /// </summary>
    IEnumerable<(string, Property)> Properties { get; }

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
    /// Attempts to Add or overwrites a base type for this type to derive from
    /// </summary>
    /// <param name="baseType"></param>
    /// <param name="context"></param>
    /// <param name="rewriter"></param>
    /// <returns></returns>
    bool TryAddBaseType(BaseTypeSyntax baseType, SyntaxContext context, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Removes a type from the list of parent types
    /// </summary>
    /// <param name="baseType"></param>
    void RemoveBaseType(string baseType);

    /// <summary>
    /// All types this type derives from
    /// </summary>
    IEnumerable<(string, BaseTypeSyntax, IBaseTypeContext)> BaseTypes { get; }

    /// <summary>
    /// Attempts to get all methods with a given name and their info
    /// </summary>
    /// <param name="name"></param>
    /// <param name="methodInfo"></param>
    /// <returns></returns>
    bool TryGetMethods(string name, out IEnumerable<Method> methodInfo);

    /// <summary>
    /// Attempts to Add or overwrites a method within this type
    /// </summary>
    /// <param name="node"></param>
    /// <param name="rewriter"></param>
    bool TryAddMethod(MethodDeclarationSyntax node, ContextCSharpSyntaxRewriter rewriter);

    /// <summary>
    /// Removes the method with the given name and matching parameters within this type
    /// </summary>
    /// <param name="name"></param>
    /// <param name="parameters"></param>
    void RemoveMethod(string name, params TypeSyntax[] parameters);

    /// <summary>
    /// Removes the methods with the given name within this type
    /// </summary>
    /// <param name="name"></param>
    void RemoveMethods(string name);

    /// <summary>
    /// All methods contained within this type
    /// </summary>
    IEnumerable<(string, IEnumerable<Method>)> Methods { get; }

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
    /// Represents a type defined within a type
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="TypeContext"></param>
    public record struct SubType(BaseTypeDeclarationSyntax? Node = null, IBaseTypeContext? TypeContext = null);

    /// <summary>
    /// Represents a field defined within a type
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="Type"></param>
    /// <param name="TypePointerDepth"></param>
    public record struct Field(BaseFieldDeclarationSyntax? Node = null, TypeContainer? Type = null, int TypePointerDepth = 0);

    /// <summary>
    /// Represents a property defined within a type
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="Type"></param>
    /// <param name="TypePointerDepth"></param>
    public record struct Property(BasePropertyDeclarationSyntax? Node = null, TypeContainer? Type = null, int TypePointerDepth = 0);

    /// <summary>
    /// Represents a method defined within a type
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="ReturnType"></param>
    /// <param name="ReturnTypePointerDepth"></param>
    /// <param name="Parameters"></param>
    public record struct Method(MethodDeclarationSyntax? Node = null, TypeContainer? ReturnType = null, int ReturnTypePointerDepth = 0, IEnumerable<(string, MethodParameter)>? Parameters = null);

    /// <summary>
    /// Represents a parameter of a method defined within a type
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="Type"></param>
    /// <param name="TypePointerDepth"></param>
    public record struct MethodParameter(ParameterSyntax Node, TypeContainer? Type, int TypePointerDepth);

    /// <summary>
    /// Represents a delegate type
    /// </summary>
    /// <param name="Node"></param>
    /// <param name="ReturnType"></param>
    /// <param name="ReturnTypePointerDepth"></param>
    /// <param name="Parameters"></param>
    public record Delegate(DelegateDeclarationSyntax? Node = null, TypeContainer? ReturnType = null, int ReturnTypePointerDepth = 0, IEnumerable<(string, MethodParameter)>? Parameters = null);
}
