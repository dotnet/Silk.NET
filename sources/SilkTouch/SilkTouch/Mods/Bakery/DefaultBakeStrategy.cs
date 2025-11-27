// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using Humanizer;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods.Bakery;

/// <summary>
/// Represents the default logic for merging multiple source sets into one source set. This will expect that
/// where there are duplicate definitions between the source sets, the relevant declarations are for the most part
/// exactly the same, save for some metadata.
/// </summary>
public class DefaultBakeStrategy(ILogger<DefaultBakeStrategy> logger) : IBakeStrategy
{
    /// <inheritdoc />
    public virtual string Name =>
        GetType() == typeof(DefaultBakeStrategy) ? "Default" : GetType().FullName ?? GetType().Name;

    /// <inheritdoc />
    public virtual MemberDeclarationSyntax BakeMember(
        MemberDeclarationSyntax node,
        string? discrim,
        BakedMember? existing
    )
    {
        // Strip the declaration down to its bare necessities.
        node = node switch
        {
            // TODO do we need to strip more than this for dedupe purposes?
            TypeDeclarationSyntax klass => klass.WithMembers(default),
            EnumDeclarationSyntax enumeration => enumeration.WithMembers(default),
            _ => node,
        };

        if (existing is null)
        {
            return node;
        }

        if (node.GetType() != existing.Value.Syntax.GetType())
        {
            throw new ArgumentException(
                "Node types differed - the profiles may contain two types with the "
                    + $"same name but with a different datatype (i.e. profile 1 contains a {node.Kind().Humanize()} "
                    + $"whereas profile 2 contains a {existing.Value.Syntax.Kind().Humanize()})"
            );
        }

        node = node.WithAttributeLists(
            List(
                existing
                    .Value.Syntax.AttributeLists.SelectMany(x =>
                        x.Attributes.Select(y => x.WithAttributes(SingletonSeparatedList(y)))
                    )
                    .Concat(
                        node.AttributeLists.SelectMany(x =>
                            x.Attributes.Select(y => x.WithAttributes(SingletonSeparatedList(y)))
                        )
                    )
                    .DistinctBy(x => x.ToString())
            )
        );

        if (node is BaseTypeDeclarationSyntax ty)
        {
            node = ty.WithModifiers(
                    TokenList(node.Modifiers.Concat(node.Modifiers).DistinctBy(x => x.ToString()))
                )
                .WithBaseList(
                    ty.BaseList?.WithTypes(
                        SeparatedList(
                            ty.BaseList.Types.Concat(
                                    ((BaseTypeDeclarationSyntax)existing.Value.Syntax)
                                        .BaseList
                                        ?.Types ?? []
                                )
                                .DistinctBy(x => x.ToString())
                        )
                    )
                );

            // If this is a struct or record struct, fields should exactly match.
            if (
                (
                    node is StructDeclarationSyntax s
                        ? (SyntaxList<MemberDeclarationSyntax>?)s.Members
                    : node is RecordDeclarationSyntax r && r.Modifiers.Any(SyntaxKind.StructKeyword)
                        ? r.Members
                    : null
                ) is
                { } members
            )
            {
                var bakedFields = (
                    existing.Value.Inner?.Children.Values ?? (IEnumerable<BakedMember>)[]
                )
                    .OrderBy(x => x.Index)
                    .Select(x => x.Syntax)
                    .OfType<FieldDeclarationSyntax>()
                    .SelectMany(x =>
                        x.Declaration.Variables.Select(y => (x.Declaration.Type, Var: y))
                    )
                    .ToArray();
                var ourFields = members
                    .OfType<FieldDeclarationSyntax>()
                    .SelectMany(x =>
                        x.Declaration.Variables.Select(y => (x.Declaration.Type, Var: y))
                    )
                    .ToArray();
                if (bakedFields.Length != ourFields.Length)
                {
                    throw new InvalidOperationException(
                        $"Differing number of fields between definitions of {ty.Identifier} ({bakedFields.Length} vs "
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
                            $"Field {i} differs between definitions of {ty.Identifier}. "
                                + $"Left: {bakedFields[i]}, right: {ourFields[i]}"
                        );
                    }
                }
            }
        }

        // Boldly assume it's the same implementation, modifiers, etc
        // TODO ^^^ is this okay? should be fine if we're getting DllImports as inputs.

        // Okay fine here's some extra handling just in case it's a partial:
        if (
            node is BaseMethodDeclarationSyntax meth
            && existing.Value.Syntax is BaseMethodDeclarationSyntax bakedMeth
            && existing.Value.Syntax.Modifiers.Any(SyntaxKind.PartialKeyword)
            && node.Modifiers.Any(SyntaxKind.PartialKeyword)
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

            if (!precedence)
            {
                node = existing.Value.Syntax.AddAttributeLists(
                    node.AttributeLists.Select(x =>
                            x.WithAttributes(
                                SeparatedList(
                                    x.Attributes.Where(y => y.IsAttribute("Silk.NET.Core.SupportedApiAttribute"))
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
            (existing.Value.Syntax, node) is

            (EnumMemberDeclarationSyntax lEnum, EnumMemberDeclarationSyntax rEnum)
        )
        {
            if (lEnum.EqualsValue?.Value.ToString() != rEnum.EqualsValue?.Value.ToString())
            {
                logger.LogWarning(
                    "Enum member with discriminator \"{}\" differs between definitions. Left: {}, right: {}",
                    discrim,
                    lEnum.EqualsValue?.Value.ToString() ?? "auto-assigned",
                    rEnum.EqualsValue?.Value.ToString() ?? "auto-assigned"
                );
            }
        }
        else if (
            (existing.Value.Syntax, node) is

            (FieldDeclarationSyntax lConst, FieldDeclarationSyntax rConst)
        )
        {
            var isConst = lConst.Modifiers.Any(SyntaxKind.ConstKeyword);
            if (isConst != rConst.Modifiers.Any(SyntaxKind.ConstKeyword))
            {
                logger.LogWarning(
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
                logger.LogWarning(
                    "Const value with discriminator \"{}\" differs between definitions. Left: {}, right: {}",
                    discrim,
                    lConst.Declaration.Variables[0].Initializer?.Value.ToString(),
                    rConst.Declaration.Variables[0].Initializer?.Value.ToString()
                );
            }
        }

        return node;
    }
}
