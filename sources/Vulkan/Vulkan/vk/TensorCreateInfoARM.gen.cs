// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTensorCreateInfoARM")]
public unsafe partial struct TensorCreateInfoARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.TensorCreateInfoARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public TensorCreateFlagsARM Flags;

    [NativeName("pDescription")]
    public TensorDescriptionARM* PDescription;

    [NativeName("sharingMode")]
    public SharingMode SharingMode;

    [NativeName("queueFamilyIndexCount")]
    public uint QueueFamilyIndexCount;

    [NativeName("pQueueFamilyIndices")]
    public uint* PQueueFamilyIndices;

    public TensorCreateInfoARM() { }
}
