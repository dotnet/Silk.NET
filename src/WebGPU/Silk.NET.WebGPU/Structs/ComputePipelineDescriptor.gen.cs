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
            byte* label = null,
            PipelineLayout* layout = null,
            ProgrammableStageDescriptor? compute = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (label is not null)
            {
                Label = label;
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


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "label")]
        public byte* Label;

        [NativeName("Type", "WGPUPipelineLayout")]
        [NativeName("Type.Name", "WGPUPipelineLayout")]
        [NativeName("Name", "layout")]
        public PipelineLayout* Layout;

        [NativeName("Type", "WGPUProgrammableStageDescriptor")]
        [NativeName("Type.Name", "WGPUProgrammableStageDescriptor")]
        [NativeName("Name", "compute")]
        public ProgrammableStageDescriptor Compute;
    }
}
