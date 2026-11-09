// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Contains various transformations related to enums.
/// </summary>
public class TransformEnums(TransformEnums.Configuration config) : IMod
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
        public EnumBackingTypePreference CoerceBackingTypes { get; init; } =
            EnumBackingTypePreference.None;

        /// <summary>
        /// Whether to rewrite enum member values or not.
        /// Hexadecimal is used for [Flags] enums while decimal is used for normal enums.
        /// For example: <c>unchecked((ulong)0x00000001UL)</c> would be replaced with <c>0x1</c> in [Flags] enums.
        /// </summary>
        /// <remarks>
        /// This likely is required if <see cref="CoerceBackingTypes"/> is enabled.
        /// </remarks>
        public bool RewriteMemberValues { get; init; } = false;

        /// <summary>
        /// Whether to sort enum members by their value.
        /// </summary>
        public bool SortMembers { get; init; } = false;

        /// <summary>
        /// Whether to identify enum types that are likely to be [Flags] enums as [Flags] enums.
        /// </summary>
        public bool IdentifyFlags { get; init; } = false;
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
                    MemberValue = long.Parse(
                        configuration.MemberValue["0x".Length..],
                        NumberStyles.AllowHexSpecifier
                    );
                }
                else
                {
                    MemberValue = long.Parse(configuration.MemberValue);
                }
            }
        }

        public bool IsTypeMatch(ITypeSymbol? enumType) =>
            enumType != null && TypeName.IsMatch(enumType.Name);

        public bool IsMemberMatch(EnumMemberInfo member)
        {
            if (!MemberName.IsMatch(member.Node.Identifier.Text))
            {
                return false;
            }

            if (MemberValue == null)
            {
                // Filter is disabled
                return true;
            }

            if (member.Value == null)
            {
                // We don't know the constant value for sure
                // Return false as a default
                return false;
            }

            return member.Value == MemberValue;
        }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var removeMemberFilters = config
            .RemoveMembers.Select(c => new EnumMemberFilter(c))
            .ToList();

        var proj = ctx.SourceProject;
        var compilation = await proj.GetCompilationAsync(ct);
        if (compilation == null)
        {
            return;
        }

        var memberRewriteDecider = new MemberRewriteDecider();
        var rewriter = new Rewriter(config, removeMemberFilters, compilation, memberRewriteDecider);
        foreach (var docId in proj.DocumentIds)
        {
            var doc =
                proj.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            proj = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))
                    ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        ctx.SourceProject = proj;
    }

    /// <summary>
    /// Identifies whether an enum is probably a [Flags] enum based on its members.
    /// </summary>
    /// <remarks>
    /// Ported from Silk.NET 2.X BuildTools IsProbablyABitmask:
    /// https://github.com/dotnet/Silk.NET/blob/c87fc664cc5d15abd754997b0a9ad138470554c4/src/Core/Silk.NET.BuildTools/Common/Utilities.cs#L627
    /// </remarks>
    private static bool IsProbablyFlags(List<EnumMemberInfo> members)
    {
        var values = members.Where(m => m.Value != null).Select(m => m.Value!.Value).ToArray();
        var countWith1BitSet = values.Count(x => BitOperations.PopCount(unchecked((ulong)x)) == 1);
        return (
                // There is more than one member
                members.Count > 1
                &&
                // At least approx 50% of the members have only one bit set
                countWith1BitSet >= MathF.Floor(members.Count / 2f)
                &&
                // It's not sequential (1, 2, 3)
                !IsSeeminglySequential(values)
            )
            || (
                // Alternatively, all items that are not MaxValue or 0 have popcnt == 1
                // https://github.com/dotnet/Silk.NET/issues/2238
                values.Count(x => x is not 0 and not 0x7FFFFFFF) == countWith1BitSet
                &&
                // And there are more than two items with popcnt == 1
                countWith1BitSet > 2
            );
    }

    // Renamed from IsSequential as suggested by this comment:
    // https://discord.com/channels/521092042781229087/587346162802229298/1284528132807987212
    private static bool IsSeeminglySequential(long[] @enum)
    {
        const int maxMisses = 1;
        var misses = 0;
        for (var i = 0; i < @enum.Length; i++)
        {
            if (@enum[i] != i - misses && @enum[i] != i - misses + 1)
            {
                misses++;
            }

            if (misses > maxMisses)
            {
                return false;
            }
        }

        return true;
    }

    private class Rewriter(
        Configuration config,
        List<EnumMemberFilter> removeMemberFilters,
        Compilation compilation,
        MemberRewriteDecider memberRewriteDecider
    ) : CSharpSyntaxRewriter
    {
        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            var semanticModel = compilation.GetSemanticModel(node.SyntaxTree);
            var symbol = semanticModel.GetDeclaredSymbol(node);
            if (symbol == null)
            {
                return base.VisitEnumDeclaration(node);
            }

            var originalNode = node;
            var members = node
                .Members.Select(n =>
                {
                    var symbol = semanticModel.GetDeclaredSymbol(n);
                    long? value = symbol != null ? Convert.ToInt64(symbol.ConstantValue) : null;
                    return new EnumMemberInfo(n, symbol, value);
                })
                .ToList();

            foreach (var filter in removeMemberFilters)
            {
                if (!filter.IsTypeMatch(symbol))
                {
                    continue;
                }

                members.RemoveAll(m => filter.IsMemberMatch(m));
            }

            var isFlagsEnum = node.AttributeLists.ContainsAttribute("System.Flags");
            var addFlagsAttribute = false;
            if (!isFlagsEnum && config.IdentifyFlags && IsProbablyFlags(members))
            {
                isFlagsEnum = true;
                addFlagsAttribute = true;
            }

            if (isFlagsEnum && config.AddNoneMemberToFlags)
            {
                // Add None member if it doesn't exist yet
                var hasNoneMember = symbol
                    .Members()
                    .Any(member =>
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
                        .WithEqualsValue(CreateEqualsValueClause(0, isFlagsEnum));
                    members.Insert(0, new EnumMemberInfo(noneMember, null, 0));
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

                            if (
                                SymbolEqualityComparer.Default.Equals(
                                    type,
                                    compilation.GetSpecialType(SpecialType.System_UInt32)
                                )
                            )
                            {
                                return null;
                            }

                            if (
                                SymbolEqualityComparer.Default.Equals(
                                    type,
                                    compilation.GetSpecialType(SpecialType.System_UInt64)
                                )
                            )
                            {
                                return SimpleBaseType(
                                    PredefinedType(Token(SyntaxKind.LongKeyword))
                                );
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
                        node = node.WithBaseList(BaseList([.. baseTypes]));
                    }

                    break;
                }

                case EnumBackingTypePreference.PreferUnsigned:
                {
                    var hasNegativeValues = members.Any(m =>
                    {
                        if (m.Symbol == null)
                        {
                            return false;
                        }

                        var value = Convert.ToInt64(m.Symbol.ConstantValue);
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

                            if (
                                SymbolEqualityComparer.Default.Equals(
                                    type,
                                    compilation.GetSpecialType(SpecialType.System_Int32)
                                )
                            )
                            {
                                return SimpleBaseType(
                                    PredefinedType(Token(SyntaxKind.UIntKeyword))
                                );
                            }

                            if (
                                SymbolEqualityComparer.Default.Equals(
                                    type,
                                    compilation.GetSpecialType(SpecialType.System_Int64)
                                )
                            )
                            {
                                return SimpleBaseType(
                                    PredefinedType(Token(SyntaxKind.ULongKeyword))
                                );
                            }

                            return t;
                        })
                        .Where(x => x is not null)
                        .Cast<BaseTypeSyntax>()
                        .ToList();

                    if (baseTypes.Count == 0)
                    {
                        node = node.WithBaseList(
                            BaseList([
                                SimpleBaseType(PredefinedType(Token(SyntaxKind.UIntKeyword))),
                            ])
                        );
                    }
                    else
                    {
                        node = node.WithBaseList(BaseList([.. baseTypes]));
                    }

                    break;
                }
            }

            if (config.RewriteMemberValues)
            {
                members = members
                    .Select(m =>
                    {
                        if (m.Node.EqualsValue != null)
                        {
                            memberRewriteDecider.Visit(m.Node.EqualsValue);
                            if (!memberRewriteDecider.ShouldRewrite)
                            {
                                return m;
                            }
                        }

                        var value = m.Value;
                        if (value == null)
                        {
                            return m;
                        }

                        return m with
                        {
                            Node = m.Node.WithEqualsValue(
                                CreateEqualsValueClause(value.Value, isFlagsEnum)
                            ),
                        };
                    })
                    .ToList();
            }

            if (config.SortMembers)
            {
                members = members.OrderBy(m => m, new EnumMemberInfoValueComparer()).ToList();
            }

            node = node.WithMembers([.. members.Select(m => m.Node)]);

            if (addFlagsAttribute)
            {
                node = node.WithAttributeLists(node.AttributeLists.WithFlags());
            }

            return base.VisitEnumDeclaration(node);
        }

        private EqualsValueClauseSyntax CreateEqualsValueClause(long value, bool useHex)
        {
            var stringValue = useHex ? $"0x{value:X}" : $"{value}";
            return EqualsValueClause(
                LiteralExpression(
                    SyntaxKind.NumericLiteralExpression,
                    Literal([], stringValue, value, [])
                )
            );
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

    /// <param name="Node">The node corresponding to the member.</param>
    /// <param name="Symbol">The symbol corresponding to the member, if available.</param>
    /// <param name="Value">The value of the member, if known.</param>
    private readonly record struct EnumMemberInfo(
        EnumMemberDeclarationSyntax Node,
        IFieldSymbol? Symbol,
        long? Value
    );

    private class EnumMemberInfoValueComparer : IComparer<EnumMemberInfo>
    {
        public int Compare(EnumMemberInfo a, EnumMemberInfo b)
        {
            // Ascending value
            // Null is after non-null
            if (a.Value.HasValue)
            {
                if (b.Value.HasValue)
                {
                    return a.Value.Value.CompareTo(b.Value.Value);
                }

                return -1;
            }

            if (b.Value.HasValue)
            {
                return 1;
            }

            return 0;
        }
    }
}
