// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDevicePrivateDataCreateInfo")]
public unsafe partial struct DevicePrivateDataCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DevicePrivateDataCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("privateDataSlotRequestCount")]
    public uint PrivateDataSlotRequestCount;

    public DevicePrivateDataCreateInfo() { }
}
