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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueueFamilyProperties")]
    public unsafe partial struct QueueFamilyProperties
    {
        public QueueFamilyProperties
        (
            QueueFlags queueFlags = default,
            uint queueCount = default,
            uint timestampValidBits = default,
            Extent3D minImageTransferGranularity = default
        )
        {
            QueueFlags = queueFlags;
            QueueCount = queueCount;
            TimestampValidBits = timestampValidBits;
            MinImageTransferGranularity = minImageTransferGranularity;
        }

/// <summary></summary>
        [NativeName("Type", "VkQueueFlags")]
        [NativeName("Type.Name", "VkQueueFlags")]
        [NativeName("Name", "queueFlags")]
        public QueueFlags QueueFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueCount")]
        public uint QueueCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "timestampValidBits")]
        public uint TimestampValidBits;
/// <summary></summary>
        [NativeName("Type", "VkExtent3D")]
        [NativeName("Type.Name", "VkExtent3D")]
        [NativeName("Name", "minImageTransferGranularity")]
        public Extent3D MinImageTransferGranularity;
    }
}
