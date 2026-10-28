// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceShaderCorePropertiesAMD")]
public unsafe partial struct PhysicalDeviceShaderCorePropertiesAMD
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceShaderCorePropertiesAMD;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderEngineCount")]
    public uint ShaderEngineCount;

    [NativeName("shaderArraysPerEngineCount")]
    public uint ShaderArraysPerEngineCount;

    [NativeName("computeUnitsPerShaderArray")]
    public uint ComputeUnitsPerShaderArray;

    [NativeName("simdPerComputeUnit")]
    public uint SimdPerComputeUnit;

    [NativeName("wavefrontsPerSimd")]
    public uint WavefrontsPerSimd;

    [NativeName("wavefrontSize")]
    public uint WavefrontSize;

    [NativeName("sgprsPerSimd")]
    public uint SgprsPerSimd;

    [NativeName("minSgprAllocation")]
    public uint MinSgprAllocation;

    [NativeName("maxSgprAllocation")]
    public uint MaxSgprAllocation;

    [NativeName("sgprAllocationGranularity")]
    public uint SgprAllocationGranularity;

    [NativeName("vgprsPerSimd")]
    public uint VgprsPerSimd;

    [NativeName("minVgprAllocation")]
    public uint MinVgprAllocation;

    [NativeName("maxVgprAllocation")]
    public uint MaxVgprAllocation;

    [NativeName("vgprAllocationGranularity")]
    public uint VgprAllocationGranularity;

    public PhysicalDeviceShaderCorePropertiesAMD() { }
}
