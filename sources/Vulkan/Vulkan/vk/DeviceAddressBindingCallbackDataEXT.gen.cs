// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceAddressBindingCallbackDataEXT")]
public unsafe partial struct DeviceAddressBindingCallbackDataEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.DeviceAddressBindingCallbackDataEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public DeviceAddressBindingFlagsEXT Flags;

    [NativeName("baseAddress")]
    public ulong BaseAddress;

    [NativeName("size")]
    public ulong Size;

    [NativeName("bindingType")]
    public DeviceAddressBindingTypeEXT BindingType;

    public DeviceAddressBindingCallbackDataEXT() { }
}
