// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Mods.Transformation;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Handles creation of new documents.
/// </summary>
public class DocumentFactory
{
    /// <summary>
    /// Represents an <see cref="IMod"/> with common functionality.
    /// </summary>
    public abstract class Mod : IMod
    {
        /// <summary>
        /// Gets the common namespace determined from the default namespaces within the response file.
        /// </summary>
        public string? CommonNamespace { get; private set; }

        /// <summary>
        /// Determines where to locate the given "fully qualified file name" i.e. a file name for a type prefixed with its
        /// namespace e.g. Silk.NET.Core.SomeType`1.gen.cs. The extension is removed so that we don't mistake it as part of
        /// the namespace.
        /// </summary>
        /// <param name="fullyQualified">
        /// The fully qualified file name without the extension e.g. Silk.NET.Core.SomeType`1
        /// </param>
        /// <param name="extension">The file extension e.g. .gen.cs</param>
        /// <returns>The path within the sources directory to place this file.</returns>
        public string PathForFullyQualified(string fullyQualified, string extension = ".gen.cs")
        {
            if (!fullyQualified.Contains('.') || CommonNamespace is null or { Length: 0 })
            {
                return fullyQualified + extension;
            }

            return fullyQualified.StartsWith(CommonNamespace)
                ? fullyQualified[CommonNamespace.Length..].Trim('.').Replace('.', '/') + extension
                : fullyQualified + extension;
        }

        /// <inheritdoc />
        public virtual Task InitializeAsync(IModContext ctx, CancellationToken ct = default) =>
            Task.CompletedTask;

        /// <inheritdoc />
        public virtual async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
        {
            if (
                ctx.SourceProject is not null
                && await ctx.SourceProject.GetCompilationAsync(ct) is { } comp
            )
            {
                CommonNamespace = CommonNamespaceVisitor.CommonNamespaceFrom(comp.SourceModule);
            }
        }

        class CommonNamespaceVisitor : SymbolVisitor
        {
            private List<INamespaceSymbol> _namespacesWithTypes = [];

            public override void DefaultVisit(ISymbol symbol)
            {
                foreach (var member in symbol.Members())
                {
                    Visit(member);
                }
            }

            public override void VisitNamedType(INamedTypeSymbol symbol)
            {
                if (!_namespacesWithTypes.Contains(symbol.ContainingNamespace))
                {
                    _namespacesWithTypes.Add(symbol.ContainingNamespace);
                }
            }

            public string CommonNamespace =>
                NameUtils.FindCommonPrefix(
                    _namespacesWithTypes
                        .Select(x => x.NamespaceFromSymbol())
                        .Where(x => !string.IsNullOrWhiteSpace(x))
                        .ToList(),
                    true,
                    int.MaxValue,
                    true
                );

            public static string CommonNamespaceFrom(ISymbol symbol)
            {
                var visitor = new CommonNamespaceVisitor();
                visitor.Visit(symbol);
                return visitor.CommonNamespace;
            }
        }
    }

    /// <summary>
    /// <see cref="CSharpSyntaxRewriter"/> containing common functionality for mods.
    /// </summary>
    public abstract class ModCSharpSyntaxRewriter(bool visitIntoStructuredTrivia = false)
        : CSharpSyntaxRewriter(visitIntoStructuredTrivia),
            ITransformationContext
    {
        /// <summary>
        /// <c>using</c>s to add to the appropriate place within the syntax tree.
        /// </summary>
        public Dictionary<string, UsingDirectiveSyntax> UsingsToAdd { get; set; } = [];

        /// <inheritdoc />
        public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
        {
            var ret = base.VisitCompilationUnit(node);
            if (ret is not CompilationUnitSyntax comp)
            {
                return ret;
            }

            foreach (
                var use in comp.Usings.Where(use =>
                    !use.GlobalKeyword.IsKind(SyntaxKind.GlobalKeyword)
                )
            )
            {
                AddUsing(use);
            }

            ret = comp.WithUsings(GetUsings(UsingsToAdd, comp))
                .WithMembers(
                    UsingsToAdd.Count == 0
                        ? comp.Members
                        : List(
                            comp.Members.Select(x =>
                                x.WithLeadingTrivia(
                                    x.GetLeadingTrivia()
                                        .Where(y =>
                                            y.Kind()
                                                is not SyntaxKind.SingleLineCommentTrivia
                                                    and not SyntaxKind.MultiLineCommentTrivia
                                        )
                                )
                            )
                        )
                );

            return ret;
        }

        /// <inheritdoc />
        public override SyntaxNode? VisitFileScopedNamespaceDeclaration(
            FileScopedNamespaceDeclarationSyntax node
        )
        {
            foreach (
                var use in node.Usings.Where(use =>
                    !use.GlobalKeyword.IsKind(SyntaxKind.GlobalKeyword)
                )
            )
            {
                AddUsing(use);
            }

            return base.VisitFileScopedNamespaceDeclaration(node.WithUsings(default));
        }

        /// <summary>
        /// Gets all the usings for the given compilation unit.
        /// </summary>
        /// <param name="usingsToAdd">The usings to get.</param>
        /// <param name="comp">The compilation unit.</param>
        /// <returns>The using list.</returns>
        public static SyntaxList<UsingDirectiveSyntax> GetUsings(
            IReadOnlyCollection<KeyValuePair<string, UsingDirectiveSyntax>> usingsToAdd,
            CompilationUnitSyntax? comp
        ) =>
            List(
                usingsToAdd.Select(
                    (x, i) =>
                        i == 0
                            ? x
                                .Value.WithoutTrailingTrivia()
                                .WithLeadingTrivia(
                                    usingsToAdd
                                        .Select(y => y.Value.GetLeadingTrivia())
                                        .Concat(
                                            comp?.Members.Select(y => y.GetLeadingTrivia()) ?? []
                                        )
                                        .OrderByDescending(y =>
                                            y.Count(z =>
                                                z.Kind()
                                                    is SyntaxKind.SingleLineCommentTrivia
                                                        or SyntaxKind.MultiLineCommentTrivia
                                                        or SyntaxKind.WhitespaceTrivia
                                            )
                                        )
                                        .FirstOrDefault()
                                )
                            : x.Value.WithoutTrivia()
                )
            );

        /// <inheritdoc />
        public MethodDeclarationSyntax? Original { get; set; }

        /// <inheritdoc />
        public IFunctionTransformer[]? Transformers { get; set; }

        /// <summary>
        /// Adds a namespace import to the resultant syntax tree.
        /// </summary>
        /// <param name="str">The dot-separated namespace.</param>
        /// <returns>Whether it was added.</returns>
        protected bool AddUsing(string str) =>
            AddUsing(UsingDirective(ModUtils.NamespaceIntoIdentifierName(str)));

        /// <summary>
        /// Adds a using directive to the resultant syntax tree.
        /// </summary>
        /// <param name="use">The directive.</param>
        /// <returns>Whether it was added.</returns>
        public bool AddUsing(UsingDirectiveSyntax use) => UsingsToAdd.TryAdd(Discrim(use), use);

        /// <summary>
        /// Gets a discriminator for the given using.
        /// </summary>
        /// <param name="use">The using.</param>
        /// <returns>The discriminator string.</returns>
        protected static string Discrim(UsingDirectiveSyntax use) =>
            new(use.WithoutTrivia().ToString().Where(char.IsAsciiLetterOrDigit).ToArray());
    }
}
