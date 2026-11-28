// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkExportMetalObjectTypeFlagsEXT")]
[Flags]
[SupportedApiProfile("vulkan")]
public enum ExportMetalObjectTypeFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_EXPORT_METAL_OBJECT_TYPE_METAL_DEVICE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    MetalDeviceBit = 0x1,

    [NativeName("VK_EXPORT_METAL_OBJECT_TYPE_METAL_COMMAND_QUEUE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    MetalCommandQueueBit = 0x2,

    [NativeName("VK_EXPORT_METAL_OBJECT_TYPE_METAL_BUFFER_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    MetalBufferBit = 0x4,

    [NativeName("VK_EXPORT_METAL_OBJECT_TYPE_METAL_TEXTURE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    MetalTextureBit = 0x8,

    [NativeName("VK_EXPORT_METAL_OBJECT_TYPE_METAL_IOSURFACE_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    MetalIosurfaceBit = 0x10,

    [NativeName("VK_EXPORT_METAL_OBJECT_TYPE_METAL_SHARED_EVENT_BIT_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_metal_objects"])]
    MetalSharedEventBit = 0x20,
}
