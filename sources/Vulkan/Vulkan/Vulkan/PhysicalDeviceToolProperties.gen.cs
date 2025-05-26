// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceToolProperties
{
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public StructureType SType;

    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public void* PNext;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public _name_e__FixedBuffer Name;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public _version_e__FixedBuffer Version;

    [NativeTypeName("VkToolPurposeFlags")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public uint Purposes;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public _description_e__FixedBuffer Description;

    [NativeTypeName("char[256]")]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public _layer_e__FixedBuffer Layer;

    [InlineArray(256)]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public partial struct _name_e__FixedBuffer
    {
        [SupportedApiProfile("vulkan")]
        public sbyte e0;
    }

    [InlineArray(256)]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public partial struct _version_e__FixedBuffer
    {
        [SupportedApiProfile("vulkan")]
        public sbyte e0;
    }

    [InlineArray(256)]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public partial struct _description_e__FixedBuffer
    {
        [SupportedApiProfile("vulkan")]
        public sbyte e0;
    }

    [InlineArray(256)]
    [SupportedApiProfile("vulkan", ["VK_VERSION_1_3", "VK_VERSION_1_4"], MinVersion = "1.3")]
    public partial struct _layer_e__FixedBuffer
    {
        [SupportedApiProfile("vulkan")]
        public sbyte e0;
    }
}
