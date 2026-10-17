// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Jobs;

internal static partial class Jobs
{
    public static SilkTouchHost DefineOpenXRJob(this SilkTouchHost host) =>
        host.DefineJob(
            "OpenXR",
            new()
            {
                Solution = "Silk.NET.slnx",
                SourceProject = "sources/OpenXR/OpenXR/Silk.NET.OpenXR.csproj",
                DefaultLicenseHeader = "eng/silktouch/openxr/header.txt",
                DefaultNamespace = "Silk.NET.OpenXR",
            },
            context =>
                context
                    .WithDefaultFunctionTransformers(
                        new() { BoolTypes = new() { ["XrBool32"] = null } }
                    )
                    .AddIncludes(new())
                    .ClangScraper(
                        new()
                        {
                            CacheKey = "Windows",
                            ScrapeIf = static () => OperatingSystem.IsWindows(),

                            ClangSharpResponseFiles =
                            [
                                "eng/silktouch/openxr/openxr-windows/generate.rsp",
                            ],
                            InputSourceRoot = "sources/OpenXR",
                            InputTestRoot = "tests/OpenXR",
                        }
                    )
                    .ClangScraper(
                        new()
                        {
                            CacheKey = "Linux",
                            ScrapeIf = static () => OperatingSystem.IsLinux(),

                            ClangSharpResponseFiles =
                            [
                                "eng/silktouch/openxr/openxr-linux/generate.rsp",
                            ],
                            InputSourceRoot = "sources/OpenXR",
                            InputTestRoot = "tests/OpenXR",
                        }
                    )
                    .ClangScraper(
                        new()
                        {
                            CacheKey = "Mac",
                            ScrapeIf = static () => OperatingSystem.IsMacOS(),

                            ClangSharpResponseFiles =
                            [
                                "eng/silktouch/openxr/openxr-mac/generate.rsp",
                            ],
                            InputSourceRoot = "sources/OpenXR",
                            InputTestRoot = "tests/OpenXR",
                        }
                    )
                    .BakeSourceSets(
                        new()
                        {
                            SourceSets = new()
                            {
                                ["xr-windows"] = "xr",
                                ["xr-linux"] = "xr",
                                ["xr-mac"] = "xr",
                            },
                        }
                    )
                    .MarkNativeNames()
                    .ExtractHandles()
                    .ExtractNestedTypes()
                    .ExtractFunctionPointers()
                    .TransformHandles(new() { UseDsl = true })
                    .MixKhronosData(
                        new()
                        {
                            SpecPath = "eng/submodules/openxr-sdk/specification/registry/xr.xml",
                            Namespace = "Silk.NET.OpenXR",
                            StructureTypes = ["XrStructureType"],
                            FlagsTypes = ["XrFlags64"],
                            IdentifyEnumMemberImpliedVendors = true,
                        }
                    )
                    .AddApiProfiles(
                        new()
                        {
                            Profiles =
                            [
                                new() { Profile = "openxr", SourceSubdirectory = "openxr" },
                            ],
                        }
                    )
                    .InterceptNativeFunctions(new() { NativeFunctionNames = ["xrCreateInstance"] })
                    .TransformFunctions()
                    .TransformProperties(new() { BoolTypes = new() { ["XrBool32"] = null } })
                    .IdentifySharedPrefixes(
                        new()
                        {
                            GlobalPrefixHints = ["PFN_xr", "xr"],
                            PrefixOverrides = new()
                            {
                                ["XrPerfSettingsNotificationLevelEXT"] =
                                    "XR_PERF_SETTINGS_NOTIF_LEVEL",
                                ["XrSceneMarkerQRCodeSymbolTypeMSFT"] =
                                    "XR_SCENE_MARKER_QR_CODE_SYMBOL_TYPE",
                                ["XrStructureType"] = "XR_TYPE",
                            },
                        }
                    )
                    .PrettifyNames(
                        new()
                        {
                            Affixes = new()
                            {
                                ["HandleType"] = new() { Order = 1 },
                                ["FunctionPointerDelegateType"] = new() { Order = 1 },
                                ["KhronosVendor"] = new() { Order = -1 },
                                ["KhronosImpliedVendor"] = new() { Remove = true },
                                ["KhronosHandleType"] = new() { Remove = true },
                                ["SharedPrefix"] = new() { Remove = true },
                            },
                        }
                    )
                    .TransformEnums(
                        new()
                        {
                            AddNoneMemberToFlags = true,
                            RemoveMembers =
                            [
                                new() { MemberName = "MaxEnum", MemberValue = "0x7FFFFFFF" },
                            ],
                            CoerceBackingTypes = TransformEnums
                                .EnumBackingTypePreference
                                .PreferUnsigned,
                            RewriteMemberValues = true,
                        }
                    )
                    .AddVTables(
                        new()
                        {
                            VTables =
                            [
                                new AddVTables.DllImport(),
                                new AddVTables.StaticWrapper(),
                                new AddVTables.ThisThread()
                                {
                                    IsDefault = true,
                                    GenerateFactoryPartial = true,
                                },
                            ],
                        }
                    )
                    .StripAttributes(
                        new() { Remove = ["NativeTypeName", "NameAffix", "Transformed"] }
                    )
        );
}
