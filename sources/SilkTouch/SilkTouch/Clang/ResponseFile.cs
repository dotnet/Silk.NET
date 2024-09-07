using System.Collections.Generic;
using ClangSharp;
using ClangSharp.Interop;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Output from <see cref="ResponseFileHandler"/>.
/// </summary>
/// <param name="ErrorList">Errors encountered in handling.</param>
/// <param name="GeneratorConfiguration">The determined generator configuration.</param>
/// <param name="Files">The input files.</param>
/// <param name="FileDirectory">The directory the input files are relative to.</param>
/// <param name="ClangCommandLineArgs">
/// Additional clang command line arguments to use when creating the translation unit.
/// </param>
/// <param name="TranslationFlags">Flags to use when creating the translation unit.</param>
/// <param name="FileHash">The XxHash64 hash of the original input.</param>
public record ResponseFile(
    IReadOnlyList<string> ErrorList,
    PInvokeGeneratorConfiguration GeneratorConfiguration,
    IReadOnlyList<string> Files,
    string FileDirectory,
    string[] ClangCommandLineArgs,
    CXTranslationUnit_Flags TranslationFlags,
    ulong FileHash
);
