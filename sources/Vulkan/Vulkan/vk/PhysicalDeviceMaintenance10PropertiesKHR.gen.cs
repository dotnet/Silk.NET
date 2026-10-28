// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceMaintenance10PropertiesKHR")]
public unsafe partial struct PhysicalDeviceMaintenance10PropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceMaintenance10PropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("rgba4OpaqueBlackSwizzled")]
    public MaybeBool<uint> Rgba4OpaqueBlackSwizzled;

    [NativeName("resolveSrgbFormatAppliesTransferFunction")]
    public MaybeBool<uint> ResolveSrgbFormatAppliesTransferFunction;

    [NativeName("resolveSrgbFormatSupportsTransferFunctionControl")]
    public MaybeBool<uint> ResolveSrgbFormatSupportsTransferFunctionControl;

    public PhysicalDeviceMaintenance10PropertiesKHR() { }
}
