// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCooperativeMatrixFlexibleDimensionsPropertiesNV")]
public unsafe partial struct CooperativeMatrixFlexibleDimensionsPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CooperativeMatrixFlexibleDimensionsPropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("MGranularity")]
    public uint MGranularity;

    [NativeName("NGranularity")]
    public uint NGranularity;

    [NativeName("KGranularity")]
    public uint KGranularity;

    [NativeName("AType")]
    public ComponentTypeKHR AType;

    [NativeName("BType")]
    public ComponentTypeKHR BType;

    [NativeName("CType")]
    public ComponentTypeKHR CType;

    [NativeName("ResultType")]
    public ComponentTypeKHR ResultType;

    [NativeName("saturatingAccumulation")]
    public MaybeBool<uint> SaturatingAccumulation;

    [NativeName("scope")]
    public ScopeKHR Scope;

    [NativeName("workgroupInvocations")]
    public uint WorkgroupInvocations;

    public CooperativeMatrixFlexibleDimensionsPropertiesNV() { }
}
