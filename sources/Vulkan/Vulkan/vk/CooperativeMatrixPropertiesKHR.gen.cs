// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCooperativeMatrixPropertiesKHR")]
public unsafe partial struct CooperativeMatrixPropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CooperativeMatrixPropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("MSize")]
    public uint MSize;

    [NativeName("NSize")]
    public uint NSize;

    [NativeName("KSize")]
    public uint KSize;

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

    public CooperativeMatrixPropertiesKHR() { }
}
