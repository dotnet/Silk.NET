// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVulkan13Features")]
public unsafe partial struct PhysicalDeviceVulkan13Features
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVulkan1x3Features;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("robustImageAccess")]
    public MaybeBool<uint> RobustImageAccess;

    [NativeName("inlineUniformBlock")]
    public MaybeBool<uint> InlineUniformBlock;

    [NativeName("descriptorBindingInlineUniformBlockUpdateAfterBind")]
    public MaybeBool<uint> DescriptorBindingInlineUniformBlockUpdateAfterBind;

    [NativeName("pipelineCreationCacheControl")]
    public MaybeBool<uint> PipelineCreationCacheControl;

    [NativeName("privateData")]
    public MaybeBool<uint> PrivateData;

    [NativeName("shaderDemoteToHelperInvocation")]
    public MaybeBool<uint> ShaderDemoteToHelperInvocation;

    [NativeName("shaderTerminateInvocation")]
    public MaybeBool<uint> ShaderTerminateInvocation;

    [NativeName("subgroupSizeControl")]
    public MaybeBool<uint> SubgroupSizeControl;

    [NativeName("computeFullSubgroups")]
    public MaybeBool<uint> ComputeFullSubgroups;

    [NativeName("synchronization2")]
    public MaybeBool<uint> Synchronization2;

    [NativeName("textureCompressionASTC_HDR")]
    public MaybeBool<uint> TextureCompressionAstcHdr;

    [NativeName("shaderZeroInitializeWorkgroupMemory")]
    public MaybeBool<uint> ShaderZeroInitializeWorkgroupMemory;

    [NativeName("dynamicRendering")]
    public MaybeBool<uint> DynamicRendering;

    [NativeName("shaderIntegerDotProduct")]
    public MaybeBool<uint> ShaderIntegerDotProduct;

    [NativeName("maintenance4")]
    public MaybeBool<uint> Maintenance4;

    public PhysicalDeviceVulkan13Features() { }
}
