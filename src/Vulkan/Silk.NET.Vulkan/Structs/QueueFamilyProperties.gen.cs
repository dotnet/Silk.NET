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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueueFamilyProperties")]
    public unsafe partial struct QueueFamilyProperties
    {
        public QueueFamilyProperties
        (
            QueueFlags? queueFlags = null,
            uint? queueCount = null,
            uint? timestampValidBits = null,
            Extent3D? minImageTransferGranularity = null
        ) : this()
        {
            if (queueFlags is not null)
            {
                QueueFlags = queueFlags.Value;
            }

            if (queueCount is not null)
            {
                QueueCount = queueCount.Value;
            }

            if (timestampValidBits is not null)
            {
                TimestampValidBits = timestampValidBits.Value;
            }

            if (minImageTransferGranularity is not null)
            {
                MinImageTransferGranularity = minImageTransferGranularity.Value;
            }
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
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
