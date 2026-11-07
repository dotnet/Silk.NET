// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkResourceDescriptorDataEXT")]
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct ResourceDescriptorDataEXT
{
    [NativeName("pImage")]
    [FieldOffset(0)]
    public ImageDescriptorInfoEXT* PImage;

    [NativeName("pTexelBuffer")]
    [FieldOffset(0)]
    public TexelBufferDescriptorInfoEXT* PTexelBuffer;

    [NativeName("pAddressRange")]
    [FieldOffset(0)]
    public DeviceAddressRangeKHR* PAddressRange;

    [NativeName("pTensorARM")]
    [FieldOffset(0)]
    public TensorViewCreateInfoARM* PTensorARM;
}
