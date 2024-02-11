using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// A mod that will convert other naming conventions to the PascalCase nomenclature typically used in C#.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="config">Configuration snapshot.</param>
/// <param name="trimmerProviders">Name trimmer providers.</param>
[ModConfiguration<Configuration>]
public class PrettifyNames(
    ILogger<PrettifyNames> logger,
    IOptionsSnapshot<PrettifyNames.Configuration> config,
    IEnumerable<IJobDependency<INameTrimmer>> trimmerProviders
) : IMod
{
    /// <summary>
    /// The configuration for the prettify names mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// Corrections to the automatic prefix determination.
        /// </summary>
        public Dictionary<string, string>? PrefixOverrides { get; init; }

        /// <summary>
        /// The base trimmer version. If null, trimming is disabled.
        /// </summary>
        public Version? TrimmerBaseline { get; init; } = new(3, 0);

        /// <summary>
        /// The maximum length of an all capitals string to be treated as a single acronym, rather than as an all
        /// capitals word.
        /// </summary>
        public int? LongAcronymThreshold { get; init; }

        /// <summary>
        /// A hint for a "global prefix".
        /// </summary>
        public string? GlobalPrefixHint { get; init; }
    }

    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var visitor = new Visitor();
        foreach (var (_, node) in syntax.Files.Where(x => x.Key.StartsWith("sources/")))
        {
            visitor.Visit(node);
        }

        var rewriter = new Rewriter();
        var cfg = config.Get(key);
        var translator = new NameUtils.NameTransformer(cfg.LongAcronymThreshold ?? 3);
        if (cfg.TrimmerBaseline is not null)
        {
            var trimmers = trimmerProviders
                .SelectMany(x => x.Get(key))
                .OrderBy(x => x.Version)
                .ToArray();
            var typeNames = visitor.Types.ToDictionary(
                x => x.Key,
                x => (x.Key, (List<string>?)null)
            );
            if (typeNames.Count > 1 || cfg.GlobalPrefixHint is not null)
            {
                Trim(null, cfg.GlobalPrefixHint, key, typeNames, cfg.PrefixOverrides, trimmers);
            }

            foreach (var (typeName, (newTypeName, _)) in typeNames)
            {
                var (_, (consts, functions)) = visitor.Types.First(x => x.Key == typeName);
                var constNames = consts?.ToDictionary(
                    x => x,
                    x => (Primary: x, (List<string>?)null)
                );
                if (constNames is not null)
                {
                    Trim(
                        typeName,
                        cfg.GlobalPrefixHint,
                        key,
                        constNames,
                        cfg.PrefixOverrides,
                        trimmers
                    );
                }
                else
                {
                    constNames = new Dictionary<string, (string Primary, List<string>?)>();
                }

                var functionNames = functions?.ToDictionary(
                    x => x.Name,
                    x => (Primary: x.Name, (List<string>?)null)
                );
                var functionSyntax = functions?.ToDictionary(x => x.Name, x => x.Syntax);
                if (functionNames is not null)
                {
                    Trim(
                        typeName,
                        cfg.GlobalPrefixHint,
                        key,
                        functionNames,
                        cfg.PrefixOverrides,
                        trimmers,
                        functionSyntax
                    );
                }

                var prettifiedOnly = visitor.PrettifyOnlyTypes.TryGetValue(typeName, out var val)
                    ? val.Select(x => new KeyValuePair<string, (string Primary, List<string>?)>(
                        x,
                        (x, null)
                    ))
                    : Enumerable.Empty<KeyValuePair<string, (string Primary, List<string>?)>>();

                rewriter.Types[typeName] = (
                    newTypeName.Prettify(translator),
                    // TODO deprecate secondaries if they're within the baseline?
                    constNames
                        .Concat(prettifiedOnly)
                        .ToDictionary(x => x.Key, x => x.Value.Primary.Prettify(translator)),
                    functionNames?.ToDictionary(x => x.Key, x => x.Value.Primary.Prettify(translator))
                );
            }
        }
        else
        {
            foreach (var (name, (nonFunctions, functions)) in visitor.Types)
            {
                rewriter.Types[name] = (
                    name.Prettify(translator),
                    nonFunctions?.ToDictionary(x => x, x => x.Prettify(translator)),
                    functions?.ToDictionary(x => x.Name, x => x.Name.Prettify(translator))
                );
            }
        }

        foreach (var (name, (newName, nonFunctions, functions)) in rewriter.Types)
        {
            logger.LogDebug("{} = {}", name, newName);
            foreach (var (old, @new) in nonFunctions ?? new())
            {
                logger.LogDebug("{}.{} = {}.{}", name, old, newName, @new);
            }
            foreach (var (old, @new) in functions ?? new())
            {
                logger.LogDebug("{}.{} = {}.{}", name, old, newName, @new);
            }
        }

        return Task.FromResult(
            syntax with
            {
                Files = syntax
                    .Files.Select(x =>
                        (
                            x.Key.EndsWith(".gen.cs")
                            && rewriter.Types.TryGetValue(
                                x.Key[(x.Key.LastIndexOf('/') + 1)..^7],
                                out var info
                            )
                                ? $"{x.Key[..(x.Key.LastIndexOf('/') + 1)]}{info.NewName}.gen.cs"
                                : x.Key,
                            rewriter.Visit(x.Value)
                        )
                    )
                    .ToDictionary(x => x.Item1, x => x.Item2)
            }
        );
    }

    private void Trim(
        string? container,
        string? globalPrefixHint,
        string? key,
        Dictionary<string, (string Primary, List<string>? Secondary)> names,
        Dictionary<string, string>? prefixOverrides,
        IEnumerable<INameTrimmer> trimmers,
        Dictionary<string, MethodDeclarationSyntax>? functionSyntax = null
    )
    {
        // Run each trimmer
        string? identifiedPrefix = null;
        foreach (var trimmer in trimmers)
        {
            trimmer.Trim(
                container,
                globalPrefixHint,
                key,
                names,
                prefixOverrides,
                ref identifiedPrefix
            );
        }

        // Prefer shorter names
        foreach (var (trimmingName, (primary, secondary)) in names)
        {
            names[trimmingName] = (primary, secondary?.OrderByDescending(x => x.Length).ToList());
        }

        // Unwind some names back to their secondary names if the primaries would duplicate
        var primaries = new HashSet<string>();
        var discrims = new HashSet<string>(); // <-- some conflicts are okay
        foreach (var (trimmingName, (ogPrimary, secondary)) in names)
        {
            var primary = ogPrimary;
            // Get the discriminator string to account for overloads of the same function
            var discrim = functionSyntax?[trimmingName] is { } meth
                ? ModUtils.DiscrimStr(
                    meth.Modifiers,
                    meth.TypeParameterList,
                    primary,
                    meth.ParameterList,
                    meth.ReturnType
                )
                : null;
            // If we contain the current proposed name and there is either no discriminant (i.e. no reoccurrences of the
            // same name allowed) or the discriminant has been seen before...
            while (primaries.Contains(primary) && (discrim is null || discrims.Contains(discrim)))
            {
                // Remove the occurence
                primaries.Remove(primary);
                if (discrim is not null)
                {
                    discrims.Remove(discrim);
                }

                // If there's no secondary, this is an involuntary conflict where the trimmed version of a separate
                // function happens to be the same as this function's untrimmed name.
                // "Am I out of touch? No it's the children that are wrong!"
                var nextPrimary = secondary?.LastOrDefault() ?? primary;
                if (secondary is { Count: > 0 })
                {
                    secondary.RemoveAt(secondary.Count - 1);
                }

                // Let's attempt to resolve any conflicts.
                string? notRenamedConflict = null;
                foreach (
                    var (
                        conflictingTrimmingName,
                        (conflictingPrimary, conflictingSecondary)
                    ) in names
                )
                {
                    // Micro-opt: do the checks we can ahead of creating the DiscrimStr which isn't the cheapest thing
                    // in the world
                    if (conflictingTrimmingName == trimmingName || conflictingPrimary != primary)
                    {
                        // This is us, we will always conflict with ourselves (or the primary names don't conflict)
                        continue;
                    }
                    var conflictingDiscrim = functionSyntax?[conflictingTrimmingName] is { } cMeth
                        ? ModUtils.DiscrimStr(
                            cMeth.Modifiers,
                            cMeth.TypeParameterList,
                            conflictingPrimary,
                            cMeth.ParameterList,
                            cMeth.ReturnType
                        )
                        : null;
                    if (conflictingDiscrim != discrim)
                    {
                        // The conflict is benign because the members are different enough to be differentiated by the
                        // C# compiler (i.e. it's an overload of a function)
                        continue;
                    }

                    // If we don't have precedence (i.e. it's obvious that it's us that should have the shorter name),
                    // do we have another name for the conflict?
                    if (
                        conflictingTrimmingName.Length > trimmingName.Length
                        && conflictingSecondary?.LastOrDefault() is { } resolvedConflict
                    )
                    {
                        // Rename the conflicting entry so that we can take precedence.
                        names[conflictingTrimmingName] = (resolvedConflict, conflictingSecondary);
                        conflictingSecondary.RemoveAt(conflictingSecondary.Count - 1);
                        primaries.Add(resolvedConflict);
                        if (
                            conflictingDiscrim is not null
                            && functionSyntax?[conflictingTrimmingName] is { } nMeth
                        )
                        {
                            discrims.Add(
                                ModUtils.DiscrimStr(
                                    nMeth.Modifiers,
                                    nMeth.TypeParameterList,
                                    resolvedConflict,
                                    nMeth.ParameterList,
                                    nMeth.ReturnType
                                )
                            );
                        }

                        notRenamedConflict = null;
                    }
                    else
                    {
                        // They take precedence, and we'll try to use nextPrimary.
                        // We add the conflicting primary back because we removed it at the start of the outer loop.
                        primaries.Add(conflictingPrimary);
                        if (conflictingDiscrim is not null)
                        {
                            discrims.Add(conflictingDiscrim);
                        }

                        notRenamedConflict = conflictingTrimmingName;
                    }
                }

                // Retry but with our secondary name.
                if (notRenamedConflict is not null)
                {
                    if (primary == nextPrimary)
                    {
                        logger.LogError(
                            "Couldn't resolve conflict automatically: {} is used by both {} and {}",
                            primary,
                            trimmingName,
                            notRenamedConflict
                        );
                        break;
                    }
                    primary = nextPrimary;
                }
            }

            names[trimmingName] = (primary, secondary);
            primaries.Add(primary);
            if (discrim is not null && functionSyntax?[trimmingName] is { } fMeth)
            {
                discrims.Add(
                    ModUtils.DiscrimStr(
                        fMeth.Modifiers,
                        fMeth.TypeParameterList,
                        primary,
                        fMeth.ParameterList,
                        fMeth.ReturnType
                    )
                );
            }
        }
    }

    private class Visitor : CSharpSyntaxWalker
    {
        public Dictionary<
            string,
            (
                List<string>? NonFunctions,
                List<(string Name, MethodDeclarationSyntax Syntax)>? Functions
            )
        > Types = new();

        public Dictionary<string, List<string>> PrettifyOnlyTypes = new();
        private (
            ClassDeclarationSyntax Class,
            List<string> NonFunctions,
            List<(string Name, MethodDeclarationSyntax Syntax)> Functions
        )? _classInProgress;
        private (EnumDeclarationSyntax Enum, List<string> EnumMembers)? _enumInProgress;
        private FieldDeclarationSyntax? _visitingField = null;
        private bool _prettifyOnly;

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (
                _classInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                // ignoring nesting for now
                return;
            }

            _classInProgress = (
                node,
                new List<string>(),
                new List<(string, MethodDeclarationSyntax)>()
            );
            base.VisitClassDeclaration(node);
            var id = _classInProgress.Value.Class.Identifier.ToString();
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = (new List<string>(), new List<(string, MethodDeclarationSyntax)>());
                Types.Add(id, inner);
            }

            (inner.NonFunctions ??= new List<string>()).AddRange(
                _classInProgress.Value.NonFunctions
            );
            (inner.Functions ??= new List<(string, MethodDeclarationSyntax)>()).AddRange(
                _classInProgress.Value.Functions
            );
            _classInProgress = null;
        }

        public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (_visitingField is not null || _enumInProgress is not null)
            {
                return;
            }

            if (
                !node.Modifiers.Any(SyntaxKind.ConstKeyword)
                && (
                    !node.Modifiers.Any(SyntaxKind.StaticKeyword)
                    || !node.Modifiers.Any(SyntaxKind.ReadOnlyKeyword)
                )
            )
            {
                _prettifyOnly = true;
            }

            _visitingField = node;
            base.VisitFieldDeclaration(node);
            _prettifyOnly = false;
            _visitingField = null;
        }

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (node.Parent?.Parent != _visitingField)
            {
                return;
            }

            if (
                _prettifyOnly
                && node.Parent?.Parent?.Parent is BaseTypeDeclarationSyntax type
                && type.Parent?.FirstAncestorOrSelf<BaseTypeDeclarationSyntax>() is null
            )
            {
                var tiden = type.Identifier.ToString();
                if (!PrettifyOnlyTypes.TryGetValue(tiden, out var inner))
                {
                    inner = new List<string>();
                    PrettifyOnlyTypes.Add(tiden, inner);
                }

                var iden = node.Identifier.ToString();
                inner.Add(iden);
            }
            else if (_classInProgress is not null && !_prettifyOnly)
            {
                _classInProgress.Value.NonFunctions.Add(node.Identifier.ToString());
            }
        }

        public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (node.Parent == _classInProgress?.Class)
            {
                _classInProgress!.Value.Functions.Add((node.Identifier.ToString(), node));
            }
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (
                _classInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                return;
            }

            Types[node.Identifier.ToString()] = (null, null);
            base.VisitStructDeclaration(node);
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (
                _classInProgress is not null
                || _enumInProgress is not null
                || node.Ancestors().OfType<BaseTypeDeclarationSyntax>().Any()
            )
            {
                return;
            }

            _enumInProgress = (node, new List<string>());
            base.VisitEnumDeclaration(node);
            var id = _enumInProgress.Value.Enum.Identifier.ToString();
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = (new List<string>(), new List<(string, MethodDeclarationSyntax)>());
                Types.Add(id, inner);
            }

            (inner.NonFunctions ??= new List<string>()).AddRange(_enumInProgress.Value.EnumMembers);
            _enumInProgress = null;
        }
    }

    private class Rewriter : CSharpSyntaxRewriter
    {
        public Dictionary<
            string,
            (
                string NewName,
                Dictionary<string, string>? NonFunctions,
                Dictionary<string, string>? Functions
            )
        > Types = new();

        private (
            BaseTypeDeclarationSyntax Type,
            Dictionary<string, string>? NonFunctions,
            Dictionary<string, string>? Functions
        )? _typeInProgress;
        private FieldDeclarationSyntax? _memberInProgress;
        private bool _memberAccess;
        private bool _accessing;
        private bool _member;
        private string? _memberAccessType;
        private readonly List<FieldDeclarationSyntax> _constants = new();

        public override SyntaxNode? VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || !Types.TryGetValue(node.Identifier.ToString(), out var info)
            )
            {
                return base.VisitClassDeclaration(node);
            }

            _typeInProgress = (node, info.NonFunctions, info.Functions);
            var ret = (ClassDeclarationSyntax)base.VisitClassDeclaration(node)!;
            _typeInProgress = null;
            ret = ret.WithIdentifier(Identifier(info.NewName))
                .WithMembers(
                    List(
                        // Constants can be quite prone to conflicting with their functions e.g. consider
                        // GL_PROGRAM_STRING_ARB and glProgramStringARB, as such we relegate the ones that don't
                        // eventually end up in an enum to be in a subclass instead
                        SingletonList<MemberDeclarationSyntax>(
                                ClassDeclaration("Constants")
                                    .WithModifiers(
                                        TokenList(
                                            Token(SyntaxKind.PublicKeyword),
                                            Token(SyntaxKind.StaticKeyword),
                                            Token(SyntaxKind.PartialKeyword)
                                        )
                                    )
                                    .WithMembers(List<MemberDeclarationSyntax>(_constants))
                            )
                            .Concat(ret.Members)
                    )
                );
            _constants.Clear();
            return ret;
        }

        public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
        {
            if (
                _typeInProgress?.Functions is not null
                && _typeInProgress.Value.Functions.TryGetValue(
                    node.Identifier.ToString(),
                    out var newName
                )
            )
            {
                return ((MethodDeclarationSyntax)base.VisitMethodDeclaration(node)!)
                    .WithIdentifier(Identifier(newName))
                    .WithAttributeLists(
                        List(
                            node.AttributeLists.Select(x =>
                                x.WithAttributes(
                                    SeparatedList(
                                        x.Attributes.Select(y =>
                                            y.IsAttribute(
                                                "System.Runtime.InteropServices.DllImport"
                                            )
                                            && (
                                                y.ArgumentList?.Arguments.All(z =>
                                                    z.NameEquals?.Name.ToString() != "EntryPoint"
                                                ) ?? true
                                            )
                                                ? y.AddArgumentListArguments(
                                                    AttributeArgument(
                                                            LiteralExpression(
                                                                SyntaxKind.StringLiteralExpression,
                                                                Literal(node.Identifier.ToString())
                                                            )
                                                        )
                                                        .WithNameEquals(NameEquals("EntryPoint"))
                                                )
                                                : y
                                        )
                                    )
                                )
                            )
                        )
                    );
            }
            return base.VisitMethodDeclaration(node);
        }

        public override SyntaxNode? VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || !Types.TryGetValue(node.Identifier.ToString(), out var info)
            )
            {
                return base.VisitEnumDeclaration(node);
            }

            _typeInProgress = (node, info.NonFunctions, info.Functions);
            var ret = base.VisitEnumDeclaration(node);
            _typeInProgress = null;
            return ((EnumDeclarationSyntax)ret!).WithIdentifier(Identifier(info.NewName));
        }

        public override SyntaxNode? VisitEnumMemberDeclaration(EnumMemberDeclarationSyntax node)
        {
            if (
                _typeInProgress is null
                || !(
                    _typeInProgress.Value.NonFunctions?.TryGetValue(
                        node.Identifier.ToString(),
                        out var newName
                    ) ?? false
                )
            )
            {
                return node;
            }
            return node.WithIdentifier(Identifier(newName));
        }

        public override SyntaxNode? VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (
                _typeInProgress is not null
                || !Types.TryGetValue(node.Identifier.ToString(), out var info)
            )
            {
                return base.VisitStructDeclaration(node);
            }

            _typeInProgress = (node, info.NonFunctions, info.Functions);
            var ret = ((StructDeclarationSyntax)base.VisitStructDeclaration(node)!).WithIdentifier(
                Identifier(info.NewName)
            );
            _typeInProgress = null;
            return ret;
        }

        public override SyntaxNode? VisitFieldDeclaration(FieldDeclarationSyntax node)
        {
            if (_typeInProgress is not null && _memberInProgress is null)
            {
                _memberInProgress = node;
            }
            var ret = base.VisitFieldDeclaration(node);
            _memberInProgress = null;
            if (
                !node.Modifiers.Any(SyntaxKind.ConstKeyword)
                || _typeInProgress?.Type is not ClassDeclarationSyntax
            )
            {
                return ret;
            }

            _constants.Add((FieldDeclarationSyntax)ret!);
            return null;
        }

        public override SyntaxNode? VisitPropertyDeclaration(PropertyDeclarationSyntax node)
        {
            if (
                _typeInProgress?.NonFunctions is null
                || !_typeInProgress.Value.NonFunctions.TryGetValue(
                    node.Identifier.ToString(),
                    out var newName
                )
            )
            {
                return node;
            }
            return node.WithIdentifier(Identifier(newName));
        }

        public override SyntaxNode? VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (
                _typeInProgress?.NonFunctions is not null
                && _memberInProgress == node.Parent?.Parent
                && _typeInProgress.Value.NonFunctions.TryGetValue(
                    node.Identifier.ToString(),
                    out var newName
                )
            )
            {
                return node.WithIdentifier(Identifier(newName));
            }

            return node;
        }

        public override SyntaxNode? VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
        {
            _memberAccess = true;
            _accessing = true;
            Visit(node.Expression);
            _accessing = false;
            if (_memberAccessType is null || !Types.TryGetValue(_memberAccessType, out var info))
            {
                _memberAccess = false;
                return node;
            }

            var accessing = (ExpressionSyntax)Visit(node.Expression);
            _member = true;
            var member = (SimpleNameSyntax)Visit(node.Name);
            _member = false;
            var ret = node.Update(accessing, VisitToken(node.OperatorToken), member);
            _memberAccess = false;
            _memberAccessType = null;
            return ret;
        }

        public override SyntaxNode? VisitIdentifierName(IdentifierNameSyntax node)
        {
            if (_memberAccess)
            {
                if (_accessing) // getting the last identifier in the thing we're accessing
                {
                    _memberAccessType = node.Identifier.ToString();
                    return node;
                }

                if (_member) // change name of the member we're accessing
                {
                    if (!Types.TryGetValue(_memberAccessType!, out var info))
                    {
                        return base.VisitIdentifierName(node);
                    }

                    if (
                        info.NonFunctions?.TryGetValue(node.Identifier.ToString(), out var cName)
                        ?? false
                    )
                    {
                        return IdentifierName(cName);
                    }

                    if (
                        info.Functions?.TryGetValue(node.Identifier.ToString(), out var fName)
                        ?? false
                    )
                    {
                        return IdentifierName(fName);
                    }
                }
                else // changing name of the thing we're accessing
                {
                    var str = node.Identifier.ToString();
                    if (str == _memberAccessType)
                    {
                        return IdentifierName(Types[str].NewName);
                    }
                }
            }
            else if (
                _typeInProgress?.Functions is not null
                && _typeInProgress.Value.Functions.TryGetValue(
                    node.Identifier.ToString(),
                    out var fName
                )
            )
            {
                return IdentifierName(fName);
            }
            else if (
                _typeInProgress?.NonFunctions is not null
                && _typeInProgress.Value.NonFunctions.TryGetValue(
                    node.Identifier.ToString(),
                    out var cName
                )
            )
            {
                return IdentifierName(cName);
            }
            else if (Types.TryGetValue(node.Identifier.ToString(), out var info))
            {
                return IdentifierName(info.NewName);
            }
            return base.VisitIdentifierName(node);
        }
    }
}
