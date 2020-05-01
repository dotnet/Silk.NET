// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct DeviceOrHostAddressKHR
    {
        public DeviceOrHostAddressKHR
        (
            ulong deviceAddress = default,
            void* hostAddress = default
        )
        {
           DeviceAddress = deviceAddress;
           HostAddress = hostAddress;
        }

/// <summary></summary>
        [FieldOffset(0)]
        public ulong DeviceAddress;
/// <summary></summary>
        [FieldOffset(0)]
        public void* HostAddress;
    }
}
