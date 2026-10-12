// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Handles creation of new documents.
/// </summary>
public class DocumentFactory
{
    /// <summary>
    /// The namespace common to all reported documents.
    /// </summary>
    private string? _commonNamespace;

    /// <summary>
    /// Using statements to add to all initialized documents.
    /// </summary>
    private readonly Dictionary<string, UsingDirectiveSyntax> _usings = [];

    private readonly DocumentReporter _reporter;
    private readonly DocumentInitializer _initializer;

    /// <summary>
    /// Creates a new <see cref="DocumentFactory"/>.
    /// </summary>
    public DocumentFactory()
    {
        _initializer = new DocumentInitializer(this);
        _reporter = new DocumentReporter(this);
    }

    private DocumentFactory(DocumentFactory original)
        : this()
    {
        _commonNamespace = original._commonNamespace;
        _usings = original._usings.ToDictionary();
    }

    /// <summary>
    /// Determines the path to place a document given the "fully qualified file name".
    /// </summary>
    /// <param name="fullyQualified">
    /// The name of a type prefixed with its namespace. Should not contain a file extension.
    /// Eg: Silk.NET.Core.SomeType`1.
    /// </param>
    /// <param name="extension">The file extension. Eg: .gen.cs</param>
    /// <returns>The path within the project source directory to place this file.</returns>
    public string PathForFullyQualified(string fullyQualified, string extension = ".gen.cs")
    {
        if (!fullyQualified.Contains('.') || _commonNamespace is null or { Length: 0 })
        {
            return fullyQualified + extension;
        }

        return fullyQualified.StartsWith(_commonNamespace)
            ? fullyQualified[_commonNamespace.Length..].Trim('.').Replace('.', '/') + extension
            : fullyQualified + extension;
    }

    /// <summary>
    /// Reports information about a document in the project.
    /// </summary>
    /// <remarks>
    /// This currently saves the using statements and common namespace for use in initializing new documents.
    /// </remarks>
    public void ReportDocument(SyntaxNode root) => _reporter.Visit(root);

    /// <summary>
    /// Initializes and reports information about a new document.
    /// </summary>
    /// <remarks>
    /// This currently adds using statements and header comments if not added already.
    /// This also calls <see cref="ReportDocument"/>.
    /// </remarks>
    public SyntaxNode InitializeDocument(SyntaxNode root)
    {
        _reporter.Visit(root);
        return _initializer.Visit(root);
    }

    /// <summary>
    /// Registers a using directive to be added for all newly initialized documents.
    /// </summary>
    /// <param name="ns">The dot-separated namespace.</param>
    public void AddUsing(string ns) =>
        AddUsing(UsingDirective(ModUtils.NamespaceIntoIdentifierName(ns)));

    /// <summary>
    /// Registers a using directive to be added for all newly initialized documents.
    /// </summary>
    /// <param name="directive">The using directive.</param>
    public void AddUsing(UsingDirectiveSyntax directive)
    {
        var directiveNoTrivia = directive.WithoutTrivia();
        _usings.TryAdd(GetDiscriminator(directiveNoTrivia), directiveNoTrivia);
    }

    /// <summary>
    /// Creates a clone of this document factory.
    /// </summary>
    /// <remarks>
    /// Can be useful for registering local using statements without affecting the original document factory.
    /// </remarks>
    public DocumentFactory Clone() => new(this);

    /// <summary>
    /// Gets a discriminator for the given using.
    /// </summary>
    /// <param name="use">The using.</param>
    /// <returns>The discriminator string.</returns>
    private static string GetDiscriminator(UsingDirectiveSyntax use) =>
        use.WithoutTrivia().NormalizeWhitespace().ToFullString();

    private class DocumentReporter(DocumentFactory factory) : CSharpSyntaxWalker { }

    private class DocumentInitializer(DocumentFactory factory) : CSharpSyntaxRewriter { }

    private abstract class ModCSharpSyntaxRewriter(bool visitIntoStructuredTrivia = false)
        : CSharpSyntaxRewriter(visitIntoStructuredTrivia)
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

        /// <summary>
        /// Adds a namespace import to the resultant syntax tree.
        /// </summary>
        /// <param name="ns">The dot-separated namespace.</param>
        /// <returns>Whether it was added.</returns>
        public bool AddUsing(string ns) =>
            AddUsing(UsingDirective(ModUtils.NamespaceIntoIdentifierName(ns)));

        /// <summary>
        /// Adds a using directive to the resultant syntax tree.
        /// </summary>
        /// <param name="use">The directive.</param>
        /// <returns>Whether it was added.</returns>
        public bool AddUsing(UsingDirectiveSyntax use) =>
            UsingsToAdd.TryAdd(GetDiscriminator(use), use);
    }
}
