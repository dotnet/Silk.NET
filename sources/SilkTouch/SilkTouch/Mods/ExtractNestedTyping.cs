// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Extracts nested types into their own separate types.
/// In particular, this also handles fixed buffers and anonymous structures output by <see cref="ClangScraper"/>.
/// </summary>
public partial class ExtractNestedTyping(ILogger<ExtractNestedTyping> logger) : Mod
{
    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);

        var project = ctx.SourceProject;
        if (project == null)
        {
            return;
        }

        // First pass to gather data, such as the types to extract and generate
        var walker = new Walker();
        foreach (var doc in project.Documents)
        {
            var (fname, node) = (doc.RelativePath(), await doc.GetSyntaxRootAsync(ct));
            if (fname is null)
            {
                continue;
            }

            walker.File = fname;
            walker.Visit(node);
        }

        // Second pass to modify existing files as per our discovery.
        var rewriter = new Rewriter(logger);
        foreach (var docId in project.DocumentIds)
        {
            var doc =
                project.GetDocument(docId)
                ?? throw new InvalidOperationException("Document missing");
            var (fname, node) = (doc.RelativePath(), await doc.GetSyntaxRootAsync(ct));
            if (fname is null)
            {
                continue;
            }

            // Rewrite node
            // What this does depends on the node's type
            //
            // For example:
            // This will handle removing nested structs.
            // This is also where extracted enums are processed.
            rewriter.File = fname;
            project = doc.WithSyntaxRoot(
                rewriter.Visit(node)
                    ?? throw new InvalidOperationException("Rewriter returned null")
            ).Project;

            foreach (var newStruct in rewriter.ExtractedNestedStructs)
            {
                // Add new documents for each nested struct
                project = project
                    .AddDocument(
                        $"{newStruct.Identifier}.gen.cs",
                        CompilationUnit()
                            .WithMembers(
                                rewriter.Namespace is not null
                                    ? SingletonList<MemberDeclarationSyntax>(
                                        FileScopedNamespaceDeclaration(
                                                ModUtils.NamespaceIntoIdentifierName(
                                                    rewriter.Namespace
                                                )
                                            )
                                            .WithMembers(
                                                SingletonList<MemberDeclarationSyntax>(newStruct)
                                            )
                                    )
                                    : SingletonList<MemberDeclarationSyntax>(newStruct)
                            ),
                        filePath: project.FullPath(
                            $"{fname.AsSpan()[..fname.LastIndexOf('/')]}/{newStruct.Identifier}.gen.cs"
                        )
                    )
                    .Project;
            }

            rewriter.File = null;
            rewriter.Namespace = null;
            rewriter.ExtractedNestedStructs.Clear();
        }

        ctx.SourceProject = project;
    }

    private static ReadOnlySpan<char> GetNativeTypeNameForPredefinedType(
        PredefinedTypeSyntax node,
        Dictionary<string, (SyntaxKind, HashSet<string>, HashSet<string>)?>? numericTypeNames = null
    )
    {
        // Walk up to the parameter or method. We only allow primitive integer types right now.
        var current = node.Parent;
        var indirectionLevels = 0;
        while (current is PointerTypeSyntax)
        {
            indirectionLevels++;
            current = current.Parent;
        }

        var attrs = current switch
        {
            MethodDeclarationSyntax meth => meth.AttributeLists,
            ParameterSyntax param => param.AttributeLists,
            _ => default,
        };

        if (attrs.Count == 0)
        {
            return default;
        }

        if (!attrs.TryParseNativeTypeName(out var info))
        {
            return null;
        }

        // Ensure that the indirection levels indicated by the type name is the same as we've encountered when walking
        // up the type. If this isn't, this indicates that the native type name is a typedef to a pointer and shouldn't
        // be something that is mapped into an enum.
        if (info.IndirectionLevels == indirectionLevels)
        {
            return info.Name;
        }

        InvalidateIfSeen(numericTypeNames, info.Name);
        return null;
    }

    private static void InvalidateIfSeen(
        Dictionary<string, (SyntaxKind, HashSet<string>, HashSet<string>)?>? numericTypeNames,
        string nativeTypeName
    )
    {
        if (numericTypeNames?.ContainsKey(nativeTypeName) ?? false)
        {
            numericTypeNames[nativeTypeName] = null;
        }
    }

    private partial class Rewriter(ILogger logger) : CSharpSyntaxRewriter
    {
        private Dictionary<string, string> _typeRenames = [];

        public List<StructDeclarationSyntax> ExtractedNestedStructs { get; } = [];

        public string? Namespace { get; set; }
        public string? File { get; set; }

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

        public override SyntaxNode? VisitPredefinedType(PredefinedTypeSyntax node)
        {
            var nativeTypeName = GetNativeTypeNameForPredefinedType(node).ToString();
            if (ExtractedEnums?.Contains(nativeTypeName) ?? false)
            {
                return IdentifierName(nativeTypeName).WithTriviaFrom(node);
            }

            return base.VisitPredefinedType(node);
        }

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            // Extract nested structs
            // This will do two things:
            // 1. Remove the nested struct(s) from the original struct
            // 2. Add them to the ExtractedNestedStructs list to be processed later
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

                var iden = $"{node.Identifier}{match.Groups[1].Value}";
                _typeRenames[struc.Identifier.ToString()] = iden;
                struc =
                    VisitStructDeclaration(
                        struc
                            .WithIdentifier(Identifier(iden))
                            .WithAttributeLists(
                                struc.AttributeLists.AddReferencedNameAffix(
                                    NameAffixType.Prefix,
                                    "NestedStructParent",
                                    node.Identifier.ToString()
                                )
                            )
                    ) as StructDeclarationSyntax
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
    }
}
