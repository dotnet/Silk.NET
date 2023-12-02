using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClangSharp;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Options;
using Silk.NET.SilkTouch.Clang;
using static Microsoft.CodeAnalysis.CSharp.SyntaxFactory;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Adds opaque structs.
/// </summary>
[ModConfiguration<Configuration>]
public class AddOpaqueStructs : IMod
{
    private readonly IOptionsSnapshot<Configuration> _config;
    private readonly Dictionary<string, string> _defaultNamespaces = new();

    /// <summary>
    /// The configuration for the opaque structs mod.
    /// </summary>
    public record Configuration // DON'T USE CONSTRUCTOR-STYLE RECORDS! Needs a default ctor.
    {
        /// <summary>
        /// Opaque struct names.
        /// </summary>
        public required string[]? Names { get; init; }
    }

    /// <summary>
    /// Creates an instance of the mod using the given config.
    /// </summary>
    /// <param name="config">The config.</param>
    public AddOpaqueStructs(IOptionsSnapshot<Configuration> config) => _config = config;

    /// <inheritdoc />
    public Task<List<ResponseFile>> BeforeScrapeAsync(string key, List<ResponseFile> rsps)
    {
        if (rsps.Count <= 0)
        {
            return Task.FromResult(rsps);
        }

        var ns = rsps[0].GeneratorConfiguration.DefaultNamespace;
        if (rsps.All(responseFile => responseFile.GeneratorConfiguration.DefaultNamespace == ns))
        {
            _defaultNamespaces.Add(key, ns);
        }

        return Task.FromResult(rsps);
    }

    /// <inheritdoc />
    public Task<GeneratedSyntax> AfterScrapeAsync(string key, GeneratedSyntax syntax)
    {
        var cfg = _config.Get(key);
        var diags = new List<Diagnostic>(syntax.Diagnostics);
        foreach (var name in cfg.Names ?? Array.Empty<string>())
        {
            var qualified = name.LastIndexOf('.');
            var ns =
                qualified != -1
                    ? ModUtils.NamespaceIntoIdentifierName(name.AsSpan()[..qualified])
                    : _defaultNamespaces.TryGetValue(key, out var def)
                        ? ModUtils.NamespaceIntoIdentifierName(def)
                        : null;
            if (ns is null)
            {
                diags.Add(
                    new Diagnostic(
                        DiagnosticLevel.Warning,
                        $"Couldn't resolve namespace for opaque struct \"{name}\" - consider fully qualifying the type "
                            + "in the config"
                    )
                );
                continue;
            }

            syntax.Files.Add(
                $"sources/{name[(qualified + 1)..]}.gen.cs",
                CompilationUnit()
                    .WithMembers(
                        SingletonList<MemberDeclarationSyntax>(
                            FileScopedNamespaceDeclaration(ns)
                                .WithMembers(
                                    SingletonList<MemberDeclarationSyntax>(
                                        StructDeclaration(name[(qualified + 1)..])
                                            .WithModifiers(
                                                TokenList(
                                                    Token(SyntaxKind.PublicKeyword),
                                                    Token(SyntaxKind.ReadOnlyKeyword)
                                                )
                                            )
                                    )
                                )
                        )
                    )
            );
        }

        return Task.FromResult(syntax with { Diagnostics = diags });
    }
}
