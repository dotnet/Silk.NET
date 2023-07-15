using System.Collections.Generic;
using System.IO;
using ClangSharp;

namespace SilkTouchX.Clang;

/// <summary>
/// Output from the <see cref="ClangScraper"/>.
/// </summary>
/// <param name="Files">Raw C# bindings as memory streams.</param>
/// <param name="Diagnostics"></param>
public record GeneratedBindings(Dictionary<string, Stream> Files, IReadOnlyList<Diagnostic> Diagnostics);
