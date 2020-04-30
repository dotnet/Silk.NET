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
    public unsafe struct PhysicalDeviceFeatures2
    {
        public PhysicalDeviceFeatures2
        (
            StructureType sType = StructureType.PhysicalDeviceFeatures2,
            void* pNext = default,
            PhysicalDeviceFeatures features = default
        )
        {
           SType = sType;
           PNext = pNext;
           Features = features;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public PhysicalDeviceFeatures Features;
    }
}
