// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct QueueFamilyProperties
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
        public QueueFlags QueueFlags;
/// <summary></summary>
        public uint QueueCount;
/// <summary></summary>
        public uint TimestampValidBits;
/// <summary></summary>
        public Extent3D MinImageTransferGranularity;
    }
}
