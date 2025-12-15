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
            StringView? label = null,
            PassTimestampWrites* timestampWrites = null
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

            if (timestampWrites is not null)
            {
                TimestampWrites = timestampWrites;
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

        [NativeName("Type", "const WGPUPassTimestampWrites *")]
        [NativeName("Type.Name", "const WGPUPassTimestampWrites *")]
        [NativeName("Name", "timestampWrites")]
        public PassTimestampWrites* TimestampWrites;
    }
}
