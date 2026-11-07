// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceTexelBufferAlignmentProperties")]
public unsafe partial struct PhysicalDeviceTexelBufferAlignmentProperties
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceTexelBufferAlignmentProperties;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("storageTexelBufferOffsetAlignmentBytes")]
    public ulong StorageTexelBufferOffsetAlignmentBytes;

    [NativeName("storageTexelBufferOffsetSingleTexelAlignment")]
    public MaybeBool<uint> StorageTexelBufferOffsetSingleTexelAlignment;

    [NativeName("uniformTexelBufferOffsetAlignmentBytes")]
    public ulong UniformTexelBufferOffsetAlignmentBytes;

    [NativeName("uniformTexelBufferOffsetSingleTexelAlignment")]
    public MaybeBool<uint> UniformTexelBufferOffsetSingleTexelAlignment;

    public PhysicalDeviceTexelBufferAlignmentProperties() { }
}
