// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDeviceGeneratedCommandsPropertiesEXT")]
public unsafe partial struct PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxIndirectPipelineCount")]
    public uint MaxIndirectPipelineCount;

    [NativeName("maxIndirectShaderObjectCount")]
    public uint MaxIndirectShaderObjectCount;

    [NativeName("maxIndirectSequenceCount")]
    public uint MaxIndirectSequenceCount;

    [NativeName("maxIndirectCommandsTokenCount")]
    public uint MaxIndirectCommandsTokenCount;

    [NativeName("maxIndirectCommandsTokenOffset")]
    public uint MaxIndirectCommandsTokenOffset;

    [NativeName("maxIndirectCommandsIndirectStride")]
    public uint MaxIndirectCommandsIndirectStride;

    [NativeName("supportedIndirectCommandsInputModes")]
    public IndirectCommandsInputModeFlagsEXT SupportedIndirectCommandsInputModes;

    [NativeName("supportedIndirectCommandsShaderStages")]
    public ShaderStageFlags SupportedIndirectCommandsShaderStages;

    [NativeName("supportedIndirectCommandsShaderStagesPipelineBinding")]
    public ShaderStageFlags SupportedIndirectCommandsShaderStagesPipelineBinding;

    [NativeName("supportedIndirectCommandsShaderStagesShaderBinding")]
    public ShaderStageFlags SupportedIndirectCommandsShaderStagesShaderBinding;

    [NativeName("deviceGeneratedCommandsTransformFeedback")]
    public MaybeBool<uint> DeviceGeneratedCommandsTransformFeedback;

    [NativeName("deviceGeneratedCommandsMultiDrawIndirectCount")]
    public MaybeBool<uint> DeviceGeneratedCommandsMultiDrawIndirectCount;

    public PhysicalDeviceDeviceGeneratedCommandsPropertiesEXT() { }
}
