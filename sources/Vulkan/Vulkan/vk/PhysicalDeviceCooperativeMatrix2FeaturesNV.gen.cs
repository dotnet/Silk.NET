// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceCooperativeMatrix2FeaturesNV")]
public unsafe partial struct PhysicalDeviceCooperativeMatrix2FeaturesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceCooperativeMatrix2FeaturesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("cooperativeMatrixWorkgroupScope")]
    public MaybeBool<uint> CooperativeMatrixWorkgroupScope;

    [NativeName("cooperativeMatrixFlexibleDimensions")]
    public MaybeBool<uint> CooperativeMatrixFlexibleDimensions;

    [NativeName("cooperativeMatrixReductions")]
    public MaybeBool<uint> CooperativeMatrixReductions;

    [NativeName("cooperativeMatrixConversions")]
    public MaybeBool<uint> CooperativeMatrixConversions;

    [NativeName("cooperativeMatrixPerElementOperations")]
    public MaybeBool<uint> CooperativeMatrixPerElementOperations;

    [NativeName("cooperativeMatrixTensorAddressing")]
    public MaybeBool<uint> CooperativeMatrixTensorAddressing;

    [NativeName("cooperativeMatrixBlockLoads")]
    public MaybeBool<uint> CooperativeMatrixBlockLoads;

    public PhysicalDeviceCooperativeMatrix2FeaturesNV() { }
}
