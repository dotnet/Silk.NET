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
/// A mod that extracts type system information nested within other types. This currently includes:
/// <list type="bullet">
/// <item><description>
/// Replacing function pointers identified by their <see cref="NativeTypeNameAttribute"/>s with delegates and
/// <c>Pfn</c>-prefixed structures.
/// </description></item>
/// <item><description>
/// Moving constants into their respective enums. These constants are identified by checking for an enum with
/// a matching prefix, as identified by the enum's <see cref="NativeTypeNameAttribute"/>.
/// This accounts for the below pattern seen frequently pre-C99:
/// <code>
/// typedef unsigned int MyEnum;
/// #define MY_ENUM_HELLO 0
/// extern MyEnum GetMyEnum();
/// </code>
/// </description></item>
/// <item><description>
/// Extracting fixed buffers and anonymous structures contained within structures into separate types.
/// </description></item>
/// </list>
/// </summary>
public partial class ExtractNestedTyping(ILogger<ExtractNestedTyping> logger) : Mod
{
    /// <inheritdoc />
    public override async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        await base.ExecuteAsync(ctx, ct);

        var project = ctx.SourceProject;
        if (project == null)
        {
            return;
        }

        var compilation = await project.GetCompilationAsync(ct);
        if (compilation == null)
        {
            throw new InvalidOperationException("Failed to get compilation");
        }

        // First pass to gather data, such as the types to extract and generate
        var walker = new Walker();
        foreach (var doc in ctx.SourceProject?.Documents ?? [])
        {
            var (fname, node) = (doc.RelativePath(), await doc.GetSyntaxRootAsync(ct));
            if (fname is null)
            {
                continue;
            }

            walker.File = fname;
            walker.Visit(node);
        }

        // Second pass to modify existing files as per our discovery.
        var rewriter = new Rewriter(logger);
        // rewriter.FunctionPointerTypes = walker.GetFunctionPointerTypes();
        var (enums, constants) = walker.GetExtractedEnums();
        rewriter.ConstantsToRemove = constants;
        rewriter.ExtractedEnums = enums.Keys;
        foreach (var docId in ctx.SourceProject?.DocumentIds ?? [])
        {
            var doc =
                project.GetDocument(docId) ?? throw new InvalidOperationException("Document missing");
            var (fname, node) = (doc.RelativePath(), await doc.GetSyntaxRootAsync(ct));
            if (fname is null)
            {
                continue;
            }

            // Rewrite node
            // What this does depends on the node's type
            //
            // For example:
            // This will handle removing nested structs.
            // This is also where extracted enums are processed.
            rewriter.File = fname;
            project = doc.WithSyntaxRoot(
                rewriter.Visit(node)?.NormalizeWhitespace()
                    ?? throw new InvalidOperationException("Rewriter returned null")
            ).Project;

            foreach (var newStruct in rewriter.ExtractedNestedStructs)
            {
                // Add new documents for each nested struct
                 project = project.AddDocument(
                    $"{newStruct.Identifier}.gen.cs",
                    CompilationUnit()
                        .WithMembers(
                            rewriter.Namespace is not null
                                ? SingletonList<MemberDeclarationSyntax>(
                                    FileScopedNamespaceDeclaration(
                                            ModUtils.NamespaceIntoIdentifierName(rewriter.Namespace)
                                        )
                                        .WithMembers(
                                            SingletonList<MemberDeclarationSyntax>(newStruct)
                                        )
                                )
                                : SingletonList<MemberDeclarationSyntax>(newStruct)
                        )
                        .NormalizeWhitespace(),
                    filePath: project.FullPath(
                        $"{fname.AsSpan()[..fname.LastIndexOf('/')]}/{newStruct.Identifier}.gen.cs"
                    )
                ).Project;
            }

            rewriter.File = null;
            rewriter.Namespace = null;
            rewriter.ExtractedNestedStructs.Clear();
        }

