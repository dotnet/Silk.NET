// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVulkanDeviceCreateInfoKHR")]
    public unsafe partial struct VulkanDeviceCreateInfoKHR
    {
        public VulkanDeviceCreateInfoKHR
        (
            StructureType? type = StructureType.TypeVulkanDeviceCreateInfoKhr,
            void* next = null,
            ulong? systemId = null,
            VulkanDeviceCreateFlagsKHR? createFlags = null,
            PfnVoidFunction? pfnGetInstanceProcAddr = null,
            Silk.NET.Core.Native.VkHandle? vulkanPhysicalDevice = null,
            void** vulkanCreateInfo = null,
            void** vulkanAllocator = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (systemId is not null)
            {
                SystemId = systemId.Value;
            }

            if (createFlags is not null)
            {
                CreateFlags = createFlags.Value;
            }

            if (pfnGetInstanceProcAddr is not null)
            {
                PfnGetInstanceProcAddr = pfnGetInstanceProcAddr.Value;
            }

            if (vulkanPhysicalDevice is not null)
            {
                VulkanPhysicalDevice = vulkanPhysicalDevice.Value;
            }

            if (vulkanCreateInfo is not null)
            {
                VulkanCreateInfo = vulkanCreateInfo;
            }

            if (vulkanAllocator is not null)
            {
                VulkanAllocator = vulkanAllocator;
            }
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
        [NativeName("Type", "XrSystemId")]
        [NativeName("Type.Name", "XrSystemId")]
        [NativeName("Name", "systemId")]
        public ulong SystemId;
/// <summary></summary>
        [NativeName("Type", "XrVulkanDeviceCreateFlagsKHR")]
        [NativeName("Type.Name", "XrVulkanDeviceCreateFlagsKHR")]
        [NativeName("Name", "createFlags")]
        public VulkanDeviceCreateFlagsKHR CreateFlags;
/// <summary></summary>
        [NativeName("Type", "PFN_vkGetInstanceProcAddr")]
        [NativeName("Type.Name", "PFN_vkGetInstanceProcAddr")]
        [NativeName("Name", "pfnGetInstanceProcAddr")]
        public PfnVoidFunction PfnGetInstanceProcAddr;
/// <summary></summary>
        [NativeName("Type", "VkPhysicalDevice")]
        [NativeName("Type.Name", "VkPhysicalDevice")]
        [NativeName("Name", "vulkanPhysicalDevice")]
        public Silk.NET.Core.Native.VkHandle VulkanPhysicalDevice;
/// <summary></summary>
        [NativeName("Type", "VkDeviceCreateInfo*")]
        [NativeName("Type.Name", "VkDeviceCreateInfo")]
        [NativeName("Name", "vulkanCreateInfo")]
        public void** VulkanCreateInfo;
/// <summary></summary>
        [NativeName("Type", "VkAllocationCallbacks*")]
        [NativeName("Type.Name", "VkAllocationCallbacks")]
        [NativeName("Name", "vulkanAllocator")]
        public void** VulkanAllocator;
    }
}
