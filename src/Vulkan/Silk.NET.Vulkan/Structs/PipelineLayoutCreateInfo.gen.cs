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
    public unsafe struct PipelineLayoutCreateInfo
    {
        public PipelineLayoutCreateInfo
        (
            StructureType sType = StructureType.PipelineLayoutCreateInfo,
            void* pNext = default,
            uint flags = default,
            uint setLayoutCount = default,
            DescriptorSetLayout* pSetLayouts = default,
            uint pushConstantRangeCount = default,
            PushConstantRange* pPushConstantRanges = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           SetLayoutCount = setLayoutCount;
           PSetLayouts = pSetLayouts;
           PushConstantRangeCount = pushConstantRangeCount;
           PPushConstantRanges = pPushConstantRanges;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public uint SetLayoutCount;
/// <summary></summary>
        public DescriptorSetLayout* PSetLayouts;
/// <summary></summary>
        public uint PushConstantRangeCount;
/// <summary></summary>
        public PushConstantRange* PPushConstantRanges;
    }
}
