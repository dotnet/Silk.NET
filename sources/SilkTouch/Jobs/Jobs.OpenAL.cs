// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Jobs;

internal static partial class Jobs
{
    public static SilkTouchHost DefineOpenALJob(this SilkTouchHost host) =>
        host.DefineJob(
            "OpenAL",
            new()
            {
                Solution = "Silk.NET.slnx",
                SourceProject = "sources/OpenAL/OpenAL/Silk.NET.OpenAL.csproj",
                DefaultLicenseHeader = "eng/silktouch/header.txt",
            },
            context =>
                context
                    .WithDefaultFunctionTransformers(
                        new()
                        {
                            BoolTypes = new() { ["ALboolean"] = null, ["ALCboolean"] = null },
                        }
                    )
                    .WithMods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles =
                                    [
                                        "eng/silktouch/openal*/**/generate.rsp",
                                    ],
                                    InputSourceRoot = "sources/OpenAL",
                                    InputTestRoot = "tests/OpenAL",
                                }
                            )
                            .MarkNativeNames()
                            .ChangeNativeClass(
                                new()
                                {
                                    NewClasses = new()
                                    {
                                        ["(alc|ALC_).*"] = "ALContext",
                                        ["EFX_REVERB_PRESET_.*"] = "EfxReverbPreset",
                                    },
                                }
                            )
                            .AddApiProfiles(new())
                            .MixKhronosData(
                                new()
                                {
                                    SpecPath = "eng/submodules/openal-soft/registry/xml/al.xml",
                                    Namespace = "Silk.NET.OpenAL",
                                    TypeMap = new() { ["ALenum"] = "uint", ["ALCenum"] = "uint" },
                                    NonStandardExtensionNomenclature = true,
                                    Vendors = ["SOFT", "LOKI", "EXT"],
                                    NonVendorSuffixes = ["Direct"],
                                    IdentifyFunctionDataTypes = true,
                                    IdentifyEnumTypeNonExclusiveVendors = true,
                                    IdentifyEnumMemberImpliedVendors = true,
                                }
                            )
                            .ExtractHandles()
                            .ExtractNestedTypes()
                            .ExtractEnumConstants()
                            .ExtractFunctionPointers()
                            .TransformHandles(new() { UseDsl = true })
                            .InterceptNativeFunctions(
                                new()
                                {
                                    NativeFunctionNames =
                                    [
                                        "alcOpenDevice",
                                        "alcMakeContextCurrent",
                                    ],
                                }
                            )
                            .TransformFunctions()
                            .TransformProperties(
                                new()
                                {
                                    BoolTypes = new()
                                    {
                                        ["ALboolean"] = null,
                                        ["ALCboolean"] = null,
                                    },
                                }
                            )
                            .IdentifySharedPrefixes(new() { GlobalPrefixHints = ["alc", "al"] })
                            .PrettifyNames(
                                new()
                                {
                                    NameOverrides = new()
                                    {
                                        ["ALContext"] = "ALContext",
                                        ["EFXEAXREVERBPROPERTIES"] = "EfxEaxReverbProperties",
                                        ["ALCcontextHandle"] = "ContextHandle",
                                        ["ALCdeviceHandle"] = "DeviceHandle",
                                        ["ALBUFFERCALLBACKTYPESOFT"] = "BufferCallbackSOFT",
                                        ["ALCEVENTPROCTYPESOFT"] = "ContextEventProcSOFT",
                                        ["ALEVENTPROCSOFT"] = "EventProcSOFT",
                                        ["ALDEBUGPROCEXT"] = "DebugProcEXT",
                                        ["LPALFOLDBACKCALLBACK"] = "FoldbackCallback",
                                    },
                                    Affixes = new()
                                    {
                                        ["HandleType"] = new() { Order = 1 },
                                        ["FunctionPointerDelegateType"] = new() { Order = 1 },
                                        ["KhronosVendor"] = new() { Order = -1 },
                                        ["KhronosFunctionDataType"] = new()
                                        {
                                            IsDiscriminator = true,
                                        },
                                        ["KhronosImpliedVendor"] = new() { Remove = true },
                                        ["KhronosNonExclusiveVendor"] = new() { Remove = true },
                                        ["SharedPrefix"] = new() { Remove = true },
                                    },
                                }
                            )
                            .TransformEnums(
                                new() { AddNoneMemberToFlags = true, RewriteMemberValues = true }
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
                    )
        );
}
