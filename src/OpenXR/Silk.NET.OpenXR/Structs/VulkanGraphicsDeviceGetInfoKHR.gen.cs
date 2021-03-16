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
    [NativeName("Name", "XrVulkanGraphicsDeviceGetInfoKHR")]
    public unsafe partial struct VulkanGraphicsDeviceGetInfoKHR
    {
        public VulkanGraphicsDeviceGetInfoKHR
        (
            StructureType? type = StructureType.TypeVulkanGraphicsDeviceGetInfoKhr,
            void* next = null,
            ulong? systemId = null,
            Silk.NET.Core.Native.VkHandle? vulkanInstance = null
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

            if (vulkanInstance is not null)
            {
                VulkanInstance = vulkanInstance.Value;
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
        [NativeName("Type", "VkInstance")]
        [NativeName("Type.Name", "VkInstance")]
        [NativeName("Name", "vulkanInstance")]
        public Silk.NET.Core.Native.VkHandle VulkanInstance;
    }
}
