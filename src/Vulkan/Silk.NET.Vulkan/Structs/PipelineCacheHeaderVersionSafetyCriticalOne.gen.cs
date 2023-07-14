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
    [NativeName("Name", "VkPipelineCacheHeaderVersionSafetyCriticalOne")]
    public unsafe partial struct PipelineCacheHeaderVersionSafetyCriticalOne
    {
        public PipelineCacheHeaderVersionSafetyCriticalOne
        (
            PipelineCacheHeaderVersionOne? headerVersionOne = null,
            PipelineCacheValidationVersion? validationVersion = null,
            uint? implementationData = null,
            uint? pipelineIndexCount = null,
            uint? pipelineIndexStride = null,
            ulong? pipelineIndexOffset = null
        ) : this()
        {
            if (headerVersionOne is not null)
            {
                HeaderVersionOne = headerVersionOne.Value;
            }

            if (validationVersion is not null)
            {
                ValidationVersion = validationVersion.Value;
            }

            if (implementationData is not null)
            {
                ImplementationData = implementationData.Value;
            }

            if (pipelineIndexCount is not null)
            {
                PipelineIndexCount = pipelineIndexCount.Value;
            }

            if (pipelineIndexStride is not null)
            {
                PipelineIndexStride = pipelineIndexStride.Value;
            }

            if (pipelineIndexOffset is not null)
            {
                PipelineIndexOffset = pipelineIndexOffset.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkPipelineCacheHeaderVersionOne")]
        [NativeName("Type.Name", "VkPipelineCacheHeaderVersionOne")]
        [NativeName("Name", "headerVersionOne")]
        public PipelineCacheHeaderVersionOne HeaderVersionOne;
/// <summary></summary>
        [NativeName("Type", "VkPipelineCacheValidationVersion")]
        [NativeName("Type.Name", "VkPipelineCacheValidationVersion")]
        [NativeName("Name", "validationVersion")]
        public PipelineCacheValidationVersion ValidationVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "implementationData")]
        public uint ImplementationData;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineIndexCount")]
        public uint PipelineIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pipelineIndexStride")]
        public uint PipelineIndexStride;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "pipelineIndexOffset")]
        public ulong PipelineIndexOffset;
    }
}
