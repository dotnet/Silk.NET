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
/// <remarks>
/// In general, this class adds defaults when the document is missing them.
/// Namespaces, using statements, and header comments are currently handled.
/// Best practice is to call <see cref="PopulateDocument"/> when the document is added to a project.
/// </remarks>
public class DocumentFactory
{
    /// <summary>
    /// The default header to add if the document does not currently have one.
    /// </summary>
    public SyntaxTriviaList? DefaultHeader { get; set; }

    /// <summary>
    /// The default namespace to use for documents.
    /// </summary>
    public string? DefaultNamespace { get; set; }

    /// <summary>
    /// Using statements to add to all initialized documents.
    /// </summary>
    public IReadOnlyList<UsingDirectiveSyntax> Usings => _usings;

    private readonly List<UsingDirectiveSyntax> _usings = [];
    private readonly List<string> _orderedUsingDiscriminators = [];
    private readonly HashSet<string> _usingDiscriminators = [];

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
        DefaultHeader = original.DefaultHeader;
        DefaultNamespace = original.DefaultNamespace;
        _usings = [.. original._usings];
        _orderedUsingDiscriminators = [.. original._orderedUsingDiscriminators];
        _usingDiscriminators = [.. original._usingDiscriminators];
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
        if (!fullyQualified.Contains('.') || DefaultNamespace is null)
        {
            return fullyQualified + extension;
        }

        return fullyQualified.StartsWith(DefaultNamespace)
            ? fullyQualified[DefaultNamespace.Length..].Trim('.').Replace('.', '/') + extension
            : fullyQualified + extension;
    }

    /// <summary>
    /// Reports information about a document in the project.
    /// </summary>
    /// <remarks>
    /// This currently saves the using statements for use in initializing new documents.
    /// </remarks>
    public void ReportDocument(SyntaxNode root) => _reporter.Visit(root);

    /// <summary>
    /// Initializes and reports information about a new document.
    /// </summary>
    /// <remarks>
    /// This currently adds using statements and header comments if not added already.
    /// This also calls <see cref="ReportDocument"/>.
    /// </remarks>
    public T PopulateDocument<T>(T root)
        where T : SyntaxNode
    {
        _reporter.Visit(root);
        return (T)_initializer.Visit(root);
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
        var discriminator = GetDiscriminator(directiveNoTrivia);
        if (_usingDiscriminators.Add(discriminator))
        {
            var index = ~_orderedUsingDiscriminators.BinarySearch(
                discriminator,
                UsingDirectiveComparer.Instance
            );

            _orderedUsingDiscriminators.Insert(index, discriminator);
            _usings.Insert(index, directiveNoTrivia);
        }
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

    private class DocumentReporter(DocumentFactory factory) : CSharpSyntaxWalker
    {
        public override void VisitUsingDirective(UsingDirectiveSyntax node)
        {
            if (!node.GlobalKeyword.IsKind(SyntaxKind.GlobalKeyword))
            {
                factory.AddUsing(node);
            }
        }
    }

    private class DocumentInitializer(DocumentFactory factory) : CSharpSyntaxRewriter
    {
        public override SyntaxNode VisitCompilationUnit(CompilationUnitSyntax node)
        {
            var leadingTrivia = node.GetLeadingTrivia();
            var hasHeader = leadingTrivia.Any(x =>
                x.IsKind(SyntaxKind.SingleLineCommentTrivia)
                || x.IsKind(SyntaxKind.MultiLineCommentTrivia)
            );

            node = (CompilationUnitSyntax)base.VisitCompilationUnit(node)!;

            var hasNamespace = node.Members.Any(x => x is BaseNamespaceDeclarationSyntax);
            if (!hasNamespace)
            {
                node = node.WithMembers([
                    FileScopedNamespaceDeclaration(
                            ModUtils.NamespaceIntoIdentifierName(factory.DefaultNamespace)
                        )
                        .WithMembers(node.Members),
                ]);
            }

            var header = hasHeader ? leadingTrivia : factory.DefaultHeader;
            return node.WithUsings(List(factory._usings)).WithLeadingTrivia(header);
        }

        public override SyntaxNode? VisitFileScopedNamespaceDeclaration(
            FileScopedNamespaceDeclarationSyntax node
        ) => base.VisitFileScopedNamespaceDeclaration(node.WithUsings(default));
    }

    private class UsingDirectiveComparer : IComparer<string>
    {
        public static readonly UsingDirectiveComparer Instance = new();

        public int Compare(string? x, string? y)
        {
            const string prefix = "using ";
            const string suffix = ";";

            var xSpan = x.AsSpan()[prefix.Length..][..^suffix.Length];
            var ySpan = y.AsSpan()[prefix.Length..][..^suffix.Length];

            var xSys = IsSystem(xSpan);
            var ySys = IsSystem(ySpan);
            return xSys != ySys
                ? xSys
                    ? -1
                    : 1
                : xSpan.CompareTo(ySpan, StringComparison.Ordinal);

            bool IsSystem(ReadOnlySpan<char> ns) =>
                ns.Equals("System", StringComparison.Ordinal)
                || ns.StartsWith("System.", StringComparison.Ordinal);
        }
    }
}
