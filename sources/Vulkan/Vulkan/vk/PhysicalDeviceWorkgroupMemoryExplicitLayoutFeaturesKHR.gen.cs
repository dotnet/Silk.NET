// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR")]
public unsafe partial struct PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR
{
    [NativeName("sType")]
    public StructureType SType =
        StructureType.PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("workgroupMemoryExplicitLayout")]
    public MaybeBool<uint> WorkgroupMemoryExplicitLayout;

    [NativeName("workgroupMemoryExplicitLayoutScalarBlockLayout")]
    public MaybeBool<uint> WorkgroupMemoryExplicitLayoutScalarBlockLayout;

    [NativeName("workgroupMemoryExplicitLayout8BitAccess")]
    public MaybeBool<uint> WorkgroupMemoryExplicitLayout8BitAccess;

    [NativeName("workgroupMemoryExplicitLayout16BitAccess")]
    public MaybeBool<uint> WorkgroupMemoryExplicitLayout16BitAccess;

    public PhysicalDeviceWorkgroupMemoryExplicitLayoutFeaturesKHR() { }
}
