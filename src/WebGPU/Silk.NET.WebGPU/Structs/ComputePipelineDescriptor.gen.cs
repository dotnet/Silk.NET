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

namespace Silk.NET.WebGPU
{
    [NativeName("Name", "WGPUComputePipelineDescriptor")]
    public unsafe partial struct ComputePipelineDescriptor
    {
        public ComputePipelineDescriptor
        (
            ChainedStruct* nextInChain = null,
            StringView? label = null,
            PipelineLayout* layout = null,
            ComputeState? compute = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label.Value;
            }

            if (layout is not null)
            {
                Layout = layout;
            }

            if (compute is not null)
            {
                Compute = compute.Value;
            }
        }


        [NativeName("Type", "WGPUChainedStruct *")]
        [NativeName("Type.Name", "WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUStringView")]
        [NativeName("Type.Name", "WGPUStringView")]
        [NativeName("Name", "label")]
        public StringView Label;

        [NativeName("Type", "WGPUPipelineLayout")]
        [NativeName("Type.Name", "WGPUPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout* Layout;

        [NativeName("Type", "WGPUComputeState")]
        [NativeName("Type.Name", "WGPUComputeState")]
        [NativeName("Name", "compute")]
        public ComputeState Compute;
    }
}
