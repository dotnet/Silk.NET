using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.Core;
using Silk.NET.SilkTouch.Mods.Metadata;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Adds SupportedApiProfile attributes to APIs in given source roots.
/// </summary>
/// <param name="logger">The logger to use.</param>
/// <param name="config">The configuration snapshot.</param>
/// <param name="versionProviders">The version providers.</param>
[ModConfiguration<Configuration>]
public class AddApiProfiles(
    ILogger<AddApiProfiles> logger,
    IOptionsSnapshot<AddApiProfiles.Configuration> config,
    IEnumerable<
        IJobDependency<IApiMetadataProvider<IEnumerable<SupportedApiProfileAttribute>>>
    > versionProviders
) : Mod
{
    /// <summary>
    /// The mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// The API profile declarations.
        /// </summary>
        public ApiProfileDecl[]? Profiles { get; init; }

        /// <summary>
        /// Whether to also search for <see cref="SupportedApiProfileAttribute"/>s for files that do not match any
        /// profiles in <see cref="Profiles"/> but that might match against an <see cref="IApiMetadataProvider{T}"/>.
        /// Defaults to <c>true</c> if <see cref="Profiles"/> is <c>null</c> or empty.
        /// </summary>
        public bool? SearchAllFiles { get; init; }
    }

    /// <summary>
    /// An API profile.
    /// </summary>
    public class ApiProfileDecl() : SupportedApiProfileAttribute(string.Empty) // <-- required for serialization
    {
        /// <summary>
        /// APIs declared in this relative source root are part of this profile.
        /// </summary>
        public required string SourceSubdirectory { get; init; }
    }

    class Rewriter(
        string? jobKey,
        IEnumerable<
            IApiMetadataProvider<IEnumerable<SupportedApiProfileAttribute>>
        > versionProviders
    ) : CSharpSyntaxRewriter
    {
        public ApiProfileDecl? Profile { get; set; }

        private string? _currentParentSymbol;

        private IEnumerable<AttributeSyntax> GetProfileAttributes(string? childSymbol) =>
            Profile is null
                ? versionProviders
                    .GetAllMetadata(jobKey, _currentParentSymbol, childSymbol)
                    .Select(x => x?.GetSupportedApiProfileAttribute())
                    .OfType<AttributeSyntax>()
                :
                [
                    versionProviders
                        .GetMetadata(
                            jobKey,
                            _currentParentSymbol,
                            childSymbol,
                            x => x.Profile == Profile.Profile,
                            Profile
                        )
                        .GetSupportedApiProfileAttribute(),
                ];

        public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitDelegateDeclaration);

        public override SyntaxNode? VisitEventDeclaration(EventDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitEventDeclaration);

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitPropertyDeclaration);

        public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitEnumMemberDeclaration);

        public override SyntaxNode? VisitIndexerDeclaration(IndexerDeclarationSyntax node) =>
            Visit(node, null, base.VisitIndexerDeclaration);

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            Debug.Assert(node.Declaration.Variables.Count == 1);
            return Visit(
                node,
                node.Declaration.Variables[0].Identifier.ToString(),
                base.VisitFieldDeclaration
            );
        }

        public override SyntaxNode? VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
        {
            Debug.Assert(node.Declaration.Variables.Count == 1);
            return Visit(
                node,
                node.Declaration.Variables[0].Identifier.ToString(),
                base.VisitEventFieldDeclaration
            );
        }

        public override SyntaxNode? VisitConstructorDeclaration(
            ConstructorDeclarationSyntax node
        ) => Visit(node, null, base.VisitConstructorDeclaration);

        public override SyntaxNode? VisitDestructorDeclaration(DestructorDeclarationSyntax node) =>
            Visit(node, null, base.VisitDestructorDeclaration);

        public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax node) =>
            Visit(node, null, base.VisitOperatorDeclaration);

        public override SyntaxNode? VisitConversionOperatorDeclaration(
            ConversionOperatorDeclarationSyntax node
        ) => Visit(node, null, base.VisitConversionOperatorDeclaration);

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitMethodDeclaration);

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node) =>
            VisitType(node, base.VisitStructDeclaration);

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node) =>
            VisitType(node, base.VisitClassDeclaration);

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node) =>
            VisitType(node, base.VisitEnumDeclaration);

        public override SyntaxNode? VisitRecordDeclaration(RecordDeclarationSyntax node) =>
            VisitType(node, base.VisitRecordDeclaration);

        public override SyntaxNode? VisitInterfaceDeclaration(InterfaceDeclarationSyntax node) =>
            VisitType(node, base.VisitInterfaceDeclaration);

        private SyntaxNode? VisitType<T>(T node, Func<T, SyntaxNode?> @base)
            where T : BaseTypeDeclarationSyntax
        {
            // If it's a struct, split field decls with multiple var decs into individual field decls. This is so we can
            // find the attributes individually.
            if (node is StructDeclarationSyntax @struct)
            {
                @struct = @struct.WithMembers(
                    List(
                        @struct.Members.SelectMany(x =>
                            x is not BaseFieldDeclarationSyntax fld
                                ? [x]
                                : fld.Declaration.Variables.Select<
                                    VariableDeclaratorSyntax,
                                    MemberDeclarationSyntax
                                >(v =>
                                    fld.WithDeclaration(
                                        fld.Declaration.WithVariables(SingletonSeparatedList(v))
                                    )
                                )
                        )
                    )
                );
                node = (T)(object)@struct;
            }

            _currentParentSymbol = _currentParentSymbol.PushParentSymbolIdentifier(
                node.Identifier.ToString(),
                out var parentSymbolBefore
            );
            var retNode = @base(node);
            _currentParentSymbol = parentSymbolBefore;
            var attrs = SeparatedList(GetProfileAttributes(null));
            return retNode is T ret && attrs.Any()
                ? ret.AddAttributeLists(AttributeList(attrs))
                : retNode;
        }

        private SyntaxNode? Visit<T>(T node, string? name, Func<T, SyntaxNode?> @base)
            where T : MemberDeclarationSyntax
        {
            // First, call the base visitor logic.
            var retNode = @base(node);

            // Add the attribute if this is the node we are visiting.
            var attrs = SeparatedList(GetProfileAttributes(name));
            return retNode is T ret && attrs.Any()
                ? ret.AddAttributeLists(AttributeList(attrs))
                : retNode;
        }
    }

    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);
        if (ctx.SourceProject is null)
        {
            return;
        }

        var cfg = config.Get(ctx.JobKey);
        var rewriter = new Rewriter(
            ctx.JobKey,
            versionProviders.SelectMany(x => x.Get(ctx.JobKey)).ToArray()
        );
        foreach (var docId in ctx.SourceProject.DocumentIds)
        {
            var doc =
                ctx.SourceProject.GetDocument(docId)
                ?? throw new InvalidOperationException("Document missing");
            var path = doc.RelativePath();
            if (path is null)
            {
                continue;
            }

            var tree = await doc.GetSyntaxTreeAsync(ct);
            if (tree is null)
            {
                continue;
            }

            var root = await tree.GetRootAsync(ct);
            rewriter.Profile = cfg
                .Profiles?.Where(x =>
                    path.StartsWith(x.SourceSubdirectory, StringComparison.OrdinalIgnoreCase)
                )
                .MaxBy(x => x.SourceSubdirectory.Length);
            if (
                rewriter.Profile is null
                && !(
                    cfg.SearchAllFiles.GetValueOrDefault()
                    || (cfg.SearchAllFiles is null && cfg.Profiles is null or { Length: 0 })
                )
            )
            {
                continue;
            }

            if (rewriter.Profile is not null)
            {
                logger.LogDebug("Identified profile {} for {}", rewriter.Profile, path);
            }
            else
            {
                logger.LogDebug("No profile identified for {}", path);
            }

            ctx.SourceProject = doc.WithSyntaxRoot(
                rewriter.Visit(root).NormalizeWhitespace()
            ).Project;
            rewriter.Profile = null;
        }
    }
}
