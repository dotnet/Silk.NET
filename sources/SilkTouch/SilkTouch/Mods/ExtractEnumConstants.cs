// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Moves enum constants into their respective enums.
/// These constants are identified by checking for an enum with
/// a matching prefix, as identified by the enum's <see cref="NativeTypeNameAttribute"/>.
/// This accounts for the below pattern seen frequently pre-C99:
/// <code>
/// typedef unsigned int MyEnum;
/// #define MY_ENUM_HELLO 0
/// extern MyEnum GetMyEnum();
/// </code>
/// </summary>
public class ExtractEnumConstants : IMod
{
    /// <inheritdoc />
    public async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        var project = ctx.SourceProject;
        if (project == null)
        {
            return;
        }

        // First pass to gather data, such as the types to extract and generate
        var walker = new Walker();
        foreach (var doc in project.Documents)
        {
            var file = doc.RelativePath();
            if (file is null)
            {
                continue;
            }

            var node = await doc.GetSyntaxRootAsync(ct);
            walker.File = file;
            walker.Visit(node);
        }

        var rewriter = new Rewriter();
        var (enums, constants) = walker.GetExtractedEnums();
        rewriter.ConstantsToRemove = constants;
        rewriter.ExtractedEnums = enums.Keys;
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

            project = doc.WithSyntaxRoot(
                rewriter.Visit(await doc.GetSyntaxRootAsync(ct))
                    ?? throw new InvalidOperationException("Visit returned null.")
            ).Project;
        }

        var newEnums = enums.Select(x =>
            (
                (MemberDeclarationSyntax)x.Value.Item1,
                x.Value.Item1.Identifier.ToString(),
                x.Value.Item2,
                x.Value.Item3
            )
        );

        foreach (var (typeDecl, identifier, fileDirs, namespaces) in newEnums)
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
                    // Place extracted enum types in the directory common to where the types are referenced from
                    filePath: project.FullPath($"{dir}/{identifier}.gen.cs")
                )
                .Project;
        }

        ctx.SourceProject = project;
    }

    private static ReadOnlySpan<char> GetNativeTypeNameForPredefinedType(PredefinedTypeSyntax node)
    {
        // Walk up to the parameter or method. We only allow primitive integer types right now.
        var current = node.Parent;
        var indirectionLevels = 0;
        while (current is PointerTypeSyntax)
        {
            indirectionLevels++;
            current = current.Parent;
        }

        var attrs = current switch
        {
            MethodDeclarationSyntax meth => meth.AttributeLists,
            ParameterSyntax param => param.AttributeLists,
            _ => default,
        };

        if (attrs.Count == 0)
        {
            return default;
        }

        if (!attrs.TryParseNativeTypeName(out var info))
        {
            return null;
        }

        // Ensure that the indirection levels indicated by the type name is the same as we've encountered when walking
        // up the type. If this isn't, this indicates that the native type name is a typedef to a pointer and shouldn't
        // be something that is mapped into an enum.
        if (info.IndirectionLevels == indirectionLevels)
        {
            return info.Name;
        }

        return null;
    }

    private class Walker : CSharpSyntaxRewriter
    {
        private readonly Dictionary<
            string,
            (
                SyntaxKind Type,
                HashSet<string> ReferencingFileDirs,
                HashSet<string> ReferencingNamespaces
            )?
        > _numericTypeNames = new();

        /// <summary>
        /// Tracks the name and value of constants discovered.
        /// </summary>
        private readonly Dictionary<string, ExpressionSyntax> _constants = [];

        public string? File { get; set; }

        public override SyntaxNode? VisitPredefinedType(PredefinedTypeSyntax node)
        {
            var nativeTypeName = GetNativeTypeNameForPredefinedType(node).ToString();
            if (nativeTypeName.Length > 0)
            {
                // Detect type discrepancies.
                var thisType = node.Keyword.Kind();
                if (!_numericTypeNames.TryGetValue(nativeTypeName, out var numericTypeName))
                {
                    _numericTypeNames[nativeTypeName] = numericTypeName = (thisType, [], []);
                }

                if (
                    thisType
                        is not (
                            SyntaxKind.ByteKeyword
                            or SyntaxKind.SByteKeyword
                            or SyntaxKind.ShortKeyword
                            or SyntaxKind.UShortKeyword
                            or SyntaxKind.IntKeyword
                            or SyntaxKind.UIntKeyword
                            or SyntaxKind.LongKeyword
                            or SyntaxKind.ULongKeyword
                        )
                    || thisType != numericTypeName?.Type
                )
                {
                    _numericTypeNames[nativeTypeName] = numericTypeName = null;
                }

                if (numericTypeName is { } theTypeDetails)
                {
                    theTypeDetails.ReferencingNamespaces.Add(node.NamespaceFromSyntaxNode());
                    if (File?[..File.LastIndexOf('/')] is { } dir)
                    {
                        theTypeDetails.ReferencingFileDirs.Add(dir);
                    }
                }
            }

            return base.VisitPredefinedType(node);
        }

        // This code can probably be better.
        public (
            Dictionary<
                string,
                (EnumDeclarationSyntax, HashSet<string>, HashSet<string>)
            > ExtractedEnums,
            HashSet<string> ExtractedConstants
        ) GetExtractedEnums()
        {
            var ineligibleConstants = new HashSet<string>();
            var extractedConstants = new HashSet<string>();
            var extractedEnums = new Dictionary<
                string,
                (EnumDeclarationSyntax, HashSet<string>, HashSet<string>)
            >(_numericTypeNames.Count);

            // Try and find constants for each of the enums we've found.
            // We do this in descending length order to ensure that we find the longest match for constant names to enum
            // names.
            foreach (
                var (enumName, enumType) in _numericTypeNames.OrderByDescending(x => x.Key.Length)
            )
            {
                var enumTrimmingName = NameSplitter.Underscore(enumName);
                (EnumDeclarationSyntax, HashSet<string>, HashSet<string>)? extractedEnum = enumType
                    is { } theType
                    ? (
                        EnumDeclaration(enumName)
                            .AddBaseListTypes(SimpleBaseType(PredefinedType(Token(theType.Type))))
                            .AddModifiers(Token(SyntaxKind.PublicKeyword)),
                        theType.ReferencingFileDirs,
                        theType.ReferencingNamespaces
                    )
                    : null;

                // Look through all of the constants and see whether they start with our enum name.
                foreach (var (constant, value) in _constants)
                {
                    // We want to account for PascalCase vs SCREAMING_SNAKE_CASE differences (for example) so we do
                    // four passes (for each combination of the original name vs trimming name, the latter of which
                    // taking casing into account). It is possible that this could be expanded, but this should be done
                    // carefully to ensure we don't light up prematurely.
                    var nextConst = false;
                    var trimmingName = NameSplitter.Underscore(constant);
                    foreach (
                        var enumCandidate in (ReadOnlySpan<string>)[enumName, enumTrimmingName]
                    )
                    {
                        foreach (
                            var constCandidate in (ReadOnlySpan<string>)[constant, trimmingName]
                        )
                        {
                            // Make sure the constant name starts with the enum name, and that there is clearly a word
                            // gap after the enum name in the constant name e.g. API_BlendOp doesn't pull in
                            // API_BLEND_OPAQUE but it does pull in API_BLEND_OP_ADD (or API_BLENDOP_ADD).
                            // I wouldn't feel safe relaxing this right now, despite there being obvious use cases.
                            // Perhaps as a future improvement we can try to walk back the enum's trimming name, check
                            // that there are no other enums that conflict with that shorter trimming name, and then try
                            // to widen the scope. So for example, if we have found nothing for API_BlendOp then we'd
                            // just try API_Blend (provided there's no API_BlendFactor, API_Blend, or any other
                            // conflicts) which would then sweep up API_BLEND_OPAQUE. We'd then keep the original enum
                            // names to stay in-keeping with the native API. TODO investigate this
                            if (
                                !constCandidate.StartsWith(
                                    enumCandidate,
                                    StringComparison.OrdinalIgnoreCase
                                )
                                || (
                                    constCandidate[enumCandidate.Length] != '_'
                                    && char.IsUpper(constCandidate[enumCandidate.Length - 1])
                                        == char.IsUpper(constCandidate[enumCandidate.Length])
                                )
                            )
                            {
                                continue;
                            }

                            // We don't generate enums that have had inconsistent usage (e.g. int vs short vs long) but
                            // if we are able to map constants into those enums, we still want to ensure we don't go and
                            // map it to a less relevant enum as a result. So we add the constant to a separate HashSet,
                            // with which we remove the constant from the _constants dictionary but don't return it to
                            // the Rewriter, ensuring it is not removed (at is has not been mapped to an eligible enum).
                            (enumType is null ? ineligibleConstants : extractedConstants).Add(
                                constant
                            );
                            nextConst = true;
                            if (extractedEnum is not { } theExtractedEnum)
                            {
                                break;
                            }

                            theExtractedEnum.Item1 = theExtractedEnum.Item1.AddMembers(
                                EnumMemberDeclaration(constant)
                                    .WithEqualsValue(EqualsValueClause(value))
                            );
                            extractedEnum = theExtractedEnum;
                            break;
                        }

                        if (nextConst)
                        {
                            break;
                        }
                    }
                }

                // Remove the constants that we've mapped into enums
                foreach (
                    var constant in (IEnumerable<string>)
                        [.. ineligibleConstants, .. extractedConstants]
                )
                {
                    _constants.Remove(constant);
                }

                ineligibleConstants.Clear();
                if (extractedEnum is { Item1.Members.Count: > 0 })
                {
                    extractedEnums[enumName] = extractedEnum.Value;
                }
            }

            return (extractedEnums, extractedConstants);
        }

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (node.Modifiers.Any(SyntaxKind.ConstKeyword))
            {
                foreach (var vardec in node.Declaration.Variables)
                {
                    if (vardec.Initializer is null)
                    {
                        continue;
                    }

                    _constants.Add(vardec.Identifier.ToString(), vardec.Initializer.Value);
                }
            }
            return base.VisitFieldDeclaration(node);
        }
    }

    private class Rewriter : CSharpSyntaxRewriter
    {
        public IReadOnlyCollection<string>? ConstantsToRemove { get; set; }
        public IReadOnlyCollection<string>? ExtractedEnums { get; set; }

        public override SyntaxNode? VisitPredefinedType(PredefinedTypeSyntax node)
        {
            var nativeTypeName = GetNativeTypeNameForPredefinedType(node).ToString();
            if (ExtractedEnums?.Contains(nativeTypeName) ?? false)
            {
                return IdentifierName(nativeTypeName).WithTriviaFrom(node);
            }

            return base.VisitPredefinedType(node);
        }

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            var ret = base.VisitFieldDeclaration(node) as FieldDeclarationSyntax;
            return ret?.Declaration.Variables.Count == 0 ? null : ret;
        }

        public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (ConstantsToRemove?.Contains(node.Identifier.ToString()) ?? false)
            {
                return null;
            }
            return base.VisitVariableDeclarator(node);
        }
    }
}
