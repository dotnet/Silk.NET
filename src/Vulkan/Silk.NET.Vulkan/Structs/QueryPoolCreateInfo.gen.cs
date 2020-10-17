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
    [NativeName("Name", "VkQueryPoolCreateInfo")]
    public unsafe partial struct QueryPoolCreateInfo
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
        [NativeName("Type", "VkQueryPoolCreateFlags")]
        [NativeName("Type.Name", "VkQueryPoolCreateFlags")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkQueryType")]
        [NativeName("Type.Name", "VkQueryType")]
        [NativeName("Name", "queryType")]
        public QueryType QueryType;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queryCount")]
        public uint QueryCount;
/// <summary></summary>
        [NativeName("Type", "VkQueryPipelineStatisticFlags")]
        [NativeName("Type.Name", "VkQueryPipelineStatisticFlags")]
        [NativeName("Name", "pipelineStatistics")]
        public QueryPipelineStatisticFlags PipelineStatistics;
    }
}
