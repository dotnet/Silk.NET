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
    public unsafe struct PipelineExecutablePropertiesKHR
    {
        public PipelineExecutablePropertiesKHR
        (
            StructureType sType = StructureType.PipelineExecutablePropertiesKhr,
            void* pNext = default,
            ShaderStageFlags stages = default,
            uint subgroupSize = default
        )
        {
           SType = sType;
           PNext = pNext;
           Stages = stages;
           SubgroupSize = subgroupSize;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ShaderStageFlags Stages;
        /// <summary></summary>
       public fixed byte Name[256];
        /// <summary></summary>
       public fixed byte Description[256];
/// <summary></summary>
        public uint SubgroupSize;
    }
}
