using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SilkTouchX.Clang;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace SilkTouchX.Mods;

/// <summary>
/// Adds SupportedApiProfile attributes to APIs in given source roots, optionally merging APIs into a single source set.
/// </summary>
/// <param name="logger">The logger to use.</param>
/// <param name="config">The configuration snapshot.</param>
[ModConfiguration<Configuration>]
public class AddApiProfiles(
    ILogger<AddApiProfiles> logger,
    IOptionsSnapshot<AddApiProfiles.Configuration> config
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
    public record ApiProfileDecl
    {
        /// <summary>
        /// APIs declared in this relative source root are part of this profile.
        /// </summary>
        public required string SourceSubdirectory { get; init; }

        /// <summary>
        /// The name of the API profile.
        /// </summary>
        public required string Name { get; init; }

        /// <summary>
        /// The extension that this specific profile declaration represents.
        /// </summary>
        public string? Extension { get; init; }

        /// <summary>
        /// The minimum version that this specific profile declaration represents.
        /// </summary>
        public string? MinVersion { get; init; }

        /// <summary>
        /// The minimum version that this specific profile declaration rpresents.
        /// </summary>
        public string? MaxVersion { get; init; }

        /// <summary>
        /// If provided, merge and deduplicate ("bake") the APIs contained in the <see cref="SourceSubdirectory"/> into
        /// this root with any other profiles being baked into this root.
        /// </summary>
        public string? BakedOutputSubdirectory { get; init; }

        internal IEnumerable<AttributeArgumentSyntax> GetSupportedApiProfileAttributeArgs()
        {
            yield return AttributeArgument(
                LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(Name))
            );

            if (Extension is not null)
            {
                yield return AttributeArgument(
                    NameEquals(nameof(Extension)),
                    null,
                    LiteralExpression(SyntaxKind.StringLiteralExpression, Literal(Extension))
                );
            }

            if (MinVersion is not null)
            {
                yield return AttributeArgument(
                    NameEquals(nameof(MinVersion)),
                    null,
                    LiteralExpression(
                        SyntaxKind.StringLiteralExpression,
                        Literal(MinVersion.ToString())
                    )
                );
            }

            if (MaxVersion is not null)
            {
                yield return AttributeArgument(
                    NameEquals(nameof(MaxVersion)),
                    null,
                    LiteralExpression(
                        SyntaxKind.StringLiteralExpression,
                        Literal(MaxVersion.ToString())
                    )
                );
            }
        }

        internal AttributeSyntax GetSupportedApiProfileAttribute() =>
            Attribute(
                IdentifierName("SupportedApiProfile"),
                AttributeArgumentList(SeparatedList(GetSupportedApiProfileAttributeArgs()))
            );
    }

    class Rewriter : ModCSharpSyntaxRewriter
    {
        public BakeSet? Baked { get; set; }

        public ApiProfileDecl? Profile { get; set; }

        public ILogger? Logger { get; set; }

        public Dictionary<string, UsingDirectiveSyntax> Usings { get; } = new();

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

        public override SyntaxNode? VisitUsingDirective(UsingDirectiveSyntax node)
        {
            Usings[node.ToString()] = node;
            return base.VisitUsingDirective(node);
        }

        public override SyntaxNode? VisitDelegateDeclaration(DelegateDeclarationSyntax node) =>
            Visit(
                node,
                node.Identifier
                    + (
                        node is { TypeParameterList.Parameters.Count: > 0 and var cnt }
                            ? $"`{cnt}"
                            : string.Empty
                    ),
                base.VisitDelegateDeclaration
            );

        public override SyntaxNode? VisitEventDeclaration(EventDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitEventDeclaration);

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitPropertyDeclaration);

        public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node) =>
            Visit(node, node.Identifier.ToString(), base.VisitEnumMemberDeclaration);

        public override SyntaxNode? VisitIndexerDeclaration(IndexerDeclarationSyntax node) =>
            Visit(
                node,
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
                ModUtils.DiscrimStr(node.Modifiers, null, string.Empty, node.ParameterList, null),
                base.VisitConstructorDeclaration
            );

        public override SyntaxNode? VisitDestructorDeclaration(DestructorDeclarationSyntax node) =>
            Visit(node, "~", base.VisitDestructorDeclaration);

        public override SyntaxNode? VisitOperatorDeclaration(OperatorDeclarationSyntax node) =>
            Visit(
                node,
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
            if (Baked is null && Profile is not null && retNode is T ret)
            {
                // When we're in baking mode, all of the baking logic is done in VisitVariableDeclarator. However this
                // does nothing in the non-baking case, where we should add the attribute to the field as a marker.
                return ret.AddAttributeLists(
                    AttributeList(SingletonSeparatedList(Profile.GetSupportedApiProfileAttribute()))
                );
            }

            return retNode;
        }

        private SyntaxNode? VisitType<T>(T node, Func<T, SyntaxNode?> @base)
            where T : BaseTypeDeclarationSyntax
        {
            var retNode = @base(node);
            if (Profile is null)
            {
                return retNode;
            }

            if (Baked is null)
            {
                return retNode is T ret
                    ? ret.AddAttributeLists(
                        AttributeList(
                            SingletonSeparatedList(Profile.GetSupportedApiProfileAttribute())
                        )
                    )
                    : retNode;
            }

            // Get this type's bake set for some final validation checks.
            // This also registers the bake set if the type had no members.
            var bakeSet = GetOrRegisterTypeBakeSet(node);

            // If this is a struct or record struct, fields should exactly match.
            if (
                (
                    node is StructDeclarationSyntax s
                        ? (SyntaxList<MemberDeclarationSyntax>?)s.Members
                        : node is RecordDeclarationSyntax r
                        && r.Modifiers.Any(SyntaxKind.StructKeyword)
                            ? r.Members
                            : null
                )
                is not { } members
            )
            {
                // If it's not a struct or record struct, we've registered the type and that's all we really need to do.
                // Any members will have been registered in the base call.
                return null; // baking erases, but the caller should know that.
            }

            var bakedFields = bakeSet.Children
                .OrderBy(x => x.Value.Index)
                .Select(x => x.Value.Syntax)
                .OfType<FieldDeclarationSyntax>()
                .SelectMany(x => x.Declaration.Variables.Select(y => (x.Declaration.Type, Var: y)))
                .ToArray();
            var ourFields = members
                .OfType<FieldDeclarationSyntax>()
                .SelectMany(x => x.Declaration.Variables.Select(y => (x.Declaration.Type, Var: y)))
                .ToArray();
            if (bakedFields.Length != ourFields.Length)
            {
                throw new InvalidOperationException(
                    $"Differing number of fields between definitions of {node.Identifier} ({bakedFields.Length} vs "
                        + $"{ourFields.Length})"
                );
            }

            for (var i = 0; i < bakedFields.Length; i++)
            {
                if (
                    bakedFields[i].Type.ToString() != ourFields[i].Type.ToString()
                    || bakedFields[i].Var.Identifier.ToString()
                        != ourFields[i].Var.Identifier.ToString()
                    || bakedFields[i].Var.Initializer?.ToString()
                        != ourFields[i].Var.Initializer?.ToString()
                    || bakedFields[i].Var.ArgumentList?.ToString()
                        != ourFields[i].Var.ArgumentList?.ToString()
                )
                {
                    throw new InvalidOperationException(
                        $"Field {i} differs between definitions of {node.Identifier}. "
                            + $"Left: {bakedFields[i]}, right: {ourFields[i]}"
                    );
                }
            }

            return null; // baking erases, but the caller should know that.
        }

        private SyntaxNode? Visit<T>(T node, string discrim, Func<T, SyntaxNode?> @base)
            where T : MemberDeclarationSyntax => Visit(node, node, discrim, @base);

        // This is super convoluted but to deduplicate the member handling code for fields (wherein one field decl may
        // have many declarators of logically independent fields) we separate nodeToAdd vs nodeVisiting. Most of the
        // time these will be the same, but for fields we will be wanting to add a field representing that one
        // individual field whereas we're actually visiting the declarator for that individual field (because if we
        // tried to add the field decl as nodeVisiting directly we'd be adding 3 fields in one)
        private SyntaxNode? Visit<TSeparated, TVisiting>(
            TSeparated nodeToAdd,
            TVisiting nodeVisiting,
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

            // If we're not in baking mode...
            if (Baked is null)
            {
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
                    AttributeList(SingletonSeparatedList(Profile.GetSupportedApiProfileAttribute()))
                );
            }

            Logger?.LogTrace(
                "Baking item for \"{}\" with discriminator \"{}\": {}",
                Profile.Name,
                discrim,
                nodeToAdd
            );
            var parent = GetOrRegisterAncestorBakeSet(nodeVisiting);

            // Have we seen the member before?
            if (parent.Children.TryGetValue(discrim, out var baked))
            {
                // Make sure it's the same concrete type
                if (baked.Syntax.GetType() != nodeToAdd.GetType())
                {
                    throw new InvalidOperationException(
                        $"The existing definition for \"{discrim}\" is a {baked.Syntax.GetType()} whereas this "
                            + $"definition is a {nodeToAdd.GetType()}. Left: {baked.Syntax}, right: {nodeToAdd}"
                    );
                }

                // Boldly assume it's the same implementation, modifiers, etc
                // TODO ^^^ is this okay? should be fine if we're getting DllImports as inputs.

                // Okay fine here's some extra handling just in case it's a partial:
                var bakedNode = (TSeparated)baked.Syntax;
                if (
                    nodeToAdd is BaseMethodDeclarationSyntax meth
                    && bakedNode is BaseMethodDeclarationSyntax bakedMeth
                    && baked.Syntax.Modifiers.Any(SyntaxKind.PartialKeyword)
                    && nodeToAdd.Modifiers.Any(SyntaxKind.PartialKeyword)
                )
                {
                    var precedence = false;
                    if (bakedMeth.Body is null && meth.Body is not null)
                    {
                        if (bakedMeth.ExpressionBody is not null)
                        {
                            throw new InvalidOperationException(
                                $"The existing definition for \"{discrim}\" provides an expression body whereas this "
                                    + "definition provides a statement body"
                            );
                        }

                        // Our definition takes precedence
                        precedence = true;
                    }

                    if (bakedMeth.ExpressionBody is null && meth.ExpressionBody is not null)
                    {
                        if (bakedMeth.Body is not null)
                        {
                            throw new InvalidOperationException(
                                $"The existing definition for \"{discrim}\" provides an expression body whereas this "
                                    + "definition provides a statement body"
                            );
                        }

                        if (precedence)
                        {
                            throw new InvalidOperationException(
                                $"This definition for \"{discrim}\" provides both an expression and a statement body."
                            );
                        }

                        // Our definition takes precedence
                        precedence = true;
                    }

                    if (precedence)
                    {
                        baked.Syntax = nodeToAdd.AddAttributeLists(
                            baked.Syntax.AttributeLists
                                .Select(
                                    x =>
                                        x.WithAttributes(
                                            SeparatedList(
                                                x.Attributes.Where(
                                                    y =>
                                                        y.IsAttribute(
                                                            "Silk.NET.Core.SupportedApiAttribute"
                                                        )
                                                )
                                            )
                                        )
                                )
                                .Where(x => x.Attributes.Count > 0)
                                .ToArray()
                        );
                    }
                }

                // Check that constants and enums have the same value
                if (
                    (baked.Syntax, nodeToAdd) is

                    (EnumMemberDeclarationSyntax lEnum, EnumMemberDeclarationSyntax rEnum)
                )
                {
                    if (lEnum.EqualsValue?.Value.ToString() != rEnum.EqualsValue?.Value.ToString())
                    {
                        Logger?.LogWarning(
                            "Enum member with discriminator \"{}\" differs between definitions. Left: {}, right: {}",
                            discrim,
                            lEnum.EqualsValue?.Value.ToString() ?? "auto-assigned",
                            rEnum.EqualsValue?.Value.ToString() ?? "auto-assigned"
                        );
                    }
                }
                else if (
                    (baked.Syntax, nodeToAdd) is

                    (FieldDeclarationSyntax lConst, FieldDeclarationSyntax rConst)
                )
                {
                    var isConst = lConst.Modifiers.Any(SyntaxKind.ConstKeyword);
                    if (isConst != rConst.Modifiers.Any(SyntaxKind.ConstKeyword))
                    {
                        Logger?.LogWarning(
                            "Const with discriminator \"{}\" isn't const in its redefinition. Left: {}, right: {}",
                            discrim,
                            lConst.ToString(),
                            rConst.ToString()
                        );
                    }
                    else if (
                        isConst
                        && lConst.Declaration.Variables[0].Initializer?.Value.ToString()
                            != rConst.Declaration.Variables[0].Initializer?.Value.ToString()
                    )
                    {
                        Logger?.LogWarning(
                            "Const value with discriminator \"{}\" differs between definitions. Left: {}, right: {}",
                            discrim,
                            lConst.Declaration.Variables[0].Initializer?.Value.ToString(),
                            rConst.Declaration.Variables[0].Initializer?.Value.ToString()
                        );
                    }
                }
            }

            // Update the bake set. This adds if we haven't seen the member before, otherwise we just update the
            // existing declaration by adding our attribute list.
            parent.Children[discrim] = (
                (baked.Syntax ?? nodeToAdd).AddAttributeLists(
                    AttributeList(SingletonSeparatedList(Profile.GetSupportedApiProfileAttribute()))
                ),
                null,
                baked.Syntax is null ? parent.Children.Count : baked.Index
            );

            return null; // erase it, but the caller should know to do that anyway.
        }

        private BakeSet GetOrRegisterAncestorBakeSet(SyntaxNode node) =>
            node.Parent is null
                ? Baked ?? throw new InvalidOperationException("BakeSet not set")
                : GetOrRegisterTypeBakeSet(node.Parent);

        private BakeSet GetOrRegisterTypeBakeSet(SyntaxNode node)
        {
            var nsPre = node.NamespaceFromSyntaxNode() is { Length: > 0 } ns
                ? $"{ns}."
                : string.Empty;
            var bakeSet = Baked ?? throw new InvalidOperationException("BakeSet not set");

            // To handle nested types, we go through each ancestor (starting from the top, hence the reverse) and get
            // the bake set (or create if needed), and do this for each ancestor until we finally get to the containing
            // type of the given node.
            foreach (
                var decl in node.AncestorsAndSelf().OfType<BaseTypeDeclarationSyntax>().Reverse()
            )
            {
                var discrim = $"{nsPre}{decl.Identifier}";
                if (
                    decl is TypeDeclarationSyntax
                    {
                        TypeParameterList.Parameters.Count: > 0 and var cnt
                    }
                )
                {
                    discrim += $"`{cnt}";
                }
                nsPre = string.Empty; // only the top-level type shall be prefixed with the namespace
                bakeSet = (
                    bakeSet!.Children.TryGetValue(discrim, out var baked)
                        ? bakeSet.Children[discrim] = (
                            MergeDecls(
                                WithProfile(StripBare(decl), Profile),
                                (BaseTypeDeclarationSyntax)baked.Syntax
                            ),
                            baked.Inner ?? new BakeSet(),
                            baked.Index
                        )
                        : bakeSet.Children[discrim] = (
                            WithProfile(StripBare(decl), Profile),
                            new BakeSet(),
                            bakeSet.Children.Count
                        )
                ).Inner;
            }

            return bakeSet!;
            static BaseTypeDeclarationSyntax StripBare(BaseTypeDeclarationSyntax node) =>
                node switch
                {
                    // TODO do we need to strip more than this for dedupe purposes?
                    TypeDeclarationSyntax klass => klass.WithMembers(default),
                    EnumDeclarationSyntax enumeration => enumeration.WithMembers(default),
                    _ => node
                };

            static BaseTypeDeclarationSyntax MergeDecls(
                BaseTypeDeclarationSyntax node1,
                BaseTypeDeclarationSyntax node2
            )
            {
                if (node1.GetType() != node2.GetType())
                {
                    throw new ArgumentException(
                        "Node types differed - the profiles may contain two types with the "
                            + "same name but with a different datatype (i.e. profile 1 contains a "
                            + $"{node1.Kind().Humanize()} whereas profile 2 contains a {node2.Kind().Humanize()})"
                    );
                }
                return node1
                    .WithModifiers(
                        TokenList(
                            node2.Modifiers.Concat(node2.Modifiers).DistinctBy(x => x.ToString())
                        )
                    )
                    .WithBaseList(
                        node1.BaseList?.WithTypes(
                            SeparatedList(
                                node1.BaseList.Types
                                    .Concat(
                                        node2.BaseList?.Types ?? Enumerable.Empty<BaseTypeSyntax>()
                                    )
                                    .DistinctBy(x => x.ToString())
                            )
                        )
                    )
                    .WithAttributeLists(
                        List(
                            node1.AttributeLists
                                .SelectMany(
                                    x =>
                                        x.Attributes.Select(
                                            y => x.WithAttributes(SingletonSeparatedList(y))
                                        )
                                )
                                .Concat(
                                    node2.AttributeLists.SelectMany(
                                        x =>
                                            x.Attributes.Select(
                                                y => x.WithAttributes(SingletonSeparatedList(y))
                                            )
                                    )
                                )
                                .DistinctBy(x => x.ToString())
                        )
                    );
            }

            static BaseTypeDeclarationSyntax WithProfile(
                BaseTypeDeclarationSyntax decl,
                ApiProfileDecl? profile
            ) =>
                profile is null
                    ? decl
                    : decl.AddAttributeLists(
                        AttributeList(
                            SingletonSeparatedList(profile.GetSupportedApiProfileAttribute())
                        )
                    );
        }
    }

    class BakeSet
    {
        public Dictionary<
            string,
            (MemberDeclarationSyntax Syntax, BakeSet? Inner, int Index)
        > Children { get; } = new();
    }

    /// <summary>
    /// A map of baked roots to deduplicated <see cref="MemberDeclarationSyntax"/>es and their associated discriminants.
    /// </summary>
    private Dictionary<string, BakeSet> _baked = new();

    /// <inheritdoc />
    public override Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var cfg = config.Get(key);
        var rewriter = new Rewriter { Logger = logger };
        var bakery = new Dictionary<string, BakeSet>();
        var baked = new List<string>();
        foreach (var (path, root) in syntax.Files)
        {
            if (!path.StartsWith("sources/"))
            {
                continue;
            }

            rewriter.Profile = cfg.Profiles
                ?.Where(
                    x =>
                        path[8..].StartsWith(
                            x.SourceSubdirectory,
                            StringComparison.OrdinalIgnoreCase
                        )
                )
                .MaxBy(x => x.SourceSubdirectory.Length);
            if (rewriter.Profile is null)
            {
                continue;
            }

            logger.LogDebug("Identified profile {} for {}", rewriter.Profile, path);
            if (rewriter.Profile.BakedOutputSubdirectory is not null)
            {
                var discrim = $"sources/{rewriter.Profile.BakedOutputSubdirectory.Trim('/')}";
                if (!bakery.TryGetValue(discrim, out var bakeSet))
                {
                    bakeSet = bakery[discrim] = new BakeSet();
                }

                rewriter.Baked = bakeSet;
                baked.Add(path);
            }

            syntax.Files[path] = rewriter.Visit(root);
            rewriter.Baked = null;
            rewriter.Profile = null;
        }

        foreach (var path in baked)
        {
            syntax.Files.Remove(path);
        }

        foreach (var (subdir, bakeSet) in bakery)
        {
            foreach (var (fqTopLevelType, bakedMember) in bakeSet.Children)
            {
                var (iden, bakedSyntax) = Bake(bakedMember);
                if (iden is null)
                {
                    throw new InvalidOperationException(
                        "Cannot output an unidentified syntax. Top-level syntax should be type declarations only."
                    );
                }

                var ns = fqTopLevelType.LastIndexOf('.') is not -1 and var idx
                    ? fqTopLevelType[..idx]
                    : null;
                syntax.Files[$"{subdir}/{PathForFullyQualified(fqTopLevelType)}"] =
                    CompilationUnit()
                        .WithMembers(
                            ns is null
                                ? SingletonList(bakedSyntax)
                                : SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(ns)
                                        )
                                        .WithMembers(SingletonList(bakedSyntax))
                                        .WithUsings(List(rewriter.Usings.Values))
                                )
                        )
                        .WithUsings(ns is null ? List(rewriter.Usings.Values) : default);
            }
        }

        return Task.FromResult(syntax);
    }

    private static (string? Identifier, MemberDeclarationSyntax Syntax) Bake(
        (MemberDeclarationSyntax Syntax, BakeSet? Inner, int Index) member
    ) =>
        member.Syntax switch
        {
            TypeDeclarationSyntax ty
                => (
                    ty.Identifier
                        + (
                            ty.TypeParameterList is { Parameters.Count: > 0 and var cnt }
                                ? $"`{cnt}"
                                : string.Empty
                        ),
                    ty.WithMembers(
                        List(
                            ty.Members.Concat(
                                member.Inner?.Children.Values
                                    .OrderBy(x => x.Index)
                                    .Select(x => Bake(x).Syntax)
                                    ?? Enumerable.Empty<MemberDeclarationSyntax>()
                            )
                        )
                    )
                ),
            EnumDeclarationSyntax enumDecl
                => (
                    enumDecl.Identifier.ToString(),
                    enumDecl.WithMembers(
                        SeparatedList(
                            enumDecl.Members.Concat(
                                member.Inner?.Children.Values
                                    .OrderBy(x => x.Index)
                                    .Select(x => x.Syntax)
                                    .OfType<EnumMemberDeclarationSyntax>()
                                    ?? Enumerable.Empty<EnumMemberDeclarationSyntax>()
                            )
                        )
                    )
                ),
            DelegateDeclarationSyntax del
                => (
                    del.Identifier
                        + (
                            del.TypeParameterList is { Parameters.Count: > 0 and var cnt }
                                ? $"`{cnt}"
                                : string.Empty
                        ),
                    del
                ),
            var x => (null, x)
        };
}
