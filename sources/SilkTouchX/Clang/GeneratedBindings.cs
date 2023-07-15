using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;
using Diagnostic = ClangSharp.Diagnostic;

namespace SilkTouchX.Clang;

/// <summary>
/// Output from the <see cref="ClangScraper"/>.
/// </summary>
/// <param name="Files">Raw C# bindings as memory streams.</param>
/// <param name="Diagnostics"></param>
public record GeneratedBindings(Dictionary<string, Stream> Files, IReadOnlyList<Diagnostic> Diagnostics);


/// <summary>
/// Output from the <see cref="SilkTouchGenerator"/>.
/// </summary>
/// <param name="Files">C# bindings that have probably been through relevant mods.</param>
/// <param name="Diagnostics"></param>
public record GeneratedSyntax(Dictionary<string, SyntaxNode> Files, IReadOnlyList<Diagnostic> Diagnostics);
