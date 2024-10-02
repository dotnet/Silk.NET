using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Silk.NET.SilkTouch.Clang;
using Silk.NET.SilkTouch.Naming;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Represents an <see cref="IMod"/> with common functionality.
/// </summary>
public abstract class Mod : IMod
{
    /// <summary>
    /// Gets the common namespace determined from the default namespaces within the response file.
    /// </summary>
    public string? CommonNamespace { get; private set; }

    /// <summary>
    /// Determines where to locate the given "fully qualified file name" i.e. a file name for a type prefixed with its
    /// namespace e.g. Silk.NET.Core.SomeType`1.gen.cs. The extension is removed so that we don't mistake it as part of
    /// the namespace.
    /// </summary>
    /// <param name="fullyQualified">
    /// The fully qualified file name without the extension e.g. Silk.NET.Core.SomeType`1
    /// </param>
    /// <param name="extension">The file extension e.g. .gen.cs</param>
    /// <returns>The path within the sources directory to place this file.</returns>
    public string PathForFullyQualified(string fullyQualified, string extension = ".gen.cs")
    {
        if (!fullyQualified.Contains('.') || CommonNamespace is null or { Length: 0 })
        {
            return fullyQualified + extension;
        }

        return fullyQualified.StartsWith(CommonNamespace)
            ? fullyQualified[CommonNamespace.Length..].Trim('.').Replace('.', '/') + extension
            : fullyQualified + extension;
    }

    /// <inheritdoc />
    public virtual void Initialize(IModContext ctx) { }

    /// <inheritdoc />
    public virtual async Task ExecuteAsync(IModContext ctx, CancellationToken ct = default)
    {
        if (
            ctx.SourceProject is not null
            && await ctx.SourceProject.GetCompilationAsync(ct) is { } comp
        )
        {
            CommonNamespace = CommonNamespaceVisitor.CommonNamespaceFrom(comp.GlobalNamespace);
        }
    }

    class CommonNamespaceVisitor : SymbolVisitor
    {
        private List<INamespaceSymbol> _namespacesWithTypes = [];

        public override void VisitNamespace(INamespaceSymbol symbol)
        {
            foreach (var member in symbol.GetMembers())
            {
                if (_namespacesWithTypes.Contains(member, SymbolEqualityComparer.Default))
                {
                    continue;
                }

                member.Accept(this);
            }
        }

        public override void VisitNamedType(INamedTypeSymbol symbol)
        {
            if (!_namespacesWithTypes.Contains(symbol.ContainingNamespace))
            {
                _namespacesWithTypes.Add(symbol.ContainingNamespace);
            }
        }

        public string CommonNamespace =>
            NameUtils.FindCommonPrefix(
                _namespacesWithTypes.Select(x => x.NamespaceFromSymbol()).ToList(),
                true,
                int.MaxValue,
                true
            );

        public static string CommonNamespaceFrom(ISymbol symbol)
        {
            var visitor = new CommonNamespaceVisitor();
            visitor.Visit(symbol);
            return visitor.CommonNamespace;
        }
    }
}
