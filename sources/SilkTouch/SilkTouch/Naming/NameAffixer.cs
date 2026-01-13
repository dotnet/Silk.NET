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
    public static NameAffix[] GetAffixData(this SyntaxList<AttributeListSyntax> attributeLists)
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
                        new NameAffix(type == "Prefix", category, affix, declarationOrder),
                    ];
                    declarationOrder++;
                }
            }
        }

        return affixes;
    }

    /// <summary>
    /// Adds a name prefix attribute to the given attribute list.
    /// </summary>
    /// <param name="attributeLists">The attribute lists to add the attribute to.</param>
    /// <param name="category">The affix category.</param>
    /// <param name="prefix">The value of the affix.</param>
    /// <param name="addToInner">
    /// Use true if the affix comes from the inside of the name.
    /// Use false if not (outside or appended to end).
    /// True means that the attribute is added to the start of the attribute list, meaning that the affix is re-appended earlier.
    /// </param>
    public static SyntaxList<AttributeListSyntax> AddNamePrefix(
        this IEnumerable<AttributeListSyntax> attributeLists,
        string category,
        string prefix,
        bool addToInner = false
    ) => attributeLists.AddNamePrefixOrSuffix("Prefix", category, prefix, addToInner);

    /// <summary>
    /// Adds a name suffix attribute to the given attribute list.
    /// </summary>
    /// <param name="attributeLists">The attribute lists to add the attribute to.</param>
    /// <param name="category">The affix category.</param>
    /// <param name="suffix">The value of the affix.</param>
    /// <param name="addToInner">
    /// Use true if the affix comes from the inside of the name.
    /// Use false if not (outside or appended to end).
    /// True means that the attribute is added to the start of the attribute list, meaning that the affix is re-appended earlier.
    /// </param>
    public static SyntaxList<AttributeListSyntax> AddNameSuffix(
        this IEnumerable<AttributeListSyntax> attributeLists,
        string category,
        string suffix,
        bool addToInner = false
    ) => attributeLists.AddNamePrefixOrSuffix("Suffix", category, suffix, addToInner);

    private static SyntaxList<AttributeListSyntax> AddNamePrefixOrSuffix(
        this IEnumerable<AttributeListSyntax> attributeLists,
        string type,
        string category,
        string affix,
        bool addToInner = false
    )
    {
        var typeArgument = AttributeArgument(
            LiteralExpression(SyntaxKind.StringLiteralExpression, Literal($"\"{type}\"", type))
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
    /// Removes affixes from the specified primary name and adds the original specified primary to the secondary list if provided.
    /// </summary>
    /// <param name="name">The name to remove affixes from.</param>
    /// <param name="affixes">The affixes to remove. Note that the span will be modified.</param>
    /// <returns>The new primary name.</returns>
    public static string RemoveAffixes(string name, Span<NameAffix> affixes)
    {
        if (affixes.Length == 0)
        {
            return name;
        }

        var originalPrimary = name;

        // Sort affixes so that the outer affixes are first
        affixes.Sort(
            static (a, b) =>
            {
                // Sort by descending declaration order
                // Lower declaration order means the affix is closer to the inside of the name
                return -a.DeclarationOrder.CompareTo(b.DeclarationOrder);
            }
        );

        // TODO: Write this to not require a list/allocations
        var prefixes = affixes.Where(x => x.IsPrefix).ToList();
        var suffixes = affixes.Where(x => !x.IsPrefix).ToList();

        RemoveSide(true, prefixes);
        RemoveSide(false, suffixes);

        if (originalPrimary != name)
        {
            secondary?.Add(originalPrimary);
        }

        return name;

        void RemoveSide(bool isPrefix, List<NameAffix> nameAffixes)
        {
            while (nameAffixes.Count > 0)
            {
                var removedAffix = false;
                for (var i = 0; i < nameAffixes.Count; i++)
                {
                    var affix = nameAffixes[i];
                    if (isPrefix ? name.StartsWith(affix.Affix) : name.EndsWith(affix.Affix))
                    {
                        name = isPrefix ? name[affix.Affix.Length..] : name[..^affix.Affix.Length];

                        nameAffixes.RemoveAt(i);
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
    }
}
