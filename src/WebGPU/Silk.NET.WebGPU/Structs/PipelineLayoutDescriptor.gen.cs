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
    [NativeName("Name", "WGPUPipelineLayoutDescriptor")]
    public unsafe partial struct PipelineLayoutDescriptor
    {
        public PipelineLayoutDescriptor
        (
            ChainedStruct* nextInChain = null,
            StringView? label = null,
            nuint? bindGroupLayoutCount = null,
            BindGroupLayout** bindGroupLayouts = null,
            uint? immediateSize = null
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

            if (bindGroupLayoutCount is not null)
            {
                BindGroupLayoutCount = bindGroupLayoutCount.Value;
            }

            if (bindGroupLayouts is not null)
            {
                BindGroupLayouts = bindGroupLayouts;
            }

            if (immediateSize is not null)
            {
                ImmediateSize = immediateSize.Value;
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

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "bindGroupLayoutCount")]
        public nuint BindGroupLayoutCount;

        [NativeName("Type", "const WGPUBindGroupLayout *")]
        [NativeName("Type.Name", "const WGPUBindGroupLayout *")]
        [NativeName("Name", "bindGroupLayouts")]
        public BindGroupLayout** BindGroupLayouts;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "immediateSize")]
        public uint ImmediateSize;
    }
}
