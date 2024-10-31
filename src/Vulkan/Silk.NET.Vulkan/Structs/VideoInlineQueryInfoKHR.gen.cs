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
    [NativeName("Name", "VkVideoInlineQueryInfoKHR")]
    public unsafe partial struct VideoInlineQueryInfoKHR : IExtendsChain<VideoDecodeInfoKHR>, IExtendsChain<VideoEncodeInfoKHR>
    {
        public VideoInlineQueryInfoKHR
        (
            StructureType? sType = StructureType.VideoInlineQueryInfoKhr,
            void* pNext = null,
            QueryPool? queryPool = null,
            uint? firstQuery = null,
            uint? queryCount = null
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

            if (queryPool is not null)
            {
                QueryPool = queryPool.Value;
            }

            if (firstQuery is not null)
            {
                FirstQuery = firstQuery.Value;
            }

            if (queryCount is not null)
            {
                QueryCount = queryCount.Value;
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
        [NativeName("Type", "VkQueryPool")]
        [NativeName("Type.Name", "VkQueryPool")]
        [NativeName("Name", "queryPool")]
        public QueryPool QueryPool;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstQuery")]
        public uint FirstQuery;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queryCount")]
        public uint QueryCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoInlineQueryInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
