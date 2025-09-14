// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkQueryPoolCreateInfo")]
    public unsafe partial struct QueryPoolCreateInfo : IChainStart
    {
        public QueryPoolCreateInfo
        (
            StructureType? sType = StructureType.QueryPoolCreateInfo,
            void* pNext = null,
            QueryPoolCreateFlags? flags = null,
            QueryType? queryType = null,
            uint? queryCount = null,
            QueryPipelineStatisticFlags? pipelineStatistics = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (queryType is not null)
            {
                QueryType = queryType.Value;
            }

            if (queryCount is not null)
            {
                QueryCount = queryCount.Value;
            }

            if (pipelineStatistics is not null)
            {
                PipelineStatistics = pipelineStatistics.Value;
            }
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
        public QueryPoolCreateFlags Flags;
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.QueryPoolCreateInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref QueryPoolCreateInfo Chain(
            out QueryPoolCreateInfo capture)
        {
            capture = new QueryPoolCreateInfo(StructureType.QueryPoolCreateInfo);
            return ref capture;
        }
    }
}
