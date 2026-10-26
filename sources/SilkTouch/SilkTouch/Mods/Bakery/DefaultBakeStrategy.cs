// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
    public virtual MemberDeclarationSyntax? Cleanup(MemberDeclarationSyntax? node)
    {
        node = node switch
        {
            // TODO do we need to strip more than this for dedupe purposes?
            TypeDeclarationSyntax klass => klass.WithMembers(default),
            EnumDeclarationSyntax enumeration => enumeration.WithMembers(default),
            _ => node,
        };

        return node;
    }

    /// <inheritdoc />
    public virtual MemberDeclarationSyntax? Merge(
        string discrim,
        SyntaxNode? existingParent,
        BakedMember? existing,
        SyntaxNode? incomingParent,
        BakedMember incoming
    )
    {
        if (existing == null)
        {
            // If parent is a struct or record struct, fields counts should be equal.
            if (
                incomingParent is BaseTypeDeclarationSyntax parent
                && (
                    incomingParent is StructDeclarationSyntax
                    || (
                        incomingParent is RecordDeclarationSyntax r
                        && r.ClassOrStructKeyword.IsKind(SyntaxKind.StructKeyword)
                    )
                )
            )
            {
                throw new InvalidOperationException(
                    $"Differing number of fields between definitions of {parent.Identifier}"
                );
            }

            return incoming.Syntax;
        }

        var node = incoming.Syntax;
        if (node.GetType() != existing.Syntax.GetType())
        {
            throw new ArgumentException(
                "Node types differed - the profiles may contain two types with the "
                    + $"same name but with a different datatype (i.e. profile 1 contains a {existing.Syntax.Kind()} "
                    + $"whereas profile 2 contains a {node.Kind()})"
            );
        }

        // Fields should exactly match.
        {
            if (
                (existing.Syntax, node: node) is
                (FieldDeclarationSyntax existingField, FieldDeclarationSyntax incomingField)
            )
            {
                if (incomingParent is BaseTypeDeclarationSyntax parent)
                {
                    // BakeSourceSets splits declarators into standalone fields
                    var existingDeclarator = existingField.Declaration.Variables.Single();
                    var incomingDeclarator = incomingField.Declaration.Variables.Single();

                    if (
                        existingField.Declaration.Type.ToString()
                            != incomingField.Declaration.Type.ToString()
                        || existingDeclarator.Identifier.ToString()
                            != incomingDeclarator.Identifier.ToString()
                        || existingDeclarator.Initializer?.ToString()
                            != incomingDeclarator.Initializer?.ToString()
                        || existingDeclarator.ArgumentList?.ToString()
                            != incomingDeclarator.ArgumentList?.ToString()
                    )
                    {
                        throw new InvalidOperationException(
                            $"Field {discrim} differs between definitions of {parent.Identifier}."
                        );
                    }
                }
            }
        }

        // Merge attributes
        node = node.WithAttributeLists(
            List(
                existing
                    .Syntax.AttributeLists.SelectMany(x =>
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

        if (node is BaseTypeDeclarationSyntax incomingType)
        {
            var baseTypes = (((BaseTypeDeclarationSyntax)existing.Syntax).BaseList?.Types ?? [])
                .Concat(incomingType.BaseList?.Types ?? [])
                .DistinctBy(x => x.ToString())
                .ToArray();

            node = incomingType
                .WithModifiers(
                    TokenList(
                        existing
                            .Syntax.Modifiers.Concat(node.Modifiers)
                            .DistinctBy(x => x.ToString())
                    )
                )
                .WithBaseList(baseTypes.Length != 0 ? BaseList(SeparatedList(baseTypes)) : null);
        }

        // Boldly assume it's the same implementation, modifiers, etc
        // TODO ^^^ is this okay? should be fine if we're getting DllImports as inputs.

        // Okay fine here's some extra handling just in case it's a partial:
        if (
            node is BaseMethodDeclarationSyntax incomingMethod
            && existing.Syntax is BaseMethodDeclarationSyntax existingMethod
            && existing.Syntax.Modifiers.Any(SyntaxKind.PartialKeyword)
            && node.Modifiers.Any(SyntaxKind.PartialKeyword)
        )
        {
            var precedence = false;
            if (existingMethod.Body is null && incomingMethod.Body is not null)
            {
                if (existingMethod.ExpressionBody is not null)
                {
                    throw new InvalidOperationException(
                        $"The existing definition for \"{discrim}\" provides an expression body whereas this "
                            + "definition provides a statement body"
                    );
                }

                // Our definition takes precedence
                precedence = true;
            }

            if (existingMethod.ExpressionBody is null && incomingMethod.ExpressionBody is not null)
            {
                if (existingMethod.Body is not null)
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
                node = existing.Syntax.AddAttributeLists(
                    node.AttributeLists.Select(x =>
                            x.WithAttributes(
                                SeparatedList(
                                    x.Attributes.Where(y =>
                                        y.IsAttribute("Silk.NET.Core.SupportedApiAttribute")
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
            (existing.Syntax, node: node) is
            (EnumMemberDeclarationSyntax existingEnum, EnumMemberDeclarationSyntax incomingEnum)
        )
        {
            if (
                existingEnum.EqualsValue?.Value.ToString()
                != incomingEnum.EqualsValue?.Value.ToString()
            )
            {
                logger.LogWarning(
                    "Enum member with discriminator \"{}\" differs between definitions. Left: {}, right: {}",
                    discrim,
                    existingEnum.EqualsValue?.Value.ToString() ?? "auto-assigned",
                    incomingEnum.EqualsValue?.Value.ToString() ?? "auto-assigned"
                );
            }
        }
        else if (
            (existing.Syntax, node: node) is
            (FieldDeclarationSyntax existingConst, FieldDeclarationSyntax incomingConst)
        )
        {
            var isConst = existingConst.Modifiers.Any(SyntaxKind.ConstKeyword);
            if (isConst != incomingConst.Modifiers.Any(SyntaxKind.ConstKeyword))
            {
                logger.LogWarning(
                    "Const with discriminator \"{}\" isn't const in its redefinition. Left: {}, right: {}",
                    discrim,
                    existingConst.ToString(),
                    incomingConst.ToString()
                );
            }
            else if (
                isConst
                && existingConst.Declaration.Variables[0].Initializer?.Value.ToString()
                    != incomingConst.Declaration.Variables[0].Initializer?.Value.ToString()
            )
            {
                logger.LogWarning(
                    "Const value with discriminator \"{}\" differs between definitions. Left: {}, right: {}",
                    discrim,
                    existingConst.Declaration.Variables[0].Initializer?.Value.ToString(),
                    incomingConst.Declaration.Variables[0].Initializer?.Value.ToString()
                );
            }
        }

        return node;
    }
}
