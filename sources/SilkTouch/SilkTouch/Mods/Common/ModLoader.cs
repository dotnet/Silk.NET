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
            nameof(ChangeNamespace) => typeof(ChangeNamespace),
            nameof(AddIncludes) => typeof(AddIncludes),
            nameof(TransformFunctions) => typeof(TransformFunctions),
            nameof(PrettifyNames) => typeof(PrettifyNames),
            nameof(AddOpaqueStructs) => typeof(AddOpaqueStructs),
            nameof(AddVTables) => typeof(AddVTables),
            nameof(BakeSourceSets) => typeof(BakeSourceSets),
            nameof(AddApiProfiles) => typeof(AddApiProfiles),
            nameof(MixKhronosData) => typeof(MixKhronosData),
            nameof(TransformHandles) => typeof(TransformHandles),
            nameof(TransformEnums) => typeof(TransformEnums),
            nameof(ExtractNestedTyping) => typeof(ExtractNestedTyping),
            nameof(TransformProperties) => typeof(TransformProperties),
            nameof(ClangScraper) => typeof(ClangScraper),
            nameof(ChangeNativeClass) => typeof(ChangeNativeClass),
            nameof(InterceptNativeFunctions) => typeof(InterceptNativeFunctions),
            nameof(TransformInterfaces) => typeof(TransformInterfaces),
            nameof(TransformCOM) => typeof(TransformCOM),
            nameof(DisableWarnings) => typeof(DisableWarnings),
            nameof(ImportManualFiles) => typeof(ImportManualFiles),
            nameof(RemapTypes) => typeof(RemapTypes),
            nameof(RemoveStaticUsings) => typeof(RemoveStaticUsings),
            nameof(DiscardOutput) => typeof(DiscardOutput),
            nameof(FixOptionalParams) => typeof(FixOptionalParams),
            _ => null,
        };
}
