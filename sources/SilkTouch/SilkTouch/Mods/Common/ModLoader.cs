using System;
using Silk.NET.SilkTouch.Clang;

namespace Silk.NET.SilkTouch.Mods;

/// <summary>
/// Loads <see cref="IMod"/>s based on strings contained within the configuration file.
/// </summary>
public class ModLoader
{
    /// <summary>
    /// Gets a mod from the given name/string.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <returns>The loaded mod if the mod was found, null otherwise.</returns>
    public static Type? LoadModByName(string name) =>
        name switch
        {
            nameof(AddApiProfiles) => typeof(AddApiProfiles),
            nameof(AddIncludes) => typeof(AddIncludes),
            nameof(AddOpaqueStructs) => typeof(AddOpaqueStructs),
            nameof(AddVTables) => typeof(AddVTables),
            nameof(BakeSourceSets) => typeof(BakeSourceSets),
            nameof(ChangeNamespace) => typeof(ChangeNamespace),
            nameof(ChangeNativeClass) => typeof(ChangeNativeClass),
            nameof(ClangScraper) => typeof(ClangScraper),
            nameof(ExtractHandles) => typeof(ExtractHandles),
            nameof(ExtractNestedTyping) => typeof(ExtractNestedTyping),
            nameof(IdentifySharedPrefixes) => typeof(IdentifySharedPrefixes),
            nameof(InterceptNativeFunctions) => typeof(InterceptNativeFunctions),
            nameof(MarkNativeNames) => typeof(MarkNativeNames),
            nameof(MixKhronosData) => typeof(MixKhronosData),
            nameof(PrettifyNames) => typeof(PrettifyNames),
            nameof(StripAttributes) => typeof(StripAttributes),
            nameof(TransformEnums) => typeof(TransformEnums),
            nameof(TransformFunctions) => typeof(TransformFunctions),
            nameof(TransformHandles) => typeof(TransformHandles),
            nameof(TransformProperties) => typeof(TransformProperties),
            _ => null,
        };
}
