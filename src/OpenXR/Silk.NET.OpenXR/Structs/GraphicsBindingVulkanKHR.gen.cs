// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrGraphicsBindingVulkanKHR")]
    public unsafe partial struct GraphicsBindingVulkanKHR
    {
        public GraphicsBindingVulkanKHR
        (
            StructureType type = StructureType.TypeGraphicsBindingVulkanKhr,
            void* next = default,
            Silk.NET.GLFW.VkHandle instance = default,
            Silk.NET.GLFW.VkHandle physicalDevice = default,
            Silk.NET.GLFW.VkHandle device = default,
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
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "VkInstance")]
        [NativeName("Type.Name", "VkInstance")]
        [NativeName("Name", "instance")]
        public Silk.NET.GLFW.VkHandle Instance;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "physicalDevice")]
        public Silk.NET.GLFW.VkHandle PhysicalDevice;
/// <summary></summary>
        [NativeName("Type", "VkDevice")]
        [NativeName("Type.Name", "VkDevice")]
        [NativeName("Name", "device")]
        public Silk.NET.GLFW.VkHandle Device;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndex")]
        public uint QueueFamilyIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueIndex")]
        public uint QueueIndex;
    }
}
