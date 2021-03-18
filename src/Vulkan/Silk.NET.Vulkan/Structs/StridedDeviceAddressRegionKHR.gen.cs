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
    [NativeName("Name", "VkStridedDeviceAddressRegionKHR")]
    public unsafe partial struct StridedDeviceAddressRegionKHR
    {
        public StridedDeviceAddressRegionKHR
        (
            ulong? deviceAddress = null,
            ulong? stride = null,
            ulong? size = null
        ) : this()
        {
            if (deviceAddress is not null)
            {
                DeviceAddress = deviceAddress.Value;
            }

            if (stride is not null)
            {
                Stride = stride.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "deviceAddress")]
        public ulong DeviceAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "stride")]
        public ulong Stride;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "size")]
        public ulong Size;
    }
}
