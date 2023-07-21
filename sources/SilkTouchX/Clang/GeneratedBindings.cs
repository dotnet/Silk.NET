using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
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

/// <summary>
/// The generator into which the generated bindings shall be output.
/// </summary>
/// <param name="Workspace"></param>
/// <param name="SourceProject"></param>
/// <param name="TestProject"></param>
/// <param name="SourceFiles"></param>
/// <param name="TestFiles"></param>
public record GeneratorWorkspace(MSBuildWorkspace Workspace,
    Project? SourceProject,
    Project? TestProject,
    IReadOnlyList<string> SourceFiles,
    IReadOnlyList<string> TestFiles);
