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
using SilkTouchX.Clang;
using SilkTouchX.Naming;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace SilkTouchX.Mods;

/// <summary>
/// A mod that will convert other naming conventions to the PascalCase nomenclature typically used in C#.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="config">Configuration snapshot.</param>
/// <param name="trimmers">Name trimmers.</param>
/// <param name="otherMods">Other mods present in the generator.</param>
/// <param name="jobConfig">The general job configuration.</param>
[ModConfiguration<Configuration>]
public class PrettifyNames(
    ILogger<PrettifyNames> logger,
    IOptionsSnapshot<PrettifyNames.Configuration> config,
    IEnumerable<INameTrimmer> trimmers,
    IEnumerable<IMod> otherMods,
    IOptionsSnapshot<SilkTouchConfiguration> jobConfig
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
        if (cfg.TrimmerBaseline is not null)
        {
            var typeNames = visitor.Types.ToDictionary(
                x => x.Key,
                x => (x.Key, (List<string>?)null)
            );
            if (typeNames.Count > 1 || cfg.GlobalPrefixHint is not null)
            {
                foreach (
                    var trimmer in (
                        jobConfig.Value.Mods
                            ?.Select(x => otherMods.First(y => y.GetType().Name == x))
                            .OfType<INameTrimmer>() ?? Enumerable.Empty<INameTrimmer>()
                    ).Concat(
                        trimmers
                            .Where(x => x.Version >= cfg.TrimmerBaseline)
                            .OrderBy(x => x.Version)
                    )
                )
                {
                    trimmer.Trim(null, cfg.GlobalPrefixHint, typeNames, cfg.PrefixOverrides);
                }
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
                    foreach (
                        var trimmer in trimmers
                            .Where(x => x.Version >= cfg.TrimmerBaseline)
                            .OrderBy(x => x.Version)
                    )
                    {
                        trimmer.Trim(
                            typeName,
                            cfg.GlobalPrefixHint,
                            constNames,
                            cfg.PrefixOverrides
                        );
                    }
                }
                else
                {
                    constNames = new Dictionary<string, (string Primary, List<string>?)>();
                }

                var functionNames = functions?.ToDictionary(
                    x => x,
                    x => (Primary: x, (List<string>?)null)
                );
                if (functionNames is not null)
                {
                    foreach (
                        var trimmer in trimmers
                            .Where(x => x.Version >= cfg.TrimmerBaseline)
                            .OrderBy(x => x.Version)
                    )
                    {
                        trimmer.Trim(
                            typeName,
                            cfg.GlobalPrefixHint,
                            functionNames,
                            cfg.PrefixOverrides
                        );
                    }
                }

                var prettifiedOnly = visitor.PrettifyOnlyTypes.TryGetValue(typeName, out var val)
                    ? val.Select(
                        x => new KeyValuePair<string, (string Primary, List<string>?)>(x, (x, null))
                    )
                    : Enumerable.Empty<KeyValuePair<string, (string Primary, List<string>?)>>();

                rewriter.Types[typeName] = (
                    newTypeName.Prettify(),
                    // TODO handle secondaries?
                    constNames
                        .Concat(prettifiedOnly)
                        .ToDictionary(x => x.Key, x => x.Value.Primary.Prettify()),
                    functionNames?.ToDictionary(x => x.Key, x => x.Value.Primary.Prettify())
                );
            }
        }
        else
        {
            foreach (var (name, (nonFunctions, functions)) in visitor.Types)
            {
                rewriter.Types[name] = (
                    name.Prettify(),
                    nonFunctions?.ToDictionary(x => x, x => x.Prettify()),
                    functions?.ToDictionary(x => x, x => x.Prettify())
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
                Files = syntax.Files
                    .Select(
                        x =>
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

    private class Visitor : CSharpSyntaxWalker
    {
        public Dictionary<string, (List<string>? NonFunctions, List<string>? Functions)> Types =
            new();

        public Dictionary<string, List<string>> PrettifyOnlyTypes = new();
        private (
            ClassDeclarationSyntax Class,
            List<string> NonFunctions,
            List<string> Functions
        )? _classInProgress;
        private (EnumDeclarationSyntax Enum, List<string> EnumMembers)? _enumInProgress;
        private FieldDeclarationSyntax? _visitingField = null;
        private bool _prettifyOnly;

        public override void VisitClassDeclaration(ClassDeclarationSyntax node)
        {
            if (_classInProgress is not null || _enumInProgress is not null)
            {
                // ignoring nesting for now
                return;
            }

            _classInProgress = (node, new List<string>(), new List<string>());
            base.VisitClassDeclaration(node);
            var id = _classInProgress.Value.Class.Identifier.ToString();
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = (new List<string>(), new List<string>());
                Types.Add(id, inner);
            }

            (inner.NonFunctions ??= new List<string>()).AddRange(
                _classInProgress.Value.NonFunctions
            );
            (inner.Functions ??= new List<string>()).AddRange(_classInProgress.Value.Functions);
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
                _classInProgress!.Value.Functions.Add(node.Identifier.ToString());
            }
        }

        public override void VisitStructDeclaration(StructDeclarationSyntax node)
        {
            if (_classInProgress is not null || _enumInProgress is not null)
            {
                return;
            }

            Types[node.Identifier.ToString()] = (null, null);
            base.VisitStructDeclaration(node);
        }

        public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
        {
            if (_classInProgress is not null || _enumInProgress is not null)
            {
                return;
            }

            _enumInProgress = (node, new List<string>());
            base.VisitEnumDeclaration(node);
            var id = _enumInProgress.Value.Enum.Identifier.ToString();
            if (!Types.TryGetValue(id, out var inner))
            {
                inner = (new List<string>(), new List<string>());
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
            var ret = base.VisitClassDeclaration(node);
            _typeInProgress = null;
            return ((ClassDeclarationSyntax)ret!).WithIdentifier(Identifier(info.NewName));
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
                            node.AttributeLists.Select(
                                x =>
                                    x.WithAttributes(
                                        SeparatedList(
                                            x.Attributes.Select(
                                                y =>
                                                    y.IsAttribute(
                                                        "System.Runtime.InteropServices.DllImport"
                                                    )
                                                    && (
                                                        y.ArgumentList?.Arguments.All(
                                                            z =>
                                                                z.NameEquals?.Name.ToString()
                                                                != "EntryPoint"
                                                        ) ?? true
                                                    )
                                                        ? y.AddArgumentListArguments(
                                                            AttributeArgument(
                                                                    LiteralExpression(
                                                                        SyntaxKind.StringLiteralExpression,
                                                                        Literal(
                                                                            node.Identifier.ToString()
                                                                        )
                                                                    )
                                                                )
                                                                .WithNameEquals(
                                                                    NameEquals("EntryPoint")
                                                                )
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
            return ret;
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
