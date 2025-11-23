// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PipelineCompilerControlCreateInfoAMD
{
    [SupportedApiProfile("vulkan", ["VK_AMD_pipeline_compiler_control"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_AMD_pipeline_compiler_control"])]
    public void* PNext;

    [NativeTypeName("VkPipelineCompilerControlFlagsAMD")]
    [SupportedApiProfile("vulkan", ["VK_AMD_pipeline_compiler_control"])]
    public PipelineCompilerControlFlagsAMD CompilerControlFlags;
}
