// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SilkTouch.Mods;

namespace Silk.NET.SilkTouch.Jobs;

internal static partial class Jobs
{
    public static SilkTouchHost DefineVulkanJob(this SilkTouchHost host) =>
        host.DefineJob(
            "Vulkan",
            new()
            {
                Solution = "Silk.NET.slnx",
                SourceProject = "sources/Vulkan/Vulkan/Silk.NET.Vulkan.csproj",
                DefaultLicenseHeader = "eng/silktouch/vulkan/header.txt",
                DefaultNamespace = "Silk.NET.Vulkan",
            },
            context =>
                context
                    .WithDefaultFunctionTransformers(
                        new() { BoolTypes = new() { ["VkBool32"] = null } }
                    )
                    .AddIncludes(new())
                    .ClangScraper(
                        new()
                        {
                            ClangSharpResponseFiles = ["eng/silktouch/vulkan/**/generate.rsp"],
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
                        new() { NativeFunctionNames = ["vkCreateInstance", "vkCreateDevice"] }
                    )
                    .TransformFunctions()
                    .TransformProperties(new() { BoolTypes = new() { ["VkBool32"] = null } })
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
                                new() { MemberName = "MaxEnum", MemberValue = "0x7FFFFFFF" },
                                new() { MemberName = "Invalid", MemberValue = "0x7FFFFFFF" },
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
