// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Text.RegularExpressions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Replaces function pointers identified by their <see cref="NativeTypeNameAttribute"/>s
/// with delegates and function pointer structs.
/// </summary>
public partial class ExtractFunctionPointers(ILogger<ExtractFunctionPointers> logger) : IMod
{
    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var project = ctx.SourceProject;
        if (project == null)
        {
            return;
        }

        // Scan and extract function pointers
        var rewriter = new Rewriter(logger);
        foreach (var docId in project.DocumentIds)
        {
            var doc =
                project.GetDocument(docId)
                ?? throw new InvalidOperationException("Document missing");

            var file = doc.RelativePath();
            if (file is null)
            {
                continue;
            }

            rewriter.File = file;
            project = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))
                    ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        // Add documents for each extracted function pointer
        // This is moved out of the foreach statement for better debuggability
        var extractedFunctionPointers = rewriter
            .FunctionPointerTypes.Values.SelectMany(x =>
                (IEnumerable<(MemberDeclarationSyntax, string, HashSet<string>, HashSet<string>)>)
                    [
                        (
                            x.Delegate,
                            x.Delegate.Identifier.ToString(),
                            x.ReferencingFileDirs,
                            x.ReferencingNamespaces
                        ),
                        (
                            x.Pfn,
                            x.Pfn.Identifier.ToString(),
                            x.ReferencingFileDirs,
                            x.ReferencingNamespaces
                        ),
                    ]
            )
            .ToList();

        foreach (var (typeDecl, identifier, fileDirs, namespaces) in extractedFunctionPointers)
        {
            var ns = NameUtils.FindCommonPrefix(namespaces, true, false, true);
            var dir = NameUtils.FindCommonPrefix(fileDirs, true, false, true).TrimEnd('/');
            project = project
                ?.AddDocument(
                    $"{identifier}.gen.cs",
                    CompilationUnit()
                        .WithMembers(
                            ns is { Length: > 0 }
                                ? SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(ns.TrimEnd('.'))
                                        )
                                        .WithMembers(SingletonList(typeDecl))
                                )
                                : SingletonList(typeDecl)
                        ),
                    // Place extracted function pointer types in the directory common to where the types are referenced from
                    filePath: project.FullPath($"{dir}/{identifier}.gen.cs")
                )
                .Project;
        }

        ctx.SourceProject = project;
    }

    private partial class Rewriter(ILogger logger) : CSharpSyntaxRewriter
    {
        private string? _typeNameFromOuterFunctionPointer;
        private string? _fallbackFromOuterFunctionPointer;

        public Dictionary<
            string,
            (
                StructDeclarationSyntax Pfn,
                DelegateDeclarationSyntax Delegate,
                HashSet<string> ReferencingFileDirs,
                HashSet<string> ReferencingNamespaces
            )
        > FunctionPointerTypes { get; } = [];

        public string? File { get; set; }

        public override SyntaxNode VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (!FunctionPointerTypes.TryGetValue(node.Identifier.ToString(), out var pfnInfo))
            {
                return node;
            }

            return node.WithIdentifier(Identifier(pfnInfo.Pfn.Identifier.ToString()));
        }

        public override SyntaxNode VisitFunctionPointerType(FunctionPointerTypeSyntax node)
        {
            // Walk up the type. We expect only pointers above us, but we could encounter a function pointer type in
            // which case we just ignore all this as we should already have a _currentNativeTypeName. Anything else and
            // we don't have enough context for a fallback.
            var current = node.Parent;
            var indirectionLevels = 0;
            while (current is PointerTypeSyntax)
            {
                indirectionLevels++;
                current = current.Parent;
            }

            // As above, get the native type name if we can and also get a fallback name based on context.
            var (currentNativeTypeName, fallback) = current switch
            {
                MethodDeclarationSyntax meth => (
                    meth.AttributeLists.GetNativeTypeName(SyntaxKind.ReturnKeyword),
                    $"{meth.Identifier}_r"
                ),
                ParameterSyntax { Parent.Parent: MethodDeclarationSyntax meth } param => (
                    param.AttributeLists.GetNativeTypeName(),
                    $"{meth.Identifier}_{param.Identifier}"
                ),
                VariableDeclarationSyntax
                {
                    Parent: FieldDeclarationSyntax { Parent: BaseTypeDeclarationSyntax type } fld
                } vardec => (
                    fld.AttributeLists.GetNativeTypeName(),
                    $"{type.Identifier}_{vardec.Variables[0].Identifier}"
                ),
                _ => (null, null),
            };

            // If the native type name is actually the function pointer signature (i.e. not through a typedef) then we
            // should pass the native type name down when recursing.
            fallback = _fallbackFromOuterFunctionPointer ?? fallback;
            currentNativeTypeName =
                (_typeNameFromOuterFunctionPointer ?? currentNativeTypeName)?.Trim() ?? fallback;
            string[]? recursiveTypeNames = null;
            if (currentNativeTypeName.AsSpan().ContainsAnyExcept(NameUtils.IdentifierChars))
            {
                var match = FunctionPointerNativeTypeNameRegex().Match(currentNativeTypeName!);
                if (match.Success)
                {
                    currentNativeTypeName = fallback;

                    // NOTE: We expect the groups to be as follows:
                    // 0 = everything
                    // 1 = return type
                    // 2 = indirection levels + 1
                    // 3 = comma separated parameter types
                    recursiveTypeNames = new string[
                        1
                            + (match.Groups[3].Value.Length > 0 ? 1 : 0)
                            + match.Groups[3].Value.AsSpan().Count(',')
                    ];
                    if (match.Groups[2].Value.AsSpan().Count('*') != indirectionLevels + 1)
                    {
                        logger.LogWarning(
                            "Unable to deal with function pointer usage at {} - mismatch of indirection "
                                + "levels: {} for {}",
                            node.GetLocation().GetLineSpan(),
                            node,
                            currentNativeTypeName
                        );
                        return node;
                    }

                    recursiveTypeNames[^1] = match.Groups[1].Value;
                    var @params = match
                        .Groups[3]
                        .Value.Split(
                            ',',
                            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries
                        );
                    for (var i = 0; i < @params.Length; i++)
                    {
                        recursiveTypeNames[i] = @params[i];
                    }
                }
                else
                {
                    // Maybe it's a pointer type?
                    var idSpan = currentNativeTypeName.AsSpan();
                    if (idSpan.StartsWith("const "))
                    {
                        idSpan = idSpan["const ".Length..];
                    }

                    // If the indirection levels match (and the only other non-identifier characters are whitespace)
                    // then we can use the identifier as the native name.
                    idSpan = idSpan.Trim();
                    var badStart = idSpan.IndexOfAnyExcept(NameUtils.IdentifierChars);
                    var bad = idSpan[badStart..];
                    currentNativeTypeName =
                        badStart == -1
                        || (
                            bad.Count('*') == indirectionLevels
                            && bad.Count(' ') == bad.Length - indirectionLevels
                        )
                            ? idSpan[..badStart].ToString()
                            : fallback;
                }
            }

            if (currentNativeTypeName is null)
            {
                logger.LogWarning(
                    "Unable to deal with function pointer usage at {} - terminated at {}: {}",
                    node.GetLocation().GetLineSpan(),
                    current?.GetType().Name ?? "null",
                    current
                );
                return node;
            }

            // Assert that our state is valid given the tests we've done above before recursing.
            Debug.Assert(
                _fallbackFromOuterFunctionPointer is not null
                    == node.Ancestors().OfType<FunctionPointerTypeSyntax>().Any()
            );

            // Ensure that we've recursively generated and fixed up any function pointers contained within this function
            // pointer.
            var ns = node.NamespaceFromSyntaxNode();
            node = node.WithParameterList(
                node.ParameterList.WithParameters(
                    SeparatedList(
                        node.ParameterList.Parameters.Select(
                                (x, i) =>
                                {
                                    var typeNameBefore = _typeNameFromOuterFunctionPointer;
                                    var fallbackBefore = _fallbackFromOuterFunctionPointer;
                                    _typeNameFromOuterFunctionPointer = recursiveTypeNames?[i];
                                    _fallbackFromOuterFunctionPointer =
                                        $"{currentNativeTypeName}_p{i}";
                                    var ret = base.Visit(x);
                                    _typeNameFromOuterFunctionPointer = typeNameBefore;
                                    _fallbackFromOuterFunctionPointer = fallbackBefore;
                                    return ret;
                                }
                            )
                            .OfType<FunctionPointerParameterSyntax>()
                    )
                )
            );

            // Generate the types if we haven't already.
            if (!FunctionPointerTypes.TryGetValue(currentNativeTypeName, out var pfnInfo))
            {
                var (pfn, @delegate) = CreateFunctionPointerTypes(
                    currentNativeTypeName,
                    $"{currentNativeTypeName}Delegate",
                    (
                        currentNativeTypeName == fallback
                            ? SingletonList(
                                AttributeList(
                                    SingletonSeparatedList(Attribute(IdentifierName("Transformed")))
                                )
                            )
                            : default
                    ).WithNativeName(currentNativeTypeName),
                    (
                        currentNativeTypeName == fallback
                            ? SingletonList(
                                AttributeList(
                                    SingletonSeparatedList(Attribute(IdentifierName("Transformed")))
                                )
                            )
                            : default
                    )
                        .WithNativeName(currentNativeTypeName)
                        .AddReferencedNameAffix(
                            NameAffixType.Prefix,
                            "FunctionPointerParent",
                            currentNativeTypeName
                        )
                        .AddNameAffix(
                            NameAffixType.Suffix,
                            "FunctionPointerDelegateType",
                            "Delegate"
                        ),
                    node
                );
                FunctionPointerTypes[currentNativeTypeName] = pfnInfo = (pfn, @delegate, [], []);
            }

            // Ensure this visitation is used to determine the namespace/location.
            pfnInfo.ReferencingNamespaces.Add(ns);
            if (File?[..File.LastIndexOf('/')] is { } dir)
            {
                pfnInfo.ReferencingFileDirs.Add(dir);
            }

            return IdentifierName(currentNativeTypeName);
        }

        private static (
            StructDeclarationSyntax Pfn,
            DelegateDeclarationSyntax Delegate
        ) CreateFunctionPointerTypes(
            string pfnName,
            string delegateName,
            SyntaxList<AttributeListSyntax> pfnAttrLists,
            SyntaxList<AttributeListSyntax> delegateAttrLists,
            FunctionPointerTypeSyntax rawPfn
        )
        {
            // Ported from https://github.com/dotnet/Silk.NET/blob/d30cc43b/src/Core/Silk.NET.BuildTools/Bind/StructWriter.cs#L744-L774
            var pfn = StructDeclaration(pfnName)
                .WithModifiers(
                    TokenList(
                        Token(SyntaxKind.PublicKeyword),
                        Token(SyntaxKind.UnsafeKeyword),
                        Token(SyntaxKind.ReadOnlyKeyword)
                    )
                )
                .WithBaseList(
                    BaseList(
                        SingletonSeparatedList<BaseTypeSyntax>(
                            SimpleBaseType(IdentifierName("IDisposable"))
                        )
                    )
                )
                .WithAttributeLists(pfnAttrLists)
                .WithMembers(
                    List<MemberDeclarationSyntax>(
                        [
                            FieldDeclaration(
                                    VariableDeclaration(
                                        PointerType(PredefinedType(Token(SyntaxKind.VoidKeyword))),
                                        SingletonSeparatedList(VariableDeclarator("_pointer"))
                                    )
                                )
                                .WithModifiers(
                                    TokenList(
                                        Token(SyntaxKind.PrivateKeyword),
                                        Token(SyntaxKind.ReadOnlyKeyword)
                                    )
                                ),
                            PropertyDeclaration(rawPfn, "Handle")
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        CastExpression(rawPfn, IdentifierName("_pointer"))
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConstructorDeclaration(pfnName)
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("ptr")).WithType(rawPfn)
                                        )
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        AssignmentExpression(
                                            SyntaxKind.SimpleAssignmentExpression,
                                            IdentifierName("_pointer"),
                                            IdentifierName("ptr")
                                        )
                                    )
                                )
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConstructorDeclaration(pfnName)
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("proc"))
                                                .WithType(IdentifierName(delegateName))
                                        )
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        AssignmentExpression(
                                            SyntaxKind.SimpleAssignmentExpression,
                                            IdentifierName("_pointer"),
                                            InvocationExpression(
                                                MemberAccessExpression(
                                                    SyntaxKind.SimpleMemberAccessExpression,
                                                    IdentifierName("SilkMarshal"),
                                                    IdentifierName("DelegateToPtr")
                                                ),
                                                ArgumentList(
                                                    SingletonSeparatedList(
                                                        Argument(IdentifierName("proc"))
                                                    )
                                                )
                                            )
                                        )
                                    )
                                )
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            MethodDeclaration(
                                    PredefinedType(Token(SyntaxKind.VoidKeyword)),
                                    "Dispose"
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        InvocationExpression(
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("SilkMarshal"),
                                                IdentifierName("Free")
                                            ),
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(IdentifierName("_pointer"))
                                                )
                                            )
                                        )
                                    )
                                )
                                .WithModifiers(TokenList(Token(SyntaxKind.PublicKeyword)))
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConversionOperatorDeclaration(
                                    Token(SyntaxKind.ImplicitKeyword),
                                    IdentifierName(pfnName)
                                )
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("pfn")).WithType(rawPfn)
                                        )
                                    )
                                )
                                .WithModifiers(
                                    TokenList(
                                        Token(SyntaxKind.PublicKeyword),
                                        Token(SyntaxKind.StaticKeyword)
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        ImplicitObjectCreationExpression(
                                            ArgumentList(
                                                SingletonSeparatedList(
                                                    Argument(IdentifierName("pfn"))
                                                )
                                            ),
                                            null
                                        )
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            ConversionOperatorDeclaration(Token(SyntaxKind.ImplicitKeyword), rawPfn)
                                .WithParameterList(
                                    ParameterList(
                                        SingletonSeparatedList(
                                            Parameter(Identifier("pfn"))
                                                .WithType(IdentifierName(pfnName))
                                        )
                                    )
                                )
                                .WithModifiers(
                                    TokenList(
                                        Token(SyntaxKind.PublicKeyword),
                                        Token(SyntaxKind.StaticKeyword)
                                    )
                                )
                                .WithExpressionBody(
                                    ArrowExpressionClause(
                                        CastExpression(
                                            rawPfn,
                                            MemberAccessExpression(
                                                SyntaxKind.SimpleMemberAccessExpression,
                                                IdentifierName("pfn"),
                                                IdentifierName("_pointer")
                                            )
                                        )
                                    )
                                )
                                .WithSemicolonToken(Token(SyntaxKind.SemicolonToken)),
                            // TODO invoke method?
                        ]
                    )
                );

            var @delegate = DelegateDeclaration(
                    rawPfn.ParameterList.Parameters.Last().Type,
                    Identifier(delegateName)
                )
                .WithModifiers(
                    TokenList(Token(SyntaxKind.PublicKeyword), Token(SyntaxKind.UnsafeKeyword))
                )
                .WithAttributeLists(delegateAttrLists)
                .WithParameterList(
                    ParameterList(
                        SeparatedList(
                            rawPfn
                                .ParameterList.Parameters.SkipLast(1)
                                .Select(
                                    (y, i) =>
                                        Parameter(
                                            y.AttributeLists,
                                            y.Modifiers,
                                            y.Type,
                                            Identifier($"arg{i}"),
                                            null
                                        )
                                )
                        )
                    )
                );
            return (pfn, @delegate);
        }

        [GeneratedRegex(
            @"^((?:[A-Za-z0-9\s\*_]|\[[0-9]*\])+)\((\*)+\)\(((?:(?:[A-Za-z0-9\s\*_]|\[[0-9]*\])+,?)*)\)"
        )]
        private partial Regex FunctionPointerNativeTypeNameRegex();
    }
}
