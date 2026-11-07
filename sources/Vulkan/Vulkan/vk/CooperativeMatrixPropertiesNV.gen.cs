// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCooperativeMatrixPropertiesNV")]
public unsafe partial struct CooperativeMatrixPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CooperativeMatrixPropertiesNV;

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

    [NativeName("DType")]
    public ComponentTypeKHR DType;

    [NativeName("scope")]
    public ScopeKHR Scope;

    public CooperativeMatrixPropertiesNV() { }
}
