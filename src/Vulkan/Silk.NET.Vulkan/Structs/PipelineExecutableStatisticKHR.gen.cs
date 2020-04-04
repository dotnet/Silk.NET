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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
        /// <summary></summary>
       public fixed byte Name[256];
        /// <summary></summary>
       public fixed byte Description[256];
/// <summary></summary>
        public PipelineExecutableStatisticFormatKHR Format;
/// <summary></summary>
        public PipelineExecutableStatisticValueKHR Value;
    }
}
