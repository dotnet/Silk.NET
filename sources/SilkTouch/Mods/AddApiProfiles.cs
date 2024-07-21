using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.Core;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Mods.Metadata;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Adds SupportedApiProfile attributes to APIs in given source roots, optionally merging APIs into a single source set.
/// </summary>
/// <param name="logger">The logger to use.</param>
/// <param name="config">The configuration snapshot.</param>
/// <param name="versionProviders">The version providers.</param>
[ModConfiguration<Configuration>]
public class AddApiProfiles(
    ILogger<AddApiProfiles> logger,
    IOptionsSnapshot<AddApiProfiles.Configuration> config,
    IJobDependency<IApiMetadataProvider<IEnumerable<SupportedApiProfileAttribute>>> versionProviders
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

        /// <summary>
        /// If provided, merge and deduplicate ("bake") the APIs contained in the <see cref="SourceSubdirectory"/> into
        /// this root with any other profiles being baked into this root.
        /// </summary>
        public string? BakedOutputSubdirectory { get; init; }
    }

    class Rewriter(
        string? jobKey,
        IEnumerable<
            IApiMetadataProvider<IEnumerable<SupportedApiProfileAttribute>>
        > versionProviders,
        Dictionary<string, UsingDirectiveSyntax> aggregatedUsings,
        Configuration cfg
    ) : ModCSharpSyntaxRewriter
    {
        public ApiProfileDecl? Profile { get; set; }

        public ILogger? Logger { get; set; }

        private SupportedApiProfileAttribute GetVersionInfo(
            string? parentSymbol = null,
            string? childSymbol = null
        )
        {
            Debug.Assert(Profile is not null);
            if (parentSymbol is null)
            {
                return Profile;
            }

            SupportedApiProfileAttribute? parent = null;
            foreach (var apimd in versionProviders)
            {
                if (
                    childSymbol is not null
                    && apimd.TryGetChildSymbolMetadata(
                        jobKey,
                        parentSymbol,
                        childSymbol,
                        out var vers
                    )
                    && vers.FirstOrDefault(x => x.Profile == Profile.Profile) is { } ver
                )
                {
                    return ver;
                }

                if (
                    apimd.TryGetSymbolMetadata(jobKey, parentSymbol, out var parentVers)
                    && (
                        parent =
                            parentVers.FirstOrDefault(x => x.Profile == Profile.Profile) ?? parent
                    )
                        is not null
                    && childSymbol is null
                )
                {
                    break;
                }
            }

            return parent ?? Profile;
        }

        private string? _currentParentSymbol;

        private AttributeSyntax GetProfileAttribute(string? childSymbol) =>
            GetVersionInfo(_currentParentSymbol, childSymbol).GetSupportedApiProfileAttribute();

        // Allowable type members for baking (we need to override these):
        // - [x] FieldDeclarationSyntax (VariableDeclarator)
        // - [x] EventFieldDeclarationSyntax
        // - [x] EventDeclarationSyntax
        // - [x] IndexerDeclarationSyntax
        // - [x] PropertyDeclarationSyntax
        // - [x] DelegateDeclarationSyntax
        // - [x] BaseMethodDeclarationSyntax:
        //     - [x] ConstructorDeclarationSyntax
        //     - [x] ConversionOperatorDeclarationSyntax
        //     - [x] DestructorDeclarationSyntax
        //     - [x] MethodDeclarationSyntax
        //     - [x] OperatorDeclarationSyntax
        // - [x] EnumMemberDeclarationSyntax
        //
        // Additional allowed members (done for free by GetOrRegisterTypeBakeSet)
        // - [x] StructDeclarationSyntax
        // - [x] ClassDeclarationSyntax
        // - [x] EnumDeclarationSyntax
        // - [x] RecordDeclarationSyntax
        // - [x] InterfaceDeclarationSyntax

        public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            Visit(
                node,
                node.Identifier.ToString(),
                node.Identifier
                    + (
                        node is { TypeParameterList.Parameters.Count: > 0 and var cnt }
                            ? $"`{cnt}"
                            : string.Empty
                    ),
                base.VisitDelegateDeclaration
            );

        public override SyntaxNode? VisitEventDeclaration(EventDeclarationSyntax node) =>
            Visit(
                node,
                node.Identifier.ToString(),
                node.Identifier.ToString(),
                base.VisitEventDeclaration
            );

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            Visit(
                node,
                node.Identifier.ToString(),
                node.Identifier.ToString(),
                base.VisitPropertyDeclaration
            );

        public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            Visit(
                node,
                node.Identifier.ToString(),
                node.Identifier.ToString(),
                base.VisitEnumMemberDeclaration
            );

        public override SyntaxNode? VisitIndexerDeclaration(IndexerDeclarationSyntax node) =>
            Visit(
                node,
                null,
                $"this[{string.Join(", ", node.ParameterList.Parameters.Select(ModUtils.DiscrimStr))}]",
                base.VisitIndexerDeclaration
            );

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node) =>
            VisitField(node, base.VisitFieldDeclaration);

        public override SyntaxNode? VisitEventFieldDeclaration(EventFieldDeclarationSyntax node) =>
            VisitField(node, base.VisitEventFieldDeclaration);

        public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node) =>
            node.FirstAncestorOrSelf<BaseFieldDeclarationSyntax>() is { } baseFld
            && node.FirstAncestorOrSelf<VariableDeclarationSyntax>() is { } varDecl
                ? Visit(
                    // We want to add just this one specific individual standalone field.
                    baseFld.WithDeclaration(varDecl.WithVariables(SingletonSeparatedList(node))),
                    // But we're visiting the inner declarator representing that field.
                    node,
                    // So we discriminate using the identifier of the field's declarator (which should be guaranteed to
                    // be unique as you can't have differing fields with the same name)
                    node.Identifier.ToString(),
                    node.Identifier.ToString(),
                    // And if for whatever reason we can't continue on with the baking logic, we carry on to the base
                    // inner declarator visitation logic as usual.
                    base.VisitVariableDeclarator
                )
                : base.VisitVariableDeclarator(node);

        public override SyntaxNode? VisitConstructorDeclaration(
            ConstructorDeclarationSyntax node
        ) =>
            Visit(
                node,
                null,
                ModUtils.DiscrimStr(node.Modifiers, null, string.Empty, node.ParameterList, null),
                base.VisitConstructorDeclaration
            );

        public override SyntaxNode? VisitDestructorDeclaration(DestructorDeclarationSyntax node) =>
            Visit(node, null, "~", base.VisitDestructorDeclaration);

        public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax node) =>
            Visit(
                node,
                null,
                ModUtils.DiscrimStr(
                    node.Modifiers,
                    null,
                    $"op_{node.OperatorToken.Kind()}",
                    node.ParameterList,
                    node.ReturnType
                ),
                base.VisitOperatorDeclaration
            );

        public override SyntaxNode? VisitConversionOperatorDeclaration(
            ConversionOperatorDeclarationSyntax node
        ) =>
            Visit(
                node,
                null,
                ModUtils.DiscrimStr(
                    node.Modifiers,
                    null,
                    $"op_{node.ImplicitOrExplicitKeyword.Kind()}",
                    node.ParameterList,
                    node.Type
                ),
                base.VisitConversionOperatorDeclaration
            );

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node) =>
            Visit(
                node,
                node.Identifier.ToString(),
                ModUtils.DiscrimStr(
                    node.Modifiers,
                    node.TypeParameterList,
                    node.Identifier.ToString(),
                    node.ParameterList,
                    node.ReturnType
                ),
                base.VisitMethodDeclaration
            );

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

        private SyntaxNode? VisitField<T>(T node, Func<T, SyntaxNode?> @base)
            where T : BaseFieldDeclarationSyntax
        {
            var retNode = @base(node);
            if (Profile is not null && retNode is T ret)
            {
                // When we're in baking mode, all of the baking logic is done in VisitVariableDeclarator. However this
                // does nothing in the non-baking case, where we should add the attribute to the field as a marker.
                return ret.AddAttributeLists(
                    AttributeList(
                        SingletonSeparatedList(
                            GetProfileAttribute(
                                ret.Declaration.Variables.Count == 1
                                    ? ret.Declaration.Variables[0].Identifier.ToString()
                                    : null
                            )
                        )
                    )
                );
            }

            return retNode;
        }

        private SyntaxNode? VisitType<T>(T node, Func<T, SyntaxNode?> @base)
            where T : BaseTypeDeclarationSyntax
        {
            var parentSymbolBefore = _currentParentSymbol;
            _currentParentSymbol = parentSymbolBefore is not null
                ? $"{_currentParentSymbol}.{node.Identifier}"
                : node.Identifier.ToString();
            var retNode = @base(node);
            _currentParentSymbol = parentSymbolBefore;
            if (Profile is null)
            {
                return retNode;
            }

            return retNode is T ret
                    ? ret.AddAttributeLists(
                        AttributeList(SingletonSeparatedList(GetProfileAttribute(null)))
                    )
                    : retNode;
        }

        private SyntaxNode? Visit<T>(
            T node,
            string? name,
            string discrim,
            Func<T, SyntaxNode?> @base
        )
            where T : MemberDeclarationSyntax => Visit(node, node, name, discrim, @base);

        // This is super convoluted but to deduplicate the member handling code for fields (wherein one field decl may
        // have many declarators of logically independent fields) we separate nodeToAdd vs nodeVisiting. Most of the
        // time these will be the same, but for fields we will be wanting to add a field representing that one
        // individual field whereas we're actually visiting the declarator for that individual field (because if we
        // tried to add the field decl as nodeVisiting directly we'd be adding 3 fields in one)
        private SyntaxNode? Visit<TSeparated, TVisiting>(
            TSeparated nodeToAdd,
            TVisiting nodeVisiting,
            string? name,
            string discrim,
            Func<TVisiting, SyntaxNode?> @base
        )
            where TSeparated : MemberDeclarationSyntax
            where TVisiting : SyntaxNode
        {
            // First, call the base visitor logic.
            var retNode = @base(nodeVisiting);

            // If we have no profile to get information pertaining to the current profile (why are we even here?)
            if (Profile is null)
            {
                // early out, we can't do anything
                return retNode;
            }

            // If we didn't get an inner node when we're not in baking mode, return now as this is bad.
            // Also, we can only add attributes for TSeparated, not the inner TVisiting, so we also return now if we
            // want to add an attribute. This is super convoluted I know. The onus is on the caller to add the
            // attribute in this case.
            if (retNode is not (TSeparated ret and TVisiting))
            {
                // expected to at least be TVisiting, but we can only add if it's TSeparated. If it's not at least
                // TVisiting, it is likely null. In either case this does what we want.
                return retNode;
            }

            // Add the attribute if this is the node we are visiting.
            return ret.AddAttributeLists(
                AttributeList(SingletonSeparatedList(GetProfileAttribute(name)))
            );
        }

        public override bool ShouldSkipFile(string fileName)
        {
            if (!fileName.StartsWith("sources/"))
            {
                return true;
            }

            Profile = cfg
                .Profiles?.Where(x =>
                    fileName[8..].StartsWith(x.SourceSubdirectory, StringComparison.OrdinalIgnoreCase)
                )
                .MaxBy(x => x.SourceSubdirectory.Length);
            if (Profile is null)
            {
                return true;
            }
            return false;
        }

        public override void OnFileStarted(string fileName)
        {
            Logger?.LogDebug("Identified profile {} for {}", Profile, fileName);
        }

        public override void OnFileFinished(string fileName)
        {
            foreach (var (k, v) in UsingsToAdd)
            {
                aggregatedUsings.TryAdd(k, v);
            }
            UsingsToAdd.Clear();
            Profile = null;
        }
    }

    class BakeSet
    {
        public Dictionary<
            string,
            (MemberDeclarationSyntax Syntax, BakeSet? Inner, int Index)
        > Children { get; } = new();
    }

    /// <inheritdoc />
    public override Task<SyntaxContext> AfterScrapeAsync(string key, SyntaxContext context)
    {
        var cfg = config.Get(key);
        var aggregatedUsings = new Dictionary<string, UsingDirectiveSyntax>();
        var rewriter = new Rewriter(key, versionProviders.Get(key).ToArray(), aggregatedUsings, cfg) { Logger = logger };

        context.Rewrite(rewriter);

        return Task.FromResult(context);
    }
}
