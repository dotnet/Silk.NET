// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.Core.Analyzers;

/// <summary>
/// A source generator to aid usage of HLU types.
/// </summary>
[Generator]
public partial class HluSourceGenerator : IIncrementalGenerator
{
    /// <inheritdoc />
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        context.RegisterSourceOutput(
            context
                .SyntaxProvider.ForAttributeWithMetadataName(
                    "Silk.NET.Core.HluHostedComponentAttribute",
                    (node, _) =>
                        node
                            is VariableDeclaratorSyntax
                            {
                                Parent: VariableDeclarationSyntax
                                {
                                    Parent: FieldDeclarationSyntax
                                    {
                                        Parent: ClassDeclarationSyntax
                                    }
                                }
                            },
                    (ctx, _) =>
                        (
                            IsMandatory: !ctx.Attributes[0]
                                .ConstructorArguments.Any(y => y.Value is false),
                            Class: (ctx.TargetSymbol as IFieldSymbol)?.ContainingType,
                            Field: ctx.TargetSymbol as IFieldSymbol,
                            FieldType: (ctx.TargetSymbol as IFieldSymbol)?.Type.ToDisplayString(
                                SymbolDisplayFormat.FullyQualifiedFormat.WithGenericsOptions(
                                    SymbolDisplayGenericsOptions.IncludeTypeParameters
                                )
                            ),
                            ctx.SemanticModel
                        )
                )
                .Collect()
                .Select(
                    (x, _) =>
                        x.Where(y => y.Class is not null)
                            .GroupBy(y => y.Class, SymbolEqualityComparer.Default)
                ),
            (outCtx, data) =>
            {
                foreach (var klass in data)
                {
                    if (klass.Key is not INamedTypeSymbol classSym)
                    {
                        continue;
                    }

                    outCtx.AddSource(
                        $"{classSym.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat.WithGlobalNamespaceStyle(SymbolDisplayGlobalNamespaceStyle.Omitted))}_HluComponentHost.g.cs",
                        CreateHostPartial(classSym, klass).ToFullString()
                    );
                }
            }
        );

        context.RegisterSourceOutput(
            context
                .SyntaxProvider.ForAttributeWithMetadataName(
                    "Silk.NET.Core.HluRegisteredComponentAttribute`2",
                    (node, _) => node is ClassDeclarationSyntax,
                    (ctx, _) =>
                        (
                            Class: ctx.TargetSymbol as INamedTypeSymbol,
                            Components: ctx.Attributes.Select(x =>
                                    (
                                        ComponentType: x.AttributeClass?.TypeArguments[0]
                                            as INamedTypeSymbol,
                                        ImplementationType: x.AttributeClass?.TypeArguments[1]
                                            as INamedTypeSymbol,
                                        ApplicationSyntax: x.ApplicationSyntaxReference?.GetSyntax()
                                            as AttributeSyntax,
                                        IsDefault: !x.ConstructorArguments.Any(y =>
                                            y.Value is false
                                        )
                                    )
                                )
                                .Where(x =>
                                    x
                                        is {
                                            ComponentType.TypeArguments.Length: 0,
                                            ImplementationType: not null,
                                            ApplicationSyntax: not null
                                        }
                                ),
                            ctx.SemanticModel
                        )
                )
                .Where(y => y.Class is not null),
            (outCtx, data) =>
            {
                outCtx.AddSource(
                    $"{data.Class!.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat.WithGlobalNamespaceStyle(SymbolDisplayGlobalNamespaceStyle.Omitted))}_HluComponentRegistry.g.cs",
                    CreateRegistryPartial(
                            data.Class,
                            data.SemanticModel,
                            data.Components.ToArray()!
                        )
                        .ToFullString()
                );
            }
        );
    }
}
