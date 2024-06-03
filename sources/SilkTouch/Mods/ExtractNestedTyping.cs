// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.Core;
using Silk.NET.SilkTouch.Clang;
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
        var rewriter = new Rewriter();
        var fnPtrs =
            new Dictionary<
                string,
                (StructDeclarationSyntax Decl, HashSet<string> ReferencingFiles)
            >();
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
        private readonly List<StructDeclarationSyntax> _pfnStructs = [];
        private Dictionary<string, string> _typeRenames = [];

        public List<StructDeclarationSyntax> ExtractedNestedStructs { get; } = [];

        public string? Namespace { get; set; }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node) =>
            base.VisitIdentifierName(
                _typeRenames.TryGetValue(node.Identifier.ToString(), out var v)
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

        [GeneratedRegex("^_([a-zA-Z0-9_]*)_e__(Union|Struct|FixedBuffer)$")]
        private partial Regex GeneratedNestedTypeRegex();

        public override SyntaxNode? VisitFunctionPointerType(FunctionPointerTypeSyntax node)
        {
            // node.Ancestors().Where(x => x is not TypeSyntax).First() is MethodDeclarationSyntax
            return base.VisitFunctionPointerType(node);
        }
    }
}
