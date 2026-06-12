// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Extracts unions, fixed buffers, and anonymous structs output by <see cref="ClangScraper"/>
/// into their own files as non-nested structs.
/// </summary>
/// <remarks>
/// Apparently this mod only handles the special nested structs output by <see cref="ClangScraper"/>
/// right now. We might change this in the future if there is the need.
/// </remarks>
public partial class ExtractNestedTypes : IMod
{
    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var project = ctx.SourceProject;
        if (project == null)
        {
            return;
        }

        // Scan and extract nested structs
        var rewriter = new Rewriter();
        foreach (var docId in project.DocumentIds)
        {
            var doc =
                project.GetDocument(docId)
                ?? throw new InvalidOperationException("Document missing");

            var file = doc.RelativePath();
            if (file is null)
            {
                continue;
            }

            project = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))
                    ?? throw new InvalidOperationException("Visit returned null.")
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
                        // Place extracted struct next to the original file it came from
                        filePath: project.FullPath(
                            $"{file.AsSpan()[..file.LastIndexOf('/')]}/{newStruct.Identifier}.gen.cs"
                        )
                    )
                    .Project;
            }

            rewriter.Namespace = null;
            rewriter.ExtractedNestedStructs.Clear();
        }

        ctx.SourceProject = project;
    }

    private partial class Rewriter : CSharpSyntaxRewriter
    {
        private Dictionary<string, string> _typeRenames = [];

        public List<StructDeclarationSyntax> ExtractedNestedStructs { get; } = [];

        public string? Namespace { get; set; }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node) =>
            base.VisitIdentifierName(
                _typeRenames.TryGetValue(node.Identifier.ToString(), out var newType)
                || (newType = null) is not null
                    ? node.WithIdentifier(Identifier(newType))
                    : node
            );

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
                var member = members[i];
                if (
                    member is not StructDeclarationSyntax structNode
                    || GeneratedNestedTypeRegex().Match(structNode.Identifier.ToString())
                        is not { Success: true, Groups.Count: 3 } match
                )
                {
                    continue;
                }

                var extractedIdentifier = $"{node.Identifier}{match.Groups[1].Value}";
                _typeRenames[structNode.Identifier.ToString()] = extractedIdentifier;
                structNode =
                    VisitStructDeclaration(
                        structNode
                            .WithIdentifier(Identifier(extractedIdentifier))
                            .WithAttributeLists(
                                structNode.AttributeLists.AddReferencedNameAffix(
                                    NameAffixType.Prefix,
                                    "NestedStructParent",
                                    node.Identifier.ToString()
                                )
                            )
                    ) as StructDeclarationSyntax
                    ?? structNode;
                ExtractedNestedStructs.Add(structNode);
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
