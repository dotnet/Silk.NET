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
    public unsafe struct GraphicsBindingVulkanKHR
    {
        public GraphicsBindingVulkanKHR
        (
            StructureType type = StructureType.TypeGraphicsBindingVulkanKhr,
            void* next = default,
            VkInstance instance = default,
            VkPhysicalDevice physicalDevice = default,
            VkDevice device = default,
            uint queueFamilyIndex = default,
            uint queueIndex = default
        )
        {
           Type = type;
           Next = next;
           Instance = instance;
           PhysicalDevice = physicalDevice;
           Device = device;
           QueueFamilyIndex = queueFamilyIndex;
           QueueIndex = queueIndex;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public VkInstance Instance;
/// <summary></summary>
        public VkPhysicalDevice PhysicalDevice;
/// <summary></summary>
        public VkDevice Device;
/// <summary></summary>
        public uint QueueFamilyIndex;
/// <summary></summary>
        public uint QueueIndex;
    }
}
