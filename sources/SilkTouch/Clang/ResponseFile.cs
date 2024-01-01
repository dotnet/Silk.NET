using System;
using System.Collections.Generic;
using System.Linq;
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
public record ResponseFile(
    IReadOnlyList<string> ErrorList,
    PInvokeGeneratorConfiguration GeneratorConfiguration,
    IReadOnlyList<string> Files,
    string FileDirectory,
    string[] ClangCommandLineArgs,
    CXTranslationUnit_Flags TranslationFlags
)
{
    internal string FlatString =>
        $"{GeneratorConfiguration.OutputLocation}:{GeneratorConfiguration.TestOutputLocation}:"
        + $"{GeneratorConfiguration.GenerateLatestCode}:{GeneratorConfiguration.GeneratePreviewCode}:"
        + $"{GeneratorConfiguration.GenerateCompatibleCode}:{GeneratorConfiguration.Language}:"
        + $"{GeneratorConfiguration.DefaultClass}:{GeneratorConfiguration.DefaultNamespace}:"
        + $"{string.Join(',', GeneratorConfiguration.ExcludedNames)}:{GeneratorConfiguration.HeaderText}:"
        + $"{string.Join(',', GeneratorConfiguration.IncludedNames)}:{GeneratorConfiguration.LanguageStandard}:"
        + $"{GeneratorConfiguration.LibraryPath}:{GeneratorConfiguration.LogExclusions}:"
        + $"{GeneratorConfiguration.OutputMode}:{string.Join(',', GeneratorConfiguration.RemappedNames)}:"
        + $"{string.Join(',', GeneratorConfiguration.TraversalNames)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithAttributes)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithClasses)}:{string.Join(',', GeneratorConfiguration.WithGuids)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithNamespaces)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithPackings)}:{string.Join(',', GeneratorConfiguration.WithTypes)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithUsings.Select(x => (x.Key, string.Join(',', x.Value))))}:"
        + $"{GeneratorConfiguration.ExcludeComProxies}:{GeneratorConfiguration.ExcludeEmptyRecords}:"
        + $"{GeneratorConfiguration.ExcludeEnumOperators}:{GeneratorConfiguration.ExcludeFnptrCodegen}:"
        + $"{string.Join(',', GeneratorConfiguration.ForceRemappedNames)}:"
        + $"{GeneratorConfiguration.GenerateAggressiveInlining}:{GeneratorConfiguration.GenerateCppAttributes}:"
        + $"{GeneratorConfiguration.GenerateDocIncludes}:{GeneratorConfiguration.GenerateExplicitVtbls}:"
        + $"{GeneratorConfiguration.GenerateGuidMember}:{GeneratorConfiguration.GenerateHelperTypes}:"
        + $"{GeneratorConfiguration.GenerateMacroBindings}:{GeneratorConfiguration.GenerateMarkerInterfaces}:"
        + $"{GeneratorConfiguration.GenerateMultipleFiles}:{GeneratorConfiguration.GenerateTemplateBindings}:"
        + $"{GeneratorConfiguration.GenerateTrimmableVtbls}:{GeneratorConfiguration.GenerateUnixTypes}:"
        + $"{GeneratorConfiguration.GenerateUnmanagedConstants}:{GeneratorConfiguration.LogVisitedFiles}:"
        + $"{string.Join(',', GeneratorConfiguration.WithAccessSpecifiers)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithCallConvs)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithLibraryPaths)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithManualImports)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithTransparentStructs)}:"
        + $"{GeneratorConfiguration.ExcludeAnonymousFieldHelpers}:{GeneratorConfiguration.ExcludeFunctionsWithBody}:"
        + $"{GeneratorConfiguration.ExcludeNIntCodegen}:{GeneratorConfiguration.GenerateFileScopedNamespaces}:"
        + $"{GeneratorConfiguration.GenerateNativeBitfieldAttribute}:"
        + $"{GeneratorConfiguration.GenerateNativeInheritanceAttribute}:"
        + $"{GeneratorConfiguration.GenerateSourceLocationAttribute}:{GeneratorConfiguration.GenerateTestsNUnit}:"
        + $"{GeneratorConfiguration.GenerateTestsXUnit}:{GeneratorConfiguration.GenerateVtblIndexAttribute}:"
        + $"{GeneratorConfiguration.LogPotentialTypedefRemappings}:{GeneratorConfiguration.MethodPrefixToStrip}:"
        + $"{string.Join(',', GeneratorConfiguration.WithSetLastErrors)}:"
        + $"{string.Join(',', GeneratorConfiguration.NativeTypeNamesToStrip)}:"
        + $"{string.Join(',', GeneratorConfiguration.WithSuppressGCTransitions)}:"
        + $"{GeneratorConfiguration.DontUseUsingStaticsForEnums}:"
        + $"{GeneratorConfiguration.GenerateSetsLastSystemErrorAttribute}";
}
