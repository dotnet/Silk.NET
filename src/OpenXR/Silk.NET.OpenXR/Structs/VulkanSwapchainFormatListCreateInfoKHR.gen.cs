// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    public unsafe struct VulkanSwapchainFormatListCreateInfoKHR
    {
        public VulkanSwapchainFormatListCreateInfoKHR
        (
            StructureType type = StructureType.TypeVulkanSwapchainFormatListCreateInfoKhr,
            void* next = default,
            uint viewFormatCount = default,
            VkFormat* viewFormats = default
        )
        {
           Type = type;
           Next = next;
           ViewFormatCount = viewFormatCount;
           ViewFormats = viewFormats;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public uint ViewFormatCount;
/// <summary></summary>
        public VkFormat* ViewFormats;
    }
}
