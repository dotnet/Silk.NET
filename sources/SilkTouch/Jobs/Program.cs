// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Jobs;

internal static class Program
{
    public static Task Main(string[] args) =>
        SilkTouchHost
            .Create()
            .DefineJob(
                "Microsoft",
                new()
                {
                    Solution = "Silk.NET.slnx",
                    SourceProject = "sources/Win32/Win32/Silk.NET.Win32.csproj",
                    TestProject = "tests/Win32/Win32/Silk.NET.Win32.UnitTests.csproj",
                    DefaultLicenseHeader = "eng/silktouch/header.txt",
                },
                context =>
                    context.Mods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles =
                                    [
                                        "eng/submodules/terrafx.interop.windows/generation/**/generate.rsp",
                                    ],
                                    ManualOverrides = new()
                                    {
                                        ["sources/Windows/um/icm/Windows.gen.cs"] =
                                            "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Windows/um/icm/Windows.cs",
                                        ["sources/Gdiplus/um/gdiplustypes/GpRect.gen.cs"] =
                                            "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Gdiplus/um/gdiplustypes/GpRect.cs",
                                        ["sources/Gdiplus/um/gdiplustypes/GpRectF.gen.cs"] =
                                            "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Gdiplus/um/gdiplustypes/GpRectF.cs",
                                        ["sources/Gdiplus/um/gdiplustypes/GpPathData.gen.cs"] =
                                            "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Gdiplus/um/gdiplustypes/GpPathData.cs",
                                        ["sources/Windows/shared/strsafe/Windows.gen.cs"] =
                                            "eng/submodules/terrafx.interop.windows/sources/Interop/Windows/Windows/shared/strsafe/Windows.gen.cs",
                                    },
                                    InputSourceRoot =
                                        "eng/submodules/terrafx.interop.windows/sources/Interop/Windows",
                                    InputTestRoot =
                                        "eng/submodules/terrafx.interop.windows/tests/Interop/Windows",
                                    SkipScrapeIf = ["!win"],
                                }
                            )
                            .ChangeNamespace(
                                new()
                                {
                                    Mappings = new() { ["TerraFX.Interop.(.*)"] = "Silk.NET.$1" },
                                }
                            )
                    )
            )
            .DefineJob(
                "SDL",
                new()
                {
                    Solution = "Silk.NET.slnx",
                    SourceProject = "sources/SDL/SDL/Silk.NET.SDL.csproj",
                    TestProject = "tests/SDL/SDL/Silk.NET.SDL.UnitTests.csproj",
                    DefaultLicenseHeader = "eng/silktouch/header.txt",
                },
                context =>
                    context.Mods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles = ["eng/silktouch/sdl/**/generate.rsp"],
                                    InputSourceRoot = "sources/SDL",
                                    InputTestRoot = "tests/SDL",
                                }
                            )
                            .MarkNativeNames()
                            .ExtractHandles()
                            .ExtractNestedTypes()
                            .ExtractEnumConstants()
                            .ExtractFunctionPointers()
                            .TransformHandles(new() { UseDsl = true })
                            .TransformFunctions(new() { BoolTypes = new() { ["SDL_bool"] = null } })
                            .TransformProperties(
                                new() { BoolTypes = new() { ["SDL_bool"] = null } }
                            )
                            .IdentifySharedPrefixes(new() { GlobalPrefixHints = ["SDL"] })
                            .PrettifyNames(
                                new()
                                {
                                    Affixes = new() { ["SharedPrefix"] = new() { Remove = true } },
                                }
                            )
                            .TransformEnums(
                                new() { AddNoneMemberToFlags = true, RewriteMemberValues = true }
                            )
                            .AddVTables(new())
                            .StripAttributes(
                                new() { Remove = ["NativeTypeName", "NameAffix", "Transformed"] }
                            )
                    )
            )
            .DefineJob(
                "OpenGL",
                new()
                {
                    Solution = "Silk.NET.slnx",
                    SourceProject = "sources/OpenGL/OpenGL/Silk.NET.OpenGL.csproj",
                    DefaultLicenseHeader = "eng/silktouch/header.txt",
                },
                context =>
                    context.Mods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles =
                                    [
                                        "eng/silktouch/opengl/**/generate.rsp",
                                    ],
                                    InputSourceRoot = "sources/OpenGL",
                                    InputTestRoot = "tests/OpenGL",
                                }
                            )
                            .MarkNativeNames()
                            .AddApiProfiles(
                                new()
                                {
                                    Profiles =
                                    [
                                        new() { Profile = "gl", SourceSubdirectory = "glcompat" },
                                        new()
                                        {
                                            Profile = "glcore",
                                            SourceSubdirectory = "glcore",
                                            MinVersion = "3.2",
                                        },
                                        new()
                                        {
                                            Profile = "gles1",
                                            SourceSubdirectory = "gles1",
                                            MaxVersion = "2.0",
                                        },
                                        new()
                                        {
                                            Profile = "gles2",
                                            SourceSubdirectory = "gles2",
                                            MinVersion = "2.0",
                                        },
                                    ],
                                }
                            )
                            .BakeSourceSets(
                                new()
                                {
                                    SourceSets = new()
                                    {
                                        ["glcompat"] = "gl",
                                        ["glcore"] = "gl",
                                        ["gles1"] = "gl",
                                        ["gles2"] = "gl",
                                    },
                                }
                            )
                            .AddOpaqueStructs(new() { Names = ["GLsync"] })
                            .MixKhronosData(
                                new()
                                {
                                    SpecPath = "eng/submodules/opengl-registry/xml/gl.xml",
                                    Namespace = "Silk.NET.OpenGL",
                                    TypeMap = new()
                                    {
                                        ["GLenum"] = "uint",
                                        ["TraceMaskMESA"] = "uint",
                                        ["PathRenderingTokenNV"] = "byte",
                                        ["PathCoordType"] = "byte",
                                    },
                                    IdentifyFunctionDataTypes = true,
                                    IdentifyEnumTypeNonExclusiveVendors = true,
                                    IdentifyEnumMemberImpliedVendors = true,
                                }
                            )
                            .TransformHandles(new() { UseDsl = true })
                            .TransformFunctions(
                                new() { BoolTypes = new() { ["GLboolean"] = null } }
                            )
                            .TransformProperties(
                                new() { BoolTypes = new() { ["GLboolean"] = null } }
                            )
                            .IdentifySharedPrefixes(
                                new()
                                {
                                    GlobalPrefixHints = ["gl"],
                                    PrefixOverrides = new()
                                    {
                                        ["SyncObjectMask"] = "GL_SYNC",
                                        ["OcclusionQueryParameterNameNV"] = "GL",
                                        ["TexStorageAttribs"] = "GL",
                                        ["ContainerType"] = "GL",
                                        ["SeparableTargetEXT"] = "GL",
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
                                            GenerateMakeCurrentPartial = true,
                                        },
                                    ],
                                }
                            )
                            .StripAttributes(
                                new() { Remove = ["NativeTypeName", "NameAffix", "Transformed"] }
                            )
                    )
            )
            .DefineJob(
                "OpenCL",
                new()
                {
                    Solution = "Silk.NET.slnx",
                    SourceProject = "sources/OpenCL/OpenCL/Silk.NET.OpenCL.csproj",
                    DefaultLicenseHeader = "eng/silktouch/header.txt",
                },
                context =>
                    context.Mods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles =
                                    [
                                        "eng/silktouch/opencl/**/generate.rsp",
                                    ],
                                    InputSourceRoot = "sources/OpenCL",
                                    InputTestRoot = "tests/OpenCL",
                                }
                            )
                            .MarkNativeNames()
                            .AddApiProfiles(new())
                            .ExtractHandles()
                            .ExtractNestedTypes()
                            .ExtractFunctionPointers()
                            .MixKhronosData(
                                new()
                                {
                                    SpecPath = "eng/submodules/opencl-docs/xml/cl.xml",
                                    Namespace = "Silk.NET.OpenCL",
                                    TypeMap = new()
                                    {
                                        ["cl_bitfield"] = "ulong",
                                        ["cl_properties"] = "ulong",
                                        ["intptr_t"] = "long",
                                        ["ErrorCodes"] = "int",
                                        ["cl_affinity_domain_ext"] = "uint",
                                        ["clCommandExecutionStatus"] = "uint",
                                        ["cl_compiler_mode_altera"] = "uint",
                                        ["cl_motion_estimation_desc_intel.mb_block_type"] = "uint",
                                        ["cl_motion_estimation_desc_intel.subpixel_mode"] = "uint",
                                        ["cl_motion_estimation_desc_intel.sad_adjust_mode"] =
                                            "uint",
                                        ["cl_motion_estimation_desc_intel.search_path_type"] =
                                            "uint",
                                        ["cl_arm_device_svm_capabilities.flags"] = "uint",
                                        ["cl_arm_svm_alloc.flags"] = "uint",
                                        ["cl_intel_advanced_motion_estimation.flags"] = "uint",
                                        [
                                            "cl_intel_advanced_motion_estimation.search_cost_penalty"
                                        ] = "uint",
                                        [
                                            "cl_intel_advanced_motion_estimation.search_cost_precision"
                                        ] = "uint",
                                        [
                                            "cl_intel_advanced_motion_estimation.intra_search_prediction_modes_buffer.luma_block"
                                        ] = "uint",
                                        [
                                            "cl_intel_advanced_motion_estimation.intra_search_prediction_modes_buffer.chroma_block"
                                        ] = "uint",
                                        ["cl_intel_advanced_motion_estimation.skip_block_type"] =
                                            "uint",
                                        ["cl_intel_advanced_motion_estimation.device_me_version"] =
                                            "uint",
                                        [
                                            "cl_intel_advanced_motion_estimation.cl_motion_detect_desc_intel"
                                        ] = "uint",
                                        [
                                            "cl_intel_advanced_motion_estimation.cl_motion_detect_desc_intel.2"
                                        ] = "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.version"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.major"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.minor"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.major.dir"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.partition"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.window"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.adjust"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.subpixel"] =
                                            "uint",
                                        [
                                            "cl_intel_device_side_avc_motion_estimation.cost.precision"
                                        ] = "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.weight"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.border"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.skip"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.skip.dir"] =
                                            "uint",
                                        [
                                            "cl_intel_device_side_avc_motion_estimation.skip.block.based"
                                        ] = "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.intra"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.intra.luma"] =
                                            "uint",
                                        [
                                            "cl_intel_device_side_avc_motion_estimation.intra.neighbor"
                                        ] = "uint",
                                        [
                                            "cl_intel_device_side_avc_motion_estimation.luma.predictor"
                                        ] = "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.frame.dir"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.slice"] =
                                            "uint",
                                        ["cl_intel_device_side_avc_motion_estimation.scan.dir"] =
                                            "uint",
                                        ["cl_command_termination_reason_arm"] = "uint",
                                        ["cl_platform_command_buffer_capabilities_khr"] = "uint",
                                        ["cl_device_command_buffer_capabilities_khr"] = "uint",
                                        ["cl_media_adapter_type_khr"] = "uint",
                                        ["cl_media_adapter_set_khr"] = "uint",
                                        ["host_cache_policy"] = "uint",
                                        ["allocation_type"] = "uint",
                                        ["cl_unified_shared_memory_capabilities_intel"] = "uint",
                                        ["cl_mem_alloc_info_intel"] = "uint",
                                        ["cl_semaphore_type"] = "uint",
                                        ["cl_kernel_workgroup_info"] = "uint",
                                    },
                                    Vendors = ["ALTERA"],
                                    IdentifyEnumMemberImpliedVendors = true,
                                }
                            )
                            .TransformHandles(new() { UseDsl = true })
                            .TransformFunctions(new() { BoolTypes = new() { ["cl_bool"] = null } })
                            .TransformProperties(new() { BoolTypes = new() { ["cl_bool"] = null } })
                            .IdentifySharedPrefixes(
                                new()
                                {
                                    GlobalPrefixHints = ["cl", "_cl"],
                                    PrefixOverrides = new()
                                    {
                                        ["cl_device_info"] = "CL_DEVICE",
                                        ["cl_context_properties"] = "CL_CONTEXT",
                                        ["cl_device_integer_dot_product_capabilities"] =
                                            "CL_DEVICE_INTEGER_DOT_PRODUCT",
                                        ["cl_device_integer_dot_product_capabilities_khr"] =
                                            "CL_DEVICE_INTEGER_DOT_PRODUCT",
                                    },
                                }
                            )
                            .PrettifyNames(
                                new()
                                {
                                    NameOverrides = new()
                                    {
                                        ["CL_DRIVER_VERSION"] = "DriverVersion",
                                        ["CL_DRIVER_UUID"] = "DriverUuid",
                                        ["CL_DRIVER_UUID_KHR"] = "DriverUuidKHR",
                                    },
                                    Affixes = new()
                                    {
                                        ["HandleType"] = new() { Order = 1 },
                                        ["FunctionPointerDelegateType"] = new() { Order = 1 },
                                        ["KhronosVendor"] = new() { Order = -1, Capitalize = true },
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
            )
            .DefineJob(
                "OpenAL",
                new()
                {
                    Solution = "Silk.NET.slnx",
                    SourceProject = "sources/OpenAL/OpenAL/Silk.NET.OpenAL.csproj",
                    DefaultLicenseHeader = "eng/silktouch/header.txt",
                },
                context =>
                    context.Mods(mods =>
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
                            .TransformFunctions(
                                new()
                                {
                                    BoolTypes = new()
                                    {
                                        ["ALboolean"] = null,
                                        ["ALCboolean"] = null,
                                    },
                                }
                            )
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
            )
            .DefineJob(
                "OpenXR",
                new()
                {
                    Solution = "Silk.NET.slnx",
                    SourceProject = "sources/OpenXR/OpenXR/Silk.NET.OpenXR.csproj",
                    DefaultLicenseHeader = "eng/silktouch/header.txt",
                },
                context =>
                    context.Mods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles =
                                    [
                                        "eng/silktouch/openxr/**/generate.rsp",
                                    ],
                                    InputSourceRoot = "sources/OpenXR",
                                    InputTestRoot = "tests/OpenXR",
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
                                    SpecPath =
                                        "eng/submodules/openxr-sdk/specification/registry/xr.xml",
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
                            .InterceptNativeFunctions(
                                new() { NativeFunctionNames = ["xrCreateInstance"] }
                            )
                            .TransformFunctions(new() { BoolTypes = new() { ["XrBool32"] = null } })
                            .TransformProperties(
                                new() { BoolTypes = new() { ["XrBool32"] = null } }
                            )
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
                                        new()
                                        {
                                            MemberName = "MaxEnum",
                                            MemberValue = "0x7FFFFFFF",
                                        },
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
                    )
            )
            .DefineJob(
                "Vulkan",
                new()
                {
                    Solution = "Silk.NET.slnx",
                    SourceProject = "sources/Vulkan/Vulkan/Silk.NET.Vulkan.csproj",
                    DefaultLicenseHeader = "eng/silktouch/header.txt",
                },
                context =>
                    context.Mods(mods =>
                        mods.AddIncludes(new())
                            .ClangScraper(
                                new()
                                {
                                    ClangSharpResponseFiles =
                                    [
                                        "eng/silktouch/vulkan/**/generate.rsp",
                                    ],
                                    InputSourceRoot = "sources/Vulkan",
                                    InputTestRoot = "tests/Vulkan",
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
                                    SpecPath = "eng/submodules/vulkan-docs/xml/vk.xml",
                                    Namespace = "Silk.NET.Vulkan",
                                    StructureTypes = ["VkStructureType"],
                                    FlagsTypes = ["VkFlags", "VkFlags64"],
                                    ExcludeVendorSuffixIdentification =
                                    [
                                        "VK_VENDOR_ID_VIV",
                                        "VK_VENDOR_ID_VSI",
                                        "VK_VENDOR_ID_MESA",
                                    ],
                                    IdentifyEnumMemberImpliedVendors = true,
                                }
                            )
                            .AddApiProfiles(
                                new()
                                {
                                    Profiles =
                                    [
                                        new() { Profile = "vulkan", SourceSubdirectory = "vulkan" },
                                    ],
                                }
                            )
                            .InterceptNativeFunctions(
                                new()
                                {
                                    NativeFunctionNames = ["vkCreateInstance", "vkCreateDevice"],
                                }
                            )
                            .TransformFunctions(new() { BoolTypes = new() { ["VkBool32"] = null } })
                            .TransformProperties(
                                new() { BoolTypes = new() { ["VkBool32"] = null } }
                            )
                            .IdentifySharedPrefixes(
                                new()
                                {
                                    GlobalPrefixHints = ["PFN_vk", "vk"],
                                    PrefixOverrides = new()
                                    {
                                        ["VkImageCreateFlags2KHR"] = "VK_IMAGE_CREATE_2",
                                        ["VkPipelineCreateFlags2"] = "VK_PIPELINE_CREATE_2",
                                        ["VkMemoryDecompressionMethodFlagsEXT"] =
                                            "VK_MEMORY_DECOMPRESSION_METHOD",
                                    },
                                }
                            )
                            .PrettifyNames(
                                new()
                                {
                                    NameOverrides = new() { ["numAABBs"] = "NumAabbs" },
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
                                        new()
                                        {
                                            MemberName = "MaxEnum",
                                            MemberValue = "0x7FFFFFFF",
                                        },
                                        new()
                                        {
                                            MemberName = "Invalid",
                                            MemberValue = "0x7FFFFFFF",
                                        },
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
                    )
            )
            .RunAsync(args);
}
