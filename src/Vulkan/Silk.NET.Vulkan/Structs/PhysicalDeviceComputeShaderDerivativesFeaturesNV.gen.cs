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
    public unsafe struct PhysicalDeviceComputeShaderDerivativesFeaturesNV
    {
        public PhysicalDeviceComputeShaderDerivativesFeaturesNV
        (
            StructureType sType = StructureType.PhysicalDeviceComputeShaderDerivativesFeaturesNV,
            void* pNext = default,
            Bool32 computeDerivativeGroupQuads = default,
            Bool32 computeDerivativeGroupLinear = default
        )
        {
           SType = sType;
           PNext = pNext;
           ComputeDerivativeGroupQuads = computeDerivativeGroupQuads;
           ComputeDerivativeGroupLinear = computeDerivativeGroupLinear;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ComputeDerivativeGroupQuads;
/// <summary></summary>
        public Bool32 ComputeDerivativeGroupLinear;
    }
}
