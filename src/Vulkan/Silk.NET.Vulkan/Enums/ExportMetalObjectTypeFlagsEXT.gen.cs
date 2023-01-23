// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExportMetalObjectTypeFlagsEXT")]
    public enum ExportMetalObjectTypeFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeviceBitExt\"")]
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_DEVICE_BIT_EXT")]
        ExportMetalObjectTypeMetalDeviceBitExt = 1,
        [Obsolete("Deprecated in favour of \"CommandQueueBitExt\"")]
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_COMMAND_QUEUE_BIT_EXT")]
        ExportMetalObjectTypeMetalCommandQueueBitExt = 2,
        [Obsolete("Deprecated in favour of \"BufferBitExt\"")]
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_BUFFER_BIT_EXT")]
        ExportMetalObjectTypeMetalBufferBitExt = 4,
        [Obsolete("Deprecated in favour of \"TextureBitExt\"")]
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_TEXTURE_BIT_EXT")]
        ExportMetalObjectTypeMetalTextureBitExt = 8,
        [Obsolete("Deprecated in favour of \"IosurfaceBitExt\"")]
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_IOSURFACE_BIT_EXT")]
        ExportMetalObjectTypeMetalIosurfaceBitExt = 16,
        [Obsolete("Deprecated in favour of \"SharedEventBitExt\"")]
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_SHARED_EVENT_BIT_EXT")]
        ExportMetalObjectTypeMetalSharedEventBitExt = 32,
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_DEVICE_BIT_EXT")]
        DeviceBitExt = 1,
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_COMMAND_QUEUE_BIT_EXT")]
        CommandQueueBitExt = 2,
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_BUFFER_BIT_EXT")]
        BufferBitExt = 4,
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_TEXTURE_BIT_EXT")]
        TextureBitExt = 8,
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_IOSURFACE_BIT_EXT")]
        IosurfaceBitExt = 16,
        [NativeName("Name", "VK_EXPORT_METAL_OBJECT_TYPE_METAL_SHARED_EVENT_BIT_EXT")]
        SharedEventBitExt = 32,
    }
}
