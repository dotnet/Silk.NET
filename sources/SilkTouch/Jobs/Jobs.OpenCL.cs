// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Jobs;

internal static partial class Jobs
{
    public static SilkTouchHost DefineOpenCLJob(this SilkTouchHost host) =>
        host.DefineJob(
            "OpenCL",
            new()
            {
                Solution = "Silk.NET.slnx",
                SourceProject = "sources/OpenCL/OpenCL/Silk.NET.OpenCL.csproj",
                DefaultLicenseHeader = "eng/silktouch/header.txt",
                DefaultNamespace = "Silk.NET.OpenCL",
            },
            context =>
                context
                    .WithDefaultFunctionTransformers(
                        new() { BoolTypes = new() { ["cl_bool"] = null } }
                    )
                    .WithMods(mods =>
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
                            .TransformFunctions()
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
        );
}
