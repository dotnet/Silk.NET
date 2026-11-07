// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCopyMicromapToMemoryInfoEXT")]
public unsafe partial struct CopyMicromapToMemoryInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.CopyMicromapToMemoryInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("src")]
    public MicromapHandleEXT Src;

    [NativeName("dst")]
    public DeviceOrHostAddressKHR Dst;

    [NativeName("mode")]
    public CopyMicromapModeEXT Mode;

    public CopyMicromapToMemoryInfoEXT() { }
}
