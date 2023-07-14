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
    [NativeName("Name", "VkPipelineCacheSafetyCriticalIndexEntry")]
    public unsafe partial struct PipelineCacheSafetyCriticalIndexEntry
    {
        public PipelineCacheSafetyCriticalIndexEntry
        (
            ulong? pipelineMemorySize = null,
            ulong? jsonSize = null,
            ulong? jsonOffset = null,
            uint? stageIndexCount = null,
            uint? stageIndexStride = null,
            ulong? stageIndexOffset = null
        ) : this()
        {
            if (pipelineMemorySize is not null)
            {
                PipelineMemorySize = pipelineMemorySize.Value;
            }

            if (jsonSize is not null)
            {
                JsonSize = jsonSize.Value;
            }

            if (jsonOffset is not null)
            {
                JsonOffset = jsonOffset.Value;
            }

            if (stageIndexCount is not null)
            {
                StageIndexCount = stageIndexCount.Value;
            }

            if (stageIndexStride is not null)
            {
                StageIndexStride = stageIndexStride.Value;
            }

            if (stageIndexOffset is not null)
            {
                StageIndexOffset = stageIndexOffset.Value;
            }
        }

        /// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "pipelineIdentifier")]
        public fixed byte PipelineIdentifier[16];
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pipelineMemorySize")]
        public ulong PipelineMemorySize;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "jsonSize")]
        public ulong JsonSize;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "jsonOffset")]
        public ulong JsonOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stageIndexCount")]
        public uint StageIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "stageIndexStride")]
        public uint StageIndexStride;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "stageIndexOffset")]
        public ulong StageIndexOffset;
    }
}
