// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkIndirectCommandsInputModeFlagsEXT")]
    public enum IndirectCommandsInputModeFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"VulkanIndexBufferExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_INPUT_MODE_VULKAN_INDEX_BUFFER_EXT")]
        IndirectCommandsInputModeVulkanIndexBufferExt = 1,
        [Obsolete("Deprecated in favour of \"DxgiIndexBufferExt\"")]
        [NativeName("Name", "VK_INDIRECT_COMMANDS_INPUT_MODE_DXGI_INDEX_BUFFER_EXT")]
        IndirectCommandsInputModeDxgiIndexBufferExt = 2,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_INPUT_MODE_VULKAN_INDEX_BUFFER_EXT")]
        VulkanIndexBufferExt = 1,
        [NativeName("Name", "VK_INDIRECT_COMMANDS_INPUT_MODE_DXGI_INDEX_BUFFER_EXT")]
        DxgiIndexBufferExt = 2,
    }
}
