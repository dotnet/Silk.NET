// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkMicromapCreateInfoEXT")]
public unsafe partial struct MicromapCreateInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.MicromapCreateInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("createFlags")]
    public MicromapCreateFlagsEXT CreateFlags;

    [NativeName("buffer")]
    public BufferHandle Buffer;

    [NativeName("offset")]
    public ulong Offset;

    [NativeName("size")]
    public ulong Size;

    [NativeName("type")]
    public MicromapTypeEXT Type;

    [NativeName("deviceAddress")]
    public ulong DeviceAddress;

    public MicromapCreateInfoEXT() { }
}
