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
    [NativeName("Name", "VkStridedDeviceAddressNV")]
    public unsafe partial struct StridedDeviceAddressNV
    {
        public StridedDeviceAddressNV
        (
            ulong? startAddress = null,
            ulong? strideInBytes = null
        ) : this()
        {
            if (startAddress is not null)
            {
                StartAddress = startAddress.Value;
            }

            if (strideInBytes is not null)
            {
                StrideInBytes = strideInBytes.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "startAddress")]
        public ulong StartAddress;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "strideInBytes")]
        public ulong StrideInBytes;
    }
}
