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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUQuerySetDescriptorExtras")]
    public unsafe partial struct QuerySetDescriptorExtras
    {
        public QuerySetDescriptorExtras
        (
            ChainedStruct? chain = null,
            PipelineStatisticName* pipelineStatistics = null,
            nuint? pipelineStatisticCount = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (pipelineStatistics is not null)
            {
                PipelineStatistics = pipelineStatistics;
            }

            if (pipelineStatisticCount is not null)
            {
                PipelineStatisticCount = pipelineStatisticCount.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "const WGPUPipelineStatisticName *")]
        [NativeName("Type.Name", "const WGPUPipelineStatisticName *")]
        [NativeName("Name", "pipelineStatistics")]
        public PipelineStatisticName* PipelineStatistics;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "pipelineStatisticCount")]
        public nuint PipelineStatisticCount;
    }
}
