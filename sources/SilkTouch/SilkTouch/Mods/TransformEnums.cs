using System.Diagnostics;
using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Contains various transformations related to enums.
/// </summary>
[ModConfiguration<Configuration>]
public class TransformEnums(IOptionsSnapshot<TransformEnums.Configuration> cfg) : IMod
{
    /// <summary>
    /// TransformEnums mod configuration.
    /// </summary>
    public record Configuration
    {
        /// <summary>
        /// Transforms [Flags] enums to have a "None = 0" member if they do not already have an equivalent.
        /// </summary>
        public bool AddNoneMemberToFlags { get; init; } = false;

        /// <summary>
        /// Removes enum members that match the enum member filter.
        /// </summary>
        /// <remarks>
        /// This was originally designed to remove max enum value members.
        /// </remarks>
        public EnumMemberFilterConfiguration[] RemoveMembers { get; init; } = [];
    }

    /// <summary>
    /// Represents a filter used to match enum members.
    /// </summary>
    public record EnumMemberFilterConfiguration
    {
        /// <summary>
        /// The enum type name must match this regex.
        /// </summary>
        public string TypeName { get; init; } = ".*";

        /// <summary>
        /// The enum member name must match this regex.
        /// </summary>
        public string MemberName { get; init; } = ".*";

        /// <summary>
        /// The enum member value must match this in value.
        /// This value will be parsed as an integer. Hexadecimal is allowed.
        /// Use null to disable this filter.
        /// </summary>
        public string? MemberValue { get; init; }
    }

    private class EnumMemberFilter
    {
        public Regex TypeName { get; }
        public Regex MemberName { get; }
        public long? MemberValue { get; }

        public EnumMemberFilter(EnumMemberFilterConfiguration configuration)
        {
            TypeName = new Regex(configuration.TypeName);
            MemberName = new Regex(configuration.MemberName);

            if (configuration.MemberValue != null)
            {
                if (configuration.MemberValue.StartsWith("0x"))
                {
                    MemberValue = long.Parse(configuration.MemberValue["0x".Length..], NumberStyles.AllowHexSpecifier);
                }
                else
                {
                    MemberValue = long.Parse(configuration.MemberValue);
                }
            }
        }

        public bool IsTypeMatch(ITypeSymbol? enumType)
        {
            return enumType != null && TypeName.IsMatch(enumType.Name);
        }

        public bool IsMemberMatch(ISymbol? enumMember)
        {
            if (enumMember is not IFieldSymbol fieldSymbol)
            {
                return false;
            }

            if (!MemberName.IsMatch(enumMember.Name))
            {
                return false;
            }

            if (MemberValue == null)
            {
                // Filter is disabled
                return true;
            }

            if (fieldSymbol.ConstantValue == null)
            {
                // We don't know the constant value for sure
                // Return false as a default
                return false;
            }

            return Convert.ToInt64(fieldSymbol.ConstantValue) == MemberValue;
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var config = cfg.Get(ctx.JobKey);
        var removeMemberFilters = config.RemoveMembers.Select(c => new EnumMemberFilter(c)).ToList();

        var proj = ctx.SourceProject;
        if (proj == null)
        {
            return;
        }

        var compilation = await proj.GetCompilationAsync(ct);
        if (compilation == null)
        {
            return;
        }

        var rewriter = new Rewriter(config, removeMemberFilters, compilation);
        foreach (var docId in proj?.DocumentIds ?? [])
        {
            var doc = proj!.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private class Rewriter(Configuration config, List<EnumMemberFilter> removeMemberFilters, Compilation compilation) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            var semanticModel = compilation.GetSemanticModel(node.SyntaxTree);
            var symbol = semanticModel.GetDeclaredSymbol(node);
            if (symbol == null)
            {
                return base.VisitEnumDeclaration(node);
            }

            // This list is used to defer the modification of the enum declaration syntax node
            // This is important because modifying the node will detach it from the semantic model
            var members = node.Members.ToList();

            foreach (var filter in removeMemberFilters)
            {
                if (!filter.IsTypeMatch(symbol))
                {
                    continue;
                }

                members = members
                    .Where(member => !filter.IsMemberMatch(semanticModel.GetDeclaredSymbol(member)))
                    .ToList();
            }

            var isFlagsEnum = node.AttributeLists.SelectMany(list => list.Attributes)
                .Any(attribute => attribute.IsAttribute("System.Flags"));

            if (node.Identifier.ToString() == "ClusterAccelerationStructureAddressResolutionFlagsNV")
            {
                Debugger.Break();
            }

            if (isFlagsEnum && config.AddNoneMemberToFlags)
            {
                // Add None member if it doesn't exist yet
                var hasNoneMember = symbol.Members().Any(member =>
                {
                    if (member is not IFieldSymbol fieldSymbol)
                    {
                        return false;
                    }

                    if (member.Name == "None")
                    {
                        return true;
                    }

                    if (fieldSymbol.ConstantValue == null)
                    {
                        // We don't know the constant value for sure
                        // Return false as a default
                        return false;
                    }

                    return Convert.ToInt64(fieldSymbol.ConstantValue) == 0;
                });

                if (!hasNoneMember)
                {
                    var noneMember = EnumMemberDeclaration("None")
                        .WithEqualsValue(
                            EqualsValueClause(
                                LiteralExpression(SyntaxKind.NumericLiteralExpression, Literal(0))
                            )
                        );

                    members.Insert(0, noneMember);
                }
            }

            node = node.WithMembers([..members]);

            return base.VisitEnumDeclaration(node);
        }
    }
}