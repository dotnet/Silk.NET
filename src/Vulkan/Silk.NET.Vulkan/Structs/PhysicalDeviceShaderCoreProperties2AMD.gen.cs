// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceShaderCoreProperties2AMD")]
    public unsafe partial struct PhysicalDeviceShaderCoreProperties2AMD
    {
        public PhysicalDeviceShaderCoreProperties2AMD
        (
            StructureType sType = StructureType.PhysicalDeviceShaderCoreProperties2Amd,
            void* pNext = default,
            ShaderCorePropertiesFlagsAMD shaderCoreFeatures = default,
            uint activeComputeUnitCount = default
        )
        {
            SType = sType;
            PNext = pNext;
            ShaderCoreFeatures = shaderCoreFeatures;
            ActiveComputeUnitCount = activeComputeUnitCount;
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
        [NativeName("Type", "VkShaderCorePropertiesFlagsAMD")]
        [NativeName("Type.Name", "VkShaderCorePropertiesFlagsAMD")]
        [NativeName("Name", "shaderCoreFeatures")]
        public ShaderCorePropertiesFlagsAMD ShaderCoreFeatures;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "activeComputeUnitCount")]
        public uint ActiveComputeUnitCount;
    }
}