        // Add documents for each extracted function pointer
        // This is moved out of the foreach statement for better debuggability
        var extractedFunctionPointers = rewriter
            .FunctionPointerTypes.Values //.Where(x => x.IsUnique)
            .SelectMany(x =>
                (IEnumerable<(
                    MemberDeclarationSyntax,
                    string,
                    HashSet<string>,
                    HashSet<string>
                    )>) [
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
            .Concat(
                enums.Select(x =>
                    (
                        (MemberDeclarationSyntax)x.Value.Item1,
                        x.Value.Item1.Identifier.ToString(),
                        x.Value.Item2,
                        x.Value.Item3
                    )
                )
            ).ToList();

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
                        )
                        .NormalizeWhitespace(),
                    filePath: project.FullPath($"{dir}/{identifier}.gen.cs")
                )
                .Project;
        }

        ctx.SourceProject = project;
    }

    private static ReadOnlySpan<char> GetNativeTypeNameForPredefinedType(
        PredefinedTypeSyntax node,
        Dictionary<string, (SyntaxKind, HashSet<string>, HashSet<string>)?>? numericTypeNames = null
    )
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

        var ret = attrs.GetNativeElementTypeName(out var readIndirectionLevels);

        // Ensure that the indirection levels indicated by the type name is the same as we've encountered when walking
        // up the type. If this isn't, this indicates that the native type name is a typedef to a pointer and shouldn't
        // be something that is mapped into an enum.
        if (ret is null || readIndirectionLevels == indirectionLevels)
        {
            return ret;
        }

        InvalidateIfSeen(numericTypeNames, ret);
        return null;
    }

    private static void InvalidateIfSeen(
        Dictionary<string, (SyntaxKind, HashSet<string>, HashSet<string>)?>? numericTypeNames,
        string nativeTypeName
    )
    {
        if (numericTypeNames?.ContainsKey(nativeTypeName) ?? false)
        {
            numericTypeNames[nativeTypeName] = null;
        }
    }

    partial class Rewriter(ILogger logger) : CSharpSyntaxRewriter
    {
        private Dictionary<string, string> _typeRenames = [];

        public List<StructDeclarationSyntax> ExtractedNestedStructs { get; } = [];

        public Dictionary<
            string,
            (
                StructDeclarationSyntax Pfn,
                DelegateDeclarationSyntax Delegate,
                HashSet<string> ReferencingFileDirs,
                HashSet<string> ReferencingNamespaces
            )
        > FunctionPointerTypes { get; set; } = [];

        public IReadOnlyCollection<string>? ConstantsToRemove { get; set; }

        public IReadOnlyCollection<string>? ExtractedEnums { get; set; }

        public string? Namespace { get; set; }
        public string? File { get; set; }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node) =>
            base.VisitIdentifierName(
                _typeRenames.TryGetValue(node.Identifier.ToString(), out var v)
                || (
                    v =
                        FunctionPointerTypes?.TryGetValue(node.Identifier.ToString(), out var pfni)
                        ?? false
                            ? pfni.Pfn.Identifier.ToString()
                            : null
                )
                    is not null
                    ? node.WithIdentifier(Identifier(v))
                    : node
            );

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

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            // Extract nested structs
            // This will do two things:
            // 1. Remove the nested struct(s) from the original struct
            // 2. Add them to the ExtractedNestedStructs list to be processed later
            var nextExtractedNestedIdx = ExtractedNestedStructs.Count;
            var members = node.Members;
            for (var i = 0; i < members.Count; i++)
            {
                var mem = members[i];
                if (
                    mem is not StructDeclarationSyntax struc
                    || GeneratedNestedTypeRegex().Match(struc.Identifier.ToString())
                        is not { Success: true, Groups.Count: 3 } match
                )
                {
                    continue;
                }

                var iden = $"{node.Identifier}_{match.Groups[1].Value}";
                _typeRenames[struc.Identifier.ToString()] = iden;
                struc =
                    VisitStructDeclaration(struc.WithIdentifier(Identifier(iden)))
                        as StructDeclarationSyntax
                    ?? struc;
                ExtractedNestedStructs.Add(struc);
                members = members.RemoveAt(i--);
            }

            var ret = base.VisitStructDeclaration(node.WithMembers(members));
            for (var i = nextExtractedNestedIdx; i < ExtractedNestedStructs.Count; i++)
            {
                if (
                    _typeRenames
                        .FirstOrDefault(x =>
                            x.Value == ExtractedNestedStructs[i].Identifier.ToString()
                        )
                        .Key
                    is not { } key
                )
                {
                    continue;
                }
                _typeRenames.Remove(key);
            }

            Namespace = node.NamespaceFromSyntaxNode();
            return ret;
        }

        private string? _typeNameFromOuterFunctionPointer;
        private string? _fallbackFromOuterFunctionPointer;

        public override SyntaxNode? VisitFunctionPointerType(FunctionPointerTypeSyntax node)
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
                    currentNativeTypeName == fallback
                        ? SingletonList(
                            AttributeList(
                                SingletonSeparatedList(Attribute(IdentifierName("Transformed")))
                            )
                        )
                        : default,
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

        [GeneratedRegex("^_([a-zA-Z0-9_]*)_e__(Union|Struct|FixedBuffer)$")]
        private partial Regex GeneratedNestedTypeRegex();

        [GeneratedRegex(
            @"^((?:[A-Za-z0-9\s\*_]|\[[0-9]*\])+)\((\*)+\)\(((?:(?:[A-Za-z0-9\s\*_]|\[[0-9]*\])+,?)*)\)"
        )]
        private partial Regex FunctionPointerNativeTypeNameRegex();
    }

    class Walker : CSharpSyntaxRewriter
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

        private readonly NameTrimmer _nameTrimmer = new();

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
                var enumTrimmingName = _nameTrimmer.GetTrimmingName(null, enumName, true);
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
                    var trimmingName = _nameTrimmer.GetTrimmingName(null, constant, false);
                    foreach (var enumCandidate in (IEnumerable<string>)[enumName, enumTrimmingName])
                    {
                        foreach (
                            var constCandidate in (IEnumerable<string>)[constant, trimmingName]
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

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            InvalidateIfSeen(_numericTypeNames, node.Identifier.ToString());
            return base.VisitEnumDeclaration(node);
        }
    }

    private static (
        StructDeclarationSyntax Pfn,
        DelegateDeclarationSyntax Delegate
    ) CreateFunctionPointerTypes(
        string pfnName,
        string delegateName,
        SyntaxList<AttributeListSyntax> attrLists,
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
            .WithAttributeLists(attrLists)
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
                        MethodDeclaration(PredefinedType(Token(SyntaxKind.VoidKeyword)), "Dispose")
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
                                            SingletonSeparatedList(Argument(IdentifierName("pfn")))
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
            .WithAttributeLists(attrLists)
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
}
