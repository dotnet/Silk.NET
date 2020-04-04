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
    public unsafe struct QueryPoolCreateInfo
    {
        public QueryPoolCreateInfo
        (
            StructureType sType = StructureType.QueryPoolCreateInfo,
            void* pNext = default,
            uint flags = default,
            QueryType queryType = default,
            uint queryCount = default,
            QueryPipelineStatisticFlags pipelineStatistics = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           QueryType = queryType;
           QueryCount = queryCount;
           PipelineStatistics = pipelineStatistics;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public QueryType QueryType;
/// <summary></summary>
        public uint QueryCount;
/// <summary></summary>
        public QueryPipelineStatisticFlags PipelineStatistics;
    }
}
