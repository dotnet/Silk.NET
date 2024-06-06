// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.Core;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that extracts type system information nested within other types. Today this includes:
/// <list type="bullet">
/// <item>
/// <description>
/// Function pointers identified by their <see cref="NativeTypeNameAttribute"/>s into delegates and <c>Pfn</c>-prefixed
/// structures.
/// </description>
/// </item>
/// <item><description>Fixed buffers and anonymous structures contained within structures.</description></item>
/// </list>
/// </summary>
public partial class ExtractNestedTyping : Mod
{
    /// <inheritdoc />
    public override Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var dict = new Dictionary<string, SyntaxNode>(syntax.Files.Count);
        var fnPtrWalker = new FunctionPointerWalker();
        var rewriter = new Rewriter();
        foreach (var (fname, node) in syntax.Files)
        {
            fnPtrWalker.File = fname;
            fnPtrWalker.Visit(node);
        }

        rewriter.FunctionPointerTypes = fnPtrWalker.GetFunctionPointerTypes();
        foreach (
            var (structDecl, delegateDecl, fileDirs, namespaces) in rewriter
                .FunctionPointerTypes
                .Values
        )
        {
            var ns = NameUtils.FindCommonPrefix(namespaces, true, false, true).AsSpan();
            var dir = NameUtils.FindCommonPrefix(fileDirs, true, false, true).AsSpan().TrimEnd('/');
            dict[$"{dir}/{structDecl.Identifier}.gen.cs"] = CompilationUnit()
                .WithMembers(
                    ns is { Length: > 0 }
                        ? SingletonList<MemberDeclarationSyntax>(
                            FileScopedNamespaceDeclaration(
                                    ModUtils.NamespaceIntoIdentifierName(ns.TrimEnd('.'))
                                )
                                .WithMembers(SingletonList<MemberDeclarationSyntax>(structDecl))
                        )
                        : SingletonList<MemberDeclarationSyntax>(structDecl)
                );
            dict[$"{dir}/{delegateDecl.Identifier}.gen.cs"] = CompilationUnit()
                .WithMembers(
                    ns is { Length: > 0 }
                        ? SingletonList<MemberDeclarationSyntax>(
                            FileScopedNamespaceDeclaration(
                                    ModUtils.NamespaceIntoIdentifierName(ns.TrimEnd('.'))
                                )
                                .WithMembers(SingletonList<MemberDeclarationSyntax>(delegateDecl))
                        )
                        : SingletonList<MemberDeclarationSyntax>(delegateDecl)
                );
        }

