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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkDeviceOrHostAddressConstAMDX")]
    public unsafe partial struct DeviceOrHostAddressConstAMDX
    {
        public DeviceOrHostAddressConstAMDX
        (
            ulong? deviceAddress = null,
            void* hostAddress = null
        ) : this()
        {
            if (deviceAddress is not null)
            {
                DeviceAddress = deviceAddress.Value;
            }

            if (hostAddress is not null)
            {
                HostAddress = hostAddress;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkDeviceAddress")]
        [NativeName("Type.Name", "VkDeviceAddress")]
        [NativeName("Name", "deviceAddress")]
        public ulong DeviceAddress;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "hostAddress")]
        public void* HostAddress;
    }
}
