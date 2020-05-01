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
    public unsafe struct ImageViewAddressPropertiesNVX
    {
        public ImageViewAddressPropertiesNVX
        (
            StructureType sType = StructureType.ImageViewAddressPropertiesNvx,
            void* pNext = default,
            ulong deviceAddress = default,
            ulong size = default
        )
        {
           SType = sType;
           PNext = pNext;
           DeviceAddress = deviceAddress;
           Size = size;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ulong DeviceAddress;
/// <summary></summary>
        public ulong Size;
    }
}
