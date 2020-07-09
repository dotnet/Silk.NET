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
    [NativeName("Name", "VkPipelineExecutableStatisticKHR")]
    public unsafe struct PipelineExecutableStatisticKHR
    {
        public PipelineExecutableStatisticKHR
        (
            StructureType sType = StructureType.PipelineExecutableStatisticKhr,
            void* pNext = default,
            PipelineExecutableStatisticFormatKHR format = default,
            PipelineExecutableStatisticValueKHR value = default
        )
        {
           SType = sType;
           PNext = pNext;
           Format = format;
           Value = value;
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
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "name")]
       public fixed byte Name[256];
        /// <summary></summary>
        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "description")]
       public fixed byte Description[256];
/// <summary></summary>
        [NativeName("Type", "VkPipelineExecutableStatisticFormatKHR")]
        [NativeName("Type.Name", "VkPipelineExecutableStatisticFormatKHR")]
        [NativeName("Name", "format")]
        public PipelineExecutableStatisticFormatKHR Format;
/// <summary></summary>
        [NativeName("Type", "VkPipelineExecutableStatisticValueKHR")]
        [NativeName("Type.Name", "VkPipelineExecutableStatisticValueKHR")]
        [NativeName("Name", "value")]
        public PipelineExecutableStatisticValueKHR Value;
    }
}
