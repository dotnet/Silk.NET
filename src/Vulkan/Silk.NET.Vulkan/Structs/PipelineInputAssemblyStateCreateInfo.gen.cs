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
    [NativeName("Name", "VkPipelineInputAssemblyStateCreateInfo")]
    public unsafe struct PipelineInputAssemblyStateCreateInfo
    {
        public PipelineInputAssemblyStateCreateInfo
        (
            StructureType sType = StructureType.PipelineInputAssemblyStateCreateInfo,
            void* pNext = default,
            uint flags = default,
            PrimitiveTopology topology = default,
            Bool32 primitiveRestartEnable = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           Topology = topology;
           PrimitiveRestartEnable = primitiveRestartEnable;
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
        [NativeName("Type", "VkPipelineInputAssemblyStateCreateFlags")]
        [NativeName("Type.Name", "VkPipelineInputAssemblyStateCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkPrimitiveTopology")]
        [NativeName("Type.Name", "VkPrimitiveTopology")]
        [NativeName("Name", "topology")]
        public PrimitiveTopology Topology;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "primitiveRestartEnable")]
        public Bool32 PrimitiveRestartEnable;
    }
}
