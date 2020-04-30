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
    public unsafe struct PhysicalDeviceBufferDeviceAddressFeaturesKHR
    {
        public PhysicalDeviceBufferDeviceAddressFeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceBufferDeviceAddressFeatures,
            void* pNext = default,
            Bool32 bufferDeviceAddress = default,
            Bool32 bufferDeviceAddressCaptureReplay = default,
            Bool32 bufferDeviceAddressMultiDevice = default
        )
        {
           SType = sType;
           PNext = pNext;
           BufferDeviceAddress = bufferDeviceAddress;
           BufferDeviceAddressCaptureReplay = bufferDeviceAddressCaptureReplay;
           BufferDeviceAddressMultiDevice = bufferDeviceAddressMultiDevice;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 BufferDeviceAddress;
/// <summary></summary>
        public Bool32 BufferDeviceAddressCaptureReplay;
/// <summary></summary>
        public Bool32 BufferDeviceAddressMultiDevice;
    }
}
