// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
using ClangSharp;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.Core;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// This mod is equivalent to <see cref="PInvokeGeneratorConfiguration.WithClasses"/>, but with the ability to operate
/// on patterns rather than complete symbol names, allowing e.g. <c>alc.*</c> to be moved from <c>AL</c> (the
/// <see cref="PInvokeGeneratorConfiguration.DefaultClass"/> in this example) to <c>ALContext</c> (a new class in this
/// example).
/// </summary>
/// <remarks>
/// It is expected that input sources to this mod are as close to their "native" form (as originally scraped) as
/// possible. <see cref="NativeTypeNameAttribute"/>s are not inspected for the purposes of
/// <see cref="Configuration.NewClasses"/>. Nested types are not supported at this time. Only static members are moved.
/// </remarks>
/// <param name="log">The logger.</param>
/// <param name="options">The configuration options.</param>
[ModConfiguration<Configuration>]
public class ChangeNativeClass(
    ILogger<ChangeNativeClass> log,
    IOptionsSnapshot<ChangeNativeClass.Configuration> options
) : IMod
{
    /// <summary>
    /// Configuration for the <see cref="ChangeNativeClass"/> mod.
    /// </summary>
    public class Configuration
    {
        /// <summary>
        /// A map of native name patterns to class names. If the new class name contains <c>.</c>, it will be assumed to
        /// be a fully qualified class name. Otherwise it shall carry the same namespace as the original class.
        /// </summary>
        public required Dictionary<string, string> NewClasses { get; init; }
    }

    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        // Get the config.
        var cfg = options.Get(ctx.JobKey);

        // Compile all the patterns
        var patterns = cfg
            .NewClasses.Select(x => (Regex: new Regex(x.Key, RegexOptions.Compiled), x.Value))
            .ToList();
        var finder = new MatchFinder(patterns);

        // Remove all the members from the old classes.
        var proj = ctx.SourceProject;
        Debug.Assert(proj is not null);
        foreach (var docId in ctx.SourceProject?.DocumentIds ?? [])
        {
            var doc = proj.GetDocument(docId)!; // <-- should defo exist
            if (await doc.GetSyntaxTreeAsync(ct) is not { } tree)
            {
                continue;
            }

            finder.CurrentDocument = doc;
            proj = doc.WithSyntaxRoot(
                finder.Visit(await tree.GetRootAsync(ct))
                    ?? throw new InvalidOperationException($"{nameof(MatchFinder)} returned null.")
            ).Project;
        }

        var mover = new MemberMover();
        var membersToMove = new List<MemberDeclarationSyntax>();
        mover.Members = membersToMove;
        foreach (var (fq, (decls, inbound)) in finder.Actions)
        {
            if (inbound is null or { Count: 0 })
            {
                continue;
            }

            mover.FullyQualifiedTargetType = fq;
            var (syntaxKind, lastIndex) =
                decls?.Select(x => x.Kind).Distinct().Select((x, i) => (x, i)).LastOrDefault()
                ?? ((SyntaxKind?)null, 0);
            if (lastIndex != 0)
            {
                log.LogWarning(
                    "Declarations for the fully-qualified destination type name \"{}\" were found with multiple "
                        + "different syntax kinds! This is not possible in valid C# and is undefined behaviour herein.",
                    fq
                );
            }

            if (syntaxKind is null)
            {
                (syntaxKind, lastIndex) = inbound
                    .Select(x => x.TypeKind)
                    .Distinct()
                    .Select((x, i) => (x, i))
                    .LastOrDefault();
                if (lastIndex != 0)
                {
                    log.LogWarning(
                        "The APIs being moved to \"{}\" are coming from types with different syntax kinds (i.e. "
                            + "struct, class, etc). Given the destination type doesn't already exist, it will be "
                            + "inferred to be a class.",
                        fq
                    );
                    syntaxKind = SyntaxKind.ClassDeclaration;
                }
            }

            syntaxKind ??= SyntaxKind.ClassDeclaration;

            // Where possible, we want to keep the declarations close to where they were originally declared.
            foreach (
                var inDirectoryMemberMoves in inbound.GroupBy(x =>
                    Path.GetDirectoryName(x.Document.FilePath)
                )
            )
            {
                // Find a declaration document in this directory.
                var declDoc = decls?.FirstOrDefault(x =>
                    Path.GetDirectoryName(x.Document.FilePath) == inDirectoryMemberMoves.Key
                );

                membersToMove.Clear();
                membersToMove.AddRange(inDirectoryMemberMoves.Select(x => x.MemberToMove));
                if (declDoc is null)
                {
                    var name = fq.AsSpan();
                    if (name.LastIndexOf('.') is not -1 and var idx)
                    {
                        name = name[(idx + 1)..];
                    }

                    var filename = $"{name}.gen.cs";
                    proj = proj.AddDocument(
                        filename,
                        NewFile(membersToMove, syntaxKind.Value, fq, decls is not { Count: > 0 }),
                        filePath: Path.Join(inDirectoryMemberMoves.Key, filename)
                    ).Project;
                }
                else
                {
                    var doc =
                        proj.GetDocument(declDoc.Value.Document.Id)
                        ?? throw new InvalidOperationException(
                            "Document was somehow removed since the first pass."
                        );
                    proj = doc.WithSyntaxRoot(
                        mover.Visit(await doc.GetSyntaxRootAsync(ct))
                            ?? throw new InvalidOperationException("Syntax root was somehow null.")
                    ).Project;
                }
            }
        }

        ctx.SourceProject = proj;
    }

    private static CompilationUnitSyntax NewFile(
        IReadOnlyList<MemberDeclarationSyntax> members,
        SyntaxKind syntaxKind,
        ReadOnlySpan<char> fq,
        bool @new
    )
    {
        var nameStart = fq.LastIndexOf('.') + 1;
        var name = fq[nameStart..];
        var ns = fq[..int.Max(nameStart - 1, 0)];
        TypeDeclarationSyntax type = syntaxKind switch
        {
            SyntaxKind.ClassDeclaration => ClassDeclaration(name.ToString()),
            SyntaxKind.StructDeclaration => StructDeclaration(name.ToString()),
            SyntaxKind.InterfaceDeclaration => InterfaceDeclaration(name.ToString()),
            SyntaxKind.RecordDeclaration or SyntaxKind.RecordStructDeclaration => RecordDeclaration(
                syntaxKind,
                Token(SyntaxKind.RecordKeyword),
                name.ToString()
            ),
            _ => throw new ArgumentOutOfRangeException(nameof(syntaxKind)),
        };
        MemberDeclarationSyntax member = type.WithModifiers(
                @new
                    ? TokenList(
                        Token(SyntaxKind.PublicKeyword),
                        Token(SyntaxKind.UnsafeKeyword),
                        Token(SyntaxKind.PartialKeyword)
                    )
                    : TokenList(Token(SyntaxKind.UnsafeKeyword), Token(SyntaxKind.PartialKeyword))
            )
            .WithMembers(List(members));
        if (!ns.IsEmpty && !ns.IsWhiteSpace())
        {
            member = FileScopedNamespaceDeclaration(ModUtils.NamespaceIntoIdentifierName(ns))
                .WithMembers(SingletonList(member));
        }

        return CompilationUnit()
            .WithUsings(List(DistinctUsings(GetUsings(members))))
            .WithMembers(SingletonList(member));
    }

    private static IEnumerable<UsingDirectiveSyntax> GetUsings(IEnumerable<SyntaxNode> members) =>
        members
            .Select(x => x.Ancestors().Last())
            .OfType<CompilationUnitSyntax>()
            .Distinct()
            .SelectMany(x => x.Usings);

    private static IEnumerable<UsingDirectiveSyntax> DistinctUsings(
        IEnumerable<UsingDirectiveSyntax> usings
    ) => usings.DistinctBy(y => y.Name?.ToString());

    /// <summary>
    /// Discover the classes, and also discover matching members.
    /// </summary>
    class MatchFinder(List<(Regex Regex, string Value)> patterns) : CSharpSyntaxRewriter
    {
        /// <summary>
        /// A map of fully qualified class names to the declarations of those classes and the members that would like to
        /// be moved to that class.
        /// </summary>
        public Dictionary<
            string,
            (
                List<(Document Document, SyntaxKind Kind)>? Declarations,
                List<(
                    Document Document,
                    MemberDeclarationSyntax MemberToMove,
                    SyntaxKind TypeKind
                )>? Inbound
            )
        > Actions { get; } = [];

        private string? _currentNs;
        private string? _currentFq;
        private SyntaxKind? _currentTypeKind;

        public Document? CurrentDocument { get; set; }

        public override SyntaxNode? Visit(SyntaxNode? node)
        {
            // If we're not inside a type at the moment and we've encountered one...
            if (_currentFq is null && node is TypeDeclarationSyntax type)
            {
                _currentNs = node.NamespaceFromSyntaxNode();
                _currentFq = $"{_currentNs}.{type.Identifier}".TrimStart('.');
                _currentTypeKind = type.Kind();

                // _actions will already contain an entry for _currentFq if something wants to be moved there or we've
                // visited another part. Otherwise, we need to add it.
                if (!Actions.TryGetValue(_currentFq, out var current))
                {
                    Actions[_currentFq] = current = ([], null);
                }
                else if (current.Declarations is null)
                {
                    Actions[_currentFq] = current = current with { Declarations = [] };
                }

                Debug.Assert(CurrentDocument is not null);
                current.Declarations!.Add((CurrentDocument, type.Kind()));

                // Visit the members. Do not carry on to the next if, as that may end up renaming the container class
                // (not what we want).
                var ret = base.Visit(node);
                _currentFq = null;
                _currentNs = null;
                _currentTypeKind = null;
                return ret;
            }

            SyntaxNode? member = null;
            if (
                // This is a double negative so it's short-circuiting - likely worth it given how often visit is called.
                !(
                    _currentFq is not null // <-- is the parent a type?
                    && (
                        // is it a member we care about?
                        (member = node as MemberDeclarationSyntax)
                            is not (null or FieldDeclarationSyntax) // <-- we recurse into VariableDeclarators instead
                        || (member = node as VariableDeclaratorSyntax) is not null
                        || member
                            is VariableDeclaratorSyntax
                            {
                                Parent: not VariableDeclarationSyntax
                                    or { Parent: not FieldDeclarationSyntax }
                            }
                    )
                )
            )
            {
                var ret = base.Visit(node);
                return ret is FieldDeclarationSyntax { Declaration.Variables.Count: 0 }
                    ? null
                    : ret;
            }

            // Get the identifier of the member.
            var identifier = member switch
            {
                VariableDeclaratorSyntax fld => fld.Identifier,
                MethodDeclarationSyntax meth => meth.Identifier,
                DelegateDeclarationSyntax del => del.Identifier,
                EventDeclarationSyntax ev => ev.Identifier,
                PropertyDeclarationSyntax prop => prop.Identifier,
                BaseTypeDeclarationSyntax ty => ty.Identifier,
                EnumMemberDeclarationSyntax enumerant => enumerant.Identifier,
                _ => (SyntaxToken?)null,
            };
            if (identifier is null)
            {
                // what?
                return node;
            }

            foreach (var (pattern, newClass) in patterns)
            {
                if (!pattern.IsMatch(identifier.Value.ToString()))
                {
                    continue;
                }

                // Get the new (destination) fully qualified class name.
                var newFq = newClass;
                if (!newFq.Contains('.'))
                {
                    newFq = $"{_currentNs}.{newFq}";
                }

                // _actions will already contain an entry for _currentFq if we've visited that class already or
                // something else wants to be moved there.
                if (!Actions.TryGetValue(newFq, out var current))
                {
                    Actions[newFq] = current = (null, []);
                }
                else if (current.Inbound is null)
                {
                    Actions[newFq] = current = current with { Inbound = [] };
                }

                // If it's a VariableDeclarator, we need to create a new FieldDeclarationSyntax for the field we're
                // moving.
                if (
                    member is VariableDeclaratorSyntax
                    {
                        Parent: VariableDeclarationSyntax
                        {
                            Parent: BaseFieldDeclarationSyntax fld
                        } decl
                    } decla
                )
                {
                    member = fld.WithDeclaration(decl.WithVariables(SingletonSeparatedList(decla)));
                }

                Debug.Assert(CurrentDocument is not null);
                current.Inbound!.Add(
                    (CurrentDocument, (MemberDeclarationSyntax)member, _currentTypeKind!.Value)
                );
                return null; // <-- remove the member from the old type
            }

            // Don't recurse, we're visiting a member.
            return node;
        }
    }

    class MemberMover : CSharpSyntaxRewriter
    {
        public string? FullyQualifiedTargetType { get; set; }
        public IReadOnlyList<MemberDeclarationSyntax>? Members { get; set; }

        [return: NotNullIfNotNull("node")]
        public override SyntaxNode? Visit(SyntaxNode? node)
        {
            if (Members is null || FullyQualifiedTargetType is null)
            {
                return node;
            }

            if (
                node is TypeDeclarationSyntax type
                && $"{type.NamespaceFromSyntaxNode()}.{type.Identifier}" == FullyQualifiedTargetType
            )
            {
                return type.WithMembers(List(type.Members.Concat(Members)));
            }
            return base.Visit(node);
        }

        public override SyntaxNode? VisitCompilationUnit(CompilationUnitSyntax node)
        {
            if (base.VisitCompilationUnit(node) is not CompilationUnitSyntax ret)
            {
                return null;
            }

            return Members is not { Count: > 0 }
                ? ret
                : ret.WithUsings(List(DistinctUsings(ret.Usings.Concat(GetUsings(Members)))));
        }
    }
}
