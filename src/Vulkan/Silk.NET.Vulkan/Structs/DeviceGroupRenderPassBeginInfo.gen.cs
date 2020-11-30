// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceGroupRenderPassBeginInfo")]
    public unsafe partial struct DeviceGroupRenderPassBeginInfo
    {
        public DeviceGroupRenderPassBeginInfo
        (
            StructureType? sType = StructureType.DeviceGroupRenderPassBeginInfo,
            void* pNext = null,
            uint? deviceMask = null,
            uint? deviceRenderAreaCount = null,
            Rect2D* pDeviceRenderAreas = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (deviceMask is not null)
            {
                DeviceMask = deviceMask.Value;
            }

            if (deviceRenderAreaCount is not null)
            {
                DeviceRenderAreaCount = deviceRenderAreaCount.Value;
            }

            if (pDeviceRenderAreas is not null)
            {
                PDeviceRenderAreas = pDeviceRenderAreas;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceMask")]
        public uint DeviceMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceRenderAreaCount")]
        public uint DeviceRenderAreaCount;
/// <summary></summary>
        [NativeName("Type", "VkRect2D*")]
        [NativeName("Type.Name", "VkRect2D")]
        [NativeName("Name", "pDeviceRenderAreas")]
        public Rect2D* PDeviceRenderAreas;
    }
}
