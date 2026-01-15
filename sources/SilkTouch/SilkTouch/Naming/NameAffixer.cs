// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Mods;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Naming;

/// <summary>
/// Handles the parsing and usage of <see cref="NameAffixAttribute"/>s.
/// </summary>
public static class NameAffixer
{
    /// <summary>
    /// Reads the name affix data from the specified attribute lists.
    /// </summary>
    public static NameAffix[] GetNameAffixes(this SyntaxList<AttributeListSyntax> attributeLists)
    {
        NameAffix[] affixes = [];
        var declarationOrder = 0;
        foreach (var list in attributeLists)
        {
            foreach (var attribute in list.Attributes)
            {
                if (!attribute.IsAttribute("Silk.NET.Core.NameAffix"))
                {
                    continue;
                }

                var argumentList = attribute.ArgumentList;
                if (
                    argumentList != null
                    && argumentList.Arguments[0].Expression
                        is LiteralExpressionSyntax { Token.Value: string type }
                    && argumentList.Arguments[1].Expression
                        is LiteralExpressionSyntax { Token.Value: string category }
                    && argumentList.Arguments[2].Expression
                        is LiteralExpressionSyntax { Token.Value: string affix }
                )
                {
                    affixes =
                    [
                        .. affixes,
                        new NameAffix(
                            type == "Prefix" ? NameAffixType.Prefix : NameAffixType.Suffix,
                            category,
                            affix,
                            declarationOrder
                        ),
                    ];
                    declarationOrder++;
                }
            }
        }

        return affixes;
    }

    /// <summary>
    /// Adds a [NameAffix] attribute to the given attribute list.
    /// </summary>
    /// <param name="attributeLists">The attribute lists to add the attribute to.</param>
    /// <param name="type">The affix type to add.</param>
    /// <param name="category">The affix category.</param>
    /// <param name="affix">The value of the affix.</param>
    /// <param name="addToInner">
    /// Use true if the affix comes from the inside of the name.
    /// Use false if not (outside or appended to end).
    /// True means that the attribute is added to the start of the attribute list, meaning that the affix is re-appended earlier.
    /// </param>
    public static SyntaxList<AttributeListSyntax> AddNameAffix(
        this IEnumerable<AttributeListSyntax> attributeLists,
        NameAffixType type,
        string category,
        string affix,
        bool addToInner = false
    )
    {
        var affixType = type switch
        {
            NameAffixType.Prefix => "Prefix",
            NameAffixType.Suffix => "Suffix",
            _ => throw new ArgumentOutOfRangeException(nameof(type)),
        };

        var typeArgument = AttributeArgument(
            LiteralExpression(
                SyntaxKind.StringLiteralExpression,
                Literal($"\"{affixType}\"", affixType)
            )
        );
        var categoryArgument = AttributeArgument(
            LiteralExpression(
                SyntaxKind.StringLiteralExpression,
                Literal($"\"{category}\"", category)
            )
        );
        var affixArgument = AttributeArgument(
            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal($"\"{affix}\"", affix))
        );
        var argumentList = AttributeArgumentList([typeArgument, categoryArgument, affixArgument]);

        var attribute = AttributeList([Attribute(IdentifierName("NameAffix"), argumentList)]);

        return addToInner ? [attribute, .. attributeLists] : [.. attributeLists, attribute];
    }

    /// <summary>
    /// Applies the specified affixes to the specified name.
    /// </summary>
    /// <remarks>
    /// <see cref="PrettifyNames"/> has a much configurable version of this method.
    /// That version is intentionally not exposed since configuration of affixes should be left to the user.
    /// </remarks>
    /// <param name="name">The name to apply affixes to.</param>
    /// <param name="affixes">The affixes to apply. The span's elements may be reordered by this method.</param>
    /// <returns>The name with affixes applied.</returns>
    public static string ApplyAffixes(string name, Span<NameAffix> affixes)
    {
        if (affixes.Length == 0)
        {
            return name;
        }

        // Sort affixes so that the inner affixes are first
        affixes.Sort(
            static (a, b) =>
            {
                // Sort by ascending declaration order
                // Lower declaration order means the affix is closer to the inside of the name
                return a.DeclarationOrder.CompareTo(b.DeclarationOrder);
            }
        );

        foreach (var affix in affixes)
        {
            if (affix.Type == NameAffixType.Prefix)
            {
                name = affix.Affix + name;
            }
            else
            {
                name += affix.Affix;
            }
        }

        return name;
    }

    /// <summary>
    /// Strips the specified affixes from the specified name.
    /// Affixes not present on the name will be ignored.
    /// </summary>
    /// <param name="name">The name to strip affixes from.</param>
    /// <param name="affixes">The affixes to remove. The span's elements may be reordered by this method.</param>
    /// <returns>The name with affixes stripped.</returns>
    public static string StripAffixes(string name, Span<NameAffix> affixes)
    {
        if (affixes.Length == 0)
        {
            return name;
        }

        // Sort affixes so that the outer affixes are first
        affixes.Sort(
            static (a, b) =>
            {
                // Sort so that prefixes are first
                if (a.Type != b.Type)
                {
                    return ((int)a.Type).CompareTo((int)b.Type);
                }

                // Then by descending declaration order
                // Lower declaration order means the affix is closer to the inside of the name
                return -a.DeclarationOrder.CompareTo(b.DeclarationOrder);
            }
        );

        var firstSuffixI = 0;
        for (; firstSuffixI < affixes.Length; firstSuffixI++)
        {
            if (affixes[firstSuffixI].Type == NameAffixType.Suffix)
            {
                break;
            }
        }

        var prefixes = affixes[..firstSuffixI];
        var suffixes = affixes[firstSuffixI..];

        RemoveSide(true, prefixes);
        RemoveSide(false, suffixes);

        return name;

        void RemoveSide(bool isPrefix, Span<NameAffix> nameAffixes)
        {
            while (nameAffixes.Length > 0)
            {
                var removedAffix = false;
                for (var i = 0; i < nameAffixes.Length; i++)
                {
                    var affix = nameAffixes[i];
                    if (isPrefix ? name.StartsWith(affix.Affix) : name.EndsWith(affix.Affix))
                    {
                        name = isPrefix ? name[affix.Affix.Length..] : name[..^affix.Affix.Length];

                        nameAffixes = RemoveAt(nameAffixes, i);
                        removedAffix = true;
                        break;
                    }
                }

                if (!removedAffix)
                {
                    break;
                }
            }
        }

        // Removes the element at i by moving it to the end and slicing the span
        // The order of the remaining elements is maintained
        Span<NameAffix> RemoveAt(Span<NameAffix> nameAffixes, int i)
        {
            var removed = nameAffixes[i];
            if (nameAffixes.Length == 1)
            {
                return [];
            }

            nameAffixes[(i + 1)..].CopyTo(nameAffixes[..^1]);
            nameAffixes[^1] = removed;

            return nameAffixes[..^1];
        }
    }
}
