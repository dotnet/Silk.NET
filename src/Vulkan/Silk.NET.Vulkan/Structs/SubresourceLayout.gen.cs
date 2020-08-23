// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkSubresourceLayout")]
    public unsafe partial struct SubresourceLayout
    {
        public SubresourceLayout
        (
            ulong offset = default,
            ulong size = default,
            ulong rowPitch = default,
            ulong arrayPitch = default,
            ulong depthPitch = default
        )
        {
            Offset = offset;
            Size = size;
            RowPitch = rowPitch;
            ArrayPitch = arrayPitch;
            DepthPitch = depthPitch;
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "offset")]
        public ulong Offset;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "rowPitch")]
        public ulong RowPitch;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "arrayPitch")]
        public ulong ArrayPitch;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "depthPitch")]
        public ulong DepthPitch;
    }
}
