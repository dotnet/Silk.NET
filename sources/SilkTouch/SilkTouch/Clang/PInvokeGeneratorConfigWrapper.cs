// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using ClangSharp;
using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Clang;

/// <summary>
/// Extensions for <see cref="PInvokeGeneratorConfiguration"/>.
/// </summary>
public static class PInvokeGeneratorConfigurationExtensions
{
    /// <summary>
    /// Creates a new wrapper from a <see cref="PInvokeGeneratorConfiguration"/> instance.
    /// </summary>
    public static PInvokeGeneratorConfigWrapper ToWrapper(this PInvokeGeneratorConfiguration config) => PInvokeGeneratorConfigWrapper.FromConfiguration(config);
}

/// <summary>
/// This record class exists to make it easier to override a few properties in <see cref="PInvokeGeneratorConfiguration"/>
/// </summary>
public record class PInvokeGeneratorConfigWrapper
{
    // ----- Constructor parameters -----

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.Language"/>
    public required string Language { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.LanguageStandard"/>
    public required string LanguageStandard { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.DefaultNamespace"/>
    public required string DefaultNamespace { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.OutputLocation"/>
    public required string OutputLocation { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.HeaderText"/>
    public required string HeaderText { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.OutputMode"/>
    public required PInvokeGeneratorOutputMode OutputMode { get; init; }

    /// <summary>
    /// Options passed into <see cref="PInvokeGeneratorConfiguration"/>.
    /// Reconstructed using <see cref="ModUtils.ReconstructOptions"/>.
    /// </summary>
    public PInvokeGeneratorConfigurationOptions Options { get; init; }

    // ----- Properties -----

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.DefaultClass"/>
    public required string DefaultClass { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.ExcludeFnptrCodegen"/>
    public required bool ExcludeFnptrCodegen { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.ExcludedNames"/>
    public required IReadOnlyCollection<string> ExcludedNames { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.IncludedNames"/>
    public required IReadOnlyCollection<string> IncludedNames { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.LibraryPath"/>
    public required string LibraryPath { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.MethodPrefixToStrip"/>
    public required string MethodPrefixToStrip { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.NativeTypeNamesToStrip"/>
    public required IReadOnlyCollection<string> NativeTypeNamesToStrip { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.RemappedNames"/>
    public required IReadOnlyDictionary<string, string> RemappedNames { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.TestOutputLocation"/>
    public required string TestOutputLocation { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.TraversalNames"/>
    public required IReadOnlyCollection<string> TraversalNames { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithAccessSpecifiers"/>
    public required IReadOnlyDictionary<string, AccessSpecifier> WithAccessSpecifiers { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithAttributes"/>
    public required IReadOnlyDictionary<string, IReadOnlyList<string>> WithAttributes { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithCallConvs"/>
    public required IReadOnlyDictionary<string, string> WithCallConvs { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithClasses"/>
    public required IReadOnlyDictionary<string, string> WithClasses { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithGuids"/>
    public required IReadOnlyDictionary<string, Guid> WithGuids { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithLengths"/>
    public required IReadOnlyDictionary<string, string> WithLengths { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithLibraryPaths"/>
    public required IReadOnlyDictionary<string, string> WithLibraryPaths { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithManualImports"/>
    public required IReadOnlyCollection<string> WithManualImports { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithNamespaces"/>
    public required IReadOnlyDictionary<string, string> WithNamespaces { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithPackings"/>
    public required IReadOnlyDictionary<string, string> WithPackings { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithReadonlys"/>
    public required IReadOnlyCollection<string> WithReadonlys { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithSetLastErrors"/>
    public required IReadOnlyCollection<string> WithSetLastErrors { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithSuppressGCTransitions"/>
    public required IReadOnlyCollection<string> WithSuppressGCTransitions { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithTransparentStructs"/>
    public required IReadOnlyDictionary<string, (string Name, PInvokeGeneratorTransparentStructKind Kind)> WithTransparentStructs { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithTypes"/>
    public required IReadOnlyDictionary<string, string> WithTypes { get; init; }

    /// <inheritdoc cref="PInvokeGeneratorConfiguration.WithUsings"/>
    public required IReadOnlyDictionary<string, IReadOnlyList<string>> WithUsings { get; init; }

    /// <summary>
    /// Creates a blank wrapper.
    /// </summary>
    /// <remarks>
    /// You probably want <see cref="PInvokeGeneratorConfigurationExtensions.ToWrapper"/>.
    /// </remarks>
    public PInvokeGeneratorConfigWrapper() { }

    /// <inheritdoc cref="ToConfiguration" />
    /// <remarks>
    /// This cast is to improve the syntax when overriding properties of
    /// <see cref="PInvokeGeneratorConfiguration"/> with the 'with' keyword
    /// and needing to immediately cast back to <see cref="PInvokeGeneratorConfiguration"/> afterwards.
    /// </remarks>
    public static implicit operator PInvokeGeneratorConfiguration(PInvokeGeneratorConfigWrapper wrapper) => wrapper.ToConfiguration();

    /// <summary>
    /// Creates a new wrapper from a <see cref="PInvokeGeneratorConfiguration"/> instance.
    /// </summary>
    public static PInvokeGeneratorConfigWrapper FromConfiguration(PInvokeGeneratorConfiguration config) =>
        new() {
            // Constructor parameters
            Language = config.Language,
            LanguageStandard = config.LanguageStandard,
            DefaultNamespace = config.DefaultNamespace,
            OutputLocation = config.OutputLocation,
            HeaderText = config.HeaderText,
            OutputMode = config.OutputMode,
            Options = config.ReconstructOptions(),

            // Properties
            DefaultClass = config.DefaultClass,
            ExcludeFnptrCodegen = config.ExcludeFnptrCodegen,
            ExcludedNames = config.ExcludedNames,
            IncludedNames = config.IncludedNames,
            LibraryPath = config.LibraryPath,
            MethodPrefixToStrip = config.MethodPrefixToStrip,
            NativeTypeNamesToStrip = config.NativeTypeNamesToStrip,
            RemappedNames = config.RemappedNames,
            TestOutputLocation = config.TestOutputLocation,
            TraversalNames = config.TraversalNames,
            WithAccessSpecifiers = config.WithAccessSpecifiers,
            WithAttributes = config.WithAttributes,
            WithCallConvs = config.WithCallConvs,
            WithClasses = config.WithClasses,
            WithGuids = config.WithGuids,
            WithLengths = config.WithLengths,
            WithLibraryPaths = config.WithLibraryPaths,
            WithManualImports = config.WithManualImports,
            WithNamespaces = config.WithNamespaces,
            WithPackings = config.WithPackings,
            WithReadonlys = config.WithReadonlys,
            WithSetLastErrors = config.WithSetLastErrors,
            WithSuppressGCTransitions = config.WithSuppressGCTransitions,
            WithTransparentStructs = config.WithTransparentStructs,
            WithTypes = config.WithTypes,
            WithUsings = config.WithUsings,
        };

    /// <summary>
    /// Converts the wrapper back into a new <see cref="PInvokeGeneratorConfiguration"/> instance.
    /// </summary>
    public PInvokeGeneratorConfiguration ToConfiguration()
    {
        var tempHeaderFilePath = Path.GetTempFileName();
        File.WriteAllText(tempHeaderFilePath, HeaderText);
        return new PInvokeGeneratorConfiguration(
            Language,
            LanguageStandard,
            DefaultNamespace,
            OutputLocation,
            tempHeaderFilePath,
            OutputMode,
            Options
        ) {
            DefaultClass = DefaultClass,
            ExcludeFnptrCodegen = ExcludeFnptrCodegen,
            ExcludedNames = ExcludedNames,
            IncludedNames = IncludedNames,
            LibraryPath = LibraryPath,
            MethodPrefixToStrip = MethodPrefixToStrip,
            NativeTypeNamesToStrip = NativeTypeNamesToStrip,
            RemappedNames = RemappedNames,
            TestOutputLocation = TestOutputLocation,
            TraversalNames = TraversalNames,
            WithAccessSpecifiers = WithAccessSpecifiers,
            WithAttributes = WithAttributes,
            WithCallConvs = WithCallConvs,
            WithClasses = WithClasses,
            WithGuids = WithGuids,
            WithLengths = WithLengths,
            WithLibraryPaths = WithLibraryPaths,
            WithManualImports = WithManualImports,
            WithNamespaces = WithNamespaces,
            WithPackings = WithPackings,
            WithReadonlys = WithReadonlys,
            WithSetLastErrors = WithSetLastErrors,
            WithSuppressGCTransitions = WithSuppressGCTransitions,
            WithTransparentStructs = WithTransparentStructs,
            WithTypes = WithTypes,
            WithUsings = WithUsings,
        };
    }
}
