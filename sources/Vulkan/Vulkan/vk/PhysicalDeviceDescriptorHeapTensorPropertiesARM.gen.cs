// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDescriptorHeapTensorPropertiesARM")]
public unsafe partial struct PhysicalDeviceDescriptorHeapTensorPropertiesARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDescriptorHeapTensorPropertiesARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("tensorDescriptorSize")]
    public ulong TensorDescriptorSize;

    [NativeName("tensorDescriptorAlignment")]
    public ulong TensorDescriptorAlignment;

    [NativeName("tensorCaptureReplayOpaqueDataSize")]
    public nuint TensorCaptureReplayOpaqueDataSize;

    public PhysicalDeviceDescriptorHeapTensorPropertiesARM() { }
}
