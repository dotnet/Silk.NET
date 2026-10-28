// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceVulkan11Features")]
public unsafe partial struct PhysicalDeviceVulkan11Features
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceVulkan1x1Features;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("storageBuffer16BitAccess")]
    public MaybeBool<uint> StorageBuffer16BitAccess;

    [NativeName("uniformAndStorageBuffer16BitAccess")]
    public MaybeBool<uint> UniformAndStorageBuffer16BitAccess;

    [NativeName("storagePushConstant16")]
    public MaybeBool<uint> StoragePushConstant16;

    [NativeName("storageInputOutput16")]
    public MaybeBool<uint> StorageInputOutput16;

    [NativeName("multiview")]
    public MaybeBool<uint> Multiview;

    [NativeName("multiviewGeometryShader")]
    public MaybeBool<uint> MultiviewGeometryShader;

    [NativeName("multiviewTessellationShader")]
    public MaybeBool<uint> MultiviewTessellationShader;

    [NativeName("variablePointersStorageBuffer")]
    public MaybeBool<uint> VariablePointersStorageBuffer;

    [NativeName("variablePointers")]
    public MaybeBool<uint> VariablePointers;

    [NativeName("protectedMemory")]
    public MaybeBool<uint> ProtectedMemory;

    [NativeName("samplerYcbcrConversion")]
    public MaybeBool<uint> SamplerYcbcrConversion;

    [NativeName("shaderDrawParameters")]
    public MaybeBool<uint> ShaderDrawParameters;

    public PhysicalDeviceVulkan11Features() { }
}