        foreach (var (fname, node) in syntax.Files)
        {
            dict[fname] = rewriter.Visit(node);
            foreach (var newStruct in rewriter.ExtractedNestedStructs)
            {
                dict[$"{fname.AsSpan()[..fname.LastIndexOf('/')]}/{newStruct.Identifier}.gen.cs"] =
                    CompilationUnit()
                        .WithMembers(
                            rewriter.Namespace is not null
                                ? SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(rewriter.Namespace)
                                        )
                                        .WithMembers(
                                            SingletonList<MemberDeclarationSyntax>(newStruct)
                                        )
                                )
                                : SingletonList<MemberDeclarationSyntax>(newStruct)
                        );
            }

            rewriter.Namespace = null;
            rewriter.ExtractedNestedStructs.Clear();
        }

        return Task.FromResult(syntax with { Files = dict });
    }

    partial class Rewriter : CSharpSyntaxRewriter
    {
        private Dictionary<string, string> _typeRenames = [];

        public List<StructDeclarationSyntax> ExtractedNestedStructs { get; } = [];

        public Dictionary<
            string,
            (
                StructDeclarationSyntax Pfn,
                DelegateDeclarationSyntax Delegate,
                HashSet<string> ReferencingFileDirs,
                HashSet<string> ReferencingNamespaces
            )
        >? FunctionPointerTypes { get; set; }

        public string? Namespace { get; set; }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node) =>
            base.VisitIdentifierName(
                _typeRenames.TryGetValue(node.Identifier.ToString(), out var v)
                || (
                    v =
                        FunctionPointerTypes?.TryGetValue(node.Identifier.ToString(), out var pfni)
                        ?? false
                            ? pfni.Pfn.Identifier.ToString()
                            : null
                )
                    is not null
                    ? node.WithIdentifier(Identifier(v))
                    : node
            );

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            // Extract nested structs.
            var nextExtractedNestedIdx = ExtractedNestedStructs.Count;
            var members = node.Members;
            for (var i = 0; i < members.Count; i++)
            {
                var mem = members[i];
                if (
                    mem is not StructDeclarationSyntax struc
                    || GeneratedNestedTypeRegex().Match(struc.Identifier.ToString())
                        is not { Success: true, Groups.Count: 3 } match
                )
                {
                    continue;
                }

                var iden = $"{node.Identifier}_{match.Groups[1].Value}";
                _typeRenames[struc.Identifier.ToString()] = iden;
                struc =
                    VisitStructDeclaration(struc.WithIdentifier(Identifier(iden)))
                        as StructDeclarationSyntax
                    ?? struc;
                ExtractedNestedStructs.Add(struc);
                members = members.RemoveAt(i--);
            }

            var ret = base.VisitStructDeclaration(node.WithMembers(members));
            for (var i = nextExtractedNestedIdx; i < ExtractedNestedStructs.Count; i++)
            {
                if (
                    _typeRenames
                        .FirstOrDefault(x =>
                            x.Value == ExtractedNestedStructs[i].Identifier.ToString()
                        )
                        .Key
                    is not { } key
                )
                {
                    continue;
                }
                _typeRenames.Remove(key);
            }

            Namespace = node.NamespaceFromSyntaxNode();
            return ret;
        }

        public override SyntaxNode? VisitFunctionPointerType(FunctionPointerTypeSyntax node)
        {
            node = base.VisitFunctionPointerType(node) as FunctionPointerTypeSyntax ?? node;
            var discrim = ModUtils.DiscrimStr(
                null,
                null,
                null,
                node.ParameterList.Parameters,
                null // <-- technically this is the last parameter, but we don't really care here. we're just trying to match signatures.
            );

            return FunctionPointerTypes?.TryGetValue(discrim, out var v) ?? false
                ? IdentifierName(v.Pfn.Identifier.ToString())
                : node;
        }

        [GeneratedRegex("^_([a-zA-Z0-9_]*)_e__(Union|Struct|FixedBuffer)$")]
        private partial Regex GeneratedNestedTypeRegex();
    }

    class FunctionPointerWalker : CSharpSyntaxRewriter
    {
        private Dictionary<
            string,
            (
                FunctionPointerTypeSyntax Pfn,
                List<string> Names,
                HashSet<string> ReferencingFileDirs,
                HashSet<string> ReferencingNamespaces
            )
        > _fnPtrs = new();
        public string? File { get; set; }
        public ILogger? Logger { get; set; }

        public override SyntaxNode VisitFunctionPointerType(FunctionPointerTypeSyntax node)
        {
            var ogNode = node;
            node = base.VisitFunctionPointerType(node) as FunctionPointerTypeSyntax ?? node;
            var identifier =
                ogNode.Ancestors().FirstOrDefault(x => x is not TypeSyntax) is var first
                && first is MethodDeclarationSyntax meth
                    ? meth.GetNativeReturnTypeName()
                    : first is ParameterSyntax param
                        ? param.GetNativeTypeName()
                        : first
                            is VariableDeclarationSyntax { Parent: FieldDeclarationSyntax field }
                            ? field.AttributeLists.GetNativeTypeName()
                            : null;
            var idSpan = identifier is not null ? identifier.AsSpan() : default;
            if (idSpan.StartsWith("const "))
            {
                idSpan = idSpan["const ".Length..];
            }

            if (idSpan.ContainsAny(' ', '*'))
            {
                idSpan = idSpan[..(idSpan.LastIndexOfAny(NameUtils.IdentifierChars) + 1)];
            }

            if (idSpan.ContainsAnyExcept(NameUtils.IdentifierChars))
            {
                idSpan = identifier = null;
            }

            identifier =
                identifier is null || idSpan == identifier ? identifier : idSpan.ToString();
            var discrim = ModUtils.DiscrimStr(
                null,
                null,
                null,
                node.ParameterList.Parameters,
                null // <-- technically this is the last parameter, but we don't really care here. we're just trying to match signatures.
            );
            if (!_fnPtrs.TryGetValue(discrim, out var info))
            {
                _fnPtrs[discrim] = info = (node, [], [], []);
            }

            if (identifier is not null)
            {
                info.Names.Add(identifier);
            }

            info.ReferencingNamespaces.Add(ogNode.NamespaceFromSyntaxNode());
            if (File?.StartsWith("sources/") ?? false)
            {
                info.ReferencingFileDirs.Add(File[..File.LastIndexOf('/')]);
            }

            return IdentifierName(discrim);
        }

        public Dictionary<
            string,
            (
                StructDeclarationSyntax Pfn,
                DelegateDeclarationSyntax Delegate,
                HashSet<string> ReferencingFileDirs,
                HashSet<string> ReferencingNamespaces
            )
        > GetFunctionPointerTypes()
        {
            var dst = new Dictionary<
                string,
                (
                    StructDeclarationSyntax,
                    DelegateDeclarationSyntax,
                    HashSet<string>,
                    HashSet<string>
                )
            >(_fnPtrs.Count);
            foreach (var (discrim, info) in _fnPtrs)
            {
                AddFunctionPointerType(dst, discrim, info);
            }

            return dst;
        }

        private void AddFunctionPointerType(
            Dictionary<
                string,
                (
                    StructDeclarationSyntax Pfn,
                    DelegateDeclarationSyntax Delegate,
                    HashSet<string> ReferencingFileDirs,
                    HashSet<string> ReferencingNamespaces
                )
            > dst,
            string discrim,
            (
                FunctionPointerTypeSyntax Pfn,
                List<string> Names,
                HashSet<string> ReferencingFileDirs,
                HashSet<string> ReferencingNamespaces
            ) info
        )
        {
            if (dst.ContainsKey(discrim))
            {
                return;
            }

            string? identifier = null;
            foreach (var iden in info.Names.Distinct().Order())
            {
                if (identifier is null)
                {
                    identifier = iden;
                }
                else
                {
                    Logger?.LogWarning(
                        "Function pointer signature {} referred to by multiple names: {} and {}. "
                            + "Using {} as it appeared first.",
                        info.Pfn,
                        identifier,
                        iden,
                        identifier
                    );
                }
            }

            var rawPfn = info.Pfn;
            Dictionary<string, string>? replacements = null;
            foreach (
                var referencedIden in info.Pfn.DescendantNodes().OfType<IdentifierNameSyntax>()
            )
            {
                var id = referencedIden.Identifier.ToString();
                // Ensure we visit nested function pointers first to get their up-to-date name for generated pfn names.
                if (
                    referencedIden.Identifier.ToString() != discrim
                    && _fnPtrs.TryGetValue(id, out var v)
                )
                {
                    AddFunctionPointerType(dst, id, v);
                    (replacements ??= []).Add(id, dst[id].Pfn.Identifier.ToString());
                    foreach (var ns in dst[id].ReferencingNamespaces)
                    {
                        info.ReferencingNamespaces.Add(ns);
                    }

                    foreach (var dir in dst[id].ReferencingFileDirs)
                    {
                        info.ReferencingFileDirs.Add(dir);
                    }
                }
            }

            string? newDiscrim = null;
            if (replacements is not null)
            {
                rawPfn =
                    rawPfn.ReplaceIdentifiers(replacements) as FunctionPointerTypeSyntax ?? rawPfn;
                newDiscrim = ModUtils.DiscrimStr(
                    null,
                    null,
                    null,
                    rawPfn.ParameterList.Parameters,
                    null
                );
            }

            var (newName, delegateName) = identifier is null
                ? GetGeneratedPfnName(rawPfn, dst)
                : (identifier, $"{identifier}_delegate");
            var attrLists = identifier is null
                ? SingletonList(
                    AttributeList(
                        // non-determinant identifier
                        SingletonSeparatedList(Attribute(IdentifierName("Transformed")))
                    )
                )
                : default;

            // Ported from https://github.com/dotnet/Silk.NET/blob/d30cc43b/src/Core/Silk.NET.BuildTools/Bind/StructWriter.cs#L744-L774
            var pfn = StructDeclaration(newName)
                .WithModifiers(
                    TokenList(
                        Token(SyntaxKind.PublicKeyword),
                        Token(SyntaxKind.UnsafeKeyword),
                        Token(SyntaxKind.ReadOnlyKeyword)
                    )
                )
                .WithBaseList(
                    BaseList(
                        SingletonSeparatedList<BaseTypeSyntax>(
                            SimpleBaseType(IdentifierName("IDisposable"))
                        )
                    )
                )
                .WithAttributeLists(attrLists)
                .WithMembers(
                    List<MemberDeclarationSyntax>(
                        [
                            FieldDeclaration(
                                    VariableDeclaration(
                                        PointerType(PredefinedType(Token(SyntaxKind.VoidKeyword))),
                                        SingletonSeparatedList(VariableDeclarator("_pointer"))
                                    )
                                )
                                .WithModifiers(
                                    TokenList(
                                        Token(SyntaxKind.PrivateKeyword),
                                        Token(SyntaxKind.ReadOnlyKeyword)
                                    )
                                ),
                            PropertyDeclaration(rawPfn, "Handle")
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        CastExpression(rawPfn, IdentifierName("_pointer"))
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConstructorDeclaration(newName)
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("ptr")).WithType(rawPfn)
                                        )
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        AssignmentExpression(
                                            SyntaxKind.SimpleAssignmentExpression,
                                            IdentifierName("_pointer"),
                                            IdentifierName("ptr")
                                        )
                                    )
                                )
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConstructorDeclaration(newName)
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("proc"))
                                                .WithType(IdentifierName(delegateName))
                                        )
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        AssignmentExpression(
                                            SyntaxKind.SimpleAssignmentExpression,
                                            IdentifierName("_pointer"),
                                            InvocationExpression(
                                                MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    IdentifierName("SilkMarshal"),
                                                    IdentifierName("DelegateToPtr")
                                                ),
                                                ArgumentList(
                                                    SingletonSeparatedList(
                                                        Argument(IdentifierName("proc"))
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            MethodDeclaration(
                                    PredefinedType(Token(SyntaxKind.VoidKeyword)),
                                    "Dispose"
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("SilkMarshal"),
                                                IdentifierName("Free")
                                            ),
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(IdentifierName("_pointer"))
                                                )
                                            )
                                        )
                                    )
                                )
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConversionOperatorDeclaration(
                                    Token(SyntaxKind.ImplicitKeyword),
                                    IdentifierName(newName)
                                )
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("pfn")).WithType(rawPfn)
                                        )
                                    )
                                )
                                .WithModifiers(
                                    TokenList(
                                        Token(SyntaxKind.PublicKeyword),
                                        Token(SyntaxKind.StaticKeyword)
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        ImplicitObjectCreationExpression(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(IdentifierName("pfn"))
                                                )
                                            ),
                                            null
                                        )
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConversionOperatorDeclaration(Token(SyntaxKind.ImplicitKeyword), rawPfn)
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("pfn"))
                                                .WithType(IdentifierName(newName))
                                        )
                                    )
                                )
                                .WithModifiers(
                                    TokenList(
                                        Token(SyntaxKind.PublicKeyword),
                                        Token(SyntaxKind.StaticKeyword)
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        CastExpression(
                                            rawPfn,
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("pfn"),
                                                IdentifierName("_pointer")
                                            )
                                        )
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken))
                            // TODO invoke method?
                        ]
                    )
                );

            var @delegate = DelegateDeclaration(
                    rawPfn.ParameterList.Parameters.Last().Type,
                    Identifier(delegateName)
                )
                .WithModifiers(
                    TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
                )
                .WithAttributeLists(attrLists)
                .WithParameterList(
                    ParameterList(
                        SeparatedList(
                            rawPfn
                                .ParameterList.Parameters.SkipLast(1)
                                .Select(
                                    (y, i) =>
                                        Parameter(
                                            y.AttributeLists,
                                            y.Modifiers,
                                            y.Type,
                                            Identifier($"arg{i}"),
                                            null
                                        )
                                )
                        )
                    )
                );

            dst[discrim] = (pfn, @delegate, info.ReferencingFileDirs, info.ReferencingNamespaces);
            if (newDiscrim is not null)
            {
                dst[newDiscrim] = dst[discrim];
            }
        }

        // Ported from https://github.com/dotnet/Silk.NET/blob/d30cc43b/src/Core/Silk.NET.BuildTools/Cpp/Clang.cs#L349-L372
        private (string Pfn, string Delegate) GetGeneratedPfnName(
            FunctionPointerTypeSyntax syn,
            Dictionary<
                string,
                (
                    StructDeclarationSyntax Pfn,
                    DelegateDeclarationSyntax Delegate,
                    HashSet<string> ReferencingFileDirs,
                    HashSet<string> ReferencingNamespaces
                )
            > dst,
            bool topLevel = true
        )
        {
            var @params = string.Join(
                ' ',
                syn.ParameterList.Parameters.Select(x => ForType(x.Type, dst))
            );
            return topLevel
                ? ($"Pfn {@params}".Pascalize(), $"{@params} Proc".Pascalize())
                : ($"Pfn {@params}", $"{@params} Proc");
            string ForType(
                TypeSyntax type,
                Dictionary<
                    string,
                    (
                        StructDeclarationSyntax Pfn,
                        DelegateDeclarationSyntax Delegate,
                        HashSet<string> ReferencingFileDirs,
                        HashSet<string> ReferencingNamespaces
                    )
                > dest
            ) =>
                type switch
                {
                    ArrayTypeSyntax at => $"{ForType(at.ElementType, dest)}v",
                    AliasQualifiedNameSyntax aq => ForType(aq.Name, dest),
                    FunctionPointerTypeSyntax fn => GetGeneratedPfnName(fn, dest, false).Pfn,
                    GenericNameSyntax gn
                        => $"{gn.Identifier}T{gn.TypeArgumentList.Arguments.Count}",
                    IdentifierNameSyntax id
                        when dest.TryGetValue(id.Identifier.ToString(), out var v)
                        => v.Pfn.Identifier.ToString(),
                    IdentifierNameSyntax id => id.Identifier.ToString(),
                    QualifiedNameSyntax qn => qn.Right.Identifier.ToString(),
                    SimpleNameSyntax sn => sn.Identifier.ToString(),
                    NullableTypeSyntax nt => ForType(nt.ElementType, dest),
                    PointerTypeSyntax pt => $"{ForType(pt.ElementType, dest)}v",
                    PredefinedTypeSyntax pt
                        => pt.Keyword.Kind() switch
                        {
                            SyntaxKind.VoidKeyword => "V",
                            SyntaxKind.IntKeyword => "i",
                            SyntaxKind.UIntKeyword => "ui",
                            SyntaxKind.LongKeyword => "i64",
                            SyntaxKind.ULongKeyword => "ui64",
                            SyntaxKind.ShortKeyword => "s",
                            SyntaxKind.UShortKeyword => "us",
                            SyntaxKind.FloatKeyword => "f",
                            SyntaxKind.DoubleKeyword => "d",
                            SyntaxKind.BoolKeyword or SyntaxKind.SByteKeyword => "b",
                            SyntaxKind.ByteKeyword => "ub",
                            _ => pt.ToString()
                        },
                    RefTypeSyntax rt => $"{ForType(rt.Type, dest)}v",
                    ScopedTypeSyntax st => ForType(st.Type, dest),
                    TupleTypeSyntax tt
                        => string.Join(' ', tt.Elements.Select(x => ForType(x.Type, dest))),
                    _ => throw new ArgumentOutOfRangeException(nameof(type))
                };
        }
    }
}
