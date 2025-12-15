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
    [NativeName("Name", "WGPUComputePassDescriptor")]
    public unsafe partial struct ComputePassDescriptor
    {
        public ComputePassDescriptor
        (
            ChainedStruct* nextInChain = null,
            byte* label = null,
            ComputePassTimestampWrites* timestampWrites = null
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

            if (timestampWrites is not null)
            {
                TimestampWrites = timestampWrites;
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

        [NativeName("Type", "const WGPUComputePassTimestampWrites *")]
        [NativeName("Type.Name", "const WGPUComputePassTimestampWrites *")]
        [NativeName("Name", "timestampWrites")]
        public ComputePassTimestampWrites* TimestampWrites;
    }
}
