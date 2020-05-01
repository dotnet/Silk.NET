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
    public unsafe struct PhysicalDeviceRepresentativeFragmentTestFeaturesNV
    {
        public PhysicalDeviceRepresentativeFragmentTestFeaturesNV
        (
            StructureType sType = StructureType.PhysicalDeviceRepresentativeFragmentTestFeaturesNV,
            void* pNext = default,
            Bool32 representativeFragmentTest = default
        )
        {
           SType = sType;
           PNext = pNext;
           RepresentativeFragmentTest = representativeFragmentTest;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 RepresentativeFragmentTest;
    }
}
