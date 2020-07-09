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
    [NativeName("Name", "VkPhysicalDeviceBufferDeviceAddressFeaturesEXT")]
    public unsafe struct PhysicalDeviceBufferDeviceAddressFeaturesEXT
    {
        public PhysicalDeviceBufferDeviceAddressFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceBufferDeviceAddressFeaturesExt,
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddress")]
        public Bool32 BufferDeviceAddress;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddressCaptureReplay")]
        public Bool32 BufferDeviceAddressCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "bufferDeviceAddressMultiDevice")]
        public Bool32 BufferDeviceAddressMultiDevice;
    }
}
