// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrVulkanInstanceCreateInfoKHR")]
    public unsafe partial struct VulkanInstanceCreateInfoKHR
    {
        public VulkanInstanceCreateInfoKHR
        (
            StructureType? type = StructureType.TypeVulkanInstanceCreateInfoKhr,
            void* next = null,
            ulong? systemId = null,
            VulkanInstanceCreateFlagsKHR? createFlags = null,
            FuncPtr? pfnGetInstanceProcAddr = null,
            void* vulkanCreateInfo = null,
            void* vulkanAllocator = null
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
        [NativeName("Type", "XrVulkanInstanceCreateFlagsKHR")]
        [NativeName("Type.Name", "XrVulkanInstanceCreateFlagsKHR")]
        [NativeName("Name", "createFlags")]
        public VulkanInstanceCreateFlagsKHR CreateFlags;
/// <summary></summary>
        [NativeName("Type", "PFN_vkGetInstanceProcAddr")]
        [NativeName("Type.Name", "PFN_vkGetInstanceProcAddr")]
        [NativeName("Name", "pfnGetInstanceProcAddr")]
        public FuncPtr PfnGetInstanceProcAddr;
/// <summary></summary>
        [NativeName("Type", "VkInstanceCreateInfo*")]
        [NativeName("Type.Name", "VkInstanceCreateInfo")]
        [NativeName("Name", "vulkanCreateInfo")]
        public void* VulkanCreateInfo;
/// <summary></summary>
        [NativeName("Type", "VkAllocationCallbacks*")]
        [NativeName("Type.Name", "VkAllocationCallbacks")]
        [NativeName("Name", "vulkanAllocator")]
        public void* VulkanAllocator;
    }
}
