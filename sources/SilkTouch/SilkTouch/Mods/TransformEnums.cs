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
    /// The preferred backing type for enums.
    /// </summary>
    public enum EnumBackingTypePreference
    {
        /// <summary>
        /// Don't modify the backing type of enums.
        /// </summary>
        None = 0,

        /// <summary>
        /// Replace unsigned backing types with signed backing types.
        /// </summary>
        /// <remarks>
        /// This can be used to ensure that the backing types of enums generated on Unix
        /// match the backing types of enums generated on Windows.
        /// </remarks>
        PreferSigned,

        /// <summary>
        /// Replace unsigned backing types with signed backing types.
        /// </summary>
        /// <remarks>
        /// This can be used to ensure that the backing types of enums generated on Windows
        /// match the backing types of enums generated on Unix.
        /// </remarks>
        PreferUnsigned,
    }

    /// <summary>
    /// <see cref="TransformEnums"/> mod configuration.
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

        /// <summary>
        /// The strategy to use when coercing backing types.
        /// Defaults to not modify the backing types at all.
        /// </summary>
        public EnumBackingTypePreference CoerceBackingTypes { get; init; } = EnumBackingTypePreference.None;

        /// <summary>
        /// Whether to rewrite enum member values or not.
        /// Hexadecimal is used for [Flags] enums while decimal is used for normal enums.
        /// For example: <c>unchecked((ulong)0x00000001UL)</c> would be replaced with <c>0x1</c> in [Flags] enums.
        /// </summary>
        /// <remarks>
        /// This likely is required if <see cref="CoerceBackingTypes"/> is enabled.
        /// </remarks>
        public bool RewriteMemberValues { get; init; } = false;
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
            TypeName = new Regex(configuration.TypeName, RegexOptions.Compiled);
            MemberName = new Regex(configuration.MemberName, RegexOptions.Compiled);

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

        var memberRewriteDecider = new MemberRewriteDecider();
        var rewriter = new Rewriter(config, removeMemberFilters, compilation, memberRewriteDecider);
        foreach (var docId in proj.DocumentIds)
        {
            var doc = proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))?.NormalizeWhitespace()
                ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    private class Rewriter(Configuration config, List<EnumMemberFilter> removeMemberFilters, Compilation compilation, MemberRewriteDecider memberRewriteDecider) : CSharpSyntaxRewriter
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
            var originalNode = node;
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

            var isFlagsEnum = node.AttributeLists.ContainsAttribute("System.Flags");
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
                    var noneMember = EnumMemberDeclaration("None").WithEqualsValue(CreateEqualsValueClause(0, isFlagsEnum));
                    members.Insert(0, noneMember);
                }
            }

            // This code uses the semantic model for members so it has to run before the members are rewritten below
            switch (config.CoerceBackingTypes)
            {
                case EnumBackingTypePreference.PreferSigned:
                {
                    var baseList = originalNode.BaseList;
                    var baseTypes = (baseList?.Types ?? [])
                        .Select<BaseTypeSyntax, BaseTypeSyntax?>(t =>
                        {
                            var type = semanticModel.GetTypeInfo(t.Type).Type;

                            if (SymbolEqualityComparer.Default.Equals(type, compilation.GetSpecialType(SpecialType.System_UInt32)))
                            {
                                return null;
                            }

                            if (SymbolEqualityComparer.Default.Equals(type, compilation.GetSpecialType(SpecialType.System_UInt64)))
                            {
                                return SimpleBaseType(PredefinedType(Token(SyntaxKind.LongKeyword)));
                            }

                            return t;
                        })
                        .Where(x => x is not null)
                        .Cast<BaseTypeSyntax>()
                        .ToList();

                    if (baseTypes.Count == 0)
                    {
                        node = node.WithBaseList(null);
                    }
                    else
                    {
                        node = node.WithBaseList(BaseList([..baseTypes]));
                    }

                    break;
                }

                case EnumBackingTypePreference.PreferUnsigned:
                {
                    var hasNegativeValues = members.Any(m => {
                        if (m.Parent == null)
                        {
                            return false;
                        }

                        var fieldSymbol = semanticModel.GetDeclaredSymbol(m);
                        if (fieldSymbol == null)
                        {
                            return false;
                        }

                        var value = Convert.ToInt64(fieldSymbol.ConstantValue);
                        return value < 0;
                    });

                    if (hasNegativeValues)
                    {
                        // Enum has negative values, we can't use an unsigned backing type
                        break;
                    }

                    var baseList = originalNode.BaseList;
                    var baseTypes = (baseList?.Types ?? [])
                        .Select<BaseTypeSyntax, BaseTypeSyntax?>(t =>
                        {
                            var type = semanticModel.GetTypeInfo(t.Type).Type;

                            if (SymbolEqualityComparer.Default.Equals(type, compilation.GetSpecialType(SpecialType.System_Int32)))
                            {
                                return SimpleBaseType(PredefinedType(Token(SyntaxKind.UIntKeyword)));
                            }

                            if (SymbolEqualityComparer.Default.Equals(type, compilation.GetSpecialType(SpecialType.System_Int64)))
                            {
                                return SimpleBaseType(PredefinedType(Token(SyntaxKind.ULongKeyword)));
                            }

                            return t;
                        })
                        .Where(x => x is not null)
                        .Cast<BaseTypeSyntax>()
                        .ToList();

                    if (baseTypes.Count == 0)
                    {
                        node = node.WithBaseList(BaseList([SimpleBaseType(PredefinedType(Token(SyntaxKind.UIntKeyword)))]));
                    }
                    else
                    {
                        node = node.WithBaseList(BaseList([..baseTypes]));
                    }

                    break;
                }
            }

            if (config.RewriteMemberValues)
            {
                members = members
                    .Select(m =>
                    {
                        if (m.Parent == null)
                        {
                            return m;
                        }

                        if (m.EqualsValue != null)
                        {
                            memberRewriteDecider.Visit(m.EqualsValue);
                            if (!memberRewriteDecider.ShouldRewrite)
                            {
                                return m;
                            }
                        }

                        var fieldSymbol = semanticModel.GetDeclaredSymbol(m);
                        if (fieldSymbol == null)
                        {
                            return m;
                        }

                        if (fieldSymbol.ConstantValue == null)
                        {
                            return m;
                        }

                        var value = Convert.ToInt64(fieldSymbol.ConstantValue);
                        return m.WithEqualsValue(CreateEqualsValueClause(value, isFlagsEnum));
                    })
                    .ToList();
            }

            node = node.WithMembers([..members]);

            return base.VisitEnumDeclaration(node);
        }

        private EqualsValueClauseSyntax CreateEqualsValueClause(long value, bool useHex)
        {
            var stringValue = useHex ? $"0x{value:X}" : $"{value}";
            return EqualsValueClause(
                LiteralExpression(SyntaxKind.NumericLiteralExpression,
                    Literal([], stringValue, value, [])));
        }
    }

    private class MemberRewriteDecider : CSharpSyntaxWalker
    {
        /// <summary>
        /// Whether the enum member's value should be rewritten to be simpler.
        /// We default to rewriting the member value, but do not if the enum member contains important information.
        /// <para/>
        /// Currently, there is only 1 case.
        /// <para/>
        /// Case 1: References to enum members or constants. Eg: <c>NoneKHR = None</c> in Vulkan.
        /// We approximate this by checking for identifiers in the <see cref="EqualsValueClauseSyntax"/>.
        /// </summary>
        public bool ShouldRewrite { get; private set; }

        public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
        {
            ShouldRewrite = true;
            base.VisitEqualsValueClause(node);
        }

        public override void VisitIdentifierName(IdentifierNameSyntax node)
        {
            base.VisitIdentifierName(node);
            ShouldRewrite = false;
        }

        public override void VisitCastExpression(CastExpressionSyntax node)
        {
            // Ignore cast expressions
            // These contain identifiers, but these identifiers are references to types.
            //
            // Eg: DepthBufferBit = unchecked((uint)0x00000100)
            // uint is an identifier, but we want to rewrite this anyway
        }
    }
}
