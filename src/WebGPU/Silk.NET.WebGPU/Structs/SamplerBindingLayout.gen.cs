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
    [NativeName("Name", "WGPUSamplerBindingLayout")]
    public unsafe partial struct SamplerBindingLayout
    {
        public SamplerBindingLayout
        (
            ChainedStruct* nextInChain = null,
            SamplerBindingType? type = null
        ) : this()
        {
            if (nextInChain is not null)
            {
                NextInChain = nextInChain;
            }

            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "const WGPUChainedStruct *")]
        [NativeName("Type.Name", "const WGPUChainedStruct *")]
        [NativeName("Name", "nextInChain")]
        public ChainedStruct* NextInChain;

        [NativeName("Type", "WGPUSamplerBindingType")]
        [NativeName("Type.Name", "WGPUSamplerBindingType")]
        [NativeName("Name", "type")]
        public SamplerBindingType Type;
    }
}
