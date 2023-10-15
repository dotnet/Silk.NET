using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SilkTouchX.Clang;
using SilkTouchX.Naming;

namespace SilkTouchX.Mods;

/// <summary>
/// A mod that will convert other naming conventions to the PascalCase nomenclature typically used in C#.
/// </summary>
public class PrettifyNames : IMod
{
    private readonly ILogger<PrettifyNames> _logger;
    private readonly IOptionsSnapshot<Configuration> _config;
    private readonly IEnumerable<INameTrimmer> _trimmers;

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

    /// <summary>
    /// Creates an instance of this mod.
    /// </summary>
    /// <param name="logger">The logger.</param>
    /// <param name="config">Configuration snapshot.</param>
    /// <param name="trimmers">Name trimmers.</param>
    public PrettifyNames(
        ILogger<PrettifyNames> logger,
        IOptionsSnapshot<Configuration> config,
        IEnumerable<INameTrimmer> trimmers
    ) => (_logger, _config, _trimmers) = (logger, config, trimmers);

    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var visitor = new Visitor();
        foreach (var (_, node) in syntax.Files.Where(x => x.Key.StartsWith("sources/")))
        {
            visitor.Visit(node);
        }

        var rewriter = new Rewriter();
        var cfg = _config.Get(key);
        if (cfg.TrimmerBaseline is not null)
        {
            var typeNames = visitor.Types.ToDictionary(
                x => x.Key,
                x => (x.Key, (List<string>?)null)
            );
            foreach (
                var trimmer in _trimmers
                    .Where(x => x.Version >= cfg.TrimmerBaseline)
                    .OrderBy(x => x.Version)
            )
            {
                trimmer.Trim(null, cfg.GlobalPrefixHint, typeNames, cfg.PrefixOverrides);
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
                        var trimmer in _trimmers
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
                var functionNames = functions?.ToDictionary(
                    x => x,
                    x => (Primary: x, (List<string>?)null)
                );
                if (functionNames is not null)
                {
                    foreach (
                        var trimmer in _trimmers
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

                rewriter.Types[typeName] = (
                    newTypeName.Prettify(),
                    // TODO handle secondaries?
                    constNames?.ToDictionary(x => x.Key, x => x.Value.Primary.Prettify()),
                    functionNames?.ToDictionary(x => x.Key, x => x.Value.Primary.Prettify())
                );
            }
        }
        else
        {
            foreach (var (name, (constants, functions)) in visitor.Types)
            {
                rewriter.Types[name] = (
                    name.Prettify(),
                    constants?.ToDictionary(x => x, x => x.Prettify()),
                    functions?.ToDictionary(x => x, x => x.Prettify())
                );
            }
        }

        foreach (var (name, (newName, constants, functions)) in rewriter.Types)
        {
            _logger.LogInformation("{} = {}", name, newName);
            foreach (var (old, @new) in constants ?? new())
            {
                _logger.LogInformation("{}.{} = {}.{}", name, old, newName, @new);
            }
            foreach (var (old, @new) in functions ?? new())
            {
                _logger.LogInformation("{}.{} = {}.{}", name, old, newName, @new);
            }
        }

        return Task.FromResult(syntax);
    }

    private class Visitor : CSharpSyntaxWalker
    {
        public Dictionary<string, (List<string>? Constants, List<string>? Functions)> Types = new();
        private (
            ClassDeclarationSyntax Class,
            List<string> Constants,
            List<string> Functions
        )? _classInProgress;
        private (EnumDeclarationSyntax Enum, List<string> EnumMembers)? _enumInProgress;
        private FieldDeclarationSyntax? _visitingField = null;

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

            (inner.Constants ??= new List<string>()).AddRange(_classInProgress.Value.Constants);
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
                !node.Modifiers.Any(x => x.IsKind(SyntaxKind.ConstKeyword))
                && (
                    !node.Modifiers.Any(x => x.IsKind(SyntaxKind.StaticKeyword))
                    || !node.Modifiers.Any(x => x.IsKind(SyntaxKind.ReadOnlyKeyword))
                )
            )
            {
                return;
            }

            _visitingField = node;
            base.VisitFieldDeclaration(node);
            _visitingField = null;
        }

        public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
        {
            if (node.Parent?.Parent == _visitingField)
            {
                _classInProgress!.Value.Constants.Add(node.Identifier.ToString());
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
            if (_classInProgress is null && _enumInProgress is null)
            {
                Types[node.Identifier.ToString()] = (null, null);
            }
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

            (inner.Constants ??= new List<string>()).AddRange(_enumInProgress.Value.EnumMembers);
            _enumInProgress = null;
        }
    }

    private class Rewriter : CSharpSyntaxRewriter
    {
        public Dictionary<
            string,
            (
                string NewName,
                Dictionary<string, string>? Constants,
                Dictionary<string, string>? Functions
            )
        > Types = new();
    }
}
